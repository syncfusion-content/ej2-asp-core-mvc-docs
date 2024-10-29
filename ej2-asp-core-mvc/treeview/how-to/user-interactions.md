---
layout: post
title: User interactions in Syncfusion ##Platform_Name## Treeview Component
description: Learn here all about User interactions in Syncfusion ##Platform_Name## Treeview component of syncfusion and more.
platform: ej2-asp-core-mvc
control: User interactions
publishingplatform: ##Platform_Name##
documentation: ug
---

# User interactions in TreeView component

The below methods were available in TreeView, and we can walk through one by one.

* addNodes
* removeNodes
* updateNode
* refreshNode
* moveNodes

## addNodes

TreeView allows user to add the collection of TreeView nodes based on target and index position by using the `addNodes` method. You can add parent as well as the child by passing its id and target as arguments. Here, you can achieve this by using button click.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treeview/how-to/user-interactions-cs1/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="user-interactions-cs1.cs" %}
{% include code-snippet/treeview/how-to/user-interactions-cs1/user-interactions-cs1.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treeview/how-to/user-interactions-cs1/razor %}
{% endhighlight %}
{% highlight c# tabtitle="user-interactions-cs1.cs" %}
{% include code-snippet/treeview/how-to/user-interactions-cs1/user-interactions-cs1.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![TreeView Sample](../images/user-interactions-cs1.PNG)

## removeNodes

TreeView allows user to remove the collection of TreeView nodes by passing the array of node id by using the `removeNodes` method. You can remove parent as well as the child by passing its id value. Here, you can achieve this by using button click.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treeview/how-to/user-interactions-cs2/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="user-interactions-cs2.cs" %}
{% include code-snippet/treeview/how-to/user-interactions-cs2/user-interactions-cs2.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treeview/how-to/user-interactions-cs2/razor %}
{% endhighlight %}
{% highlight c# tabtitle="user-interactions-cs2.cs" %}
{% include code-snippet/treeview/how-to/user-interactions-cs2/user-interactions-cs2.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![TreeView Sample](../images/user-interactions-cs2.PNG)

## updateNode

TreeView allows user to update TreeView nodes by passing the target and the text to be shown by using the `updateNode` method. You can also need to enable the `allowEditing` property. Here, you can achieve this by using button click.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treeview/how-to/user-interactions-cs3/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="user-interactions-cs3.cs" %}
{% include code-snippet/treeview/how-to/user-interactions-cs3/user-interactions-cs3.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treeview/how-to/user-interactions-cs3/razor %}
{% endhighlight %}
{% highlight c# tabtitle="user-interactions-cs3.cs" %}
{% include code-snippet/treeview/how-to/user-interactions-cs3/user-interactions-cs3.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![TreeView Sample](../images/user-interactions-cs3.PNG)

## refreshNode

TreeView allows user to refresh TreeView nodes with new changes by passing the target and the new changes to be shown by using the `refreshNode` method while using the nodeTemplate property. Here, you can achieve this by using button click.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treeview/how-to/user-interactions-cs4/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="user-interactions-cs4.cs" %}
{% include code-snippet/treeview/how-to/user-interactions-cs4/user-interactions-cs4.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treeview/how-to/user-interactions-cs4/razor %}
{% endhighlight %}
{% highlight c# tabtitle="user-interactions-cs4.cs" %}
{% include code-snippet/treeview/how-to/user-interactions-cs4/user-interactions-cs4.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![TreeView Sample](../images/user-interactions-cs4.PNG)

## moveNodes

TreeView allows user to move TreeView node by passing the node to be moved, the target where to be moved, index of the moved node to be placed in target by using the `moveNodes` method. Here, you can achieve this by using button click.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treeview/how-to/user-interactions-cs5/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="user-interactions-cs5.cs" %}
{% include code-snippet/treeview/how-to/user-interactions-cs5/user-interactions-cs5.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treeview/how-to/user-interactions-cs5/razor %}
{% endhighlight %}
{% highlight c# tabtitle="user-interactions-cs5.cs" %}
{% include code-snippet/treeview/how-to/user-interactions-cs5/user-interactions-cs5.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![TreeView Sample](../images/user-interactions-cs5.PNG)