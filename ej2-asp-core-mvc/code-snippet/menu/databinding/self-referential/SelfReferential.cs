// Self Referential Data
public ActionResult SelfReferential()
{
    List<object> menuItems = new List<object>()
            {
                new { id = "parent1", text = "Events" },
                new { id = "parent2", text = "Movies" },
                new { id = "parent3", text = "Directory" },
                new { id = "parent4", text = "Queries", pId = "null"  },
                new { id = "parent5", text = "Services", pId = "null" },
                new { id = "parent6", text = "Conferences", parentId = "parent1" },
                new { id = "parent7", text = "Music", parentId = "parent1" },
                new { id = "parent8", text = "Workshops", parentId = "parent1" },

                new { id = "parent9", text = "Now Showing", parentId = "parent2" },
                new { id = "parent10", text = "Coming Soon", parentId = "parent2" },

                new { id = "parent10", text = "Media Gallery", parentId = "parent3" },
                new { id = "parent11", text = "Newsletters", parentId = "parent3" },

                new { id = "parent12", text = "Our Policy", parentId = "parent4" },
                new { id = "parent13", text = "Site Map", parentId = "parent4" },
                new { id = "parent14", text = "Pop", parentId = "parent7" },
                new { id = "parent15", text = "Folk", parentId = "parent7" },
                new { id = "parent16", text = "Classical", parentId = "parent7" }
            };

    // For MenuFieldSettings type, include Syncfusion.EJ2.Navigations in the using directive section.
    MenuFieldSettings menuFields = new MenuFieldSettings()
    {
        ItemId = "id",
        Text = "text",
        ParentId = "parentId"
    };

    ViewBag.menuItems = menuItems;
    ViewBag.menuFields = menuFields;
    return View();
}