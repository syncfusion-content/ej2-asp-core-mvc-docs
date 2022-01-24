---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Labels of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Labels
publishingplatform: ##Platform_Name##
documentation: ug
---


# Labels

## Multilevel labels

The multi-level labels for the Range Selector can be enabled by setting the `enableGrouping` property to **true**. This is restricted to the DateTime axis alone.

{% aspTab template="range-navigator/label/multi", sourceFiles="multi.cs" %}

{% endaspTab %}

![Multilevel labels](images/labels/multi.png)

## Grouping

The multi-level labels can be grouped using the `groupBy` property with the following interval types:

* Auto
* Years
* Quarter
* Months
* Weeks
* Days
* Hours
* Minutes
* Seconds

{% aspTab template="range-navigator/label/group", sourceFiles="group.cs" %}

{% endaspTab %}

![Grouping](images/labels/group.png)

## Smart labels

The `labelIntersectAction` property is used to avoid overlapping of labels. The following code sample shows the setting of `labelIntersectAction` property to **Hide**.

{% aspTab template="range-navigator/label/smart", sourceFiles="smart.cs" %}

{% endaspTab %}

![Smart labels](images/labels/smart.png)

## Label positioning

By default, the labels can be placed outside the Range Selector. It can also be placed inside the Range Selector using the `labelPosition` property.

{% aspTab template="range-navigator/label/position", sourceFiles="position.cs" %}

{% endaspTab %}

![Label positioning](images/labels/position.png)

## Labels customization

The font size, color, family, etc. can be customized using the `labelStyle` setting.

{% aspTab template="range-navigator/label/custom", sourceFiles="custom.cs" %}

{% endaspTab %}

![Labels Customization](images/labels/custom.png)