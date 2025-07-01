using Syncfusion.EJ2.BlockEditor;

public List<Block> BlocksData { get; set; } = new List<Block>();
public LabelSettingsModel labelSettings { get; set; }
private List<LabelItemModel> labelItems { get; set; }

public ActionResult Label()
{
        BlocksData.Add(new Block
        {
                type = "Heading1",
                content = new List<object>()
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
                type = "Paragraph",
                content = new List<object>()
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
                type = "Paragraph",
                content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "Fix homepage layout issue - "
                        },
                        new
                        {
                                type = "Label",
                                id = "bug"
                        },
                        new
                        {
                                type = "Text",
                                content = " "
                        },
                        new
                        {
                                type = "Label",
                                id = "high"
                        }
                }
        });
        BlocksData.Add(new Block
        {
                type = "Paragraph",
                content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "Update user documentation - "
                        },
                        new
                        {
                                type = "Label",
                                id = "task"
                        },
                        new
                        {
                                type = "Text",
                                content = ""
                        },
                        new
                        {
                                type = "Label",
                                id = "medium"
                        }
                }
        });
        BlocksData.Add(new Block
        {
                type = "Paragraph",
                content = new List<object>()
                {
                        new
                        {
                                type = "Text",
                                content = "Implement payment gateway - "
                        },
                        new
                        {
                                type = "Label",
                                id = "feature"
                        },
                        new
                        {
                                type = "Text",
                                content = ""
                        },
                        new
                        {
                                type = "Label",
                                id = "critical"
                        }
                }
        });
        labelItems = new List<LabelItemModel>()
        {
                new LabelItemModel()
                {
                        id = "bug",
                        text = "Bug",
                        labelColor = "#ff5252",
                        groupHeader = "Status"
                },
                new LabelItemModel()
                {
                        id = "task",
                        text = "Task",
                        labelColor = "#90caf9",
                        groupHeader = "Status"
                },
                new LabelItemModel()
                {
                        id = "feature",
                        text = "Feature",
                        labelColor = "#81c784",
                        groupHeader = "Status"
                },
                new LabelItemModel()
                {
                        id = "enhancement",
                        text = "Enhancement",
                        labelColor = "#ba68c8",
                        groupHeader = "Status"
                },
                new LabelItemModel()
                {
                        id = "low",
                        text = "Low Priority",
                        labelColor = "#c5e1a5",
                        groupHeader = "Priority"
                },
                new LabelItemModel()
                {
                        id = "medium",
                        text = "Medium Priority",
                        labelColor = "#fff59d",
                        groupHeader = "Priority"
                },
                new LabelItemModel()
                {
                        id = "high",
                        text = "High Priority",
                        labelColor = "#ffab91",
                        groupHeader = "Priority"
                },
                new LabelItemModel()
                {
                        id = "critical",
                        text = "Critical",
                        labelColor = "#ef9a9a",
                        groupHeader = "Priority"
                }
        };
        labelSettings = new LabelSettingsModel()
        {
                triggerChar = "#",
                labelItems = labelItems
        };
        ViewBag.labelSettings = labelSettings;
        ViewBag.BlocksData = BlocksData;
        return View();
}