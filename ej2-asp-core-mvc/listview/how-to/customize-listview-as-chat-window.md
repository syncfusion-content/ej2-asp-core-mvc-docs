---
layout: post
title: Customize Listview As Chat Window in ##Platform_Name## Listview Component
description: Learn here all about Customize Listview As Chat Window in Syncfusion ##Platform_Name## Listview component and more.
platform: ej2-asp-core-mvc
control: Customize Listview As Chat Window
publishingplatform: ##Platform_Name##
documentation: ug
---

# Customize ListView as Chat Window

ListView can be customized as chat window. To achieve that, use the ListView [template](https://ej2.syncfusion.com/documentation/api/list-view/#template) property and [Avatar](https://ej2.syncfusion.com/documentation/avatar/getting-started) component.

    * The Listview template property is used to showcase the ListView as chat window.
    * Avatar component is used to design the image of contact person.

Refer the below template code snippet for Template of chat window.

```typescript
var template = "<div class='settings'>" +
                "${if(chat!=='receiver')}" +
                "<div id='content'>" +
                "<div class='name'>${text}</div>" +
                "<div id='info'>${contact}</div></div>" +
                "${if(avatar!=='')}" +
                "<div id='image'><span class='e-avatar img1 e-avatar-circle'>${avatar}</span></div>" +
                "${else}" +
                "<div id='image'><span class='${pic} img1 e-avatar e-avatar-circle'> </span></div>" +
                "${/if}" +
                "${else}" +
            "${if(avatar!=='')}" +
                "<div id='image2'><span class='e-avatar img2 e-avatar-circle'>${avatar}</span></div>" +
                "${else}" +
                "<div id='image2'><span class='${pic} img2 e-avatar e-avatar-circle'> </span></div>" +
                "${/if}" +
                "<div id='content1'>" +
                "<div class='name1'>${text}</div>" +
                "<div id='info1'>${contact}</div>" +
                "</div>" +
                "${/if}" +
                "</div>";
```

## Chat order in template

In ListView template, we have rendered the list items based on receiver and sender information from dataSource of listview.

### Adding messages to chat window

    * Use textbox to get message from user.
    * Add the textbox message to ListView dataSource using [addItem](https://ej2.syncfusion.com/documentation/api/list-view/#additem) method.

```typescript

document.getElementById('btn').addEventListener('click', (e) => {
    var value = document.getElementById('name').value;
     document.getElementById('List').ej2_instances[0].addItem([{ text: "Amenda", contact: value, id: "2", avatar: "A", pic: "", chat: "receiver" }]);
  });

```

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/listview/chat/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="List.cs" %}
{% include code-snippet/listview/chat/list.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/listview/chat/razor %}
{% endhighlight %}
{% highlight c# tabtitle="List.cs" %}
{% include code-snippet/listview/chat/list.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

