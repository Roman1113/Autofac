using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDI.Interfaces;
using TestDI.Services;

namespace TestDI
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule(new DataModule("DefaultConnection"));

            var container = builder.Build();
            var us = container.Resolve<IUserService>();
            var res = us.Register("gordon@gmail.com", "123456");

           // IEmailService es = new EmailServiceGoogle();
           //// es.SendMessage("sdf@ff.com", "Шабон", "Треба іти гулять");

           // IUserService us = new UserService(es);
           // var res = us.Register("gordon@gmail.com", "123456");
        }
    }
}
