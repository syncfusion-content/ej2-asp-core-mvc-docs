using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Countries
    {
        public string Country { get; set; }
        public string Code { get; set; }
        public List<Countries> GetData()
        {
            List<Countries> data = new List<Countries>();
            data.Add(new Countries() { Country = "Australia", Code = "AU" });
            data.Add(new Countries() { Country = "Bermuda" , Code = "BM" } );
            data.Add(new Countries() { Country = "Canada" , Code =  "CA" } );
            data.Add(new Countries() { Country = "Cameroon" , Code = "CM" });
            data.Add(new Countries() { Country = "Denmark" , Code = "DK" });
            return data;
        }
    }
}

