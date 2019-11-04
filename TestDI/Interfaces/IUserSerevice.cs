using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDI.Interfaces
{
    /// <summary>
    /// Керування користувачами
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Реєстрація користувача в БД
        /// </summary>
        /// <param name="email">Пошта</param>
        /// <param name="password">Пароль</param>
        /// <returns>true - значить усе ОК</returns>
        bool Register(string email, string password);
    }
}
