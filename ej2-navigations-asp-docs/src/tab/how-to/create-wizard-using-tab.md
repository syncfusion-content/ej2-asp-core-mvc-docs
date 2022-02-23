---
title: "Create wizard using Tab"
component: "Tab"
description: "This online reservation example demonstrates how to create multiple components inside the Essential JS 2 Tab component."
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

{% aspTab template="tab/wizard", sourceFiles="wizard.cs" %}

{% endaspTab %}