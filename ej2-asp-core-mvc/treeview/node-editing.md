---
layout: post
title: Node Editing in ##Platform_Name## TreeView Control | Syncfusion
description: Learn here all about Node Editing in Syncfusion ##Platform_Name## TreeView control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: TreeView
publishingplatform: ##Platform_Name##
documentation: ug
---


# Node Editing in TreeView Control

The TreeView allows you to edit nodes by setting the `allowEditing` property to **true**. To directly edit the nodes in place, **double-click** the TreeView node or **select** the node and press the **F2** key.

When editing is completed by focus out or by pressing the **Enter** key, the modified node’s text saves automatically. If you do not want to save the modified node's text in the TreeView node, press the **Escape** key. It does not save the edited text to the TreeView node.

* Node editing can also be performed programmatically by using the `beginEdit` method. When passing the **node ID** or **element** through this method, an edit textbox will be created for the particular node, allowing it to be edited.

* If you need to validate or prevent editing, the `nodeEditing` event can be used which is triggered before the TreeView node is renamed. On successfully renaming a node the `nodeEdited` event will be triggered.

In the following example, the first level node’s text cannot be changed, but all other level nodes' text can be changed.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treeview/nodeediting/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Nodeediting.cs" %}
{% include code-snippet/treeview/nodeediting/nodeediting.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treeview/nodeediting/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Nodeediting.cs" %}
{% include code-snippet/treeview/nodeediting/nodeediting-mvc.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The output will look like the image below:

![TreeView Sample](./images/node-editing.PNG)

## See Also

* [How to validate the text when renaming the tree node](./how-to/validate-the-text-when-renaming-the-tree-node)
* [How to process the tree node operations using context menu](./how-to/process-the-tree-node-operations-using-context-menu)