using Syncfusion.EJ2.BlockEditor;

public List<Block> BlocksData { get; set; } = new List<Block>();
public LabelSettingsModel labelSettings { get; set; }
private List<LabelItemModel> labelItems { get; set; }

public ActionResult Label()
{
        BlocksData.Add(new Block
        {
                Type = BlockType.Heading,
                Props = new { level = 1},
                Content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "Project Planning with Custom Labels"
                        }
                }
        });
        BlocksData.Add(new Block
        {
                Type = BlockType.Paragraph,
                Content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "Type # to add status labels to your tasks."
                        }
                }
        });
        BlocksData.Add(new Block
        {
                Type = BlockType.Paragraph,
                Content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "Fix homepage layout issue - "
                        },
                        new
                        {
                                type = "Label",
                                props = new { labelId = "bug" }
                        },
                        new
                        {
                                type = "Text",
                                content = " "
                        },
                        new
                        {
                                type = "Label",
                                props = new { labelId = "high" }
                        }
                }
        });
        BlocksData.Add(new Block
        {
                Type = BlockType.Paragraph,
                Content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "Update user documentation - "
                        },
                        new
                        {
                                type = "Label",
                                props = new { labelId = "task" }
                        },
                        new
                        {
                                type = "Text",
                                content = ""
                        },
                        new
                        {
                                type = "Label",
                                props = new { labelId = "medium" }
                        }
                }
        });
        BlocksData.Add(new Block
        {
                Type = BlockType.Paragraph,
                Content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "Implement payment gateway - "
                        },
                        new
                        {
                                type = "Label",
                                props = new { labelId = "feature" }
                        },
                        new
                        {
                                type = "Text",
                                content = ""
                        },
                        new
                        {
                                type = "Label",
                                props = new { labelId = "critical" }
                        }
                }
        });
        labelItems = new List<object>()
        {
                new
                {
                        id = "bug",
                        text = "Bug",
                        labelColor = "#ff5252",
                        groupHeader = "Status"
                },
                new
                {
                        id = "task",
                        text = "Task",
                        labelColor = "#90caf9",
                        groupHeader = "Status"
                },
                new
                {
                        id = "feature",
                        text = "Feature",
                        labelColor = "#81c784",
                        groupHeader = "Status"
                },
                new
                {
                        id = "enhancement",
                        text = "Enhancement",
                        labelColor = "#ba68c8",
                        groupHeader = "Status"
                },
                new
                {
                        id = "low",
                        text = "Low Priority",
                        labelColor = "#c5e1a5",
                        groupHeader = "Priority"
                },
                new
                {
                        id = "medium",
                        text = "Medium Priority",
                        labelColor = "#fff59d",
                        groupHeader = "Priority"
                },
                new
                {
                        id = "high",
                        text = "High Priority",
                        labelColor = "#ffab91",
                        groupHeader = "Priority"
                },
                new
                {
                        id = "critical",
                        text = "Critical",
                        labelColor = "#ef9a9a",
                        groupHeader = "Priority"
                }
        };
        labelSettings = new object()
        {
                triggerChar = "#",
                labelItems = labelItems
        };
        ViewBag.labelSettings = labelSettings;
        ViewBag.BlocksData = BlocksData;
        return View();
}