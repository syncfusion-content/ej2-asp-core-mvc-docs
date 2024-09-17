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

By using the `Views` property you can define the collection of different assist view models in the AI AssistView. You can customize the default and the custom views added.

### Setting view type

You can set the type of view by using the `Type` property. It accepts two values such as `Assist`, and `Custom`.

{% tabs %}
{% highlight C# tabtitle="CSHTML" hl_lines="3 10" %}

  @Html.EJS().AIAssistView("aiAssistView").Views(view =>
  {
    view.Type(AssistViewType.Assist).Add();
    view.Type(AssistViewType.Custom).Add();
  }).Render()
....

{% endhighlight %}
{% endtabs %}

### Setting name

You can use the `Name` property to specifies the header name of the `Assist` or `Custom` views in the AI AssistView.

{% tabs %}
{% highlight C# tabtitle="CSHTML" hl_lines="3 10" %}

  @Html.EJS().AIAssistView("aiAssistView").Views(view =>
  {
    view.Name("Prompt").Add();
    view.Type(AssistViewType.Custom).Name("Response").Add();
  }).Render()
....

{% endhighlight %}
{% endtabs %}

### Setting iconCSS

You can customize the view icons by using the `IconCss` property. By default the `e-assistview-icon` class is added as built-in header icon for the AI AssistView.

{% tabs %}
{% highlight C# tabtitle="CSHTML" hl_lines="3 10" %}

  @Html.EJS().AIAssistView("aiAssistView").Views(view =>
  {
    view.IconCss("e-icons e-assistview-icon").Add();
    view.Type(AssistViewType.Custom).IconCss("e-icons e-comment-show").Add();
  }).Render()
....

{% endhighlight %}
{% endtabs %}

The following example illustrates how types, name, and iconCss are used in a AI AssistView control.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/views/itemType/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ItemType.cs" %}
{% include code-snippet/ai-assistview/views/itemType/itemType.cs %}
{% endhighlight %}
{% endtabs %}

![ItemType](images/itemType.png)

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
