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
            List<Employees> data = new List<Employees>();
            data.Add(new Employees() { Name = "Andrew Fuller", Id = "1" });
            data.Add(new Employees() { Name = "Anne Dodsworth" , Id = "2" } );
            data.Add(new Employees() { Name = "Janet Leverling" , Id =  "3" } );
            data.Add(new Employees() { Name = "Laura Callahan" , Id = "4" });
            data.Add(new Employees() { Name = "Margaret Peacock" , Id = "5" });
            return data;
        }
    }
}

