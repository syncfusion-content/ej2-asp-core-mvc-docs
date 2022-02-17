---
layout: post
title: Change Caret Icon in ##Platform_Name## Drop Down Button Component
description: Learn here all about Change Caret Icon in Syncfusion ##Platform_Name## Drop Down Button component and more.
platform: ej2-asp-core-mvc
control: Change Caret Icon
publishingplatform: ##Platform_Name##
documentation: ug
---


# Change caret icon

Dropdown arrow can be customized on popup open and close. It can be handled in
[`beforeOpen`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.DropDownButton.html#Syncfusion_EJ2_SplitButtons_DropDownButton_BeforeOpen) and
[`beforeClose`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.DropDownButton.html#Syncfusion_EJ2_SplitButtons_DropDownButton_BeforeClose) event.

In the following example, the up arrow is updated on popup close and down arrow is updated
on popup open using `beforeOpen` and `beforeClose` event by adding and removing
`e-caret-up` class.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownbutton/updown/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Updown.cs" %}
{% include code-snippet/dropdownbutton/updown/updown.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownbutton/updown/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Updown.cs" %}
{% include code-snippet/dropdownbutton/updown/updown.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

