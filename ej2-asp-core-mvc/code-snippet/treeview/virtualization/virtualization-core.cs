using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EJ2CoreSampleBrowser.Models;

namespace EJ2CoreSampleBrowser.Controllers.TreeView
{
    public partial class TreeViewController : Controller
    {
        public IActionResult Virtualization()
        {
            ViewBag.data = GetVirtualizationData();
            return View();
        }

        private List<TreeviewVirtualization> GetVirtualizationData()
        {
            List<TreeviewVirtualization> localData = new List<TreeviewVirtualization>();

            for (int i = 1; i <= 50; i++)
            {
                localData.Add(new TreeviewVirtualization
                {
                    id = i,
                    name = "Parent Node " + i,
                    HasChild = true,
                    Expanded = true
                });

                for (int j = 1; j <= 20; j++)
                {
                    localData.Add(new TreeviewVirtualization
                    {
                        id = (i * 1000) + j,
                        pid = i,
                        name = "Child Node " + i + "-" + j
                    });
                }
            }

            return localData;
        }
    }

    public class TreeviewVirtualization
    {
        public int id { get; set; }
        public int pid { get; set; }
        public string name { get; set; }
        public bool HasChild { get; set; }
        public bool Expanded { get; set; }
    }
}