---
layout: post
title: Assign URLs to Nodes in ##Platform_Name## TreeView component | Syncfusion
description: Learn here all about Assign URLs to specific nodes in Syncfusion ##Platform_Name## TreeView component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: ej2-asp-core-mvc
documentation: ug
domainurl: ##DomainURL##
---

# Navigation in ##Platform_Name## TreeView Component

{% if page.publishingplatform == "aspnet-core" %}


Using the [`NavigateUrl`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.TreeViewFieldsSettings.html#Syncfusion_EJ2_Navigations_TreeViewFieldsSettings_NavigateUrl) of the TreeView component, you can navigate from one page to another based on the node selection and link provided in the corresponding nodes.

To perform navigation in the TreeView component, use and map the `NavigateUrl` field in the data source.

## Navigation URL binding in ##Platform_Name## TreeView Component

In the TreeView component, use the [`NavigateUrl`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.TreeViewFieldsSettings.html#Syncfusion_EJ2_Navigations_TreeViewFieldsSettings_NavigateUrl) property to specify the URL to navigate to when the tree node is selected.


{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treeview/how-to/navigate-url-node-cs1/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Nodecheck.cs" %}
{% include code-snippet/treeview/how-to/navigate-url-node-cs1/node-url-core.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Using the [`NavigateUrl`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.TreeViewFieldsSettings.html#Syncfusion_EJ2_Navigations_TreeViewFieldsSettings_NavigateUrl) of the TreeView component, you can navigate from one page to another based on the node selection and link provided in the corresponding nodes.

To perform navigation in the TreeView component, use and map the `NavigateUrl` field in the data source.

## Navigation URL binding in ##Platform_Name## TreeView Component

In the TreeView component, use the [`NavigateUrl`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.TreeViewFieldsSettings.html#Syncfusion_EJ2_Navigations_TreeViewFieldsSettings_NavigateUrl) property to specify the URL to navigate to when the tree node is selected.


{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treeview/how-to/navigate-url-node-cs1/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Nodecheck.cs" %}
{% include code-snippet/treeview/how-to/navigate-url-node-cs1/node-url-mvc.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## Full row navigation in ##Platform_Name## TreeView Component

{% if page.publishingplatform == "aspnet-core" %}

The TreeView [`FullRowNavigable`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.TreeView.html#Syncfusion_EJ2_Navigations_TreeView_FullRowNavigable) property is used to make the entire TreeView node navigable instead of text element in the TreeView component.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treeview/how-to/fullrownavigate-url-node-cs1/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Nodecheck.cs" %}
{% include code-snippet/treeview/how-to/fullrownavigate-url-node-cs1/node-url-core.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The TreeView [`FullRowNavigable`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.TreeView.html#Syncfusion_EJ2_Navigations_TreeView_FullRowNavigable) property is used to make the entire TreeView node navigable instead of text element in the TreeView component.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treeview/how-to/fullrownavigate-url-node-cs1/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Nodecheck.cs" %}
{% include code-snippet/treeview/how-to/fullrownavigate-url-node-cs1/node-url-mvc.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}