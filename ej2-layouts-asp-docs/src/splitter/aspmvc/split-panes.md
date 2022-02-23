---
title: "Split panes"
component: "Splitter"
description: "This section explain about split panes behaviours."
---

# Split panes

This section explain about split panes behaviours.

## Horizontal layout

By default, splitter will render in horizontal orientation. Splitter container will be splitted as panes in horizontal flow direction with vertical seperator.

{% aspTab template="splitter/horizontal-layout", sourceFiles="controller.cs" %}

{% endaspTab %}

Output be like the below.

![Horizontal layout](./images/horizontal-layout.png)

## Vertical layout

By setting [`Orientation`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Layouts.Splitter.html#Syncfusion_EJ2_Layouts_Splitter_Orientation) API as `Vertical`, splitter will render in vertical orientation. Splitter container will be splitted as panes in vertical flow direction with horizontal seperator.

{% aspTab template="splitter/vertical-layout", sourceFiles="controller.cs" %}

{% endaspTab %}

Output be like the below.

![Vertical layout](./images/vertical-layout.png)

## Multiple panes

You can render the multiple panes with both `Horizontal/Vertical` orientations.

{% aspTab template="splitter/layouts-multiple", sourceFiles="controller.cs" %}

{% endaspTab %}

Output be like the below.

![Multiple panes](./images/layouts-multiple.png)

## Separator

By default, pane separator will be render with `1px` width/height. You can customize the separator size by using [`SeparatorSize`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Layouts.Splitter.html#Syncfusion_EJ2_Layouts_Splitter_SeparatorSize) API.

> For Horizontal orientation, it will be considered as separator width.
> For Vertical orientation, it will be considered as separator height.

{% aspTab template="splitter/separator-size", sourceFiles="controller.cs" %}

{% endaspTab %}

Output be like the below.

![Separator](./images/separator-size.png)

## Nested Splitter

Splitter provides support to render the nested pane to achieve the complex layouts. You can use the same `<div>` element for splitter pane and nested splitter.

> Also you can render the nested splitter using direct child of the splitter pane. For this, nested splitter should have `100%` width and height to match with the parent pane dimensions.

{% aspTab template="splitter/layouts-nested", sourceFiles="controller.cs" %}

{% endaspTab %}

Output be like the below.

![Nested Splitter](./images/layouts-nested.png)

## Add or remove pane

You can add the panes programmatic but it will makes you complex. For this, you can use the `addPane/removePane` methods to add and remove the panes dynamically in the splitter.

### Add pane

You can add the panes dynamically in the splitter by passing [`PaneSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Layouts.Splitter.html#Syncfusion_EJ2_Layouts_Splitter_PaneSettings) along with index to the `addPane` method

{% aspTab template="splitter/add-pane", sourceFiles="controller.cs" %}

{% endaspTab %}

Output be like the below.

![Add pane](./images/add-pane.png)

### Remove pane

You can remove the split panes dynamically by passing the pane index to `removePane` method.

{% aspTab template="splitter/remove-pane", sourceFiles="controller.cs" %}

{% endaspTab %}

Output be like the below.

![Remove pane](./images/remove-pane.png)

## See Also

* [Resizable split panes](./resizing/)
* [Collapsible panes](./expand-and-collapse/)
* [Define size to a panes](./pane-sizing/ )
* [Specify content to a panes](./pane-content/)