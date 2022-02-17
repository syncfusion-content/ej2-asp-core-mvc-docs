---
layout: post
title: Swim Lane in ##Platform_Name## Diagram Component
description: Learn here all about Swim Lane in Syncfusion ##Platform_Name## Diagram component and more.
platform: ej2-asp-core-mvc
control: Swim Lane
publishingplatform: ##Platform_Name##
documentation: ug
---


# Swimlane

Swimlane is a type of diagram nodes,which is typically used to visualize the relationship between a business process and the department responsible for it by focusing on the logical relationships between activities.

## Create a swimlane

To create a swimlane,the type of shape should be set as [`swimlane`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.Shapes.html).By Default swimlane's are arranged vertically.

The following code example illustrates how to define a swimlane object.

### Headers

Header was the primary element for swimlanes. The [`header`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.Shapes.html) property of swimlane allows you to define its textual description and to customize its appearance.

> By using this header,the swimlane interaction will be performed,like selection, dragging,etc.

The following code example illustrates how to define a swimlane header.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/swimlane/swimlaneheader/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Swimlaneheader.cs" %}
{% include code-snippet/diagram/swimlane/swimlaneheader/swimlaneheader.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Swimlaneheader.cs" %}
{% include code-snippet/diagram/swimlane/swimlaneheader/swimlaneheader.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Customization of headers

The height and width of swimlane header can be customized with [`weight`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.Shapes.html) and [`height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.Shapes.html) properties of swimlane header. set fill color of header by using the [`style`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.Shapes.html) property. The orientation of swimlane can be customized with the [`orientation`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.Shapes.html) property of the header.

> By default the swimlane orientation has Horizontal.

The following code example illustrates how to customize the swimlane header..

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/swimlane/headercustomize/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Headercustomize.cs" %}
{% include code-snippet/diagram/swimlane/headercustomize/headercustomize.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Headercustomize.cs" %}
{% include code-snippet/diagram/swimlane/headercustomize/headercustomize.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Dynamic customization of swimlane header

 You can customize the swimlane header style and text properties dynamically. The following code illustrates how to dynamically customize the lane header..

```typescript
let lane : nodeModel = diagram.nodes[0];
lane.shape.lanes[0].header.style.fill ='red';
diagram.dataBind();
```

### Header editing

Diagram provides the support to edit swimlane headers at runtime. We achieve the header editing by double click event. Double clicking the header label will enables the editing of that.
The following image illustrates how to edit the phase header.
![Phase Header Editing](images/phase-header-edit.gif)

## Lanes

Lane is a functional unit or a responsible department of a business process that helps to map a  process within the functional unit or in between other functional units.

The number of [`lanes`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.Shapes.html) can be added to swimlane. The lanes are automatically stacked inside  swimlane based on the order they are added.

### Create an empty lane

* The lanes `id` is used to define the name of the lane and its further used to find the lane at runtime and do any customization.

The following code example illustrates how to define a swimlane with lane.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/swimlane/emptylane/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Emptylane.cs" %}
{% include code-snippet/diagram/swimlane/emptylane/emptylane.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Emptylane.cs" %}
{% include code-snippet/diagram/swimlane/emptylane/emptylane.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Create lane header

* The [`header`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.Shapes.html) property of lane allows you to textually describe the lane and to customize the appearance of the description.

The following code example illustrates how to define a lane header.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/swimlane/laneheader/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Laneheader.cs" %}
{% include code-snippet/diagram/swimlane/laneheader/laneheader.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Laneheader.cs" %}
{% include code-snippet/diagram/swimlane/laneheader/laneheader.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Customizing lane header

* The size of lane can be controlled by using the [`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.Shapes.html) and [`height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.Shapes.html) properties of the lane.
* The appearance of the lane can be set by using the [`style`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.Shapes.html) properties.

The following code example illustrates how to customize the lane header.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/swimlane/laneheadercustomize/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Laneheadercustomize.cs" %}
{% include code-snippet/diagram/swimlane/laneheadercustomize/laneheadercustomize.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Laneheadercustomize.cs" %}
{% include code-snippet/diagram/swimlane/laneheadercustomize/laneheadercustomize.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Dynamic customization of lane header

 You can customize the lane header style and text properties dynamically. The following code illustrates how to dynamically customize the lane header..

```typescript
let lane : nodeModel = diagram.nodes[0];
lane.shape.lanes[0].header.style.fill ='red';
diagram.dataBind();
```

### Add lane at runtime

 You can add the a lane at runtime by using the client side API method called `addLanes`.

### Add children to lane

 To add nodes to lane,you should add [`children`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.Shapes.html) collection of the lane.

The following code example illustrates how to add nodes to lane.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/swimlane/lanechildren/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Lanechildren.cs" %}
{% include code-snippet/diagram/swimlane/lanechildren/lanechildren.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/swimlane/lanechildren/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Lanechildren.cs" %}
{% include code-snippet/diagram/swimlane/lanechildren/lanechildren.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Dynamically add children to lane

 The diagram provides support to add children dynamically. The following code illustrates how to add children to lane dynamically.

```typescript
 let node ={
      id: 'Order',
      shape: { type: 'Path', data: pathData },
      annotations: [
      {
       content: 'ORDER',
       style: { fontSize: 11 }
       } ],
      margin: { left: 60, top: 20 },
      height: 40, width: 100
 }

let lane : nodeModel = diagram.nodes[0];
swimlane.shape.lanes[0].childern[0]=node;
diagram.dataBind();
```

### Lane interaction

### Resizing lane

* Lane can be resized in the bottom and left direction.
* Lane can be resized by using resize selector of the lane.
* Once you can resize the lane,the swimlane will be resized automatically.
* The lane can be resized either resizing the selector or the tight bounds of the child object. If the child node move to edge of the lane it can be automatically resized.
The following image illustrates how resize the lane.
![Lane Resizing](images/lane-resize.gif)

### Lane swapping

* Lanes can be swapped using drag the lanes over another lane.
* Helper should intimate the insertion point while lane swapping.
The following image illustrates how swapping the lane.
![Lane Swapping](images/swapping.gif)

### Disable Swimlane Lane swapping

You can disable swimlane lane swapping by using the property called `canMove`.

The following code illustrates how to disable swimlane lane swapping.

```typescript
 let node ={
  id: 'Order',
  shape: { type: 'Path', data: pathData },
  annotations: [
  {
   content: 'ORDER',
   style: { fontSize: 11 }
   } ],
  margin: { left: 60, top: 20 },
  height: 40, width: 100,canMove: false
 }

let lane : nodeModel = diagram.nodes[0];
swimlane.shape.lanes[0].childern[0]=node;
diagram.dataBind();
```

### Resize helper

* The special resize helper will be used to resize the lanes.
* The resize cursor will be available on the left and bottom direction alone.
* Once resize the lane the swimlane will be resized automatically.

### Children interaction in lanes

* You can resize the child node within swimlanes.
* You can drag the child nodes within lane.
* Interchange the child nodes from one lane to another lane.
* Drag and drop the child nodes from lane to diagram.
* Drag and drop the child nodes from diagram to lane.
* Based on the child node interactions,the lane size should be updated.
The following image illustrates children interaction in lane.
![Lane Children Interaction](images/child-interaction.gif)  
  
### Lane Header editing

Diagram provides the support to edit Lane headers at runtime. We achieve the header editing by double click event. Double clicking the header label will enables the editing of that.
The following image illustrates how to edit the swimlane header.
![Lane Header Editing](images/lane-header-edit.gif)

## Phase

 Phase are the subprocess which will split each lane as horizontally or vertically based on the swimlane orientation. The multiple number of [`Phase`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.Shapes.html) can be added to swimlane.
The following code example illustrates how to add phase at swimlane.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/swimlane/phase/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Phase.cs" %}
{% include code-snippet/diagram/swimlane/phase/phase.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Phase.cs" %}
{% include code-snippet/diagram/swimlane/phase/phase.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Dynamically add phase to lane

 You can add the a phase at runtime by using client side API method called `addPhases`. The following code example illustrates how to add phase at run time.

```typescript
  let phase = [{
       id: 'phase1', offset: 170,
       header: { content: { content: 'Phase' } }
  }]
  diagram.addPhase(swimlane,phase)
  ```

### Customizing phase

* The length of region can be set by using the  [`offset`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.Shapes.html) property of the phase.
* Every phase region can be textually described with the [`header`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.Shapes.html) property of the phase
* You can increase the width of phase by using [`phaseSize`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.Shapes.html) property of swimlane.

The following code example illustrates how to customize the phase in swimlane.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/swimlane/phase/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Phase.cs" %}
{% include code-snippet/diagram/swimlane/phase/phase.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Phase.cs" %}
{% include code-snippet/diagram/swimlane/phase/phase.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Phase interaction

### Resizing

* The phase can be resized by using its selector.
* You must select the phase header to enable the phase selection.
* Once the phase can be resized, the lane size will be updated automatically.

### Resizing helper

* The special resize selector will be used to resize the phase.
* The resize cursor will be available on the left and bottom direction for horizontal, and the top and bottom direction for vertical swimlane.

### Phase header editing

Diagram provides the support to edit phase headers at runtime. We achieve the header editing by double click event. Double clicking the header label will enables the editing of that.
The following image illustrates how to edit the phase header.
![Phase Header Editing](images/phase-header-edit.gif)

## Add swimlane to palette

Diagram provides support to add swimlane and phases to symbol palette. The following code sample illustrate how to add swimlane and phases to palette.

The following code example illustrates how to customize the phase in swimlane.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/node/node/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Node.cs" %}
{% include code-snippet/diagram/node/node/node.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Node.cs" %}
{% include code-snippet/diagram/node/node/node.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Drag and drop swimlane to palette

* The drag and drop support for swimlane shapes has been provided.
* When you drag and drop the lane shape,if the diagram already contains swimlane with the same orientation, the lane will be added and stacked inside a swimlane based on the order. Otherwise, it will be added a new swimlane.
* The phase will only drop on swimlane shape with same orientation.
![Drag Symbol from Palette](images/symbol-palette.gif)

## Limitations

* Connectors cannot be canceled when added directly to swimlane. You must initialize the connector through connector collection.
* We cannot edit the phase line style.