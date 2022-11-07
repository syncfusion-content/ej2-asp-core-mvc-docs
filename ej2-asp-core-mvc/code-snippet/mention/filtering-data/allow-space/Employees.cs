using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Employees
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public List<Employees> GetData()
        {
            List<Employees> data = new List<Employees>
            {
                new Employees() { Name = "Andrew Fuller", ID = "1" },
                new Employees() { Name = "Anne Dodsworth", ID = "2" },
                new Employees() { Name = "Janet Leverling", ID = "3" },
                new Employees() { Name = "Laura Callahan", ID = "4" },
                new Employees() { Name = "Margaret Peacock", ID = "5" }
            };
            return data;
        }
    }
}

