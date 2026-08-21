---
layout: post
title: Add Nested Tabs in ##Platform_Name## Tab Control | Syncfusion 
description: Learn here all about Add Nested Tabs in Syncfusion ##Platform_Name## Tab component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Tab
publishingplatform: ##Platform_Name##
documentation: ug
---

# Add nested Tabs

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


