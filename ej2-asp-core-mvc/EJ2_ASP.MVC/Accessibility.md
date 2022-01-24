---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Accessibility of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Accessibility
publishingplatform: ##Platform_Name##
documentation: ug
---

---
layout: post
title: Accessibility | ASP.NET MVC | Syncfusion
description: Accessibility 
platform: ej2-asp-core-mvc
control: Common 
publishingplatform: ##Platform_Name##
documentation: ug
--- 

{% if page.publishingplatform == "aspnet-mvc" %}


# Rulers

The `Ruler` provides a Horizontal and Vertical guide for measuring in the Diagram control. The Ruler can be used to measure the Diagram objects, indicate positions, and align Diagram elements. This is especially useful in creating scale models.  

## Adding Rulers to the Diagram
Rulers can be enabled by setting the ruler Setting’s `ShowRulers` property for the diagram control.

Use the following code example to enable/disable the ruler to the Diagram.


{% highlight c# %}

    DiagramBuilderModel diagramModel = new DiagramBuilderModel();

    diagramModel.Model.RulerSettings = new RulerSettings();
    diagramModel.Model.RulerSettings.ShowRulers = true;

{% endhighlight %}


![](/aspnetmvc/Diagram/Rulers_images/Rulers_image1.png)

## Customizing the Ruler

The rulerSetting's `Interval` property is used to define the number of tick's between two major stroke lines of the ruler. 

The ruler Setting’s `SegmentWidth` is used to defines the space between the two major tick strokes.

The `ArrangeTick` event will be triggered when each tick have been drawn.By using this event you can customize the length of the tick.

Use the following code example to customize the ruler's segment.

{% tabs %} 
{% highlight c# %}

    DiagramBuilderModel diagramModel = new DiagramBuilderModel();

    diagramModel.Model.RulerSettings = new RulerSettings();
    diagramModel.Model.RulerSettings.ShowRulers = true;
    //Customizing the horizontal ruler.
    DiagramRuler HorizontalRuler = new DiagramRuler();
    //Creating a custom segment with 6 intervals.
    HorizontalRuler.Interval = 6;
    // Customizing the ruler segment width.
    HorizontalRuler.SegmentWidth = 100;
    // Customizing the Ruler ticks.
    HorizontalRuler.ArrangeTick = "arrangeTick";
    
    DiagramRuler VerticalRuler = new DiagramRuler();
    VerticalRuler.Interval = 6;
    VerticalRuler.SegmentWidth = 100;
    VerticalRuler.ArrangeTick = "arrangeTick";
   
    diagramModel.Model.RulerSettings.HorizontalRuler = HorizontalRuler;
    diagramModel.Model.RulerSettings.VerticalRuler = VerticalRuler;

{% endhighlight %}


{% highlight js %} 

    function arrangeTick(args) {
        // Customizing the Ruler ticks.
        if (args.tickInterval % 100 == 0) {
        }
        else if (args.tickInterval % 50 == 0) {
            args.tickLength = 12.5
        }
    }

{% endhighlight %}
{% endtabs %}


The width of the ruler can be set through `Thickness` property. If it’s an horizontal ruler, thickness will be taken as height of the ruler.

Tick alignment can be modified using `TickAlignment` as either `LeftOrTop` or `RightOrBottom`.

The `MarkerColor` property of the ruler is used to indicate the position of the mouse cursor.

Use the following code example to customize the ruler's tick.


{% highlight c# %}

    DiagramBuilderModel diagramModel = new DiagramBuilderModel();

    diagramModel.Model.RulerSettings = new RulerSettings();
    diagramModel.Model.RulerSettings.ShowRulers = true;
    //Customizing the horizontal ruler.
    DiagramRuler HorizontalRuler = new DiagramRuler();

    // Customizing the Ruler ticks alignment.
    HorizontalRuler.TickAlignment = TickAlignment.LeftOrTop;
    // Customizing the Ruler marker color
    HorizontalRuler.MarkerColor = "blue";
    // Customizing the thickness of the ruler bar.
    HorizontalRuler.Thickness = 25;

    DiagramRuler VerticalRuler = new DiagramRuler();
    VerticalRuler.TickAlignment = TickAlignment.LeftOrTop;
    VerticalRuler.MarkerColor = "blue";
    VerticalRuler.Thickness = 25;

    diagramModel.Model.RulerSettings.HorizontalRuler = HorizontalRuler;
    diagramModel.Model.RulerSettings.VerticalRuler = VerticalRuler;

{% endhighlight %} 

![](/aspnetmvc/Diagram/Rulers_images/Rulers_image2.png)


{% endif %}