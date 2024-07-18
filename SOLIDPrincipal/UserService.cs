using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrincipal
{
    public class UserService
    {
        private readonly EmailService _emailService;
        public UserService(EmailService emailService)
        {
            _emailService = emailService;
        }
        public void AddUser(string Email, string Password)
        {
            Console.WriteLine($"User Added Email {Email} Password {Password}");
            _emailService.SendEmail(Email);
        }
        
    }
    public class EmailService
    {
        public void SendEmail(string Email)
        {
            Console.WriteLine($"Email Send On  {Email}");
        }

    }
}
