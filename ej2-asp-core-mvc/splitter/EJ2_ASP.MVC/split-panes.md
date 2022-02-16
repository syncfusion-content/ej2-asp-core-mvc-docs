---
layout: post
title: Split Panes in ##Platform_Name## Splitter Component
description: Learn here all about Split Panes in Syncfusion ##Platform_Name## Splitter component and more.
platform: ej2-asp-core-mvc
control: Split Panes
publishingplatform: ##Platform_Name##
documentation: ug
---


# Split panes

This section explain about split panes behaviours.

## Horizontal layout

By default, splitter will render in horizontal orientation. Splitter container will be splitted as panes in horizontal flow direction with vertical seperator.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/splitter/horizontal-layout/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/splitter/horizontal-layout/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/splitter/horizontal-layout/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/splitter/horizontal-layout/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Horizontal layout](./images/horizontal-layout.png)

## Vertical layout

By setting [`Orientation`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Layouts.Splitter.html#Syncfusion_EJ2_Layouts_Splitter_Orientation) API as `Vertical`, splitter will render in vertical orientation. Splitter container will be splitted as panes in vertical flow direction with horizontal seperator.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/splitter/vertical-layout/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/splitter/vertical-layout/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/splitter/vertical-layout/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/splitter/vertical-layout/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Vertical layout](./images/vertical-layout.png)

## Multiple panes

You can render the multiple panes with both `Horizontal/Vertical` orientations.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/splitter/layouts-multiple/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/splitter/layouts-multiple/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/splitter/layouts-multiple/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/splitter/layouts-multiple/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Multiple panes](./images/layouts-multiple.png)

## Separator

By default, pane separator will be render with `1px` width/height. You can customize the separator size by using [`SeparatorSize`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Layouts.Splitter.html#Syncfusion_EJ2_Layouts_Splitter_SeparatorSize) API.

> For Horizontal orientation, it will be considered as separator width.
> For Vertical orientation, it will be considered as separator height.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/splitter/separator-size/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/splitter/separator-size/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/splitter/separator-size/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/splitter/separator-size/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Separator](./images/separator-size.png)

## Nested Splitter

Splitter provides support to render the nested pane to achieve the complex layouts. You can use the same `<div>` element for splitter pane and nested splitter.

> Also you can render the nested splitter using direct child of the splitter pane. For this, nested splitter should have `100%` width and height to match with the parent pane dimensions.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/splitter/layouts-nested/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/splitter/layouts-nested/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/splitter/layouts-nested/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/splitter/layouts-nested/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Nested Splitter](./images/layouts-nested.png)

## Add or remove pane

You can add the panes programmatic but it will makes you complex. For this, you can use the `addPane/removePane` methods to add and remove the panes dynamically in the splitter.

### Add pane

You can add the panes dynamically in the splitter by passing [`PaneSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Layouts.Splitter.html#Syncfusion_EJ2_Layouts_Splitter_PaneSettings) along with index to the `addPane` method

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/splitter/add-pane/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/splitter/add-pane/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/splitter/add-pane/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/splitter/add-pane/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Add pane](./images/add-pane.png)

### Remove pane

You can remove the split panes dynamically by passing the pane index to `removePane` method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/splitter/remove-pane/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/splitter/remove-pane/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/splitter/remove-pane/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/splitter/remove-pane/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Remove pane](./images/remove-pane.png)

## See Also

* [Resizable split panes](./resizing/)
* [Collapsible panes](./expand-and-collapse/)
* [Define size to a panes](./pane-sizing/ )
* [Specify content to a panes](./pane-content/)