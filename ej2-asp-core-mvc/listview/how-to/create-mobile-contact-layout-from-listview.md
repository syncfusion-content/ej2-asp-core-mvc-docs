---
layout: post
title: Create Mobile Contact Layout From Listview in ##Platform_Name## Listview Component
description: Learn here all about Create Mobile Contact Layout From Listview in Syncfusion ##Platform_Name## Listview component and more.
platform: ej2-asp-core-mvc
control: Create Mobile Contact Layout From Listview
publishingplatform: ##Platform_Name##
documentation: ug
---

# Create Mobile contact layout from ListView

You can customize the ListView using the
[template](https://ej2.syncfusion.com/documentation/api/list-view/#template) property. Refer
to the following steps to customize ListView as mobile contact view with our `ej2-avatar`.

* Render the ListView with
[dataSource](https://ej2.syncfusion.com/documentation/api/list-view/#datasource) that has
avatar data. You can set avatar data as either text or class names. Refer to the following codes.

```typescript

    List<object> listdata = new List<object>();
    listdata.Add(new
    {
        text = "Jenifer",
        contact = "(206) 555-985774",
        id = "1",
        avatar = "",
        pic = "pic01"
    });
        listdata.Add(new
    {
        text = "Amenda",
        contact = "(206) 555-3412",
        id = "2",
        avatar = "A",
        pic = ""
    });

```

* Set `avatar` classes in ListView template to customize contact icon. In the following codes, medium size avatar has been
set using the class name `e-avatar e-avatar-circle` from data source.

```typescript

  var template: "<div class='settings'>" +
            "${if(avatar!=='')}" +
            "<span class='e-avatar e-avatar-circle'>${avatar}</span>" +
            "${else}" +
            "<span class='${pic} e-avatar e-avatar-circle'> </span>" +
            "${/if}" +
            "<div id='content'>" +
            "<div class='name'>${text}</div>" +
            "<div id='info'>${contact}</div>" +
            "</div>";

```

> Avatars can be set in different sizes in avatar classes. To know more about avatar classes, refer to
[Avatar](https://ej2.syncfusion.com/demos/#/material/avatar/default).

* Sort the contact names using the
[`sortOder`](https://ej2.syncfusion.com/documentation/api/list-view/#sortorder) property of ListView.

* Enable the [`showHeader`](https://ej2.syncfusion.com/documentation/api/list-view/#showheader)
property, and set the
[`headerTitle`](https://ej2.syncfusion.com/documentation/api/list-view/#headertitle)
as `Contacts`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/listview/mobile/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="List.cs" %}
{% include code-snippet/listview/mobile/list.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/listview/mobile/razor %}
{% endhighlight %}
{% highlight c# tabtitle="List.cs" %}
{% include code-snippet/listview/mobile/list.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

