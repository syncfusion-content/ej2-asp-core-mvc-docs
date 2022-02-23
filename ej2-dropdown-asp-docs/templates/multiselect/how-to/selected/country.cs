using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Countries
    {
        public string Code { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }

        public bool isSelected { get; set; }
        public List<Countries> CountryList()
        {
            List<Countries> country = new List<Countries>();
            country.Add(new Countries { Id = "ct1", Name = "South Africa", Code= "001" ,isSelected=true });
            country.Add(new Countries { Id = "ct2", Name = "North America", Code="002", isSelected = false });
            country.Add(new Countries { Id = "ct3",Name = "West Indies",Code="003", isSelected = true });
            country.Add(new Countries { Id = "ct4", Name = "North California" ,Code="004", isSelected = true });
            country.Add(new Countries { Id = "ct5", Name = "East Indies",Code="005", isSelected = false });
            country.Add(new Countries { Id = "ct6", Name = "India", Code = "006", isSelected = false });
            country.Add(new Countries { Id = "ct7", Name = "Japan", Code = "007", isSelected = true });
            country.Add(new Countries { Id = "ct8", Name = "China", Code = "008", isSelected = false });
            return country;
        }

    }
}
