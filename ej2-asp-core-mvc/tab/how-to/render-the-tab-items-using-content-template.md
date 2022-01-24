---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Render The Tab Items Using Content Template of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Render The Tab Items Using Content Template
publishingplatform: ##Platform_Name##
documentation: ug
---


# Render the Tab items using content template

You can bind any data in Tab items, by simply using the content template property in ASP.NET Tab.

In the below demo, the tab items are given as [chart](../../chart), [grid](../../grid), [calender](../../calendar) using the content template. In the content template you can give the header using `e-tab-header` and content using `e-content` class.

{% aspTab template="tab/contenttemplate", sourceFiles="contenttemplate.cs" %}

{% endaspTab %}

Output be like the below.

![content template](../images/contenttemplate.PNG)
