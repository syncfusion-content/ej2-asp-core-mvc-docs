---
layout: post
title: Accessibility in ##Platform_Name## Listview Component
description: Learn here all about Accessibility in Syncfusion ##Platform_Name## Listview component and more.
platform: ej2-asp-core-mvc
control: Accessibility
publishingplatform: ##Platform_Name##
documentation: ug
---


# Accessibility

## Keyboard interaction

The following key shortcuts are used to access the ListView component without any interruption.

| Keyboard shortcuts | Actions |
|------------|-------------------|
| <kbd>Arrow Up</kbd> | Move to the previous list item. |
| <kbd>Arrow Down</kbd> | Move to the next list item. |
| <kbd>Select</kbd> | Select the targeted list from the whole list. |
| <kbd>Back</kbd> | Get back to the previous lists if it is in nested list. |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/listview/accessibility/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ListController.cs" %}
{% include code-snippet/listview/accessibility/ListController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/listview/accessibility/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ListController.cs" %}
{% include code-snippet/listview/accessibility/ListController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![ASP .NET Core ListView - Accessibility](./images/nestedlist.png)

## ARIA attributes

The following ARIA attributes are applicable for ListView component based on its state.

| Properties | Functionality |
| ------------ | ----------------------- |
| aria-selected | It indicates the selected list from the whole list. |
| aria-level | It defines the hierarchical structure of a list item. |
