using MongoDB.Driver;
using MongoDB.Bson;
using System.Collections.Generic;
using OpenAI.GPT3.Managers;
using OpenAI.GPT3;
using OpenAI.GPT3.ObjectModels.RequestModels;
using OpenAI.GPT3.ObjectModels;
using System;
using System.Threading.Tasks;


namespace курсовая.classes
{
    class DbAdminOperations : DbOperations
    {
        private readonly IMongoCollection<Account> _accountsCollection;
        private readonly IMongoCollection<UserRequest> _userRequestsCollection;
        private readonly IMongoCollection<UserRequestResponse> _userRequestsResponseCollection;
        private readonly IMongoCollection<Notification> _notificationsCollection;
        private readonly OpenAIService AIService;

        public DbAdminOperations() : base()
        {

            _accountsCollection = Database.GetCollection<Account>("account");
            _userRequestsCollection = Database.GetCollection<UserRequest>("user_request");
            _userRequestsResponseCollection = Database.GetCollection<UserRequestResponse>("user_request_response");
            _notificationsCollection = Database.GetCollection<Notification>("notification");
            AIService = new OpenAIService(new OpenAiOptions()
            {
                ApiKey = " "
            });

        }

        public async Task<String> GetAiResponse(UserRequest Request, string prompt, int tokens, string status)
        {
            string multiLineString = $@"
Уявіть, що ви урядовець, відповідальний за реагування на конкретні запити громадян. Ось інформація щодо запиту:
Тема: {Request.Topic}
Вміст: {Request.Content}
Чи прикріплені докази: {(Request.ProofImageData == null ? "Ні" : "Так")}
Інформація щодо громадяна (не обов'язково згадувати її, але май на увазі):
    - ПІБ: {Request.ApplicantObj?.UserDetails?.GetFullName()}
    - Стать: {Request.ApplicantObj?.UserDetails?.Gender}
    - Захворювання: {Request.ApplicantObj?.UserDetails?.Diseases}
    - АлегріЇ: {Request.ApplicantObj?.UserDetails?.Allergies}
    - Ступінь інвалідності:  {Request.ApplicantObj?.UserDetails?.DisabilityLevel}
Ваша відповідь має відповідати такій структурі:
1. Почніть з офіційного привітання.
2. Надати відповідь на звернення, враховуючи, що його тема зазначена як: '{prompt}', а статус заявки користувача ти змінюєш на: {status}. Зберігайте емпатичний і офіційний тон.
3. Завершіть подякою за прохання та фразою 'З повагою, служба державної допомоги'.
Будь ласка, напишіть відповідь у текстовому форматі дотримуючись усіх правил українскьої мови, переконавшись, що вона відповідає обмеженню кількості символів, представленому {tokens}. Майте на увазі, що відповідь має бути анонімною; не називати ім'я працівника.
";

            CompletionCreateRequest complectionRequest = new CompletionCreateRequest()

            {
                Prompt = multiLineString,
                Model = Models.TextDavinciV3,
                Temperature = 0.5F,
                MaxTokens = tokens
            };

            try
            {
                var completionResult = await AIService.Completions.CreateCompletion(complectionRequest);
                return completionResult.Choices[0].Text;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetAiResponse: {ex.Message}");
                return "Something went wrong. Ensure that your API key is configured.";
            }
        }


        public Account GetApplicantById(ObjectId ApplicantId)
        {
            return _accountsCollection
                .Find(a => a._id == ApplicantId)
                .FirstOrDefault();
        }

        public List<UserRequest> GetAllRequests()
        {
            return _userRequestsCollection.Find(new BsonDocument()).ToList();
        }


        public List<UserRequest> FillRequestsWithApplicantsAndFilterByNotRejected(List<UserRequest> userRequests)
        {
            var filledRequests = new List<UserRequest>();

            foreach (var request in userRequests)
            {
                // Fetch the Account object using the ApplicantId
                Account applicantObj = GetApplicantById(request.ApplicantId);
                if (applicantObj == null) continue; // Don't add requests with unknown applicants
                request.SetApplicantObj(applicantObj);

                var userRequestResponse = _userRequestsResponseCollection
                    .Find(x => x.UserRequestId == request._id)
                    .FirstOrDefault();

                if (userRequestResponse != null)
                {
                    request.SetResponse(userRequestResponse);
                }
                if (userRequestResponse?.Status == null || userRequestResponse.Status != "Відхилено")
                {
                    filledRequests.Add(request);
                }
            }

            return filledRequests;
        }


        public List<UserRequest> GetUserRequests()
        {
            var allRequests = GetAllRequests();
            return FillRequestsWithApplicantsAndFilterByNotRejected(allRequests);
        }

        public void CreateNotification(Notification Notification)
        {
            _notificationsCollection.InsertOne(Notification);
        }


        private void DeleteOldResponses(UserRequestResponse Response)
        {
            var filter = Builders<UserRequestResponse>.Filter.Eq("UserRequestId", Response.UserRequestId);
            _userRequestsResponseCollection.DeleteMany(filter);
        }

        public void CreateUserRequestResponse(UserRequestResponse Response)
        {
            DeleteOldResponses(Response);
            _userRequestsResponseCollection.InsertOne(Response);
        }

        public List<Account> GetAllUsers()
        {
            return _accountsCollection.Find(acc => acc.Role == "user").ToList();
        }

        private void ChangeApproveStatusIfPossible(Account AccountObj, bool Status)
        {
            if (AccountObj.UserDetails == null) return;
            AccountObj.UserDetails.Approved = Status;
            var filter = Builders<Account>.Filter.Eq("_id", AccountObj._id);
            var update = Builders<Account>.Update.Set("UserDetails.Approved", Status);
            _accountsCollection.UpdateOne(filter, update);

        }
        public void ApproveUser(Account AccountObj)
        {
            ChangeApproveStatusIfPossible(AccountObj, true);
        }

        public void DisapproveUser(Account AccountObj)
        {
            ChangeApproveStatusIfPossible(AccountObj, false);
        }

    }
}
