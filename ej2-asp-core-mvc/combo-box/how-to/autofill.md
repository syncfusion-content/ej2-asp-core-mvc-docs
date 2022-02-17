---
layout: post
title: Autofill in ##Platform_Name## Combo Box Component
description: Learn here all about Autofill in Syncfusion ##Platform_Name## Combo Box component and more.
platform: ej2-asp-core-mvc
control: Autofill
publishingplatform: ##Platform_Name##
documentation: ug
---


# Autofill supported with ComboBox

The ComboBox supports the `autofill` behaviour with the help
of [autofill](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ComboBox~Autofill.html) property. Whenever you change the input value,
the ComboBox will autocomplete your data by matching the typed character. Suppose, if no matches
found then, comboBox doesn't suggest any item.

In the following sample, showcase that how to work autofill with ComboBox.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/combobox/how-to/autofill/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Countries.cs" %}
{% include code-snippet/combobox/how-to/autofill/Countries.cs %}
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


