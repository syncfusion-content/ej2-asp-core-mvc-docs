---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Title of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Title
publishingplatform: ##Platform_Name##
documentation: ug
---


# Title and Subtitle

## Title

The title of the Bullet Chart displays the information about the data plotted by specifying it in the `title` property.

{% aspTab template="bullet-chart/title/title", sourceFiles="title.cs" %}

{% endaspTab %}

![Bullet Chart with Title](images/blazor-bullet-chart-with-title.png)

## Subtitle

To show additional information about the data plotted, the Bullet Chart can also be given a subtitle using the `subtitle` property.

{% aspTab template="bullet-chart/title/sub-title", sourceFiles="sub-title.cs" %}

{% endaspTab %}

![Bullet Chart with Subtitle](images/blazor-bullet-chart-subtitle.png)

## Title and SubTitle Position

The title and the subtitle positions can be customized using the `titlePosition` property. Possible positions are **Left**, **Right**, **Top**, and **Bottom**.

### Position as Left

By setting the `titlePosition` to **Left**, you can display the title and subtitle at the left side of the Bullet Chart.

{% aspTab template="bullet-chart/title/left", sourceFiles="left.cs" %}

{% endaspTab %}

### Position as Right

By setting the `titlePosition` to **Right**, you can display the title and subtitle at the right side of the Bullet Chart.

{% aspTab template="bullet-chart/title/right", sourceFiles="right.cs" %}

{% endaspTab %}

### Position as Top

By setting the `titlePosition` to **Top**, you can display the title and subtitle at the top of the Bullet Chart. The default title and subtitle positions of the Bullet Chart is **Top**.

{% aspTab template="bullet-chart/title/top", sourceFiles="top.cs" %}

{% endaspTab %}

### Position as Bottom

By setting the `titlePosition` to **Bottom**, you can display the title and subtitle at the bottom of the Bullet Chart.

{% aspTab template="bullet-chart/title/bottom", sourceFiles="bottom.cs" %}

{% endaspTab %}

![Title and Subtitle Position in Bullet Chart](images/blazor-bullet-chart-title-positions.png)

## Title Customization

The title color, opacity, font size, font family, font weight, and font style can be customized using the `titleStyle` property.

{% aspTab template="bullet-chart/title/title-custom", sourceFiles="title-custom.cs" %}

{% endaspTab %}

## SubTitle Customization

The sub-title color, opacity, font size, font family, font weight, and font style can be customized using the `subtitleStyle` property.

{% aspTab template="bullet-chart/title/sub-title-custom", sourceFiles="sub-title-custom.cs" %}

{% endaspTab %}

![Customizing Title and Subtitle in Bullet Chart](images/blazor-bullet-chart-title-customization.png)