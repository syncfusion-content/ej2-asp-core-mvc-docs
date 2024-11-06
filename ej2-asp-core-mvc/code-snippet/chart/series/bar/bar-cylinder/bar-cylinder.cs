public ActionResult Index()
{
    List<CylindricalChartData> chartData = new List<CylindricalChartData>
    {
        new CylindricalChartData { country= "USA",       gold= 50, tooltipMappingName= "USA"       },
        new CylindricalChartData { country= "Japan",     gold= 70, tooltipMappingName= "Japan"     }, 
        new CylindricalChartData { country= "Australia", gold= 60, tooltipMappingName= "Australia" },
        new CylindricalChartData { country= "France",    gold= 50, tooltipMappingName= "France"    }, 
        new CylindricalChartData { country= "Italy",     gold= 40, tooltipMappingName= "Italy"     },
        new CylindricalChartData { country= "Sweden",    gold= 55, tooltipMappingName= "Sweden"    }
    };
    ViewBag.dataSource = chartData;
    return View();
}
public class CylindricalChartData
{
    public string country;
    public double gold;
    public string tooltipMappingName;
}