using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbuyGetir.Core.Notifications
{
    public class EmailAttachment
    {
        public string Url { get; set; }
        /// <summary>
        /// base64 formatında veri resim,excel,word vs dosyası olailir
        /// </summary>
        public string Base64 { get; set; }
        public byte[] File { get; set; }
    }

    public interface IEmailSender
    {/// <summary>
    /// aralarında , olarak tek bir strin ile birden fazla kişiye mail atılabilir.
    /// Eposta atma işlemleri icin bu servisi kullancagız.
    /// </summary>
    /// <param name="to"></param>
    /// <param name="subject"></param>
    /// <param name="message"></param>
    /// <param name="cc"> aralarına , konularak birden fazla kişi cc eklenebilir.</param>
    /// <param name="emailArrachments"></param>
    /// <returns></returns>
        Task SendEmailAsync(string to, string subject, string message,string cc,List<EmailAttachment> emailArrachments=null);
    }
}
