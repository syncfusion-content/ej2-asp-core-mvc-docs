---
title: "Render the Tab items using content template"
component: "Tab"
description: "This example demonstrates how to render the Tab items using content template in the Essential JS 2 Tab component"
---

# Render the Tab items using content template

You can bind any data in Tab items, by simply using the content template property in ASP.NET Tab.

In the below demo, the tab items are given as [chart](../../chart), [grid](../../grid), [calender](../../calendar) using the content template. In the content template you can give the header using `e-tab-header` and content using `e-content` class.

{% aspTab template="tab/contenttemplate", sourceFiles="contenttemplate.cs" %}

{% endaspTab %}

Output be like the below.

![content template](../images/contenttemplate.PNG)
