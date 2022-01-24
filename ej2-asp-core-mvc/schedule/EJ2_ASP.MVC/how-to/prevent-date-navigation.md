---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Prevent Date Navigation of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Prevent Date Navigation
publishingplatform: ##Platform_Name##
documentation: ug
---

# Prevent the Date Navigation

We can prevent navigation while clicking on the date header by simply removing `e-navigate` class from header cells which can be achieved in the `RenderCell` event as shown in the following code example.

{% aspTab template="schedule/how-to/navigating", sourceFiles="data.cs"  %}

{% endaspTab %}