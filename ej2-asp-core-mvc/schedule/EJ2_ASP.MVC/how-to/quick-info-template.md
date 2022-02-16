---
layout: post
title: Quick Info Template in ##Platform_Name## Schedule Component
description: Learn here all about Quick Info Template in Syncfusion ##Platform_Name## Schedule component and more.
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

