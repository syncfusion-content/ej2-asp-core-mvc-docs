---
layout: post
title: How to add nested tabs in ##Platform_Name## Tabs | Syncfusion
description: Render nested Syncfusion ##Platform_Name## Tabs by adding a Tab element inside the parent Tab's `content` property and initializing it in a selected event handler.
platform: ej2-asp-core-mvc
control: Tab
publishingplatform: ##Platform_Name##
documentation: ug
---

# Add nested Tabs in ##Platform_Name## Tab control

Tab supports nested levels of Tabs through its `content` property. You can add the nested Tab element inside the parent Tab `content` property. Render the nested Tab by initializing the control with the nested `<ejs-tab>` element's id from the parent Tab's [selected](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.navigations.tab.html#Syncfusion_EJ2_Navigations_Tab_Selected) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tab/nested/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Nested.cs" %}
{% include code-snippet/tab/nested/nested.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tab/nested/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Nested.cs" %}
{% include code-snippet/tab/nested/nested.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


