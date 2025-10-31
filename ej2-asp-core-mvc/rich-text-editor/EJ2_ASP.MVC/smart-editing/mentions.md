---
layout: post
title: Mention Integration in ASP.NET MVC Rich Text Editor | Syncfusion
description: Learn here all about Mention Integration in Syncfusion ASP.NET MVC Rich Text Editor control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Mention Integration
publishingplatform: ##Platform_Name##
documentation: ug
---

# Mentions in the ##Platform_Name## Rich Text Editor Control

By integrating the [Mention](https://ej2.syncfusion.com/aspnetmvc/documentation/mention/getting-started) component with a Rich Text Editor, users can effortlessly mention or tag other users or objects from a suggested list. This eliminates the need to manually type out names or identifying information, improving efficiency and accuracy.

## Setup and configuration

Use the [Target](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_Target) property of the Mention component to specify the `ID` of the content editable div element within the Rich Text Editor. When setting the target, make sure to append the suffix `_rte-edit-view` to the ID. This allows you to enable the Mention functionality within the Rich Text Editor, so that users can mention or tag other users or objects from the suggested list while editing the text.

## Using mentions

When the user types the `@` symbol followed by a character, the Rich Text Editor displays a list of suggestions. Users can then select an item from the list by:

* Clicking on it
* Typing the name of the item they want to tag

## Customizing suggestion list 

### Minimum input length for Mention suggestions

You can control when the suggestion list appears by setting the [MinLength](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_MinLength) property in the Mention control. This property defines the minimum number of characters a user must type after the mention character (@) to trigger the search action. This is especially useful when working with large datasets, as it helps reduce unnecessary queries and improves performance.

By default, `MinLength` is set to 0, which means the suggestion list appears immediately after the mention character is entered. However, you can increase this value to delay the search until the user has typed a specific number of characters.

In the following example, the `MinLength` is set to 3, so the suggestion list will only appear once the user types three or more characters after the @ symbol.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/mention-min-length/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/mention-min-length/EmployeeData.cs %}
{% endhighlight %}
{% endtabs %}

### Customizing suggestion list count

You can control the number of items displayed in the Mention suggestion list using the [SuggestionCount](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_SuggestionCount) property. This is particularly useful when working with large datasets, allowing you to limit the number of suggestions shown to the user.

By default, the suggestion list displays 25 items. You can customize this value to show fewer or more items based on your application's needs.

In the example below, the `SuggestionCount` is set to 5, so only 5 items will be displayed in the suggestion list when the user types the mention character (@).

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/mention-suggestion-count/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/mention-suggestion-count/EmployeeData.cs %}
{% endhighlight %}
{% endtabs %}

### Customizing suggestion list using templates

#### Item template

You can customize how each item appears in the suggestion list using the [ItemTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_ItemTemplate) property. This allows you to display additional details such as email, role, or profile image alongside the mention name.

#### Display template 

Use the [DisplayTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_DisplayTemplate) property to define how the selected mention appears in the editor content.

For example, by default, the mention chip renders as:

```
<span contenteditable="false" class="e-mention-chip">@Selma Rose</span>

```

Using the `DisplayTemplate` property, you can customize it to render as a clickable link:

```
<a href="mailto:selma@gmail.com" title="selma@gmail.com">@Selma Rose</a>

```

This allows you to create more interactive and informative mentions within the editor.

In the following sample, we configured the following properties:

* [DisplayTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_DisplayTemplate) -Used to customize how the selected value appears in the editor content.
* [AllowSpaces](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_AllowSpaces) - Allow to continue search action if user enter space after mention character while searching.
* [SuggestionCount](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_SuggestionCount) - The maximum number of items that will be displayed in the suggestion list.
* [ItemTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.Mention.html#Syncfusion_EJ2_DropDowns_Mention_ItemTemplate) - Used to display the customized appearance in suggestion list.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/mention-integration/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/mention-integration/EmployeeData.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC mention integration ](../images/mention-integration.png)

> [View Sample](https://ej2.syncfusion.com/aspnetmvc/RichTextEditor/MentionIntegration#/bootstrap5)

## See Also

* [Getting Started with Mention](https://ej2.syncfusion.com/aspnetmvc/documentation/mention/getting-started)