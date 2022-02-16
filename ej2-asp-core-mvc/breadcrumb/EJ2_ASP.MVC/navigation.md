---
layout: post
title: Navigation in ##Platform_Name## Breadcrumb Component
description: Learn here all about Navigation in Syncfusion ##Platform_Name## Breadcrumb component and more.
platform: ej2-asp-core-mvc
control: Navigation
publishingplatform: ##Platform_Name##
documentation: ug
---


# Icons in Breadcrumb

## Navigation

The Breadcrumb item navigates to the path while clicking the item. To enable navigation, `url`property was bound to the items.

## URL

In the Breadcrumb, the item represents the url. The breadcrumb items can be provided with either relative or absolute URL.

### Relative URL

The Breadcrumb items with relative URL contain only the path but do not locate the path or server. The following example represents the breadcrumb items with relative url.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/breadcrumb/url/relative-url/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/breadcrumb/url/relative-url/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/breadcrumb/url/relative-url/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/breadcrumb/url/relative-url/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Breadcrumb Sample](./images/relative-url.PNG)

### Absolute URL

The Breadcrumb items with absolute URL contain the path and locate to the resource if the static url is bound to the breadcrumb item. The following example represents the breadcrumb items with static url.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/breadcrumb/url/absolute-url/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/breadcrumb/url/absolute-url/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/breadcrumb/url/absolute-url/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/breadcrumb/url/absolute-url/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Breadcrumb Sample](./images/relative-url.PNG)

## Enable navigation for last Breadcrumb item

The feature enables the last item of the Breadcrumb component by setting the `enableActiveItemNavigation` property to true. In the following example, the last item of the `Breadcrumb` was enabled.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/breadcrumb/url/enable-navigation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/breadcrumb/url/enable-navigation/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/breadcrumb/url/enable-navigation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/breadcrumb/url/enable-navigation/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Breadcrumb Sample](./images/navigation.PNG)

## Open URL in new page or tab

To open the Breadcrumb item in a new page or tab, set the target property of the required item url to blank in the Breadcrumb component. In the following example, the target property of `All Component` item url was set to blank by using the `beforeItemRender` event which locates to the path in the new tab.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/breadcrumb/url/open-url/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/breadcrumb/url/open-url/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/breadcrumb/url/open-url/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/breadcrumb/url/open-url/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Breadcrumb Sample](./images/navigation.PNG)