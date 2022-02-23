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

{% aspTab template="listview/mobile", sourceFiles="list.cs" %}

{% endaspTab %}