using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DropDownListController : Controller
    {
        public ActionResult nesteddata()
       {

            BeneficiaryViewModel model = new BeneficiaryViewModel();
            List<Person> person = new List<Person>();
            person.Add(new Person { AccountNumber = "5000102394555", PersonName = new Name { FirstName = "Mary", LastName = "Elizabeth", FullName = "Mary Elizabeth" } });
            person.Add(new Person { AccountNumber = "5000102394556", PersonName = new Name { FirstName = "Liz ", LastName = "Smith", FullName = "Liz Smith" } });
            person.Add(new Person { AccountNumber = "5000102394557", PersonName = new Name { FirstName = "Ada", LastName = "Maria", FullName = "Ada Maria" } });
            person.Add(new Person { AccountNumber = "5000102394558", PersonName = new Name { FirstName = "Elizabeth", LastName = "Smith", FullName = "Elizabeth Smith" } });
            person.Add(new Person { AccountNumber = "5000102394559", PersonName = new Name { FirstName = "George", LastName = "David", FullName = "George David" } });
            person.Add(new Person { AccountNumber = "5000102394560", PersonName = new Name { FirstName = "Nancy", LastName = "Rose", FullName = "Nancy Rose" } });
            model.BeneficiaryList = person;
            model.SelectedAccountNumber = "persondetails";
            return View(model);
        }
    }
    public class BeneficiaryViewModel
    {
        public string SelectedAccountNumber { get; set; }
        public List<Person> BeneficiaryList { get; set; }
    }
    public class Person
    {
        public string AccountNumber { get; set; }
        public Name PersonName { get; set; }
    }
    public class Name
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
    }
}