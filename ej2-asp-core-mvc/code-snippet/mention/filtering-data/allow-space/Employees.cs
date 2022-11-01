using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Employees
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public List<Employees> GetData()
        {
            List<Employees> data = new List<Employees>
            {
                new Employees() { Name = "Andrew Fuller", Id = "1" },
                new Employees() { Name = "Anne Dodsworth", Id = "2" },
                new Employees() { Name = "Janet Leverling", Id = "3" },
                new Employees() { Name = "Laura Callahan", Id = "4" },
                new Employees() { Name = "Margaret Peacock", Id = "5" }
            };
            return data;
        }
    }
}

