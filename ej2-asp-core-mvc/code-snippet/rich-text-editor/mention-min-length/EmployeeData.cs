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
            };
            return mention;
        }

    }
}
