---
layout: post
title: Process The Tree Node Operations Using Context Menu in ##Platform_Name## Treeview Component
description: Learn here all about Process The Tree Node Operations Using Context Menu in Syncfusion ##Platform_Name## Treeview component and more.
platform: ej2-asp-core-mvc
control: Process The Tree Node Operations Using Context Menu
publishingplatform: ##Platform_Name##
documentation: ug
---

# Process the tree node operations using context menu

You can integrate the context menu with 'TreeView' control in order to perform the tree view related operations like add, remove and renaming node.

Following is an example which demonstrates the above cases which are used to manipulate tree view operations in the 'select ' event of context menu.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treeview/how-to/context-menu/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Contextmenu.cs" %}
{% include code-snippet/treeview/how-to/context-menu/contextmenu.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treeview/how-to/context-menu/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Contextmenu.cs" %}
{% include code-snippet/treeview/how-to/context-menu/contextmenu.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![TreeView Sample](../images/contextmenu.PNG)