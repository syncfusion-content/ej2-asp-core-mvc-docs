---
layout: post
title: Ruler in ##Platform_Name## Diagram Component
description: Learn here all about Ruler in Syncfusion ##Platform_Name## Diagram component and more.
platform: ej2-asp-core-mvc
control: Ruler
publishingplatform: ##Platform_Name##
documentation: ug
---

# Ruler

The Ruler provides a horizontal and vertical guide for measuring in the Diagram control. The Ruler can be used to measure the diagram objects, indicate positions, and align diagram elements. This is especially useful in creating scale models.

## Adding Rulers to the Diagram

* The [`rulerSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramRulerSettings.html)property is used to control the visibility and appearance of the ruler in the diagram.

* The RulerSettings [`showRulers`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramRulerSettings.html#Syncfusion_EJ2_Diagrams_DiagramRulerSettings_ShowRulers)property is used to show or hide the rulers in the diagram.

* The RulerSettings [`horizontalRuler`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramRulerSettings.html#Syncfusion_EJ2_Diagrams_DiagramRulerSettings_HorizontalRuler) and [`verticalRuler`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramRulerSettings.html#Syncfusion_EJ2_Diagrams_DiagramRulerSettings_VerticalRuler) properties are used to customize the rulers appearance in the diagram.

The following code shows how to add a ruler to the diagram.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Ruler.cshtml" %}
{% include code-snippet/diagram/ruler/ruler/ruler.cshtml %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Ruler.cshtml" %}
{% include code-snippet/diagram/ruler/ruler/ruler.cshtml %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Ruler](images/Ruler.png)

## Customizing the Ruler

By default, the ruler segments are arranged based on pixel values.

* The HorizontalRuler’s [`interval`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramDiagramRuler.html#Syncfusion_EJ2_Diagrams_DiagramDiagramRuler_Interval)property allows you to define the interval between ruler segments and the [`segmentWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramDiagramRuler.html#Syncfusion_EJ2_Diagrams_DiagramDiagramRuler_SegmentWidth) property allows you to define the segment width of the ruler. Similarly, you can use the VerticalRuler’s [`interval`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramDiagramRuler.html#Syncfusion_EJ2_Diagrams_DiagramDiagramRuler_Interval) and [`segmentWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramDiagramRuler.html#Syncfusion_EJ2_Diagrams_DiagramDiagramRuler_SegmentWidth) properties are used to define the interval and segment width of the vertical ruler

* The HorizontalRuler’s [`tickAlignment`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramDiagramRuler.html#Syncfusion_EJ2_Diagrams_DiagramDiagramRuler_TickAlignment) property is used to align the ruler tick either left or right side of the ruler. The VerticalRuler’s [`tickAlignment`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramDiagramRuler.html#Syncfusion_EJ2_Diagrams_DiagramDiagramRuler_TickAlignment) property is used to align the ruler tick either top or bottom side of the ruler.

* The HorizontalRuler’s [`arrangeTick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramDiagramRuler.html#Syncfusion_EJ2_Diagrams_DiagramDiagramRuler_ArrangeTick) and VerticalRuler’s [`arrangeTick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramDiagramRuler.html#Syncfusion_EJ2_Diagrams_DiagramDiagramRuler_ArrangeTick) function is provided for the purpose of customizing the appearance of ruler ticks. It will be called for each tick rendering.

* The HorizontalRuler’s [`markerColor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramDiagramRuler.html#Syncfusion_EJ2_Diagrams_DiagramDiagramRuler_MarkerColor) and VerticalRuler’s [`markerColor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramDiagramRuler.html#Syncfusion_EJ2_Diagrams_DiagramDiagramRuler_MarkerColor) properties are used to define the ruler marker color and marker will be shown when performing the interaction in the diagram.

The following code shows how the diagram ruler can be customized.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="CustomRuler.cshtml" %}
{% include code-snippet/diagram/ruler/customRuler/customRuler.cshtml %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="CustomRuler.cshtml" %}
{% include code-snippet/diagram/ruler/customRuler/customRuler.cshtml %}
{% endhighlight %}
{% endtabs %}
{% endif %}



>Note : The MarkerColor property can be customized using the [`Marker`](./style/#customizing-the-ruler) CSS style.

![Customize](images/CustomRuler.png)
