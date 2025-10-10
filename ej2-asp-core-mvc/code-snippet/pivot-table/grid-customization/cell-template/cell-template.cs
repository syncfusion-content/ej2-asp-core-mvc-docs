public ActionResult Index()
{
    var data = GetPivotData();
    ViewBag.DataSource = data;
    ViewBag.drilledMembers = new string[] { "FY 2015", "FY 2016" };
    return View();
}

public class PivotData
{
     public string Year { get; set; }
 public string HalfYear { get; set; }
 public string EnerType { get; set; } // "Biomass"
 public string EneSource { get; set; } // "Bio-diesel", "Ethanol Fuel", etc.
 public decimal ProCost { get; set; }

 private static List<PivotData> pivotDataList = new List<PivotData>();

  public static List<PivotData> GetPivotData()
 {
     List<PivotData> pivotData = new List<PivotData>();
     pivotData.Add(new PivotData { Year = "FY 2015", HalfYear = "H1 FY 2015", EnerType = "Biomass", EneSource = "Bio-diesel", ProCost = 438 });
     pivotData.Add(new PivotData { Year = "FY 2015", HalfYear = "H1 FY 2015", EnerType = "Biomass", EneSource = "Ethanol Fuel", ProCost = 275 });
     pivotData.Add(new PivotData { Year = "FY 2015", HalfYear = "H1 FY 2015", EnerType = "Biomass", EneSource = "Wastage", ProCost = 252 });
     pivotData.Add(new PivotData { Year = "FY 2015", HalfYear = "H1 FY 2015", EnerType = "Biomass", EneSource = "Wood", ProCost = 78 });
     pivotData.Add(new PivotData { Year = "FY 2015", HalfYear = "H1 FY 2015", EnerType = "Biomass", EneSource = "Bio-diesel", ProCost = 167 });
     pivotData.Add(new PivotData { Year = "FY 2015", HalfYear = "H1 FY 2015", EnerType = "Biomass", EneSource = "Ethanol Fuel", ProCost = 183 });
     pivotData.Add(new PivotData { Year = "FY 2015", HalfYear = "H1 FY 2015", EnerType = "Biomass", EneSource = "Ethanol Fuel", ProCost = 183 });
     pivotData.Add(new PivotData { Year = "FY 2015", HalfYear = "H1 FY 2015", EnerType = "Biomass", EneSource = "Wastage", ProCost = 91 });
     pivotData.Add(new PivotData { Year = "FY 2015", HalfYear = "H1 FY 2015", EnerType = "Biomass", EneSource = "Wood", ProCost = 53 });
     pivotData.Add(new PivotData { Year = "FY 2015", HalfYear = "H2 FY 2015", EnerType = "Biomass", EneSource = "Bio-diesel", ProCost = 271 });
     pivotData.Add(new PivotData { Year = "FY 2015", HalfYear = "H2 FY 2015", EnerType = "Biomass", EneSource = "Ethanol Fuel", ProCost = 92 });
     pivotData.Add(new PivotData { Year = "FY 2015", HalfYear = "H2 FY 2015", EnerType = "Biomass", EneSource = "Wastage", ProCost = 161 });
     pivotData.Add(new PivotData { Year = "FY 2015", HalfYear = "H2 FY 2015", EnerType = "Biomass", EneSource = "Wood", ProCost = 25 });
     pivotData.Add(new PivotData { Year = "FY 2016", HalfYear = "H1 FY 2016", EnerType = "Biomass", EneSource = "Bio-diesel", ProCost = 344 });
     pivotData.Add(new PivotData { Year = "FY 2016", HalfYear = "H1 FY 2016", EnerType = "Biomass", EneSource = "Ethanol Fuel", ProCost = 331 });
     pivotData.Add(new PivotData { Year = "FY 2016", HalfYear = "H1 FY 2016", EnerType = "Biomass", EneSource = "Wastage", ProCost = 335 });
     pivotData.Add(new PivotData { Year = "FY 2016", HalfYear = "H1 FY 2016", EnerType = "Biomass", EneSource = "Wood", ProCost = 126 });
     pivotData.Add(new PivotData { Year = "FY 2016", HalfYear = "H1 FY 2016", EnerType = "Biomass", EneSource = "Bio-diesel", ProCost = 135 });
     pivotData.Add(new PivotData { Year = "FY 2016", HalfYear = "H1 FY 2016", EnerType = "Biomass", EneSource = "Ethanol Fuel", ProCost = 153 });
     pivotData.Add(new PivotData { Year = "FY 2016", HalfYear = "H1 FY 2016", EnerType = "Biomass", EneSource = "Wastage", ProCost = 147 });
     pivotData.Add(new PivotData { Year = "FY 2016", HalfYear = "H1 FY 2016", EnerType = "Biomass", EneSource = "Wood", ProCost = 76 });
     pivotData.Add(new PivotData { Year = "FY 2016", HalfYear = "H2 FY 2016", EnerType = "Biomass", EneSource = "Bio-diesel", ProCost = 209 });
     pivotData.Add(new PivotData { Year = "FY 2016", HalfYear = "H2 FY 2016", EnerType = "Biomass", EneSource = "Ethanol Fuel", ProCost = 158 });
     pivotData.Add(new PivotData { Year = "FY 2016", HalfYear = "H2 FY 2016", EnerType = "Biomass", EneSource = "Wastage", ProCost = 188 });
     pivotData.Add(new PivotData { Year = "FY 2016", HalfYear = "H2 FY 2016", EnerType = "Biomass", EneSource = "Wood", ProCost = 50 });
     pivotData.Add(new PivotData { Year = "FY 2017", HalfYear = "H1 FY 2017", EnerType = "Biomass", EneSource = "Bio-diesel", ProCost = 565 });
     pivotData.Add(new PivotData { Year = "FY 2017", HalfYear = "H1 FY 2017", EnerType = "Biomass", EneSource = "Ethanol Fuel", ProCost = 401 });
     pivotData.Add(new PivotData { Year = "FY 2017", HalfYear = "H2 FY 2017", EnerType = "Biomass", EneSource = "Wastage", ProCost = 367 });
     pivotData.Add(new PivotData { Year = "FY 2017", HalfYear = "H2 FY 2017", EnerType = "Biomass", EneSource = "Wood", ProCost = 122 });

     pivotData.Add(new PivotData { Year = "FY 2016", HalfYear = "H1 FY 2016", EnerType = "Free energy", EneSource = "Geo-thermal", ProCost = 230 });
     pivotData.Add(new PivotData { Year = "FY 2016", HalfYear = "H1 FY 2016", EnerType = "Free energy", EneSource = "Hydro-electric", ProCost = 200 });
     pivotData.Add(new PivotData { Year = "FY 2016", HalfYear = "H1 FY 2016", EnerType = "Free energy", EneSource = "Solar", ProCost = 170 });
     pivotData.Add(new PivotData { Year = "FY 2016", HalfYear = "H1 FY 2016", EnerType = "Free energy", EneSource = "Wind", ProCost = 150 });
     pivotData.Add(new PivotData { Year = "FY 2016", HalfYear = "H2 FY 2016", EnerType = "Free energy", EneSource = "Geo-thermal", ProCost = 240 });
     pivotData.Add(new PivotData { Year = "FY 2016", HalfYear = "H2 FY 2016", EnerType = "Free energy", EneSource = "Hydro-electric", ProCost = 210 });
     pivotData.Add(new PivotData { Year = "FY 2016", HalfYear = "H2 FY 2016", EnerType = "Free energy", EneSource = "Solar", ProCost = 180 });
     pivotData.Add(new PivotData { Year = "FY 2016", HalfYear = "H2 FY 2016", EnerType = "Free energy", EneSource = "Wind", ProCost = 160 });
     pivotData.Add(new PivotData { Year = "FY 2017", HalfYear = "H1 FY 2017", EnerType = "Free energy", EneSource = "Geo-thermal", ProCost = 260 });
     pivotData.Add(new PivotData { Year = "FY 2017", HalfYear = "H1 FY 2017", EnerType = "Free energy", EneSource = "Hydro-electric", ProCost = 220 });
     pivotData.Add(new PivotData { Year = "FY 2017", HalfYear = "H1 FY 2017", EnerType = "Free energy", EneSource = "Solar", ProCost = 190 });
     pivotData.Add(new PivotData { Year = "FY 2017", HalfYear = "H1 FY 2017", EnerType = "Free energy", EneSource = "Wind", ProCost = 170 });
     pivotData.Add(new PivotData { Year = "FY 2017", HalfYear = "H2 FY 2017", EnerType = "Free energy", EneSource = "Geo-thermal", ProCost = 270 });
     pivotData.Add(new PivotData { Year = "FY 2017", HalfYear = "H2 FY 2017", EnerType = "Free energy", EneSource = "Hydro-electric", ProCost = 230 });
     pivotData.Add(new PivotData { Year = "FY 2017", HalfYear = "H2 FY 2017", EnerType = "Free energy", EneSource = "Solar", ProCost = 200 });
     pivotData.Add(new PivotData { Year = "FY 2017", HalfYear = "H2 FY 2017", EnerType = "Free energy", EneSource = "Wind", ProCost = 180 });
     return pivotData;
 }
}