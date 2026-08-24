public ActionResult Index()
{
    List<SankeyNode> nodes = new List<SankeyNode>
    {
        new SankeyNode { Id = "Agricultural Waste", Color="#f41212" },
        new SankeyNode { Id = "Biomass Residues", Color="#aed62c" },
        new SankeyNode { Id = "Bio-conversion", Color="#259bc3" },
        new SankeyNode { Id = "Liquid Biofuel", Color="#0e11af" },
        new SankeyNode { Id = "Electricity", Color="#7a0e92" },
        new SankeyNode { Id = "Heat", Color="#c5b9bb" }
    };

    List<SankeyLink> links = new List<SankeyLink>
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
