---
layout: post
title: Spinner And Progress in ##Platform_Name## Progress Button Component
description: Learn here all about Spinner And Progress in Syncfusion ##Platform_Name## Progress Button component and more.
platform: ej2-asp-core-mvc
control: Spinner And Progress
publishingplatform: ##Platform_Name##
documentation: ug
---


<!-- markdownlint-disable MD002 MD022 -->
## Spinner

### Change spinner position

Spinner position can be changed by modifying the `position` property of [`spinSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.ProgressButton.html#Syncfusion_EJ2_SplitButtons_ProgressButton_SpinSettings). By default, the spinner is positioned at the left of the ProgressButton. You can position it at the `left`, `right`, `top`, `bottom`, or `center` of the text content.

### Change spinner size

Spinner size can be changed by modifying the `width` property of [`spinSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.ProgressButton.html#Syncfusion_EJ2_SplitButtons_ProgressButton_SpinSettings). In this demo, the `width` is set to `20` to change the spinner size.

### Spinner template

You can use custom spinner by specifying the `template` property of [`spinSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.ProgressButton.html#Syncfusion_EJ2_SplitButtons_ProgressButton_SpinSettings) with custom styles.

The following sample demonstrates the above functionalities of the spinner.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/progress-button/spinner/demo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/progress-button/spinner/demo/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/progress-button/spinner/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/progress-button/spinner/demo/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



<!-- markdownlint-disable MD025 MD022 -->
## Progress

### Content animation

The [`content`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.ProgressButton.html#Syncfusion_EJ2_SplitButtons_ProgressButton_Content) of the ProgressButton can be animated during progress using the `effect` property
of [`animationSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.ProgressButton.html#Syncfusion_EJ2_SplitButtons_ProgressButton_AnimationSettings). You can also set custom duration and timing function using the `duration` and `easing` properties. The possible `effect` values are `None`, `SlideLeft`, `SlideRight`, `SlideUp`, `SlideDown`, `ZoomIn`, and `ZoomOut`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/progress-button/animation/demo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/progress-button/animation/demo/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/progress-button/animation/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/progress-button/animation/demo/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Change step of the ProgressButton

The progress state can be visualized to the specified interval by changing the `step` property in the [`begin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.ProgressButton.html#Syncfusion_EJ2_SplitButtons_ProgressButton_Begin) event of the ProgressButton. In this demo, the `step` property is set to `20` to show progress at every 20% increment.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/progress-button/step/demo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/progress-button/step/demo/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/progress-button/step/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/progress-button/step/demo/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> The class `e-hide-spinner` hides the spinner in the ProgressButton, For more information, see [hide spinner](./how-to/hide-spinner) section

### Changing progress state dynamically

The progress state can be changed dynamically by modifying the `percent` property in the progress events. In this demo, on 40% completion of progress, the `percent` property is set to `90` to show dynamic change of the progress state.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/progress-button/state/demo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/progress-button/state/demo/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/progress-button/state/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/progress-button/state/demo/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> The method `dataBind` applies the property changes immediately to the component.

### Start and stop methods

You can pause and resume the progress using the `stop` and `start` methods, respectively. In this demo, clicking the ProgressButton will pause and resume the progress.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/progress-button/methods/demo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/progress-button/methods/demo/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/progress-button/methods/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/progress-button/methods/demo/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [How to hide spinner](./how-to/hide-spinner)
* [Customize ProgressButton using cssClass](how-to/customize-progress-using-cssclass)