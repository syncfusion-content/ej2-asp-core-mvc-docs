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
                new EmailData { Name = "Garth", EmailId = "garth@gmail.com" },
                new EmailData { Name = "Andrew James", EmailId = "andrew@gmail.com" },
                new EmailData { Name = "Olivia", EmailId = "olivia@gmail.com" },
                new EmailData { Name = "Margaret", EmailId = "margaret@gmail.com" },
                new EmailData { Name = "Ursula Ann", EmailId = "ursula@gmail.com" },
                new EmailData { Name = "Laura Grace", EmailId = "laura@gmail.com" },
                new EmailData { Name = "Albert", EmailId = "albert@gmail.com" },
                new EmailData { Name = "William", EmailId = "william@gmail.com" }
            };
            return email;
        }
    }
}
