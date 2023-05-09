using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Usuario
    {
        private string mail;
        private string password;
        

        public Usuario(string mail, string password) 
        {
            this.mail = mail;
            this.password = password;
        }
        public string Mail
        {
            get
            {
                return mail;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
        }

    }
}
