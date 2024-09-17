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

By using the `views` property you can define the collection of different assist view models in the AI AssistView. You can customize the default and the custom views added.

### Setting view type

You can set the type of view by using the `type` property. It accepts two values such as `Assist`, and `Custom`.

{% tabs %}
{% highlight C# tabtitle="CSHTML" hl_lines="3 10" %}

<ejs-aiassistview id="aiAssistView">
    <e-aiassistview-views>
        <e-aiassistview-view type="Assist"></e-aiassistview-view>
        <e-aiassistview-view type="Custom"></e-aiassistview-view>
    </e-aiassistview-views>
</ejs-aiassistview>
....

{% endhighlight %}
{% endtabs %}

### Setting name

You can use the `name` property to specifies the header name of the `Assist` or `Custom` views in the AI AssistView.

{% tabs %}
{% highlight C# tabtitle="CSHTML" hl_lines="3 10" %}

<ejs-aiassistview id="aiAssistView">
    <e-aiassistview-views>
        <e-aiassistview-view name="Prompt"></e-aiassistview-view>
        <e-aiassistview-view type="Custom" name="Response"></e-aiassistview-view>
    </e-aiassistview-views>
</ejs-aiassistview>
....

{% endhighlight %}
{% endtabs %}

### Setting iconCSS

You can customize the view icons by using the `iconCss` property. By default the `e-assistview-icon` class is added as built-in header icon for the AI AssistView.

{% tabs %}
{% highlight C# tabtitle="CSHTML" hl_lines="3 10" %}

<ejs-aiassistview id="aiAssistView">
    <e-aiassistview-views>
        <e-aiassistview-view iconCss="e-icons e-assistview-icon"></e-aiassistview-view>
        <e-aiassistview-view type="Custom" iconCss="e-icons e-comment-show"></e-aiassistview-view>
    </e-aiassistview-views>
</ejs-aiassistview>
....

{% endhighlight %}
{% endtabs %}

The following example illustrates how types, name, and iconCss are used in a AI AssistView control.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ai-assistview/views/itemType/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ItemType](images/itemType.png)

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
