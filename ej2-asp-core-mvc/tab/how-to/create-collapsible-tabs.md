---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Create Collapsible Tabs of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Create Collapsible Tabs
publishingplatform: ##Platform_Name##
documentation: ug
---


# Create collapsible Tabs

You can achieve collapse and expand functionality in Tab by adding/removing a custom CSS class in the click event handler for each tab.

* Define a CSS class to set the style property display as none. Here 'collapse' class is added to the content element for hiding it.
* Bind the `select`  event for Tab to collapse the initially selected Tab item and bind custom click handler for the Tab headers.
* In the event handler, add and remove 'collapse' class to hide and show the corresponding Tab content.

{% aspTab template="tab/collapsible", sourceFiles="collapsible.cs" %}

{% endaspTab %}