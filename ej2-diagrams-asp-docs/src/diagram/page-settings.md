---
title: "Page Settings"
component: "Diagram"
description: "Page settings enable you to customize the appearance, width, and height of the diagram page."
---

# Page Settings

Page settings enable to customize the appearance, width, and height of the diagram page.

## Page size and appearance

* The size and appearance of the diagram pages can be customized with the page settings property.

* The [`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramPageSettings.html#Syncfusion_EJ2_Diagrams_DiagramPageSettings_Width) and [`height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramPageSettings.html#Syncfusion_EJ2_Diagrams_DiagramPageSettings_Height) properties of page settings define the size of the page and based on the size, the [`orientation`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramPageSettings.html#Syncfusion_EJ2_Diagrams_DiagramPageSettings_Orientation) will be set for the page. In addition to that, the appearance of the page can be customized with [`source`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramBackground.html#Syncfusion_EJ2_Diagrams_DiagramBackground_Source) and set of appearance specific properties.

* The [`color`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramBackground.html#Syncfusion_EJ2_Diagrams_DiagramBackground_Color) property is used to customize the background color and border color of the page.

* The [`margin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramPageSettings.html#Syncfusion_EJ2_Diagrams_DiagramPageSettings_Margin) property is used to define the page margin.

* To explore those properties, refer to [`Page Settings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramPageSettings.htmll).

{% aspTab template="diagram/pageSettings/page", sourceFiles="page.cs" %}

{% endaspTab %}

## Set background image

Stretch and align the background image anywhere over the diagram area.
The [`source`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramBackground.html#Syncfusion_EJ2_Diagrams_DiagramBackground_Source) property of [`background`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramBackground.html) allows you to set the path of the image.
The [`scale`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramBackground.html#Syncfusion_EJ2_Diagrams_DiagramBackground_Scale) and the [`align`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramBackground.html#Syncfusion_EJ2_Diagrams_DiagramBackground_Align) properties help to stretch/align the background images.

The following code illustrates how to stretch and align the background image.

{% aspTab template="diagram/pageSettings/image", sourceFiles="image.cs" %}

{% endaspTab %}

## Multiple page and page breaks

When multiple page is enabled, the size of the page dynamically increases or decreases in multiples of page width and height and completely fits diagram within the page boundaries. Page breaks is used as a visual guide to see how pages are split into multiple pages.

The [`multiplePage`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramPageSettings.html#Syncfusion_EJ2_Diagrams_DiagramPageSettings_MultiplePage) and [`showPageBreak`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramPageSettings.html#Syncfusion_EJ2_Diagrams_DiagramPageSettings_ShowPageBreaks) properties of page settings allow you to enable/disable multiple pages and page breaks respectively.
The following code illustrates how to enable multiple page and page break lines.

{% aspTab template="diagram/pageSettings/image", sourceFiles="image.cs" %}

{% endaspTab %}

## Boundary constraints

The diagram provides support to restrict/customize the interactive region, out of which the elements cannot be dragged, resized, or rotated. The [`boundaryConstraints`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.BoundaryConstraints.html) property of page settings allows you to customize the interactive region.
To explore the boundary constraints, refer to [`Boundary Constraints`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.BoundaryConstraints.html).

The following code example illustrates how to define boundary constraints with respect to the page.

{% aspTab template="diagram/pageSettings/boundry", sourceFiles="bound.cs" %}

{% endaspTab %}