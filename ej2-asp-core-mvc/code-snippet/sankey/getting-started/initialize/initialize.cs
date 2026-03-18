public ActionResult Index()
{
    var nodes = new List<SankeyNode>
    {
        new SankeyNode { Id = "A" },
        new SankeyNode { Id = "B" },
        new SankeyNode { Id = "C" }
    };

    var links = new List<SankeyLink>
    {
        new SankeyLink { SourceId = "A", TargetId = "B", Value = 100 },
        new SankeyLink { SourceId = "B", TargetId = "C", Value = 80 }
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