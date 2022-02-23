---
title: " ASP.NET MVC Toast Template"
component: "Toast"
description: "The Syncfusion ASP.NET Core Toast control template section explains how to customize the Toast control as needed."
---

# Template

The [`Template`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Notifications.Toast.html#Syncfusion_EJ2_Notifications_Toast_Template) property can be given as the `HTML element`; this can be either a `string` or `query selector`.

The HTML element tag can be given as a string for the Template property.

```typescript
template: "<div>Toast Content</div>"

```

The Template property allows getting the template content using the query `selector`. Here, the element 'ID' attribute is specified in the template.

```typescript
template: "#Template"

```

{% aspTab template="toast/template", sourceFiles="controller.cs" %}

{% endaspTab %}

Output be like the below.

![Toast Template](./images/toast-temp.PNG)

## See Also

* [How to add dynamic template](./how-to/add-dynamic-template/)

* [How to play an audio before open the toast](./how-to/play-an-audio-before-open-the-toast/)