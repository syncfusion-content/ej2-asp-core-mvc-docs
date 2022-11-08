using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Code
    {
        public string ID { get; set; }
    }

    public class Country
    {
        public string Name { get; set; }
    }

    public class CountryGroup
    {
        public Country Country { get; set; }
        public Code Code { get; set; }
        public List<CountryGroup> GetData()
        {
            List<CountryGroup> data = new List<CountryGroup>
            {
                new CountryGroup() { Country = new Country() { Name = "Australia" }, Code = new Code() { ID = "AU" } },
                new CountryGroup() { Country = new Country() { Name = "Bermuda" }, Code = new Code() { ID = "BM" } },
                new CountryGroup() { Country = new Country() { Name = "Canada" }, Code = new Code() { ID = "CA" } },
                new CountryGroup() { Country = new Country() { Name = "Cameroon" }, Code = new Code() { ID = "CM" } },
                new CountryGroup() { Country = new Country() { Name = "Denmark" }, Code = new Code() { ID = "DK" } },
                new CountryGroup() { Country = new Country() { Name = "France" }, Code = new Code() { ID = "FR" } }
            };
            return data;
        }
    }
}