---
layout: post
title: Create Mnemonic Ui In Menuitem in ##Platform_Name## Menu Component
description: Learn here all about Create Mnemonic Ui In Menuitem in Syncfusion ##Platform_Name## Menu component and more.
platform: ej2-asp-core-mvc
control: Create Mnemonic Ui In Menuitem
publishingplatform: ##Platform_Name##
documentation: ug
---

# Create mnemonic UI in menu item

A particular character in a text can be underlined in the [`beforeItemRender`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Menu~BeforeItemRender.html) event by
adding `<u>` tag in between the text and assign the innerHTML to the `li` element.

In the following example, the first character in `File`, `Open`, and `Save` menu items are underlined.

In the below example, `File`, `Open` and `Save` items are underlined with first character in menu items.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/menu/how-to/underline/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Underline.cs" %}
{% include code-snippet/menu/how-to/underline/Underline.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/menu/how-to/underline/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Underline.cs" %}
{% include code-snippet/menu/how-to/underline/Underline.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


