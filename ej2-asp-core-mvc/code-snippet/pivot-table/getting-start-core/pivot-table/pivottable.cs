using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PivotTable.Pages
{
    public class IndexModel : PageModel
    {
        public List<PivotData> PivotDataSource { get; set; }
        public void OnGet()
        {
            PivotDataSource = GetDefaultData();
        }

        public List<PivotData> GetDefaultData()
        {
            List<PivotData> DefaultData = new List<PivotData>()
            {
                new PivotData { Sold = 31, Amount = 52824, Country = "France", Products = "Mountain Bikes", Year = "FY 2025", Quarter = "Q1" },
                new PivotData { Sold = 51, Amount = 86904, Country = "France", Products = "Mountain Bikes", Year = "FY 2025", Quarter = "Q2" },
                new PivotData { Sold = 90, Amount = 153360, Country = "France", Products = "Mountain Bikes", Year = "FY 2025", Quarter = "Q3" },
                new PivotData { Sold = 25, Amount = 42600, Country = "France", Products = "Mountain Bikes", Year = "FY 2025", Quarter = "Q4" }
            };
            return DefaultData;
            
        }
    }
    public class PivotData
    {
        public int Sold { get; set; }
        public double Amount { get; set; }
        public string Country { get; set; }
        public string Products { get; set; }
        public string Year { get; set; }
        public string Quarter { get; set; }
    }
}
