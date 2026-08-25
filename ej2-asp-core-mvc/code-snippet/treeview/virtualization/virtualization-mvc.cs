using Syncfusion.EJ2.Navigations;
using System.Collections.Generic;
using System.Web.Mvc;

public class TreeViewController : Controller
{
    public ActionResult Virtualization()
    {
        List<TreeviewVirtualization> localData = new List<TreeviewVirtualization>();

        for (int i = 1; i <= 50; i++)
        {
            localData.Add(new TreeviewVirtualization
            {
                Id = i,
                Name = "Parent Node " + i,
                HasChild = true,
                Expanded = true
            });

            for (int j = 1; j <= 20; j++)
            {
                localData.Add(new TreeviewVirtualization
                {
                    Id = (i * 1000) + j,
                    PId = i,
                    Name = "Child Node " + i + "-" + j
                });
            }
        }

        ViewBag.data = localData;
        return View("~/Views/TreeView/Virtualization/Virtualization.cshtml");
    }
}

public class TreeviewVirtualization
{
    public int Id { get; set; }
    public int PId { get; set; }
    public string Name { get; set; }
    public bool HasChild { get; set; }
    public bool Expanded { get; set; }
}