---
layout: post
title: Styles and Appearance in ##Platform_Name## TreeView component | Syncfusion
description: Checkout and learn here all about styles and appearance in Syncfusion ##Platform_Name# TreeView component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: TreeView
publishingplatform: ##Platform_Name##
documentation: ug
---

# Styles and Appearance in ##Platform_Name## TreeView Component

The following content provides the exact CSS structure that can be used to modify the component's appearance based on the user preference.

## Customizing the height of TreeView nodes

Use the following CSS to customize the TreeView nodes.

```css
.e-treeview .e-list-item { 
        line-height: 45px; 
} 
.e-treeview .e-fullrow { 
        height: 45px; 
}
```

## Customizing the text of TreeView nodes

Use the following CSS to customize the text of TreeView nodes.

```css
.e-treeview .e-list-text { 
        font-weight: bold;
        color:yellow !important;
} 
```

## Customizing the TreeView expand and collapse icons

Use the following CSS to customize the TreeView expand and collapse icons.

```css
.e-treeview .e-icon-expandable { 
        color: red; 
} 
.e-treeview .e-icon-collapsible { 
        color: black; 
}
```

## Customizing the TreeView checkboxes

Use the following CSS to customize the TreeView checkboxes.

```css
.e-checkbox-wrapper .e-frame {
    border:aqua solid 2px !important;
    border-radius: 50% !important;
}
.e-checkbox-wrapper:hover .e-frame{
    border:black solid 2px !important;
    border-radius:50% !important;
}
```
## Customizing the TreeView nodes based on levels

Use the following CSS to customize the TreeView nodes based on levels.

```css
.e-treeview .e-level-2 > .e-text-content { 
        border: 1px solid black; 
        background: #ffe800b5 !important;
} 
```

## Customizing the TreeView using HtmlAttributes

{% if page.publishingplatform == "aspnet-core" %}

The [HtmlAttributes](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.TreeViewFieldsSettings.html#Syncfusion_EJ2_Navigations_TreeViewFieldsSettings_HtmlAttributes) property of the TreeView component allows you to define a mapping field for applying custom HTML attributes to individual TreeView nodes.

```css
.child-node {
  font-weight: bold;
}
```

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/treeview/customization/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}


The [HtmlAttributes](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Navigations.TreeViewFieldsSettings.html#Syncfusion_EJ2_Navigations_TreeViewFieldsSettings_HtmlAttributes) property of the TreeView component allows you to define a mapping field for applying custom HTML attributes to individual TreeView nodes.

```css
.child-node {
  font-weight: bold;
}
```

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/treeview/customization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Selfreferential.cs" %}
{% include code-snippet/treeview/customization/selfreferential.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}