layout: post
title: Popup Items in ##Platform_Name## Drop Down Button Component
description: Learn here all about popup items in Syncfusion ##Platform_Name## Drop Down Button component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Popup Items
publishingplatform: ##Platform_Name##
documentation: ug
---

## Customize Popup Width

The [PopupWidth](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.DropDownButton.html#Syncfusion_EJ2_SplitButtons_DropDownButton_PopupWidth) property determines the width of the dropdown popup in the DropDownButton component. By default, the popup's width adjusts based on the content. However, this property allows setting a specific width, ensuring consistency and alignment with design requirements. The width can be specified using common CSS units or as a raw pixel value.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownbutton/popup-items/popup-width/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Popuptemplate.cs" %}
{% include code-snippet/dropdownbutton/popup-items/popup-width/popupWidth.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownbutton/popup-items/popup-width/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Popuptemplate.cs" %}
{% include code-snippet/dropdownbutton/popup-items/popup-width/popupWidth.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Integration with ListView component](./how-to/group-popup-items-with-listview-component)