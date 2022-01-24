---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Passing Parameter To Server Exporting of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Passing Parameter To Server Exporting
publishingplatform: ##Platform_Name##
documentation: ug
---


# Passing additional parameters to the server when Exporting

You can pass the additional parameter in the `query` property by invoking `addParams` method. In the `toolbarClick` event, you can define params as key and value pair so it will receive at the server side when exporting.

In the below example, we have passed `recordcount` as `12` using `addParams` method.

{% aspTab template="grid/how-to/passing-params-exporting", sourceFiles="additional-parameter.cs" %}

{% endaspTab %}