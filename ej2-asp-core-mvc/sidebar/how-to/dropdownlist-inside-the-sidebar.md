---
layout: post
title: Dropdownlist Inside The Sidebar in ##Platform_Name## Sidebar Component
description: Learn here all about Dropdownlist Inside The Sidebar in Syncfusion ##Platform_Name## Sidebar component and more.
platform: ej2-asp-core-mvc
control: Dropdownlist Inside The Sidebar
publishingplatform: ##Platform_Name##
documentation: ug
---


# Adding Dropdownlist inside the sidebar

While clicking the dropdownlist items inside the sidebar element,it closes the sidebar component. By default, the closeonDocumentClick property will close the Sidebar element whenever the click action will be triggered outside of the Sidebar element. The DropDownList popup element placed outside of the Sidebar element (body tag instead of sidebar element). So, during the popup element interactions (click, mousedown) the closeonDocumentClick will trigger and close the sidebar.

To overcome this behavior in your application, you can add one common class by using cssClass property to all the components that has appended their elements outside of the sidebar component. Based on that class you can prevent the Sidebar close action by using close event.

The following example shows how to prevent the closes of sidebar while click the dropdownlist.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sidebar/sidebar-dropdownlist/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Sidebar-dropdownlist.cs" %}
{% include code-snippet/sidebar/sidebar-dropdownlist/sidebar-dropdownlist.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sidebar/sidebar-dropdownlist/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Sidebar-dropdownlist.cs" %}
{% include code-snippet/sidebar/sidebar-dropdownlist/sidebar-dropdownlist.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Sidebar Sample](../images/dropdownlist.png)