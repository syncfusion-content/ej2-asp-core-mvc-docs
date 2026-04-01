public ActionResult Index()
{
    List<SankeyNode> nodes = new List<SankeyNode>
    {
        new SankeyNode { Id = "Agricultural Waste" },
        new SankeyNode { Id = "Bio-conversion" },
        new SankeyNode { Id = "Liquid Biofuel" },
        new SankeyNode { Id = "Electricity" },
        new SankeyNode { Id = "Heat" }
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
    ViewBag.TooltipFontFamily = "Arial";
    ViewBag.TooltipFontStyle = "normal";
    ViewBag.TooltipFontWeight = "500";
    ViewBag.TooltipFontSize = "14px";
    ViewBag.TooltipColor = "#000";
    ViewBag.TooltipFill = "#F3F3F3";

    return View();
}
