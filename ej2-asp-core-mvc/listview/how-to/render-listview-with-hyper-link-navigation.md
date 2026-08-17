---
layout: post
title: Render ListView with hyperlink navigation | Syncfusion
description: Bind Syncfusion ##Platform_Name## ListView items to URL navigation by configuring the anchor href inside template and handling clicks to redirect.
platform: ej2-asp-core-mvc
control: Render ListView With Hyper Link Navigation
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to render ##Platform_Name## ListView with hyperlink navigation

We can use `anchor` tag along with `href` attribute in our ListView [`template`](https://ej2.syncfusion.com/documentation/api/list-view#template) property for navigation.

```typescript

var anchor_template = "<a target='_blank' href='${url}' aria-label='${name}'>${name}</a>";

```

In the below sample, we have rendered `ListView` with search engines URL.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/listview/navigation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="List.cs" %}
{% include code-snippet/listview/navigation/list.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/listview/navigation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="List.cs" %}
{% include code-snippet/listview/navigation/list.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

