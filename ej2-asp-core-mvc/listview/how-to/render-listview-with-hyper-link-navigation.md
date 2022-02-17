---
layout: post
title: Render Listview With Hyper Link Navigation in ##Platform_Name## Listview Component
description: Learn here all about Render Listview With Hyper Link Navigation in Syncfusion ##Platform_Name## Listview component and more.
platform: ej2-asp-core-mvc
control: Render Listview With Hyper Link Navigation
publishingplatform: ##Platform_Name##
documentation: ug
---

# Render ListView with hyper-link navigation

We can use `anchor` tag along with `href` attribute in our ListView [`template`](https://ej2.syncfusion.com/documentation/api/list-view/#template) property for navigation.

```typescript

var anchor_template = "<a target='_blank' href='${url}'>${name}</a>";

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

