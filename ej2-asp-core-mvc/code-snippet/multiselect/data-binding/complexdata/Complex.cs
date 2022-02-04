using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Code
    {
        public string Id { get; set; }
    }

    public class Country
    {
        public string CountryId { get; set; }
    }
    public class Complex
    {
        public Country Country { get; set; }
        public Code Code { get; set; }
        public List<Complex> GetData()
        {
            List<Complex> data = new List<Complex>();
            data.Add(new Complex() { Country = new Country() { CountryId = "Australia" }, Code = new Code() { Id = "AU" } });
            data.Add(new Complex() { Country = new Country() { CountryId = "Bermuda" }, Code = new Code() { Id = "BM" } });
            data.Add(new Complex() { Country = new Country() { CountryId = "Canada" }, Code = new Code() { Id = "CA" } });
            data.Add(new Complex() { Country = new Country() { CountryId = "Cameroon" }, Code = new Code() { Id = "CM" } });
            data.Add(new Complex() { Country = new Country() { CountryId = "Denmark" }, Code = new Code() { Id = "DK" } });
            data.Add(new Complex() { Country = new Country() { CountryId = "France" }, Code = new Code() { Id = "FR" } });
            return data;
        }
    }
}