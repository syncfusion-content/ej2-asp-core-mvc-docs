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
            List<SportsData> mention = new List<SportsData>()
            {
                new SportsData { Name = "Selma Rose", EmployeeImage = "3.png", EmailId = "selma@gmail.com" },
                new SportsData { Name = "Selma Rose", EmployeeImage = "3.png", EmailId = "selma@gmail.com" },
                new SportsData { Name = "Russo Kay", EmployeeImage = "8.png", EmailId = "russo@gmail.com" },
                new SportsData { Name = "Camden Kate", EmployeeImage = "9.png", EmailId = "camden@gmail.com" },
                new SportsData { Name = "Mary Kate", EmployeeImage = "4.png", EmailId = "mary@gmail.com" },
                new SportsData { Name = "Ursula Ann", EmployeeImage = "2.png", EmailId = "ursula@gmail.com" },
                new SportsData { Name = "Margaret", EmployeeImage = "5.png", EmailId = "margaret@gmail.com" },
                new SportsData { Name = "Laura Grace", EmployeeImage = "6.png", EmailId = "laura@gmail.com" },
                new SportsData { Name = "Robert", EmployeeImage = "8.png", EmailId = "robert@gmail.com" },
                new SportsData { Name = "Albert", EmployeeImage = "9.png", EmailId = "albert@gmail.com" },
                new SportsData { Name = "Michale", EmployeeImage = "5.png", EmailId = "michale@gmail.com" },
                new SportsData { Name = "Andrew James", EmployeeImage = "7.png", EmailId = "james@gmail.com" },
                new SportsData { Name = "Rosalie", EmployeeImage = "4.png", EmailId = "rosalie@gmail.com" },
                new SportsData { Name = "Stella Ruth", EmployeeImage = "2.png", EmailId = "stella@gmail.com" },
                new SportsData { Name = "Richard Rose", EmployeeImage = "8.png", EmailId = "richard@gmail.com" },
                new SportsData { Name = "Gabrielle", EmployeeImage = "3.png", EmailId = "gabrielle@gmail.com" },
                new SportsData { Name = "Thomas", EmployeeImage = "7.png", EmailId = "thomas@gmail.com" },
                new SportsData { Name = "Charles Danny", EmployeeImage = "8.png", EmailId = "charles@gmail.com" },
                new SportsData { Name = "Daniel", EmployeeImage = "5.png", EmailId = "daniel@gmail.com" },
                new SportsData { Name = "Matthew", EmployeeImage = "7.png", EmailId = "matthew@gmail.com" },
                new SportsData { Name = "Donald Krish", EmployeeImage = "9.png", EmailId = "donald@gmail.com" },
                new SportsData { Name = "Yohana", EmployeeImage = "1.png", EmailId = "yohana@gmail.com" },
                new SportsData { Name = "Kevin Paul", EmployeeImage = "5.png", EmailId = "kevin@gmail.com" },
            };
            return mention;
        }

    }
}