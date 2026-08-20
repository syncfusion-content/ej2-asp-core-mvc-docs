---
layout: post
title: How to set title for ##Platform_Name## Menu items | Syncfusion
description: Set the Syncfusion ##Platform_Name## Menu item title attribute (tooltip text) using the beforeItemRender event and assigning a string to li.title.
platform: ej2-asp-core-mvc
control: Set Title
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to set title for ##Platform_Name## Menu items

In this sample , the title for settings icon  can be achievable by using `beforeItemRender`  client-side event in Menu component.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/menu/how-to/title/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Title.cs" %}
{% include code-snippet/menu/how-to/title/Title.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/menu/how-to/title/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Title.cs" %}
{% include code-snippet/menu/how-to/title/Title.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

