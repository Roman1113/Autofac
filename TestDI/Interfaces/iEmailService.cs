using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDI.Interfaces
{
    public interface IEmailService : IDisposable
    {
        /// <summary>
        /// Відравка пошти
        /// </summary>
        /// <param name="email">Кому відпрвляємо</param>
        /// <param name="subject">Тема листа</param>
        /// <param name="body">Тіло листа</param>
        /// <returns>Результат виконання операції - true усе пройшло успішно</returns>
        bool SendMessage(string email, string subject, string body);
        bool SendMessageAttachFile(string email, string subject,
            string body, string[] files);
    }
}
