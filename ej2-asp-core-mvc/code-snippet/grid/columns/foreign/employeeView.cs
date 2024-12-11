using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EJ2CoreSampleBrowser.Models
{
    public class EmployeeView
    {
        public EmployeeView()
        {

        }
        public EmployeeView(int EmployeeID, string FirstName, string LastName, string Title, DateTime BirthDate, DateTime HireDate, int ReportsTo, string Address, string PostalCode, string Phone, string City, string Country)
        {
            this.EmployeeID = EmployeeID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Title = Title;
            this.BirthDate = BirthDate;
            this.HireDate = HireDate;
            this.ReportsTo = ReportsTo;
            this.Address = Address;
            this.PostalCode = PostalCode;
            this.Phone = Phone;
            this.City = City;
            this.Country = Country;
        }
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public int ReportsTo { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public static List<EmployeeView> GetAllRecords()
        {
            List<EmployeeView> Emp = new List<Models.EmployeeView>();
            Emp.Add(new EmployeeView(1, "Nancy", "Davolio", "Sales Representative", new DateTime(1948, 12, 08), new DateTime(1992, 05, 01), 2, "507 - 20th Ave. E.Apt. 2A ", " 98122", "(206) 555-9857 ", "Seattle ", "USA"));
            Emp.Add(new EmployeeView(2, "Andrew", "Fuller", "Vice President, Sales", new DateTime(1952, 02, 19), new DateTime(1992, 08, 14), 4, "908 W. Capital Way", "98401 ", "(206) 555-9482 ", "Kirkland ", "USA"));
            Emp.Add(new EmployeeView(3, "Janet", "Leverling", "Sales Representative", new DateTime(1963, 08, 30), new DateTime(1992, 04, 01), 3, " 4110 Old Redmond Rd.", "98052 ", "(206) 555-8122", "Redmond ", "USA "));
            Emp.Add(new EmployeeView(4, "Margaret", "Peacock", "Sales Representative", new DateTime(1937, 09, 19), new DateTime(1993, 05, 03), 6, "14 Garrett Hill ", "SW1 8JR ", "(71) 555-4848 ", "London ", "UK "));
            Emp.Add(new EmployeeView(5, "Steven", "Buchanan", "Sales Manager", new DateTime(1955, 03, 04), new DateTime(1993, 10, 17), 8, "Coventry HouseMiner Rd. ", "EC2 7JR ", " (206) 555-8122", "Tacoma ", " USA"));
            Emp.Add(new EmployeeView(6, "Michael", "Suyama", "Sales Representative", new DateTime(1963, 07, 02), new DateTime(1993, 10, 17), 2, " 7 Houndstooth Rd.", " WG2 7LT", "(71) 555-4444 ", "London ", "UK "));
            Emp.Add(new EmployeeView(7, "Robert", "King", "Sales Representative", new DateTime(1960, 05, 29), new DateTime(1994, 01, 02), 7, "Edgeham HollowWinchester Way ", "RG1 9SP ", "(71) 555-5598 ", "London ", " UK"));
            Emp.Add(new EmployeeView(8, "Laura", "Callahan", "Inside Sales Coordinator", new DateTime(1958, 01, 09), new DateTime(1994, 03, 05), 9, "722 Moss Bay Blvd. ", "98033 ", " (206) 555-3412", "Seattle ", "USA "));
            Emp.Add(new EmployeeView(9, "Anne", "Dodsworth", "Sales Representative", new DateTime(1966, 01, 27), new DateTime(1994, 11, 15), 5, "4726 - 11th Ave. N.E. ", "98105 ", "(71) 555-5598 ", " London", "UK "));
            Emp.Add(new EmployeeView(10, "Albert", "Hellstrom", "Sales Manager", new DateTime(1956, 11, 13), new DateTime(1995, 01, 22), 3, "15 Maple Avenue", "11357", "(206) 555-1122", "Queens", "USA"));
            Emp.Add(new EmployeeView(11, "Emma", "Jenkins", "Marketing Specialist", new DateTime(1972, 04, 15), new DateTime(1996, 07, 12), 4, "22 Willow Drive", "90210", "(213) 555-1212", "Beverly Hills", "USA"));
            Emp.Add(new EmployeeView(12, "Samuel", "Green", "Product Manager", new DateTime(1980, 06, 24), new DateTime(1998, 09, 10), 6, "87 Elm Street", "60657", "(312) 555-9876", "Chicago", "USA"));
            Emp.Add(new EmployeeView(13, "Sophia", "Brown", "Regional Manager", new DateTime(1968, 02, 10), new DateTime(1997, 03, 14), 7, "245 Oak Lane", "33101", "(305) 555-2233", "Miami", "USA"));
            Emp.Add(new EmployeeView(14, "Liam", "Parker", "HR Specialist", new DateTime(1975, 09, 12), new DateTime(1999, 11, 18), 2, "19 Cedar Blvd", "78201", "(210) 555-3344", "San Antonio", "USA"));
            Emp.Add(new EmployeeView(15, "Olivia", "Evans", "Sales Representative", new DateTime(1985, 03, 08), new DateTime(2001, 05, 09), 5, "67 Birch Road", "94123", "(415) 555-5566", "San Francisco", "USA"));
            Emp.Add(new EmployeeView(16, "James", "Taylor", "Technical Lead", new DateTime(1979, 08, 20), new DateTime(2000, 02, 12), 8, "110 Maple Ave", "75201", "(214) 555-6677", "Dallas", "USA"));
            Emp.Add(new EmployeeView(17, "Mia", "Clark", "Sales Coordinator", new DateTime(1990, 07, 11), new DateTime(2010, 06, 15), 9, "902 Pine Street", "10001", "(212) 555-7788", "New York", "USA"));
            Emp.Add(new EmployeeView(18, "Benjamin", "Walker", "Accountant", new DateTime(1983, 11, 25), new DateTime(2005, 09, 21), 3, "35 Spruce Lane", "80203", "(303) 555-8899", "Denver", "USA"));
            Emp.Add(new EmployeeView(19, "Charlotte", "Harris", "Chief Financial Officer", new DateTime(1971, 12, 05), new DateTime(1996, 10, 29), 10, "888 Elm Drive", "98101", "(206) 555-9900", "Seattle", "USA"));
            Emp.Add(new EmployeeView(20, "Alexander", "Scott", "Software Engineer", new DateTime(1992, 05, 03), new DateTime(2018, 07, 17), 1, "12 Aspen Lane", "02139", "(617) 555-1020", "Cambridge", "USA"));
            Emp.Add(new EmployeeView(21, "Evelyn", "Mitchell", "Marketing Manager", new DateTime(1988, 10, 19), new DateTime(2012, 04, 11), 6, "24 Fir Avenue", "85001", "(602) 555-2031", "Phoenix", "USA"));
            Emp.Add(new EmployeeView(22, "Daniel", "Perez", "UX Designer", new DateTime(1991, 02, 14), new DateTime(2015, 08, 05), 2, "75 Walnut Drive", "30301", "(404) 555-3042", "Atlanta", "USA"));
            Emp.Add(new EmployeeView(23, "Grace", "Diaz", "Operations Manager", new DateTime(1984, 12, 27), new DateTime(2008, 03, 19), 7, "33 Chestnut St", "78250", "(210) 555-4053", "San Antonio", "USA"));
            Emp.Add(new EmployeeView(24, "Matthew", "Brooks", "Content Strategist", new DateTime(1986, 07, 15), new DateTime(2010, 09, 25), 4, "41 Maple Way", "90001", "(213) 555-5064", "Los Angeles", "USA"));
            return Emp;
        }
    }
}
