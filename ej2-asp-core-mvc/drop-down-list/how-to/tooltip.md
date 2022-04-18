---
layout: post
title: Tooltip in ##Platform_Name## Drop Down List Component
description: Learn here all about tooltip in Syncfusion ##Platform_Name## Drop Down List component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Tooltip
publishingplatform: ##Platform_Name##
documentation: ug
---


# DropDownList options with tooltip

You can achieve this behavior by using `ej2-tooltip` component. When the mouse hovers on the DropDownList option, the tooltip displays some details related to hovered list item.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/dropdown-with-tooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Countries.cs" %}
{% include code-snippet/dropdownlist/how-to/dropdown-with-tooltip/Countries.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/dropdown-with-tooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Countries.cs" %}
{% include code-snippet/dropdownlist/how-to/dropdown-with-tooltip/Countries.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

