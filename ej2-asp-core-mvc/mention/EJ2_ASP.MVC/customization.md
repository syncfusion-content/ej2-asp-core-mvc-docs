---
layout: post
title: Customization in ##Platform_Name## Mention Component
description: Learn here all about customization in Syncfusion ##Platform_Name## Mention component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Customization
publishingplatform: ##Platform_Name##
documentation: ug
---

# Customization

The Mention control allows the user to control the mentioned character and custom text to be displayed by using the [ShowMentionChar](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_ShowMentionChar) and [SuffixText](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_SuffixText) properties. Also, user can customize the popup height and width using the [PopupHeight](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_PopupHeight) and [PopupWidth](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_PopupWidth) properties.

## Show or hide mention character

You can show mention character as prefix of selected item in mention component using [showMentionChar](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_ShowMentionChar) property. The default value of `showMentionChar` is `false`.

The following example displays the text content along with the customized mentioned character as **#**.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/mention/customization/mention-char-customization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/mention/customization/mention-char-customization/EmailData.cs %}
{% endhighlight %}
{% endtabs %}

![Show or hide mention character](../images/asp-core-mvc-mention-show-mention-char.png)

## Adding the suffix character after selection

You can add suffix character while selecting an item in Mention component using [SuffixText](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_SuffixText) property. You can add space or new line as suffix to the selected item. The default values is empty string.

The following example displays the white space next to the text selected since the suffixText is configured as `&nbsp;`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/mention/customization/suffix-char-customization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/mention/customization/suffix-char-customization/SportsData.cs %}
{% endhighlight %}
{% endtabs %}

## Configure the popup list

By default, the width of the popup list adjusts automatically according to the mentioned suggestion list data's width, and the height of the popup list is `300px`. They can also be customized using the [PopupHeight](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_PopupHeight) and [PopupWidth](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_PopupWidth) properties respectively.

In the following sample, popup list's width and height are configured.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/mention/customization/popup-list-customization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/mention/customization/popup-list-customization/Countries.cs %}
{% endhighlight %}
{% endtabs %}

![Configure popup list](../images/asp-core-mvc-mention-popup-list-customization.png)
