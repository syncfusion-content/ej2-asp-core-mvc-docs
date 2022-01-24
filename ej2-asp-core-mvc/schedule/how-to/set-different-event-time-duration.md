---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Set Different Event Time Duration of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Set Different Event Time Duration
publishingplatform: ##Platform_Name##
documentation: ug
---

# Set Different Time Duration on Event Editor

In event window, start/end time duration will be processed based on the `interval` value within the `timeScale` property. By default, `interval` value is 30, therefore in event window start/end time duration will be in 30 mins duration. You can set custom interval range to the start/end time in event window using `popupOpen` event as shown below.

{% aspTab template="schedule/how-to/event-duration", sourceFiles="data.cs"  %}

{% endaspTab %}