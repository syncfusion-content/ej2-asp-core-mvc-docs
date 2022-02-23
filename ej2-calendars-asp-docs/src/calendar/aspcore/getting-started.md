---
title: "Getting Started"
component: "Calendar"
description: "This getting started section briefly explains how to create a calendar component in an application."
---

# Getting Started

This section briefly explains how to include simple Calendar control in your ASP.NET Core application. You can refer to [ASP.NET Core Getting Started documentation](../../getting-started/) page for system requirements, and configure common specifications.

> Starting with v16.2.0.x, if you reference Syncfusion assemblies from trial setup or from the NuGet feed, you also have to include a license key in your projects. Please refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key#aspnet-core) to know about registering Syncfusion license key in your ASP.NET Core application to use our controls.

## Initialize Calendar control to the Application

Calendar control can be rendered by using the `ejs-calendar` tag helper in ASP.NET Core application. Add the below simple code to your `index.cshtml` page which is available within the `Views/Home` folder, to initialize the Calendar.

The following example shows a basic Calendar control.

{% aspTab template="calendar/getting-started/getting-started" %}

{% endaspTab %}

> Running the above code will display the basic Calendar on the browser.

## Setting the value within min and max dates

After rendering a simple Calendar control by following the above steps, configure the Calendar to set a value within a specific range using its value, min, and max properties.

Here the Calendar allows you to select a date within the range from 5th to 27th of this month.

{% aspTab template="calendar/getting-started/daterange/", sourceFiles="daterange.cs" %}

{% endaspTab %}

## See Also

* [Select multiple dates in the Calendar](./multi-select)
* [Render Calendar with specific culture](./globalization)
* [How to change the initial view of the Calendar](./calendar-views)
* [Render Calendar with week numbers](./how-to/render-the-calendar-with-week-numbers)
* [Show other month dates](./how-to/show-dates-of-other-months)