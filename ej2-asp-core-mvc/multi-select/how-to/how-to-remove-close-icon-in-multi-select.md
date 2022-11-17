---
layout: post
title: Clear Icon in ##Platform_Name## Syncfusion Multi Select Component
description: This section demonstrates how to remove the close icon from the ##Platform_Name## MultiSelect component.
platform: ej2-asp-core-mvc
control: Clear Icon
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to remove the close icon in MultiSelect

This section explains how to remove the close icon for the MultiSelect component without removing the selected values close icon. It can be achieved by applying display none styles to the 'e-close-hooker' class name in the MultiSelect component like the following sample.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/how-to/clear-icon/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Icons.cs" %}
{% include code-snippet/multiselect/how-to/clear-icon/icons.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/how-to/clear-icon/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Icons.cs" %}
{% include code-snippet/multiselect/how-to/clear-icon/icons.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
