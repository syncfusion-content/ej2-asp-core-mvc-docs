---
layout: post
title: How to create collapsible tabs in ##Platform_Name## Tabs | Syncfusion
description: Add collapse and expand functionality to Syncfusion ##Platform_Name## Tabs by toggling a custom CSS class in each tab's click event handler.
platform: ej2-asp-core-mvc
control: Tab
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to create collapsible tabs in ##Platform_Name## Tabs

You can implement collapse and expand functionality in the Tab by adding/removing a custom CSS class in the click event handler for each tab.

* Define a CSS class to set the style property display as none. Here `collapse` class is added to the content element for hiding it.
* Bind the [selected](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.navigations.tab.html#Syncfusion_EJ2_Navigations_Tab_Selected) event for Tab to collapse the initially selected Tab item and bind custom click handler for the Tab headers.
* n the event handler, add or remove the `collapse` class to show or hide the corresponding tab content.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tab/collapsible/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Collapsible.cs" %}
{% include code-snippet/tab/collapsible/collapsible.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tab/collapsible/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Collapsible.cs" %}
{% include code-snippet/tab/collapsible/collapsible.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

