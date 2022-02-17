---
layout: post
title: Check Uncheck The Checkbox On Clicking The Tree Node Text in ##Platform_Name## Treeview Component
description: Learn here all about Check Uncheck The Checkbox On Clicking The Tree Node Text in Syncfusion ##Platform_Name## Treeview component and more.
platform: ej2-asp-core-mvc
control: Check Uncheck The Checkbox On Clicking The Tree Node Text
publishingplatform: ##Platform_Name##
documentation: ug
---

# Check/uncheck the checkbox on clicking the tree node text

You can check and uncheck the checkboxes of tree view by clicking the tree node using the `nodeClicked` event of TreeView.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treeview/how-to/node-check/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Nodecheck.cs" %}
{% include code-snippet/treeview/how-to/node-check/nodecheck.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treeview/how-to/node-check/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Nodecheck.cs" %}
{% include code-snippet/treeview/how-to/node-check/nodecheck.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![TreeView Sample](../images/node-check.PNG)