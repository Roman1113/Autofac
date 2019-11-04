using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDI.Entities;
using TestDI.Interfaces;

namespace TestDI.Services
{
    public class UserService : IUserService
    {
        private readonly IEmailService _emailService;
        private readonly EFContext _context;
        public UserService(IEmailService emailService,
            EFContext context)
        {
            _emailService = emailService;
            _context = context;
        }
        public bool Register(string email, string password)
        {
            Console.WriteLine("Create new User {0} --- {1}", email, password);
            _context.Users.Add(new DbUser
            {
                Email = email,
                Password = password
            });
            _context.SaveChanges();
            //_emailService.SendMessage(email, "noreply", "Ваш акаунт створено. " +
            //    "Дякуємо за реєстрацію");
            _emailService.SendMessageAttachFile(email,
                "noreply",
                "Ваш акаунт створено. " +
                "Дякуємо за реєстрацію", new string[] { "Hello.jpg", "Oksana.jpg" });
            return true;
        }
    }
}
