public ActionResult Index()
{
    List<SankeyNode> nodes = new List<SankeyNode>
    {
        new SankeyNode { Id = "Agricultural Waste", Label = new SankeyChartDataLabel { Text = "Agri Waste", Padding = 0 } },
        new SankeyNode { Id = "Biomass Residues", Label = new SankeyChartDataLabel { Text = "Biomass", Padding = 0 } },
        new SankeyNode { Id = "Bio-conversion", Label = new SankeyChartDataLabel { Text = "Bio", Padding = 0 } },
        new SankeyNode { Id = "Liquid Biofuel",Label = new SankeyChartDataLabel { Text = "Liquid", Padding = 0 } },
        new SankeyNode { Id = "Electricity", Label = new SankeyChartDataLabel { Text = "Electricity", Padding = 0 } },
        new SankeyNode { Id = "Heat", Label = new SankeyChartDataLabel { Text = "Heat", Padding = 0 } }
    };

    List<SankeyLink> links = new List<SankeyLink>
    {
        new SankeyLink { SourceId = "Agricultural Waste", TargetId = "Bio-conversion", Value = 84.152 },
        new SankeyLink { SourceId = "Biomass Residues", TargetId = "Bio-conversion", Value = 24.152 },
        new SankeyLink { SourceId = "Bio-conversion", TargetId = "Liquid Biofuel", Value = 10.597 },
        new SankeyLink { SourceId = "Bio-conversion", TargetId = "Electricity", Value = 36.862 },
        new SankeyLink { SourceId = "Bio-conversion", TargetId = "Heat", Value = 60.845 }
    };

    ViewBag.SankeyNodes = nodes;
    ViewBag.SankeyLinks = links;

    return View();
}
