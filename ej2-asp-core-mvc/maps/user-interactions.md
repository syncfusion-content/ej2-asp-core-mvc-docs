---
layout: post
title: User Interactions in Syncfusion ##Platform_Name## Maps Component
description: Learn here all about User Interactions in Syncfusion ##Platform_Name## Maps component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: User Interactions
publishingplatform: ##Platform_Name##
documentation: ug
---

# User Interactions

## Zooming

The zooming feature is used to zoom in and out of Maps to show in-depth information. It is controlled by the `ZoomFactor` property of the `MapsZoomSettings` of the Maps. The `ZoomFactor` is increased or decrease dynamically based on zoom in and out interaction.

<b>Enable zooming</b>

Zooming of Maps is enabled by setting the `Enable` property of `MapsZoomSettings` to **true**.

<b>Enable panning</b>

To enable the panning feature, set the `EnablePanning` property of `MapsZoomSettings` to **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/user-interactions/panning/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Panning.cs" %}
{% include code-snippet/maps/user-interactions/panning/panning.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/user-interactions/panning/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Panning.cs" %}
{% include code-snippet/maps/user-interactions/panning/panning.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Various type of zooming

Zooming can be performed in following types:

#### Zooming toolbar

By default, the toolbar is rendered with **zoom-in**, **zoom-out**, and **reset** options when it is set to **true** in the `Enable` property of `MapsZoomSettings`.

The following options are available in toolbar.

1. Zoom - Provides rectangular zoom support.
2. ZoomIn - Zoom in the Maps.
3. ZoomOut - Zoom out the Maps.
4. Pan - Switches to panning if rectangular zoom is activated.
5. Reset - Restores the Maps to the default view.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/user-interactions/zoom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Zoom.cs" %}
{% include code-snippet/maps/user-interactions/zoom/zoom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/user-interactions/zoom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Zoom.cs" %}
{% include code-snippet/maps/user-interactions/zoom/zoom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



#### Pinch zooming

To enable or disable the pinch zooming, use the `PinchZooming` property in `MapsZoomSettings`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/user-interactions/pinchzoom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Pinchzoom.cs" %}
{% include code-snippet/maps/user-interactions/pinchzoom/pinchzoom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/user-interactions/pinchzoom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Pinchzoom.cs" %}
{% include code-snippet/maps/user-interactions/pinchzoom/pinchzoom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



#### Single-click zooming

To enable or disable the single-click zooming, use the `ZoomOnClick` property in `MapsZoomSettings`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/user-interactions/singleclickzoom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Singleclick.cs" %}
{% include code-snippet/maps/user-interactions/singleclickzoom/singleclick.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/user-interactions/singleclickzoom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Singleclick.cs" %}
{% include code-snippet/maps/user-interactions/singleclickzoom/singleclick.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



#### Double-click zooming

To enable or disable the double-click zooming, use the `DoubleClickZoom` property in `MapsZoomSettings`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/user-interactions/doubleclickzoom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Doubleclick.cs" %}
{% include code-snippet/maps/user-interactions/doubleclickzoom/doubleclick.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/user-interactions/doubleclickzoom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Doubleclick.cs" %}
{% include code-snippet/maps/user-interactions/doubleclickzoom/doubleclick.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



#### Mouse wheel zooming

To enable or disable mouse wheel zooming, use the `MouseWheelZoom` property in `MapsZoomSettings`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/user-interactions/mousewheel/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Mousewheel.cs" %}
{% include code-snippet/maps/user-interactions/mousewheel/mousewheel.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/user-interactions/mousewheel/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Mousewheel.cs" %}
{% include code-snippet/maps/user-interactions/mousewheel/mousewheel.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



#### Selection zooming

To enable or disable selection zooming, use the `EnableSelectionZooming` property in `MapsZoomSettings`. The `EnablePanning` property must be set to **false** to enable the selection zooming in Maps.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/user-interactions/selectionzooming/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Selectionzooming.cs" %}
{% include code-snippet/maps/user-interactions/selectionzooming/selectionzooming.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/user-interactions/selectionzooming/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Selectionzooming.cs" %}
{% include code-snippet/maps/user-interactions/selectionzooming/selectionzooming.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Setting minimum and maximum values for zoom factor

The zooming range can be adjusted using the `MinZoom` and `MaxZoom` properties in `MapsZoomSettings`. The minZoom value is set to 1 by default, and the maxZoom value is set to 10.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/user-interactions/minzooming/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Minzooming.cs" %}
{% include code-snippet/maps/user-interactions/minzooming/minzooming.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/user-interactions/minzooming/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Minzooming.cs" %}
{% include code-snippet/maps/user-interactions/minzooming/minzooming.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Zooming with animation

To zoom in or zoom out the Maps with animation, use the `AnimationDuration` property in `MapsLayer`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/user-interactions/animationzoom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Animationzoom.cs" %}
{% include code-snippet/maps/user-interactions/animationzoom/animationzoom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/user-interactions/animationzoom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Animationzoom.cs" %}
{% include code-snippet/maps/user-interactions/animationzoom/animationzoom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


### Customizing the zoom toolbar

{% if page.publishingplatform == "aspnet-core" %}

The zoom toolbar can be customized by using the `toolbarSettings` option in the [zoomSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsZoomSettings.html). The following properties can be used to customize the zoom toolbar.

* `backgroundColor` - It is used to customize the background color of the zoom toolbar.
* `borderOpacity` - It is used to customize the opacity of the border of the zoom toolbar.
* `borderWidth` - It is used to customize the thickness of the border of the zoom toolbar.
* `borderColor` - It is used to customize the color of the border of the zoom toolbar.
* `horizontalAlignment` - It is used to position the zoom toolbar in near, far, and center positions to customize its horizontal placement.
* `verticalAlignment` - It is used to position the zoom toolbar in near, far, and center positions to customize its vertical placement.
* `orientation` - It is used to change the orientation (horizontal/vertical) of the zoom toolbar.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/user-interactions/zoom-toolbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ZoomToolbar.cs" %}
{% include code-snippet/maps/user-interactions/zoom-toolbar/zoom-toolbar.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The zoom toolbar can be customized by using the `ToolbarSettings` option in the [ZoomSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsZoomSettings.html). The following properties can be used to customize the zoom toolbar.

* `BackgroundColor` - It is used to customize the background color of the zoom toolbar.
* `BorderOpacity` - It is used to customize the opacity of the border of the zoom toolbar.
* `BorderWidth` - It is used to customize the thickness of the border of the zoom toolbar.
* `BorderColor` - It is used to customize the color of the border of the zoom toolbar.
* `HorizontalAlignment` - It is used to position the zoom toolbar in near, far, and center positions to customize its horizontal placement.
* `VerticalAlignment` - It is used to position the zoom toolbar in near, far, and center positions to customize its vertical placement.
* `Orientation` - It is used to change the orientation (horizontal/vertical) of the zoom toolbar.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/user-interactions/zoom-toolbar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ZoomToolbar.cs" %}
{% include code-snippet/maps/user-interactions/zoom-toolbar/zoom-toolbar.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Zoom toolbar customization](./images/UserInteraction/zoom-toolbar-customization.PNG)

<!-- markdownlint-disable MD036 -->
**Customizing the buttons in the zoom toolbar**

{% if page.publishingplatform == "aspnet-core" %}

The appearance of the buttons in the zoom toolbar can be customized by using the `buttonSettings` option in the `toolbarSettings` of the [zoomSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsZoomSettings.html) property. The following properties can be used to customize the zoom toolbar buttons.

* `fill` - It is used to set the background color of the buttons.
* `color` - It is used to customize the color of the icons inside the button.
* `borderOpacity` - It is used to set the opacity of the border of the zoom toolbar buttons.
* `borderWidth` - It is used to set the thickness of the border of the zoom toolbar buttons.
* `borderColor`- It is used to set the color of the border of the zoom toolbar buttons.
* `radius` - It is used to set the size of the button.
* `selectionColor` - It is used to set the color of the icons inside the button when selection is performed.
* `highlightColor` - It is used to change the color of the button when the mouse is hovered over it.
* `padding` - It is used to change the padding space between each button.
* `opacity` - It is used to change the opacity of the button.
* `toolbarItems` - It is used to change the items that should be displayed in the zoom toolbar. By default, zoom-in, zoom-out, and reset buttons will be available. Other options include selection zoom and panning.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/user-interactions/zoom-toolbar-button/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="zoomToolbarButton.cs" %}
{% include code-snippet/maps/user-interactions/zoom-toolbar-button/zoom-toolbar-button.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The appearance of the buttons in the zoom toolbar can be customized by using the `ButtonSettings` option in the `ToolbarSettings` of the [ZoomSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsZoomSettings.html) property. The following properties can be used to customize the zoom toolbar buttons.

* `Fill` - It is used to set the background color of the buttons.
* `Color` - It is used to customize the color of the icons inside the button.
* `BorderOpacity` - It is used to set the opacity of the border of the zoom toolbar buttons.
* `BorderWidth` - It is used to set the thickness of the border of the zoom toolbar buttons.
* `BorderColor`- It is used to set the color of the border of the zoom toolbar buttons.
* `Radius` - It is used to set the size of the button.
* `SelectionColor` - It is used to set the color of the icons inside the button when selection is performed.
* `HighlightColor` - It is used to change the color of the button when the mouse is hovered over it.
* `Padding` - It is used to change the padding space between each button.
* `Opacity` - It is used to change the opacity of the button.
* `ToolbarItems` - It is used to change the items that should be displayed in the zoom toolbar. By default, zoom-in, zoom-out, and reset buttons will be available. Other options include selection zoom and panning.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/user-interactions/zoom-toolbar-button/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ZoomToolbarButton.cs" %}
{% include code-snippet/maps/user-interactions/zoom-toolbar-button/zoom-toolbar-button.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Zoom toolbar button customization](./images/UserInteraction/zoom-toolbar-button-customization.PNG)

<!-- markdownlint-disable MD036 -->
**Customizing the tooltip of the zoom toolbar**

{% if page.publishingplatform == "aspnet-core" %}

The appearance of the tooltip of the zoom toolbar can be customized by using the `tooltipSettings` option in the `toolbarSettings` of the [zoomSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsZoomSettings.html) property. The following properties are available to customize the zoom toolbar tooltip.

* `visible` - Enables or disables the tooltip of the zoom toolbar.
* `fill` - It is used to change the background color of the tooltip of the zoom toolbar.
* `borderOpacity` - It is used to change the opacity of the border of the zoom toolbar's tooltip.
* `borderWidth` - It is used to change the thickness of the border of the zoom toolbar's tooltip.
* `borderColor` - It is used to change the color of the border of the zoom toolbar's tooltip.
* `fontColor` - It is used to change the color of the text in the tooltip of the zoom toolbar.
* `fontFamily` - It is used to change the font family of the text in the tooltip of the zoom toolbar.
* `fontStyle` - It is used to change the font style of the text in the tooltip of the zoom toolbar.
* `fontWeight` - It is used to change the font weight of the text in the tooltip of the zoom toolbar.
* `fontSize` - It is used to change the size of the text in the tooltip of the zoom toolbar.
* `fontOpacity` - It is used to change the opacity of the text in the tooltip of the zoom toolbar.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/user-interactions/toolbar-button-tooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ToolbarButtonTooltip.cs" %}
{% include code-snippet/maps/user-interactions/toolbar-button-tooltip/toolbar-button-tooltip.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The appearance of the tooltip of the zoom toolbar can be customized by using the `TooltipSettings` option in the `ToolbarSettings` of the [ZoomSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsZoomSettings.html) property. The following properties are available to customize the zoom toolbar tooltip.

* `Visible` - Enables or disables the tooltip of the zoom toolbar.
* `Fill` - It is used to change the background color of the tooltip of the zoom toolbar.
* `BorderOpacity` - It is used to change the opacity of the border of the zoom toolbar's tooltip.
* `BorderWidth` - It is used to change the thickness of the border of the zoom toolbar's tooltip.
* `BorderColor` - It is used to change the color of the border of the zoom toolbar's tooltip.
* `FontColor` - It is used to change the color of the text in the tooltip of the zoom toolbar.
* `FontFamily` - It is used to change the font family of the text in the tooltip of the zoom toolbar.
* `FontStyle` - It is used to change the font style of the text in the tooltip of the zoom toolbar.
* `FontWeight` - It is used to change the font weight of the text in the tooltip of the zoom toolbar.
* `FontSize` - It is used to change the size of the text in the tooltip of the zoom toolbar.
* `FontOpacity` - It is used to change the opacity of the text in the tooltip of the zoom toolbar.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/user-interactions/toolbar-button-tooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ToolbarButtonTooltip.cs" %}
{% include code-snippet/maps/user-interactions/toolbar-button-tooltip/toolbar-button-tooltip.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Zoom toolbar tooltip customization](./images/UserInteraction/zoom-toolbar-tooltip-customization.PNG)

## Selection

Each shape in the Maps can be selected and deselected during interaction with the shapes. Selection is enabled by setting the `Enable` property of `MapsSelectionSettings` to **true**.

The following properties are available to customize the selection of Maps elements such as shapes, bubbles, markers and legends.

* `Border` - To customize the color, width and opacity of the border of which element is selected in Maps.
* `Fill` - Applies the color for the element that is selected.
* `Opacity` - To customize the transparency for the element that is selected.
* `EnableMultiSelect` - To enable or disable the selection for multiple shapes or markers or bubbles in the Maps.

By tapping on the specific legend, the shapes which are bounded to the selected legend is also selected and vice versa.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/user-interactions/selection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Selection.cs" %}
{% include code-snippet/maps/user-interactions/selection/selection.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/user-interactions/selection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Selection.cs" %}
{% include code-snippet/maps/user-interactions/selection/selection.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Enable selection](./images/UserInteraction/selection-legend.PNG)

### Enable selection for bubbles

To enable the selection for bubbles in Maps, set the `MapsSelectionSettings` in `MapsBubble` and set the `Enable` property of `MapsSelectionSettings` as **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/user-interactions/selection-bubble/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Selection-bubble.cs" %}
{% include code-snippet/maps/user-interactions/selection-bubble/selection-bubble.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/user-interactions/selection-bubble/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Selection-bubble.cs" %}
{% include code-snippet/maps/user-interactions/selection-bubble/selection-bubble.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Enable selection for bubbles](./images/UserInteraction/selection-bubble.PNG)

### Enable selection for markers

To enable the selection for markers in Maps, set the `MapsSelectionSettings` in the `MapsMarker` and set the `Enable` property of the `MapsSelectionSettings` as **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/user-interactions/selection-marker/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Selection-marker.cs" %}
{% include code-snippet/maps/user-interactions/selection-marker/selection-marker.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/user-interactions/selection-marker/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Selection-marker.cs" %}
{% include code-snippet/maps/user-interactions/selection-marker/selection-marker.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Enable selection for markers](./images/UserInteraction/selection-marker.PNG)

### Enable selection for polygons

{% if page.publishingplatform == "aspnet-core" %}

When the [enable](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsSelectionSettings.html#Syncfusion_EJ2_Maps_MapsSelectionSettings_Enable) property of [selectionSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsSelectionSettings.html#properties) is set to **true**, the polygon shapes can be selected via user interaction. The following properties are available in `selectionSettings` to customize the polygon shape when it is selected.

* [enableMultiSelect](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsSelectionSettings.html#Syncfusion_EJ2_Maps_MapsSelectionSettings_EnableMultiSelect) - It is used to enable multiple selection of polygon shapes.
* [fill](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsSelectionSettings.html#Syncfusion_EJ2_Maps_MapsSelectionSettings_Fill) - It is used to change the color of the selected polygon shape.
* [opacity](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsSelectionSettings.html#Syncfusion_EJ2_Maps_MapsSelectionSettings_Opacity) - It is used to change the opacity of the selected polygon shape.
* [border](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsSelectionSettings.html#Syncfusion_EJ2_Maps_MapsSelectionSettings_Border) - This property is used to change the color, width, and opacity of the border of the selected polygon shape.

The following example shows how to select the polygon shape in the geometry map.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/polygon/polygon-shape-selection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Polygon-shape-selection.cs" %}
{% include code-snippet/maps/polygon/polygon-shape-selection/polygon-shape-selection.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

When the [Enable](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsSelectionSettings.html#Syncfusion_EJ2_Maps_MapsSelectionSettings_Enable) property of [SelectionSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsSelectionSettings.html#properties) is set to **true**, the polygon shapes can be selected via user interaction. The following properties are available in `SelectionSettings` to customize the polygon shape when it is selected.

* [EnableMultiSelect](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsSelectionSettings.html#Syncfusion_EJ2_Maps_MapsSelectionSettings_EnableMultiSelect) - It is used to enable multiple selection of polygon shapes.
* [Fill](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsSelectionSettings.html#Syncfusion_EJ2_Maps_MapsSelectionSettings_Fill) - It is used to change the color of the selected polygon shape.
* [Opacity](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsSelectionSettings.html#Syncfusion_EJ2_Maps_MapsSelectionSettings_Opacity) - It is used to change the opacity of the selected polygon shape.
* [Border](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsSelectionSettings.html#Syncfusion_EJ2_Maps_MapsSelectionSettings_Border) - This property is used to change the color, width, and opacity of the border of the selected polygon shape.

The following example shows how to select the polygon shape in the geometry map.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/polygon/polygon-shape-selection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Polygon-shape-selection.cs" %}
{% include code-snippet/maps/polygon/polygon-shape-selection/polygon-shape-selection.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Enable selection for polygons](./images/Polygon/polygon-shape-selection.gif)


### Public method for the shape selection

The `shapeSelection` method can be used to select each shape in the Maps. LayerIndex, propertyName, country name, and selected value as a boolean state(true / false) are the input parameters for this method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/user-interactions/selection-method/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Selection-method.cs" %}
{% include code-snippet/maps/user-interactions/selection-method/selection-method.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/user-interactions/selection-method/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Selection-method.cs" %}
{% include code-snippet/maps/user-interactions/selection-method/selection-method.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Public method for the shape selection](./images/UserInteraction/shapeSelection.PNG)

### Initial shape selection

The shape is initially selected using the `MapsInitialShapeSelection`, and the values are mapped to the `ShapePath` and `ShapeValue`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/user-interactions/initial-shape/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Initial-shape.cs" %}
{% include code-snippet/maps/user-interactions/initial-shape/initial-shape.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/user-interactions/initial-shape/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Initial-shape.cs" %}
{% include code-snippet/maps/user-interactions/initial-shape/initial-shape.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Public method for the shape selection](./images/UserInteraction/initialSelection.PNG)

### Initial marker selection

Using the `InitialMarkerSelection`, the marker shape can be selected initially. Markers render based on the `Latitude` and `Longitude` values.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/user-interactions/initialmarkerselection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Initialmarkerselection.cs" %}
{% include code-snippet/maps/user-interactions/initialmarkerselection/initialmarkerselection.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/user-interactions/initialmarkerselection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Initialmarkerselection.cs" %}
{% include code-snippet/maps/user-interactions/initialmarkerselection/initialmarkerselection.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Highlight

Each shape in the Maps can be highlighted during mouse hover on the Maps elements such as shapes, bubbles, markers and legends. Highlight is enabled by setting the `Enable` property of `MapsHighlightSettings` to **true**.

The following properties are available to customize the highlight of Maps elements such as shapes, bubbles, markers and legends.

* `Border` - To customize the color, width and opacity of the border of which element is highlighted in Maps.
* `Fill` - Applies the color for the element that is highlighted.
* `Opacity` - To customize the transparency for the element that is highlighted.

Hovering on the specific legend, the shapes which are bounded to the selected legend is also highlighted and vice versa.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/user-interactions/highlight/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Highlight.cs" %}
{% include code-snippet/maps/user-interactions/highlight/highlight.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/user-interactions/highlight/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Highlight.cs" %}
{% include code-snippet/maps/user-interactions/highlight/highlight.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Enable highlight](./images/UserInteraction/selection-legend.PNG)

### Enable highlight for bubbles

To enable the highlight for bubbles in Maps, set the `MapsHighlightSettings` in `MapsBubble` and set the `Enable` property of `MapsHighlightSettings` as **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/user-interactions/highlight-bubble/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Highlight-bubble.cs" %}
{% include code-snippet/maps/user-interactions/highlight-bubble/highlight-bubble.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/user-interactions/highlight-bubble/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Highlight-bubble.cs" %}
{% include code-snippet/maps/user-interactions/highlight-bubble/highlight-bubble.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Enable highlight for bubbles](./images/UserInteraction/selection-bubble.PNG)

### Enable highlight for markers

To enable the highlight for markers in Maps, set the `MapsHighlightSettings` in `MapsMarker` and set the `Enable` property of `MapsHighlightSettings` as **true**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/user-interactions/highlight-marker/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Highlight-marker.cs" %}
{% include code-snippet/maps/user-interactions/highlight-marker/highlight-marker.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/user-interactions/highlight-marker/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Highlight-marker.cs" %}
{% include code-snippet/maps/user-interactions/highlight-marker/highlight-marker.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Enable highlight for markers](./images/UserInteraction/selection-marker.PNG)


 ### Enable highlight for polygons

{% if page.publishingplatform == "aspnet-core" %}

The polygon shapes can be highlighted via user interaction if the [enable](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsHighlightSettings.html#Syncfusion_EJ2_Maps_MapsHighlightSettings_Enable) property of [highlightSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsHighlightSettings.html) is set to **true**. The following properties are available in `highlightSettings` to customize the polygon shape when it is highlighted.

* [fill](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsHighlightSettings.html#Syncfusion_EJ2_Maps_MapsHighlightSettings_Fill) - It is used to change the color of the highlighted polygon shape.
* [opacity](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsHighlightSettings.html#Syncfusion_EJ2_Maps_MapsHighlightSettings_Opacity) - It is used to change the opacity of the highlighted polygon shape.
* [border](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Maps.MapsHighlightSettings.html#Syncfusion_EJ2_Maps_MapsHighlightSettings_Border) - This property is used to change the color, width, and opacity of the border of the highlighted polygon shape.

The following example shows how to highlight a polygon shape on a geometry map.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/polygon/polygon-shape-highlight/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Polygon-shape-highlight.cs" %}
{% include code-snippet/maps/polygon/polygon-shape-highlight/polygon-shape-highlight.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The polygon shapes can be highlighted via user interaction if the [Enable](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsHighlightSettings.html#Syncfusion_EJ2_Maps_MapsHighlightSettings_Enable) property of [HighlightSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsHighlightSettings.html) is set to **true**. The following properties are available in `HighlightSettings` to customize the polygon shape when it is highlighted.

* [Fill](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsHighlightSettings.html#Syncfusion_EJ2_Maps_MapsHighlightSettings_Fill) - It is used to change the color of the highlighted polygon shape.
* [Opacity](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsHighlightSettings.html#Syncfusion_EJ2_Maps_MapsHighlightSettings_Opacity) - It is used to change the opacity of the highlighted polygon shape.
* [Border](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Maps.MapsHighlightSettings.html#Syncfusion_EJ2_Maps_MapsHighlightSettings_Border) - This property is used to change the color, width, and opacity of the border of the highlighted polygon shape.

The following example shows how to highlight a polygon shape on a geometry map.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/polygon/polygon-shape-highlight/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Polygon-shape-highlight.cs" %}
{% include code-snippet/maps/polygon/polygon-shape-highlight/polygon-shape-highlight.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Enable highlight for polygons](./images/Polygon/polygon-shape-highlight.gif)

## Tooltip

On mouse over or touch end event, the tooltip is used to get more information about the layer, bubble, or marker. It can be enabled separately for layer or bubble or marker by using the `Visible` property of `MapsTooltipSettings` as **true**. The `ValuePath` property in the tooltip takes the field name that presents in data source and displays that value as tooltip text. The `TooltipDisplayMode` property is used to change the display mode of the tooltip in Maps. Following display modes of tooltip are available in the Maps component. By default, `TooltipDisplayMode` is set to **MouseMove**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/user-interactions/tooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip.cs" %}
{% include code-snippet/maps/user-interactions/tooltip/tooltip.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/user-interactions/tooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip.cs" %}
{% include code-snippet/maps/user-interactions/tooltip/tooltip.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Enable tooltip](./images/UserInteraction/tooltip.PNG)

### Customization

The following properties are available in the `MapsTooltipSettings` to customize the tooltip of the Maps component.

* `Border` - To customize the color, width and opacity of the border of the tooltip in layers, markers, and bubbles of Maps.
* `Fill` - Applies the color of the tooltip in layers, markers, and bubbles of Maps.
* `Format` - To customize the format of the tooltip in layers, markers, and bubbles of Maps
* `TextStyle` - To customize the style of the text in the tooltip for layers, markers, and bubbles of Maps.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/user-interactions/tooltip-customization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip-customization.cs" %}
{% include code-snippet/maps/user-interactions/tooltip-customization/tooltip-customization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/user-interactions/tooltip-customization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip-customization.cs" %}
{% include code-snippet/maps/user-interactions/tooltip-customization/tooltip-customization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Enable tooltip](./images/UserInteraction/tooltip-customization.PNG)

### Tooltip template

The HTML element can be rendered in the tooltip of the Maps using the `Template` property of the `MapsTooltipSettings`. In the following example, ${value1} and ${value2} are the place holders in the HTML element to display the value1 and value2 values of the corresponding shape.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/user-interactions/tooltip-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip-template.cs" %}
{% include code-snippet/maps/user-interactions/tooltip-template/tooltip-template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/user-interactions/tooltip-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip-template.cs" %}
{% include code-snippet/maps/user-interactions/tooltip-template/tooltip-template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Enable tooltip](./images/UserInteraction/tooltip-template.PNG)
