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
            List<EmailData> email = new List<EmailData>()
            {
                new EmailData { Name = "Selma Rose", EmailId = "selma@gmail.com" },
                new EmailData { Name = "Maria", EmailId = "maria@gmail.com" },
                new EmailData { Name = "Russo kay", EmailId = "russo@gmail.com" },
                new EmailData { Name = "Robert", EmailId = "robert@gmail.com" },
                new EmailData { Name = "Garth", EmailId = "garth@gmail.com" }
            };
            return email;
        }
    }
}
