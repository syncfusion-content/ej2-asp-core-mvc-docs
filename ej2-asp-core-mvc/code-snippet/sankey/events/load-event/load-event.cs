public ActionResult Index()
{
    var nodes = new List<SankeyNode>
    {
        new SankeyNode { Id = "Agricultural Waste" },
        new SankeyNode { Id = "Bio-conversion" },
        new SankeyNode { Id = "Liquid Biofuel" },
        new SankeyNode { Id = "Electricity" },
        new SankeyNode { Id = "Heat" }
    };

    var links = new List<SankeyLink>
    {
        new SankeyLink { SourceId = "Agricultural Waste", TargetId = "Bio-conversion", Value = 124.729 },
        new SankeyLink { SourceId = "Bio-conversion", TargetId = "Liquid Biofuel", Value = 0.597 },
        new SankeyLink { SourceId = "Bio-conversion", TargetId = "Electricity", Value = 26.862 },
        new SankeyLink { SourceId = "Bio-conversion", TargetId = "Heat", Value = 280.845 }
    };

    ViewBag.SankeyNodes = nodes;
    ViewBag.SankeyLinks = links;

    return View();
}

public class SankeyNode
{
    public string Id { get; set; }
}

public class SankeyLink
{
    public string SourceId { get; set; }
    public string TargetId { get; set; }
    public double Value { get; set; }
}