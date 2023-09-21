---
layout: post
title: Virtual Scrolling in ##Platform_Name## Schedule Component | Syncfusion
description: Learn here all about Virtual Scrolling in Syncfusion ##Platform_Name## Schedule component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Virtual Scrolling
publishingplatform: ##Platform_Name##
documentation: ug
---


# Virtual scrolling in ASP.NET Core Schedule control 

To achieve better performance in the Scheduler when loading a large number of resources and events, we have added virtual scrolling support to load a large set of resources and events instantly as you scroll. You can dynamically load large number of resources and events in the Scheduler by setting `true` to the [`allowVirtualScrolling`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Schedule.ScheduleView.html#Syncfusion_EJ2_Schedule_ScheduleView_AllowVirtualScrolling) property within the view specific settings. The virtual loading of events is possible in Agenda view, by setting [`allowVirtualScrolling`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Schedule.ScheduleView.html#Syncfusion_EJ2_Schedule_ScheduleView_AllowVirtualScrolling) property to `true` within the agenda view specific settings.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/virtual-scroll/vScroll/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/virtual-scroll/vScroll/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/virtual-scroll/vScroll/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/virtual-scroll/vScroll/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N> For now, the virtual loading of resources and events is not supported in `MonthAgenda`, `Year` and `TimelineYear` (Horizontal Orientation) views.

## Enabling lazy loading for appointments

The lazy loading feature provides a convenient way to efficiently load resource appointments into the Scheduler using an on-demand approach. With this feature, you can seamlessly load a large volume of appointment data into the Scheduler without experiencing any performance degradation.

By default, the Scheduler fetches all the relevant appointments from the server with in the current date range. However, enabling this feature will trigger query requests to the server for appointment retrieval whenever new resources are rendered due to scroll actions. These queries contain the resource IDs of currently displayed resources along with current date range, which can be passed as a comma-separated string. In the server controller, these resource IDs are parsed to filter the necessary appointments to render in the scheduler. 

When you enable this feature, the Scheduler becomes capable of fetching events from remote services only for the current view port alone to optimize the data retrieval. The remaining appointment data is fetched form the server on-demand based on currently rendered view port resources as you scroll's through the scheduler content.

To enable this feature, you have to set the [`enableLazyLoading`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Schedule.ScheduleView.html#Syncfusion_EJ2_Schedule_ScheduleView_EnableLazyLoading) property to `true` within the view specific settings.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/virtual-scroll/vScroll/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/virtual-scroll/vScroll/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/virtual-scroll/vScroll/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/virtual-scroll/vScroll/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Here's the server-side controller code that retrieves appointment data based on the resource IDs provided as query parameters:

```c#
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.OData.Query;

namespace LazyLoadingServices.Controllers
{
    public class VirtualEventDataController : Controller
    {
        private readonly EventsContext dbContext;

        [HttpGet]
        [EnableQuery]
        [Route("api/VirtualEventData")]
        public IActionResult GetData([FromQuery] Params param)
        {
            IQueryable<EventData> query = dbContext.Events;
            // Filter the appointment data based on the ResourceId query params.
            if (!string.IsNullOrEmpty(param.ResourceId))
            {
                string[] resourceId = param.ResourceId.Split(',');
                query = query.Where(data => resourceId.Contains(data.ResourceId.ToString()));
            }
            return Ok(query.ToList());
        }
    }
    public class Params
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string ResourceId { get; set; }
    }
}
```

**Note:** 
* The property will be effective, when large number of resources and appointments bound to the Scheduler.
* This property is applicable only when [resource grouping](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Schedule.ScheduleGroup.html#Syncfusion_EJ2_Schedule_ScheduleGroup_Resources) is enabled in Scheduler.

N> You can refer to our [ASP.NET Core Scheduler](https://www.syncfusion.com/aspnet-core-ui-controls/scheduler) feature tour page for its groundbreaking feature representations. You can also explore our [ASP.NET Core Scheduler example](https://ej2.syncfusion.com/aspnetcore/Schedule/Overview#/material) to knows how to present and manipulate data.
