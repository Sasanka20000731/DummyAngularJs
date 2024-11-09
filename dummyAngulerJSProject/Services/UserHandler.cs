using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dummyAngulerJSProject.Services
{
    public class UserHandler : IUserHandler
    {
        public string ShowName(string UserName)
        {
            var Name = "MY Name is" + UserName + ".";
            return (Name);
        }
    }
}