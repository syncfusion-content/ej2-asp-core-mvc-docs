---
layout: post
title: How to customize Tab content height in ##Platform_Name## | Syncfusion
description: Set the Syncfusion ##Platform_Name## Tab content height using the `heightAdjustMode` property with None, Auto, Content, or Fill options.
platform: ej2-asp-core-mvc
control: Tabs
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to customize Tab content height in ##Platform_Name##

You can change the Tab content height by using the [heightAdjustMode](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Tab.html#Syncfusion_EJ2_Navigations_Tab_HeightAdjustMode) property. By default, the Tab content `heightAdjustMode` property is set to [Content](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.HeightStyles.html#Syncfusion_EJ2_Navigations_HeightStyles_Content) value.

* [None](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.HeightStyles.html#Syncfusion_EJ2_Navigations_HeightStyles_None): Each Tab content height is set based on the Tab height. This value is used only the Tab content having the [height](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Tab.html#Syncfusion_EJ2_Navigations_Tab_Height) property.
* [Auto](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.HeightStyles.html#Syncfusion_EJ2_Navigations_HeightStyles_Auto): Each Tab content height will take the maximum height of all other Tab content.
* [Content](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.HeightStyles.html#Syncfusion_EJ2_Navigations_HeightStyles_Content): Each Tab content height is set based on their own content.
* [Fill](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.HeightStyles.html#Syncfusion_EJ2_Navigations_HeightStyles_Fill): Each Tab content height is set based on the full height of Tab parent element.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tab/height/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Height.cs" %}
{% include code-snippet/tab/height/height.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tab/height/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Height.cs" %}
{% include code-snippet/tab/height/height.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Custom Tab content height](../images/height.PNG)