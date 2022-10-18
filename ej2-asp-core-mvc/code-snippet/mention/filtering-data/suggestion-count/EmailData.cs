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
        email.Add(new EmailData { Name = "Selma Rose", EmailId= "selma@gmail.com" });
        email.Add(new EmailData { Name = "Maria", EmailId= "maria@gmail.com" });
        email.Add(new EmailData { Name = "Russo kay", EmailId= "russo@gmail.com"});
        email.Add(new EmailData { Name = "Robert", EmailId= "robert@gmail.com"});
        email.Add(new EmailData { Name = "Garth", EmailId= "garth@gmail.com"});
        email.Add(new EmailData { Name = "Andrew James", EmailId= "andrew@gmail.com"});
        email.Add(new EmailData { Name = "Olivia", EmailId= "olivia@gmail.com" });
        email.Add(new EmailData { Name = "Margaret", EmailId= "margaret@gmail.com"});
        email.Add(new EmailData { Name = "Ursula Ann", EmailId= "ursula@gmail.com"});
        email.Add(new EmailData { Name = "Laura Grace", EmailId= "laura@gmail.com"});
        email.Add(new EmailData { Name = "Albert", EmailId = "albert@gmail.com" });
        email.Add(new EmailData { Name = "William", EmailId = "william@gmail.com" });
        return email;
        }
    }
}
