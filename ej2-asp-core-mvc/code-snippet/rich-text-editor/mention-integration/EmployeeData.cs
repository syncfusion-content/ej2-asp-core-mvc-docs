using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class EmployeeData
    {
        public string Name { get; set; }
        public string EmployeeImage { get; set; }
        public string EmailId { get; set; }

        public List<EmployeeData> EmployeeList()
        {
            List<EmployeeData> mention = new List<EmployeeData>()
            {
                new EmployeeData { Name = "Selma Rose", EmployeeImage = "3.png", EmailId = "selma@gmail.com" },
                new EmployeeData { Name = "Russo Kay", EmployeeImage = "8.png", EmailId = "russo@gmail.com" },
                new EmployeeData { Name = "Camden Kate", EmployeeImage = "9.png", EmailId = "camden@gmail.com" },
                new EmployeeData { Name = "Mary Kate", EmployeeImage = "4.png", EmailId = "mary@gmail.com" },
                new EmployeeData { Name = "Ursula Ann", EmployeeImage = "2.png", EmailId = "ursula@gmail.com" },
                new EmployeeData { Name = "Margaret", EmployeeImage = "5.png", EmailId = "margaret@gmail.com" },
                new EmployeeData { Name = "Laura Grace", EmployeeImage = "6.png", EmailId = "laura@gmail.com" },
                new EmployeeData { Name = "Robert", EmployeeImage = "8.png", EmailId = "robert@gmail.com" },
                new EmployeeData { Name = "Albert", EmployeeImage = "9.png", EmailId = "albert@gmail.com" },
                new EmployeeData { Name = "Michale", EmployeeImage = "5.png", EmailId = "michale@gmail.com" },
                new EmployeeData { Name = "Andrew James", EmployeeImage = "7.png", EmailId = "james@gmail.com" },
                new EmployeeData { Name = "Rosalie", EmployeeImage = "4.png", EmailId = "rosalie@gmail.com" },
                new EmployeeData { Name = "Stella Ruth", EmployeeImage = "2.png", EmailId = "stella@gmail.com" },
                new EmployeeData { Name = "Richard Rose", EmployeeImage = "8.png", EmailId = "richard@gmail.com" },
                new EmployeeData { Name = "Gabrielle", EmployeeImage = "3.png", EmailId = "gabrielle@gmail.com" },
                new EmployeeData { Name = "Thomas", EmployeeImage = "7.png", EmailId = "thomas@gmail.com" },
                new EmployeeData { Name = "Charles Danny", EmployeeImage = "8.png", EmailId = "charles@gmail.com" },
                new EmployeeData { Name = "Daniel", EmployeeImage = "5.png", EmailId = "daniel@gmail.com" },
                new EmployeeData { Name = "Matthew", EmployeeImage = "7.png", EmailId = "matthew@gmail.com" },
                new EmployeeData { Name = "Donald Krish", EmployeeImage = "9.png", EmailId = "donald@gmail.com" },
                new EmployeeData { Name = "Yohana", EmployeeImage = "1.png", EmailId = "yohana@gmail.com" },
                new EmployeeData { Name = "Kevin Paul", EmployeeImage = "5.png", EmailId = "kevin@gmail.com" },
            };
            return mention;
        }

    }
}
