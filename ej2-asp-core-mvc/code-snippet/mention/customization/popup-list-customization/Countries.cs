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
            List<Countries> data = new List<Countries>()
            {
                new Countries() { Country = "Australia", Code = "AU" },
                new Countries() { Country = "Bermuda" , Code = "BM" },
                new Countries() { Country = "Canada" , Code =  "CA" },
                new Countries() { Country = "Cameroon" , Code = "CM" },
                new Countries() { Country = "Denmark" , Code = "DK" }
            };
            return data;
        }
    }
}

