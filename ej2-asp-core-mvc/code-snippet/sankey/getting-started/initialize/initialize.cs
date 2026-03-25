public ActionResult Index()
{
    List<SankeyNode> nodes = new List<SankeyNode>
    {
        new SankeyNode { Id = "A" },
        new SankeyNode { Id = "B" },
        new SankeyNode { Id = "C" }
    };

    List<SankeyLink> links = new List<SankeyLink>
    {
        new SankeyLink { SourceId = "A", TargetId = "B", Value = 100 },
        new SankeyLink { SourceId = "B", TargetId = "C", Value = 80 }
    };

    ViewBag.SankeyNodes = nodes;
    ViewBag.SankeyLinks = links;

    return View();
}
