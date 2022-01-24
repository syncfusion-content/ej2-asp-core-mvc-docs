---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Change Sub Menu Position of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Change Sub Menu Position
publishingplatform: ##Platform_Name##
documentation: ug
---

# Change sub menu position

The submenu position can be changed by using the [`beforeOpen`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Menu~BeforeOpen.html) event. Assign the top and left position where you want to open the submenu to the [`beforeOpen`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Menu~BeforeOpen.html) event arguments `args.top` and `args.left` respectively.

In the below sample, the sub menu opens above the parent menu item.

{% aspTab template="menu/how-to/position", sourceFiles="Position.cs" %}

{% endaspTab %}

>> For custom positioning, set both `top` and `left` position in the [`beforeOpen`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Menu~BeforeOpen.html) event.