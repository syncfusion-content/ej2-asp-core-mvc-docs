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

By using the `e-aiassistview-view` tag helper you can define the collection of different assist view models in the AI AssistView. You can customize the default and the custom views added.

### Setting view type

You can set the type of view by using the [type](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.AssistViewType.html) property. It accepts two values such as [Assist](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.AssistViewType.html#Syncfusion_EJ2_InteractiveChat_AssistViewType_Assist), and [Custom](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InteractiveChat.AssistViewType.html#Syncfusion_EJ2_InteractiveChat_AssistViewType_Custom).

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/views/viewType/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ViewType](images/view-type.png)

### Setting name

You can use the `name` property to specifies the header name of the `Assist` or `Custom` views in the AI AssistView.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/views/viewName/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ViewName](images/view-name.png)

### Setting iconCss

You can customize the view icons by using the `iconCss` property. By default the `e-assistview-icon` class is added as built-in header icon for the AI AssistView.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/views/viewIcon/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ViewIcon](images/view-icon.png)

### Setting view template 

You can use the `viewTemplate` property to add the view content of the multiple views added in the AI AssistView.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/views/viewtemplate/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ViewTemplate](images/viewtemplate.png)

## Setting active view

You can use the `activeView` property to set the active view in the AI AssistView. By default, the value is `0`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/views/activeview/tagHelper %}
{% endhighlight %}
{% endtabs %}

![Activeview](images/activeview.png)
