---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Save of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Save
publishingplatform: ##Platform_Name##
documentation: ug
---


# Save Rich Text Editor content in a file in the server

Rich Text Editor content can be passed from view to controller through `XMLHttpRequest` post. Content
will be sent to the corresponding method into the controller and this value can be saved in a text
file or any other format using `streamWriter`. Refer to the following given code.

{% aspTab template="rich-text-editor/how-to/savefile", sourceFiles="controller.cs" %}

{% endaspTab %}