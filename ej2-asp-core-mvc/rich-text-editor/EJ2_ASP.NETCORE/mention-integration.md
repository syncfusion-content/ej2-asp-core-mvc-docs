---
layout: post
title: Mention Integration in ASP.NET Core Rich Text Editor | Syncfusion
description: Learn here all about Mention Integration in Syncfusion ASP.NET Core Rich Text Editor control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Mention Integration
publishingplatform: aspnet-core
documentation: ug
---

# Mention Integration with Rich Text Editor

By integrating the [Mention](https://ej2.syncfusion.com/aspnetcore/documentation/mention/getting-started) control with a Rich Text Editor, users can easily mention or tag other users or objects from the suggested list without having to manually type out their names or other identifying information.

The [target](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_Target) property of the Mention control allows you to specify the `ID` of the content editable div element within the Rich Text Editor that you want to bind the Mention control to. This allows you to enable the Mention functionality within the Rich Text Editor, so that users can mention or tag other users or objects from the suggested list while editing the text.

When the user types the `@` symbol followed by a character, the Rich Text Editor will display a list of suggestions for items that the user can select from. The user can then select an item from the list by clicking on it, or by typing the name of the item they want to tag.

In the following sample, configured the following properties with popup dimensions.

* [allowSpaces](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_AllowSpaces) - Allow to continue search action if user enter space after mention character while searching.
* [suggestionCount](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_SuggestionCount) - The maximum number of items that will be displayed in the suggestion list.
* [itemTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_ItemTemplate) - Used to display the customized appearance in suggestion list.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/mention-integration/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/mention-integration/EmployeeData.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core mention integration ](./images/mention-integration.png)

> [View Sample](https://ej2.syncfusion.com/aspnetcore/RichTextEditor/MentionIntegration#/bootstrap5)

## See Also

* [Mention](https://ej2.syncfusion.com/aspnetcore/documentation/mention/getting-started)