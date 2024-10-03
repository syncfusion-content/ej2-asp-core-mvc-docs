---
layout: post
title: Custom views in ##Platform_Name## AI AssistView Control | Syncfusion
description: Checkout and learn about Custom views in Syncfusion ##Platform_Name## AI AssistView control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Custom views
publishingplatform: ##Platform_Name##
documentation: ug
---

# Custom views in ##Platform_Name## AI AssistView control

## Adding custom views

By using the [Views](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.AIAssistView.html#Syncfusion_EJ2_InteractiveChat_AIAssistView_Views) property you can define the collection of different assist view models in the AI AssistView. You can customize the default and the custom views added.

### Setting view type

You can set the type of view by using the [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.AssistViewType.html) property. It accepts two values such as [Assist](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.AssistViewType.html#Syncfusion_EJ2_InteractiveChat_AssistViewType_Assist), and [Custom](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.InteractiveChat.AssistViewType.html#Syncfusion_EJ2_InteractiveChat_AssistViewType_Custom).

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/views/viewType/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ViewType.cs" %}
{% include code-snippet/ai-assistview/views/viewType/viewType.cs %}
{% endhighlight %}
{% endtabs %}

![ViewType](images/view-type.png)

### Setting name

You can use the `Name` property to specifies the header name of the `Assist` or `Custom` views in the AI AssistView.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/views/viewName/razor %}
{% endhighlight %}
{% highlight c# tabtitle="viewName.cs" %}
{% include code-snippet/ai-assistview/views/viewName/viewName.cs %}
{% endhighlight %}
{% endtabs %}

![ViewName](images/view-name.png)

### Setting iconCss

You can customize the view icons by using the `IconCss` property. By default the `e-assistview-icon` class is added as built-in header icon for the AI AssistView.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/views/viewIcon/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ViewIcon.cs" %}
{% include code-snippet/ai-assistview/views/viewIcon/viewIcon.cs %}
{% endhighlight %}
{% endtabs %}

![ViewIcon](images/view-icon.png)

### Setting view template 

You can use the `ViewTemplate` property to add the view content of the multiple views added in the AI AssistView.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/views/viewtemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Viewtemplate.cs" %}
{% include code-snippet/ai-assistview/views/viewtemplate/viewtemplate.cs %}
{% endhighlight %}
{% endtabs %}

![Viewtemplate](images/viewtemplate.png)

## Setting active view

You can use the `ActiveView` property to set the active view in the AI AssistView. By default, the value is `0`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/views/activeview/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Activeview.cs" %}
{% include code-snippet/ai-assistview/views/activeview/activeview.cs %}
{% endhighlight %}
{% endtabs %}

![Activeview](images/activeview.png)
