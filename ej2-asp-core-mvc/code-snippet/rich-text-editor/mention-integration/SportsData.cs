using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class SportsData
    {
        public string Name { get; set; }
        public string EmployeeImage { get; set; }
        public string EmailId { get; set; }

        public List<SportsData> SportsList()
        {
            List<SportsData> mention = new List<SportsData>();
            mention.Add(new SportsData { Name = "Selma Rose", EmployeeImage = "3.png", EmailId = "selma@gmail.com" });
            mention.Add(new SportsData { Name = "Russo Kay", EmployeeImage = "8.png", EmailId = "russo@gmail.com" });
            mention.Add(new SportsData { Name = "Camden Kate", EmployeeImage = "9.png", EmailId = "camden@gmail.com" });
            mention.Add(new SportsData { Name = "Mary Kate", EmployeeImage = "4.png", EmailId = "mary@gmail.com" });
            mention.Add(new SportsData { Name = "Ursula Ann", EmployeeImage = "2.png", EmailId = "ursula@gmail.com" });
            mention.Add(new SportsData { Name = "Margaret", EmployeeImage = "5.png", EmailId = "margaret@gmail.com" });
            mention.Add(new SportsData { Name = "Laura Grace", EmployeeImage = "6.png", EmailId = "laura@gmail.com" });
            mention.Add(new SportsData { Name = "Robert", EmployeeImage = "8.png", EmailId = "robert@gmail.com" });
            mention.Add(new SportsData { Name = "Albert", EmployeeImage = "9.png", EmailId = "albert@gmail.com" });
            mention.Add(new SportsData { Name = "Michale", EmployeeImage = "5.png", EmailId = "michale@gmail.com" });
            mention.Add(new SportsData { Name = "Andrew James", EmployeeImage = "7.png", EmailId = "james@gmail.com" });
            mention.Add(new SportsData { Name = "Rosalie", EmployeeImage = "4.png", EmailId = "rosalie@gmail.com" });
            mention.Add(new SportsData { Name = "Stella Ruth", EmployeeImage = "2.png", EmailId = "stella@gmail.com" });
            mention.Add(new SportsData { Name = "Richard Rose", EmployeeImage = "8.png", EmailId = "richard@gmail.com" });
            mention.Add(new SportsData { Name = "Gabrielle", EmployeeImage = "3.png", EmailId = "gabrielle@gmail.com" });
            mention.Add(new SportsData { Name = "Thomas", EmployeeImage = "7.png", EmailId = "thomas@gmail.com" });
            mention.Add(new SportsData { Name = "Charles Danny", EmployeeImage = "8.png", EmailId = "charles@gmail.com" });
            mention.Add(new SportsData { Name = "Daniel", EmployeeImage = "5.png", EmailId = "daniel@gmail.com" });
            mention.Add(new SportsData { Name = "Matthew", EmployeeImage = "7.png", EmailId = "matthew@gmail.com" });
            mention.Add(new SportsData { Name = "Donald Krish", EmployeeImage = "9.png", EmailId = "donald@gmail.com" });
            mention.Add(new SportsData { Name = "Yohana", EmployeeImage = "1.png", EmailId = "yohana@gmail.com" });
            mention.Add(new SportsData { Name = "Kevin Paul", EmployeeImage = "5.png", EmailId = "kevin@gmail.com" });
            return mention;
        }

    }
}
