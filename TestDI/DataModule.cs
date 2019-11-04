using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDI.Entities;
using TestDI.Interfaces;
using TestDI.Services;

namespace TestDI
{
    public class DataModule : Module
    {
        private string _connStr;

        public DataModule(string connString)
        {
            _connStr = connString;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(ctx =>
            {
                return new EFContext(_connStr);
            });
            builder.RegisterType<EmailServiceGoogle>()
                .As<IEmailService>();
            builder.RegisterType<UserService>()
                .As<IUserService>();
            base.Load(builder);
        }
    }
}
