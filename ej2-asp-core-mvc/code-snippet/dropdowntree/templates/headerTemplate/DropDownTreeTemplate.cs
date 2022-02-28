using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace itemtemplates.Models
{
    public class DropDownTreeTemplate
    {
        public List<Object> Template()
        {
            List<object> localData = new List<object>();
            localData.Add(new { id = 1, name = "Steven Buchanan", hasChild = true, expanded = true,  job = "General Manager" });
            localData.Add(new { id = 2, pid = 1, name = "Laura Callahan",  job = "Product Manager", hasChild = true });
            localData.Add(new { id = 3, pid = 2, name = "Andrew Fuller",  job = "Team Lead", hasChild = true });
            localData.Add(new { id = 4, pid = 3, name = "Anne Dodsworth",  job = "Developer" });
            localData.Add(new { id = 5, pid = 3, name = "Lilly",  job = "Developer", status = "online" });
            localData.Add(new { id = 6, pid = 1, name = "Nancy Davolio",  job = "Product Manager", hasChild = true });
            localData.Add(new { id = 7, pid = 6, name = "Michael Suyama",  job = "Team Lead", hasChild = true });
            localData.Add(new { id = 8, pid = 7, name = "Robert King",  job = "Developer" });
            localData.Add(new { id = 9, pid = 7, name = "Mary",  job = "Developer" });
            localData.Add(new { id = 10, pid = 1, name = "Janet Leverling",  job = "HR" });
            return localData;
        }
    }
}
