---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Quick Info Template of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Quick Info Template
publishingplatform: ##Platform_Name##
documentation: ug
---

# Show quick info Template

This demo showcases the quick popups for cells and appointments with the customized templates.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/how-to/quick-info-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/how-to/quick-info-template/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/how-to/quick-info-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/how-to/quick-info-template/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

