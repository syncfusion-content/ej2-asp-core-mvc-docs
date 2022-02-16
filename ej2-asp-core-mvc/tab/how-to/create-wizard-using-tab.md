---
layout: post
title: Create Wizard Using Tab in ##Platform_Name## Tab Component
description: Learn here all about Create Wizard Using Tab in Syncfusion ##Platform_Name## Tab component and more.
platform: ej2-asp-core-mvc
control: Create Wizard Using Tab
publishingplatform: ##Platform_Name##
documentation: ug
---


# Create wizard using Tab

Tab items can be disabled initial control rendering by passing the boolean value to [`disabled`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.TabTabItem~Disabled.html) property of [`TabItem`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.TabTabItem.html) class.

In the below Wizard sample, each Tab is integrated with required components to complete the reservation. Each field is provided with validation
 for all mandatory option to proceed to next tabs. Using Tab item's template property the components are added into
 content.

Create the following contents for each tab in the wizard.
1. **Search tab:**
   Created with [`DropDownList`] to select the source, destination and type of ticket. A [`DatePicker`] for choosing the date of journey.
2. **Train tab:**
   Based on the selected start and end point, populated Grid with random list of available seats and train list. Initially define the columns
    and row selected event for validating, after the source and destination chosen update the [`dataSource`] for the Grid.
3. **Passenger tab:**
   A table with Textbox, Numeric, DropDownList for adding passenger name, age, gender and preferred berth/seat. Add validation on entering
   passenger details to proceed.
4. **Payment tab:**
   Calculate the ticket cost based on location, passenger count and ticket type. Generate data for Grid with passenger details, train number
   and ticket cost summary.

You can go back on each tab using buttons available in it and tabs are disabled to navigate through tab header click actions. Once you end
the wizard all the data get cleared and wizard goes back to starting tab.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tab/wizard/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Wizard.cs" %}
{% include code-snippet/tab/wizard/wizard.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tab/wizard/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Wizard.cs" %}
{% include code-snippet/tab/wizard/wizard.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

