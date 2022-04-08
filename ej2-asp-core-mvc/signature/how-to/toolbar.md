---
layout: post
title: Integration with Toolbar in ##Platform_Name## Signature Component
description: Learn here all about Integration with Toolbar in Syncfusion ##Platform_Name## Signature component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Integration with Toolbar
publishingplatform: ##Platform_Name##
documentation: ug
---

# Integration with Toolbar

The Signature component integrates with the toolbar and the interaction performed using the `change` event of the toolbar. 
In that, `canUndo`, `canRedo` and `isEmpty` methods were used to enable/disable undo, redo, and clear buttons.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/signature/toolbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/signature/toolbar/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/signature/toolbar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/signature/toolbar/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![Signature Sample](../images/toolbar.PNG)