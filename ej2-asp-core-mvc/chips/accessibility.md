---
layout: post
title: Accessibility in ##Platform_Name## Chips Component
description: Learn here all about Accessibility in Syncfusion ##Platform_Name## Chips component and more.
platform: ej2-asp-core-mvc
control: Accessibility
publishingplatform: ##Platform_Name##
documentation: ug
---

# Accessibility

## Keyboard interaction

The following shortcut keys are used to access the Chip control without any interruption.

| Keyboard shortcuts | Actions |
|------------|-------------------|
| <kbd>Enter</kbd> | Selects the targeted chip from the ChipList/ChipCollection. |
| <kbd>Delete</kbd> | Deletes the targeted chip from the ChipList/ChipCollection. |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chips/accessibility/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/chips/accessibility/default.cs %}
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

