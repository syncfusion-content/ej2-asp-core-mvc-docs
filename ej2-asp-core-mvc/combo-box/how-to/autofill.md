---
layout: post
title: How to enable autofill in ##Platform_Name## ComboBox | Syncfusion
description: Enable Syncfusion ##Platform_Name## ComboBox autofill so the input auto-completes from the list as the user types each character.
platform: ej2-asp-core-mvc
control: Autofill
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to enable autofill in ##Platform_Name## ComboBox

The ComboBox supports the `autofill` behaviour with the help of [autofill](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.ComboBox.html#Syncfusion_EJ2_DropDowns_ComboBox_Autofill) property. Whenever you change the input value, the ComboBox will autocomplete your data by matching the typed character. Suppose, if there are no matches found then, comboBox doesn't suggest any item.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/combobox/how-to/autofill/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
public class Countries
{
    public string Name { get; set; }
    public string Code { get; set; }
}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/combobox/how-to/autofill/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Countries.cs" %}
{% include code-snippet/combobox/how-to/autofill/Countries.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/ComboBox/ComboBoxHowToSample).