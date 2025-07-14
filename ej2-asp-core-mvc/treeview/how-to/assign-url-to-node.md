---
layout: post
title: Assign URLs to Nodes in ##Platform_Name## TreeView component | Syncfusion
description: Learn here all about Assign URLs to specific nodes in Syncfusion ##Platform_Name## TreeView component of Syncfusion Essential JS 2 and more.
platform: ej2-vue
control: ej2-asp-core-mvc
documentation: ug
domainurl: ##DomainURL##
---

# How to Assign URLs to TreeView Nodes in TreeView component

{% if page.publishingplatform == "aspnet-core" %}

You can able to assign url to the nodes of TreeView by using [NavigateUrl](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.TreeViewFieldsSettings.html#Syncfusion_EJ2_Navigations_TreeViewFieldsSettings_NavigateUrl) in field property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treeview/how-to/navigate-url-node-cs1/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Nodecheck.cs" %}
{% include code-snippet/treeview/how-to/navigate-url-node-cs1/node-url-core.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

You can able to assign url to the nodes of TreeView by using [NavigateUrl](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.TreeViewFieldsSettings.html#Syncfusion_EJ2_Navigations_TreeViewFieldsSettings_NavigateUrl) in field property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treeview/how-to/navigate-url-node-cs1/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Nodecheck.cs" %}
{% include code-snippet/treeview/how-to/navigate-url-node-cs1/node-url-mvc.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
