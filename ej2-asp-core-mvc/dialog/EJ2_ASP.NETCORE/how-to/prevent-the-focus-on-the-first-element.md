---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Prevent The Focus On The First Element of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Prevent The Focus On The First Element
publishingplatform: ##Platform_Name##
documentation: ug
---


# Prevent the focus on the first element

By default, the dialog focuses on the first elements of the content area which can be active and focusable. You can prevent this default focusing behavior using the [`open`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_Open) event and by enabling the `preventFocus` argument.

Bind the open event and enable the preventFocus argument within an event like the below example.

{% aspTab template="dialog/how-to/dlg-focus", sourceFiles="controller.cs" %}

{% endaspTab %}