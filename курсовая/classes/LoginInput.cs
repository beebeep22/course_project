﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace курсовая.classes
{
    public class LoginInput
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public LoginInput(string InputUsername, string InputPassword)
        {
            this.Username = InputUsername;
            this.Password = InputPassword;
        }
    }
}
