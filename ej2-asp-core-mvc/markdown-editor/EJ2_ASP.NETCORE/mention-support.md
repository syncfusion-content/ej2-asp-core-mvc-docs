---
layout: post
title: Mention Support in ##Platform_Name## Markdown Editor Control | Syncfusion
description: Checkout and learn about Mention Support in ##Platform_Name## Markdown Editor control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Mention Support
publishingplatform: ##Platform_Name##
documentation: ug
---

# Mention Support in ##Platform_Name## Markdown Editor Control

By integrating the [Mention](https://ej2.syncfusion.com/aspnetcore/documentation/mention/getting-started) control with the Markdown Editor, users can effortlessly mention or tag other users or objects from a suggested list. This eliminates the need to manually type out names or identifying information, improving both efficiency and accuracy.

To enable the Mention functionality within the Markdown Editor, set the [target](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.dropdowns.mention.html#Syncfusion_EJ2_DropDowns_Mention_Target)  property of the Mention control to the ID of the textarea element inside the editor. When specifying the target, ensure that you append the suffix `_editable-content` to the ID. This configuration allows users to mention or tag others from the suggested list while editing text.

When a user types the `@` symbol followed by a character, the Markdown Editor displays a list of suggestions. Users can select an item from the list by either clicking on it or typing the desired name. In the following sample, we have configured the Mention control with additional properties:

* [allowSpaces](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.dropdowns.mention.html#Syncfusion_EJ2_DropDowns_Mention_AllowSpaces) - Allow to continue search action if user enter space after mention character while searching.
* [suggestionCount](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.dropdowns.mention.html#Syncfusion_EJ2_DropDowns_Mention_SuggestionCount) - Defines the maximum number of items displayed in the suggestion list.
* [itemTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.dropdowns.mention.html#Syncfusion_EJ2_DropDowns_Mention_ItemTemplate) - Customizes the appearance of items in the suggestion list.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/markdown-editor/markdown-mention-support/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/markdown-editor/markdown-mention-support/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/markdown-editor/markdown-mention-support/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/markdown-editor/markdown-mention-support/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}