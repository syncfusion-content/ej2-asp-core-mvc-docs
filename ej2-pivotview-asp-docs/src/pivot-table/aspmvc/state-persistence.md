---
title: "State Persistence"
component: "Pivot Table"
description: "Describes about persistence in pivot table"
---

# State Persistence

State persistence allows user to maintain the current state of the component along with its report bounded in the browser local storage (cookie). Even if the browser is refreshed or if you move to the next page within the browser, components state will be persisted. State persistence stores the Pivot Table object in the local storage when [`EnablePersistence`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_EnablePersistence) property in [`PivotView`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html) class is set to **true**.

{% aspTab template="pivot-table/state-persistence/persistence", sourceFiles="Persistence.cs" %}

{% endaspTab %}

# Save and Load Pivot Layout

You can save the current layout of the pivot table by using `getPersistData` in string format. The saved layout can be loaded to pivot table any time by passing the saved data as a parameter to `loadPersistData` method in the [`PivotView`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html).

{% aspTab template="pivot-table/state-persistence/save-load", sourceFiles="Save.cs" %}

{% endaspTab %}