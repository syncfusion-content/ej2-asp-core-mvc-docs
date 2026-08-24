---
layout: post
title: How to hide checkbox in ##Platform_Name## ListView | Syncfusion
description: Hide the Syncfusion ##Platform_Name## ListView checkbox column by setting showCheckBox false and disabling the entire header by setting showHeaderCheckBox false.
platform: ej2-asp-core-mvc
control: Hide Checkbox In ListView
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to hide checkbox in ##Platform_Name## ListView

The checkbox of the any list item can be hidden by using [`htmlAttributes`](https://ej2.syncfusion.com/documentation/api/list-view#htmlattributes) of [`fields`](https://ej2.syncfusion.com/documentation/api/list-view#fields) object. With the help of `htmlAttributes` we can add unique class to each list item that will be rendered from the data source, from the CSS class we can hide the checkbox of the list item.

In this sample, we had hidden the multiple leaf node of nested list. The `e-checkbox-hidden` class has been added in the data source where the checkbox needs to be hidden. Refer the below snippet for simple data source.

```typescript
    {
        text= 'New York',
        id= '3002',
        category= 'USA',
        htmlAttributes= { 'class': 'e-file e-checkbox-hidden' }
    }
```

Even though we have hidden the checkbox the functionality will be same for the list item which might affect the `getSelectedItems` method. So, to counteract that we will follow certain logic in the `select` event. The Logic here is to remove the `e-active` class from the other checkbox hidden list item which will be added when we select on that item and retain `e-active` on currently selected item.

N> In this process we will exclude the visible checkbox list items and only consider the hidden checkbox items.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/listview/checkbox/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="List.cs" %}
{% include code-snippet/listview/checkbox/list.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/listview/checkbox/razor %}
{% endhighlight %}
{% highlight c# tabtitle="List.cs" %}
{% include code-snippet/listview/checkbox/list.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

