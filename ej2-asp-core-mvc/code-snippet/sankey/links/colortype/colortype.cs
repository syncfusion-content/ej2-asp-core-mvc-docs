public ActionResult Index()
{
    var nodes = new List<SankeyNode>
    {
        new SankeyNode { Id = "Agricultural Waste", Color = "#FF6B6B" },
        new SankeyNode { Id = "Biomass Residues" },
        new SankeyNode { Id = "Bio-conversion", Color = "#4ECDC4" },
        new SankeyNode { Id = "Liquid Biofuel", Color = "#45B7D1" },
        new SankeyNode { Id = "Electricity", Color = "#FFA07A" },
        new SankeyNode { Id = "Heat", Color = "#98D8C8" }
    };

    var links = new List<SankeyLink>
    {
        new SankeyLink { SourceId = "Agricultural Waste", TargetId = "Bio-conversion", Value = 84.152 },
        new SankeyLink { SourceId = "Biomass Residues",   TargetId = "Bio-conversion", Value = 24.152 },
        new SankeyLink { SourceId = "Bio-conversion",     TargetId = "Liquid Biofuel", Value = 10.597 },
        new SankeyLink { SourceId = "Bio-conversion",     TargetId = "Electricity",    Value = 36.862 },
        new SankeyLink { SourceId = "Bio-conversion",     TargetId = "Heat",           Value = 60.845 }
    };

    ViewBag.SankeyNodes = nodes;
    ViewBag.SankeyLinks = links;

    return View();
}

public class SankeyNode
{
    public string Id { get; set; }
    public string Color { get; set; }   // optional
}

public class SankeyLink
{
    public string SourceId { get; set; }
    public string TargetId { get; set; }
    public double Value { get; set; }
}