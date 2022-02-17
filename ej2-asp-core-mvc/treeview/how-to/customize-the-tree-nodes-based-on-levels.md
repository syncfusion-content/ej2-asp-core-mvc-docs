---
layout: post
title: Customize The Tree Nodes Based On Levels in ##Platform_Name## Treeview Component
description: Learn here all about Customize The Tree Nodes Based On Levels in Syncfusion ##Platform_Name## Treeview component and more.
platform: ej2-asp-core-mvc
control: Customize The Tree Nodes Based On Levels
publishingplatform: ##Platform_Name##
documentation: ug
---

# Customize the tree nodes based on levels

You can customize the tree nodes level wise by adding custom cssClass to the control and enabling styles.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treeview/how-to/node-customize/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Nodecustomize.cs" %}
{% include code-snippet/treeview/how-to/node-customize/nodecustomize.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treeview/how-to/node-customize/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Nodecustomize.cs" %}
{% include code-snippet/treeview/how-to/node-customize/nodecustomize.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![TreeView Sample](../images/nodecustomize.PNG)
