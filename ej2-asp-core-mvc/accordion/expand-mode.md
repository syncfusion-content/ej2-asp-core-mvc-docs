---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Expand Mode of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Expand Mode
publishingplatform: ##Platform_Name##
documentation: ug
---


# Expand Mode

 The Accordion supports the two listed types of expand modes while expanding or collapsing the item.

* Single
* Multiple

## Single

The property enables to expand only one Accordion item at a time. If you expand any new item, the previously expanded one is collapsed and new item changed to expanded state.

{% aspTab template="accordion/expandMode/single", sourceFiles="single.cs" %}

{% endaspTab %}

Output be like the below.

![Accordion Control with expand mode of single type](./images/single.PNG)

## Multiple

Default expand mode of the Accordion is `Multiple`. It enables you to expand more than one Accordion item at a time. Expand/collapse action can also be toggled by clicking on it again. For example, expanded item is collapsed when you click on it again.

{% aspTab template="accordion/expandMode/multiple", sourceFiles="multiple.cs" %}

{% endaspTab %}

Output be like the below.

![Accordion Control with expand mode of multiple type](./images/multiple.PNG)

## See Also

* [How to keep single pane open always](./how-to/to-keep-single-pane-open-always)