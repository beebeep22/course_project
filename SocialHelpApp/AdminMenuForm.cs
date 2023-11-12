using System.Windows.Forms;
using SocialHelpApp.classes;


namespace SocialHelpApp
{
    public partial class AdminMenuForm : Form
    {
        private Account AccountObj { get; set; }

        public AdminMenuForm(Account AccountObj)
        {
            InitializeComponent();
            this.AccountObj = AccountObj;
        }
    }
}
