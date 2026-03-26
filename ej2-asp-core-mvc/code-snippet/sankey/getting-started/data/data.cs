public ActionResult Index()
{
    List<SankeyNode> nodes = new List<SankeyNode>
    {
        new SankeyNode { Id = "Energy Input", Label = "Energy Input" },
        new SankeyNode { Id = "Generation", Label = "Generation" },
        new SankeyNode { Id = "Distribution", Label = "Distribution" },
        new SankeyNode { Id = "Consumption", Label = "Consumption" }
    };

    List<SankeyLink> links = new List<SankeyLink>
    {
        new SankeyLink { SourceId = "Energy Input", TargetId = "Generation", Value = 500 },
        new SankeyLink { SourceId = "Generation", TargetId = "Distribution", Value = 450 },
        new SankeyLink { SourceId = "Distribution", TargetId = "Consumption", Value = 400 }
    };

    ViewBag.SankeyNodes = nodes;
    ViewBag.SankeyLinks = links;

    return View();
}
