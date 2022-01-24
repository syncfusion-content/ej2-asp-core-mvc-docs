---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Set State Persistence Of The Tab Component of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Set State Persistence Of The Tab Component
publishingplatform: ##Platform_Name##
documentation: ug
---


# Set state persistence of the Tab component

State persistence allows the Tab to retain the current modal value in the browser cookies for state maintenance. This action is handled through the enablePersistence property which is set to false by default.
When it is set to true, some of the Tab component model values will be retained even after refreshing the page.

The following sample demonstrates how to set state persistence of the Tab component.

{% aspTab template="tab/persistence", sourceFiles="styles.cs" %}

{% endaspTab %}

Output be like the below.

![State Persistence](../images/persistence.PNG)