---
layout: post
title: Perform Search Using Controller Data in ##Platform_Name## Listview Component
description: Learn here all about Perform Search Using Controller Data in Syncfusion ##Platform_Name## Listview component and more.
platform: ej2-asp-core-mvc
control: Perform Search Using Controller Data
publishingplatform: ##Platform_Name##
documentation: ug
---

# Perform Search Operation in ListView with Controller data

In ASP .Net Core environment, we can fetch the data from controller using adaptors and the fetched data can be appended to any Controls.
Here we are going to use URL Adaptor to fetch the data from Controller and bind the data to ListView.

To achieve this, refer to the below code snippet.

```html
   <div class="control-section">
    <div class="e-input-group">
        <input class="e-input" id="textbox" name='input' type="text" placeholder="Search" />
    </div>
    <ejs-listview enable="true" id="nestedlist" showHeader="true" headerTitle="Folder">
        <e-listview-fieldsettings tooltip="text">
        </e-listview-fieldsettings>
        <e-data-manager url="@Url.Action("UrlDatasource", "Home")" adaptor="UrlAdaptor">
        </e-data-manager>
    </ejs-listview>
</div>

```

```typescript
  using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using filterlist.Models;

namespace filterlist.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult UrlDatasource()
        {
            List<object> listdata = new List<object>();
            listdata.Add(new
            {
                id = "01",
                text = "Music",
                icon = "folder",
                child = new List<object>() { new { id = "01-01", text = "Gouttes.mp3", icon = "file" } }

            });
            . . .
            . . .
            listdata.Add(new
            {

                id = "04",
                text = "Pictures",
                icon = "folder",
                child = new List<object>() {
               new {
                    id= "04-01", text= "Camera Roll", icon= "folder",
                    child= new List<object>() {
                      new  { id= "04-01-01", text= "WIN_20160726_094117.JPG", icon= "file" },
                       new { id= "04-01-02", text= "WIN_20160726_094118.JPG", icon= "file" },
                       new { id= "04-01-03", text= "WIN_20160726_094119.JPG", icon= "file" }
                    }
                },
             new   {
                    id= "04-02", text= "Wind.jpg", icon= "file"
                },
              new  {
                    id= "04-02", text= "Stone.jpg", icon= "file"
                },
             new   {
                    id= "04-02", text= "Home.jpg", icon= "file"
                },
              new  {
                    id= "04-02", text= "Bridge.png", icon= "file"
                }
            }

            });
            listdata.Add(new
            {

                id = "05",
                text = "Downloads",
                icon = "folder",
                child = new List<object>() {
               new { id= "05-01", text= "UI-Guide.pdf", icon= "file" },
              new  { id= "05-02", text= "Tutorials.zip", icon= "file" },
              new  { id= "05-03", text= "Game.exe", icon= "file" },
               new { id= "05-04", text= "TypeScript.7z", icon= "file" },
            }

            });

            return Json(listdata); // Returning JSON Data
        }
    }
}

```

> While using Adaptors in our application, we need to return the JSON data from Controller.

## Perform Search Operation

To perform search operation in the fetched controller data, we have used a textbox and bound `keyup` event to the textbox.

In the `keyup` event, we have filtered the data using [`dataManager`](https://ej2.syncfusion.com/documentation/api/data/dataManager/) with user input and filtered data is appended to ListView using [refresh](https://ej2.syncfusion.com/documentation/api/list-view/#refresh) method.

Refer to the below code snippet.

```typescript

<script>
    document.getElementById("textbox").addEventListener("keyup", onKeyUp);
    //Here, the list items are filtered using the DataManager instance for ListView
    function onKeyUp() {
        var listObj = (document.getElementById("nestedlist")).ej2_instances[0];
        var value = (document.getElementById("textbox")).value;
        var newdata;
        var data = new ej.data.DataManager({ url: "/Home/UrlDatasource", adaptor: new ej.data.UrlAdaptor }).executeQuery(new ej.data.Query()).then((e) => {
            (e.result).forEach((data) => {
                newdata = e.result;
            });
            myfilter();
        });

        function myfilter() {
            var listData = new ej.data.DataManager(newdata).executeLocal(
                new ej.data.Query().where("text", "startswith", value, true)
            );
            if (!value) {
                listObj.dataSource = newdata;
            } else {
                listObj.dataSource = listData;
            }
            listObj.refresh(); // Refreshing the ListView
        }
    }
</script>

```

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/listview/search/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="List.cs" %}
{% include code-snippet/listview/search/list.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/listview/search/razor %}
{% endhighlight %}
{% highlight c# tabtitle="List.cs" %}
{% include code-snippet/listview/search/list.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

