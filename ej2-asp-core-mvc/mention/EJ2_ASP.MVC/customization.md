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

By default, the `ShowMentionChar` which does not display the text content with the mentioned character is disabled. If the property [ShowMentionChar](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_ShowMentionChar) is enabled, it allows the respective [MentionChar](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_MentionChar) configured along with the text content opted from the suggested list to display.

The following example displays the text content along with the default mentioned character.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/mention/customization/mention-char-customization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/mention/customization/mention-char-customization/mentionChar-customization.cs %}
{% endhighlight %}
{% endtabs %}

## Adding the suffix character after selection

The Mention has provided support to specify the custom suffix to append alongside with the mentioned selected item while inserting. You can append space or new line character as [SuffixText](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_SuffixText).

The following example displays the white space next to the text selected since the suffixText is configured as `&nbsp;`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/mention/customization/suffix-char-customization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/mention/customization/suffix-char-customization/suffixChar-customization.cs %}
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
{% include code-snippet/mention/customization/popup-list-customization/popup-list-customization.cs %}
{% endhighlight %}
{% endtabs %}

![Configure popup list](../images/popup-list.png)
