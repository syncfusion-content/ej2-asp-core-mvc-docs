using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class EmployeeData
    {
        public string Name { get; set; }
        public string EmailId { get; set; }

        public List<EmployeeData> EmployeeList()
        {
            List<EmployeeData> mention = new List<EmployeeData>()
            {
                new EmployeeData { Name = "Selma Rose" EmailId = "selma@gmail.com" },
                new EmployeeData { Name = "Russo Kay", EmailId = "russo@gmail.com" },
                new EmployeeData { Name = "Camden Kate",  EmailId = "camden@gmail.com" },
                new EmployeeData { Name = "Mary Kate",  EmailId = "mary@gmail.com" },
                new EmployeeData { Name = "Ursula Ann",  EmailId = "ursula@gmail.com" },
                new EmployeeData { Name = "Margaret",  EmailId = "margaret@gmail.com" },
                new EmployeeData { Name = "Laura Grace",  EmailId = "laura@gmail.com" },
                new EmployeeData { Name = "Robert",  EmailId = "robert@gmail.com" },
                new EmployeeData { Name = "Albert",  EmailId = "albert@gmail.com" },
                new EmployeeData { Name = "Michale",  EmailId = "michale@gmail.com" },
                new EmployeeData { Name = "Andrew James",  EmailId = "james@gmail.com" },
                new EmployeeData { Name = "Rosalie", EmailId = "rosalie@gmail.com" },
                new EmployeeData { Name = "Stella Ruth", EmailId = "stella@gmail.com" },
                new EmployeeData { Name = "Richard Rose", EmailId = "richard@gmail.com" },
                new EmployeeData { Name = "Gabrielle",  EmailId = "gabrielle@gmail.com" },
                new EmployeeData { Name = "Thomas",  EmailId = "thomas@gmail.com" },
            };
            return mention;
        }

    }
}
