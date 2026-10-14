---
layout: post
title: Accessibility in ##Platform_Name## Chips | Syncfusion
description: Learn keyboard navigation and ARIA support for Syncfusion ##Platform_Name## Chips, including Enter to select and Delete to remove chips from a ChipList.
platform: ej2-asp-core-mvc
control: Accessibility
publishingplatform: ##Platform_Name##
documentation: ug
---

# Accessibility in ##Platform_Name## Chips

## Keyboard interaction

The following shortcut keys are used to access the Chips control without interruption.

| Keyboard shortcuts | Actions |
|------------|-------------------|
| <kbd>Enter</kbd> | Selects the targeted Chips from the ChipList/ChipCollection. |
| <kbd>Delete</kbd> | Deletes the targeted Chips from the ChipList/ChipCollection. |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chips/accessibility/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chips/accessibility/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/chips/accessibility/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/Chips/ChipsSample).