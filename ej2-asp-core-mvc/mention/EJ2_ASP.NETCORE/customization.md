---
layout: post
title: Customization in ASP.NET Core Mention control | Syncfusion
description: Learn here all about customization in Syncfusion ASP.NET Core Mention control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Customization
publishingplatform: ASP.NET Core
documentation: ug
---

# Customization in Mention

## Show or hide mention character

You can show the mention character as the prefix of the selected item in mention control using [showMentionChar](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_ShowMentionChar) property. The default value of `showMentionChar` is `false`.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/mention/customization/mention-char-customization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/mention/filtering-data/mention-char-customization/EmailData.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Mention show or hide mention character](./images/mention-show-mention-char.png)

## Adding the suffix character after selection

You can add the suffix character while selecting an item in the Mention control using [suffixText](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_SuffixText) property. You can add space or new line as suffix to the selected item. The default values are empty string.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/mention/customization/suffix-char-customization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/mention/customization/suffix-char-customization/SportsData.cs %}
{% endhighlight %}
{% endtabs %}

## Configure the popup list

You can customize the suggestion list as width and height using the [popupHeight](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_PopupHeight) and [popupWidth](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_PopupWidth) properties.

By default, the popup list width value is set as `auto`. Depending on the mentioned suggestion data list, the width value is automatically adjusted. The popup list height value is set as `300px`.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/mention/customization/popup-list-customization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/mention/filtering-data/popup-list-customization/Countries.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Mention popup list customization](./images/mention-popup-list-customization.png)

## Trigger character

You can customize the trigger character by using the [mentionChar](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_MentionChar) property in the Mention control. The trigger character triggers the suggestion list to display in the target area.

By default, the [mentionChar](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_MentionChar) is `@`.