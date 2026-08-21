---
layout: post
title: How to create wizard using tab in ##Platform_Name## Tabs | Syncfusion
description: Build a multi-step reservation wizard using Syncfusion ##Platform_Name## Tabs with integrated DropDownList, DatePicker, Grid, and validation between each step.
platform: ej2-asp-core-mvc
control: Tab
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to create wizard using tab in ##Platform_Name## Tabs

{% if page.publishingplatform == "aspnet-core" %}

Tab items can be disabled during initial control rendering by passing a Boolean value to the [disabled](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.TabItem.html#Syncfusion_EJ2_Navigations_TabItem_Disabled) property of [TabItem](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.TabItem.html#Syncfusion_EJ2_Navigations_TabItem_TabIndex) class.

{% elsif page.publishingplatform == "aspnet-mvc" %}

Tab items can be disabled during initial control rendering by passing a Boolean value to the [disabled](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.TabItem.html#Syncfusion_EJ2_Navigations_TabItem_Disabled) property of [TabItem](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.TabItem.html#Syncfusion_EJ2_Navigations_TabItem_TabIndex) class.

{% endif %}

In the following wizard example, each Tab is integrated with required controls to complete the reservation. Each field is provided with validation for all mandatory options to proceed to next tabs. Using Tab item's template property the controls are added into content.

Create the following contents for each tab in the wizard.
1. **Search tab:**
   Created with [`DropDownList`] to select the source, destination and type of ticket. A [`DatePicker`] for choosing the date of journey.
2. **Train tab:**
   Based on the selected start and end point, populated Grid with random list of available seats and train list. Initially define the columns and row selected event for validating, after the source and destination chosen update the [`dataSource`] for the Grid.
3. **Passenger tab:**
   A table with Textbox, Numeric, DropDownList for adding passenger name, age, gender and preferred berth/seat. Add validation on entering passenger details to proceed.
4. **Payment tab:**
   Calculate the ticket cost based on location, passenger count and ticket type. Generate data for Grid with passenger details, train number and ticket cost summary.

You can go back on each tab using buttons available in it and tabs are disabled to navigate through tab header click actions. Once you end the wizard all the data is cleared and wizard goes back to the starting tab.

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

