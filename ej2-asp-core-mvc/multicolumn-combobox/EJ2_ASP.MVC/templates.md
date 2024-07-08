---
layout: post
title: Templates in ##Platform_Name## MultiColumn Combobox Control | Syncfusion
description: Checkout and learn about Templates in Syncfusion ##Platform_Name## MultiColumn Combobox control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Templates
publishingplatform: ##Platform_Name##
documentation: ug
---

# Templates in ##Platform_Name## MultiColumn Combobox control

The MultiColumn ComboBox provides several template options to customize each items, groups, header and footer elements.

## Item template

You can use the [ItemTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_ItemTemplate) property to customize each list item within the MultiColumn ComboBox.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/templates/itemtemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ItemTemplate.cs" %}
{% include code-snippet/multicolumn-combobox/templates/itemtemplate/itemtemplate.cs %}
{% endhighlight %}
{% endtabs %}

![Item template](images/itemTemp.png)

## Header template

You can add a custom element as a header element by using the `HeaderTemplate` property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/templates/headertemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HeaderTemplate.cs" %}
{% include code-snippet/multicolumn-combobox/templates/headertemplate/headertemplate.cs %}
{% endhighlight %}
{% endtabs %}

![Header template](images/headertemplate.png)

## Group template

You can use the [GroupTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_GroupTemplate) property to customize the group header in the popup list.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/templates/grouptemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="GroupTemplate.cs" %}
{% include code-snippet/multicolumn-combobox/templates/grouptemplate/grouptemplate.cs %}
{% endhighlight %}
{% endtabs %}

![Group template](images/grouptemplate.png)

## Footer template

You can add a custom element as a footer element by using the [FooterTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_FooterTemplate) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/templates/footertemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="FooterTemplate.cs" %}
{% include code-snippet/multicolumn-combobox/templates/footertemplate/footertemplate.cs %}
{% endhighlight %}
{% endtabs %}

![Footer template](images/footertemplate.png)

## No records template

You can customize the popup list for when no data is found or no matches are found by using the [NoRecordsTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_NoRecordsTemplate) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/templates/norecordtemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="NoRecordTemplate.cs" %}
{% include code-snippet/multicolumn-combobox/templates/norecordtemplate/norecordtemplate.cs %}
{% endhighlight %}
{% endtabs %}

![No records template](images/norecordtemplate.png)

## Action failure template

There is also an option to custom design the popup list content when the data fetch request fails at the remote server. This can be achieved using the [ActionFailureTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_ActionFailureTemplate) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/templates/actionfailuretemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ActionFailureTemplate.cs" %}
{% include code-snippet/multicolumn-combobox/templates/actionfailuretemplate/actionfailuretemplate.cs %}
{% endhighlight %}
{% endtabs %}

![Action failure template](images/actionfailuretemplate.png)
