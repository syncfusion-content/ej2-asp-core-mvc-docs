public ActionResult Index()
{
    var nodes = new List<SankeyNode>
    {
        new SankeyNode { Id = "Agricultural Waste" },
        new SankeyNode { Id = "Biomass Residues" },
        new SankeyNode { Id = "Bio-conversion" },
        new SankeyNode { Id = "Liquid Biofuel" },
        new SankeyNode { Id = "Electricity" },
        new SankeyNode { Id = "Heat" }
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

    // Pass custom node fill color from your theme
    ViewBag.NodeFill = "#5A5A5A";

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
