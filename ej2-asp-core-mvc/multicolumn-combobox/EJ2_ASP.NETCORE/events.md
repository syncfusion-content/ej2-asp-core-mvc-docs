---
layout: post
title: Events in ##Platform_Name## MultiColumn Combobox Control | Syncfusion
description: Checkout and learn about Events in Syncfusion ##Platform_Name## MultiColumn Combobox control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Events
publishingplatform: ##Platform_Name##
documentation: ug
---

# Events in ##Platform_Name## MultiColumn Combobox control

This section describes the multicolumn combobox events that will be triggered when appropriate actions are performed. The following events are available in the multicolumn combobox control.

## actionBegin

The [actionBegin](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_ActionBegin) event is triggered before fetching data from the remote server.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/events/actionBegin/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ActionBegin.cs" %}
{% include code-snippet/multicolumn-combobox/events/actionBegin/actionBegin.cs %}
{% endhighlight %}
{% endtabs %}

## actionFailure

The [actionFailure](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_ActionFailure) event is triggered when the data fetch request from the remote server fails.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/events/actionFailure/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ActionFailure.cs" %}
{% include code-snippet/multicolumn-combobox/events/actionFailure/actionFailure.cs %}
{% endhighlight %}
{% endtabs %}

## actionComplete

The [actionComplete](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_ActionComplete) event is triggered after data is fetched successfully from the remote server.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/events/actionComplete/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ActionComplete.cs" %}
{% include code-snippet/multicolumn-combobox/events/actionComplete/actionComplete.cs %}
{% endhighlight %}
{% endtabs %}

## select

The [select](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_Select) event is triggered when the popup item is selected.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/events/select/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Select.cs" %}
{% include code-snippet/multicolumn-combobox/events/select/select.cs %}
{% endhighlight %}
{% endtabs %}

## change

The [change](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_Change) event is triggered when the popup item is selected or when the model value is changed.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/events/change/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Change.cs" %}
{% include code-snippet/multicolumn-combobox/events/change/change.cs %}
{% endhighlight %}
{% endtabs %}

## filtering

The [filtering](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_Filtering) event is triggered when typing a character in the component.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/events/filtering/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Filtering.cs" %}
{% include code-snippet/multicolumn-combobox/events/filtering/filtering.cs %}
{% endhighlight %}
{% endtabs %}

## open

The [open](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_Open) event is triggered when the popup is opened.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/events/open/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Open.cs" %}
{% include code-snippet/multicolumn-combobox/events/open/open.cs %}
{% endhighlight %}
{% endtabs %}

## close

The [close](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_Close) event is triggered when the popup is closed.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/events/close/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Close.cs" %}
{% include code-snippet/multicolumn-combobox/events/close/close.cs %}
{% endhighlight %}
{% endtabs %}
