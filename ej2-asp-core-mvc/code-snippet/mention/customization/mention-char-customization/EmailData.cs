using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class EmailData
    {
        public string Name { get; set; }
        public string EmailId { get; set; }

        public List<EmailData> EmailList()
        {
            List<EmailData> email = new List<EmailData>();
            email.Add(new EmailData { Name = "Selma Rose", EmailId = "selma@gmail.com" });
            email.Add(new EmailData { Name = "Maria", EmailId = "maria@gmail.com" });
            email.Add(new EmailData { Name = "Russo kay", EmailId = "russo@gmail.com" });
            email.Add(new EmailData { Name = "Robert", EmailId = "robert@gmail.com" });
            email.Add(new EmailData { Name = "Garth", EmailId = "garth@gmail.com" });
            return email;
        }
    }
}
