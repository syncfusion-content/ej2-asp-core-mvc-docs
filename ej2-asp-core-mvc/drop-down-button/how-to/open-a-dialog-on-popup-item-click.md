---
layout: post
title: Open A Dialog On Popup Item Click in ##Platform_Name## Drop Down Button Component
description: Learn here all about Open A Dialog On Popup Item Click in Syncfusion ##Platform_Name## Drop Down Button component and more.
platform: ej2-asp-core-mvc
control: Open A Dialog On Popup Item Click
publishingplatform: ##Platform_Name##
documentation: ug
---


# Open a dialog on popup item click

This section explains about how to open a dialog on DropdownButton popup item click.
This can be achieved by handling dialog open in
[`select`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.DropDownButton.html#Syncfusion_EJ2_SplitButtons_DropDownButton_Select) event of the DropdownButton.

In the following example, Dialog will open while selecting `Other Folder...` item.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownbutton/dialog/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DialogButton-core.cs" %}
{% include code-snippet/dropdownbutton/dialog/dialogButton-core.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownbutton/dialog/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DialogButton-core.cs" %}
{% include code-snippet/dropdownbutton/dialog/dialogButton-core.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

