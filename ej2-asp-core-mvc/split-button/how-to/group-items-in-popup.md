---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Group Items In Popup of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Group Items In Popup
publishingplatform: ##Platform_Name##
documentation: ug
---


# Group items in Popup

Grouped items are possible in SplitButton by templating entire popup with ListView. Check ListView [`grouping`](../list-view/grouping#grouping) and create such items. Create ListView with id `listview` and provide element of the ListView as target of SplitButton to render it in popup area.

In this following example, ListView is created and its element is set as [`target`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.SplitButton.html#Syncfusion_EJ2_SplitButtons_SplitButton_Target) for SplitButton.

{% aspTab template="split-button/listview/demo", sourceFiles="listview.cs" %}

{% endaspTab %}