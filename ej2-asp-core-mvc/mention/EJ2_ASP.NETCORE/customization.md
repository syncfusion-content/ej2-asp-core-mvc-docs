---
layout: post
title: Customization in ##Platform_Name## Mention Component
description: Learn here all about customization in Syncfusion ##Platform_Name## Mention component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Customization
publishingplatform: ##Platform_Name##
documentation: ug
---

## Show or hide mention character

By default, the `showMentionChar` which does not display the text content with the mentioned character is disabled. If the property [showMentionChar](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_ShowMentionChar) is enabled, it allows to display the respective [mentionChar](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_MentionChar) configured along with the text content opted from the suggested list to display.

The following example displays the text content along with the customized mentioned character as **#**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/mention/customization/mention-char-customization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/mention/filtering-data/mention-char-customization/EmailData.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core show or hide mention character](../images/asp-core-mvc-mention-show-mention-char.png)

## Adding the suffix character after selection

The Mention has support to specify the custom suffix to append alongside with the mentioned selected item while inserting. You can append space or new line character as [suffixText](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_SuffixText).

The following example displays the white space next to the text selected since the suffixText is configured as `&nbsp;`.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/mention/customization/suffix-char-customization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/mention/customization/suffix-char-customization/SportsData.cs %}
{% endhighlight %}
{% endtabs %}

## Configure the popup list

You can customize the suggestion list width and height using the [popupHeight](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_PopupHeight) and [popupWidth](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_PopupWidth) properties.

By default, the popup list width value is set as `auto`. Depends on the mentioned suggestion list data, the width value is automatically adjust. The popup list height value is set as `300px`.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/mention/customization/popup-list-customization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/mention/filtering-data/popup-list-customization/Countries.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core popup list customization](../images/asp-core-mvc-mention-popup-list-customization.png)


