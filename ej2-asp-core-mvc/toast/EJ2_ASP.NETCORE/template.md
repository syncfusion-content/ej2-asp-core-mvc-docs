---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Template of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Template
publishingplatform: ##Platform_Name##
documentation: ug
---


# Template

The [`template`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Notifications.Toast.html#Syncfusion_EJ2_Notifications_Toast_Template) property can be given as the `HTML element`; this can be either a `string` or `query selector`.

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

![Toast template](./images/toast-temp.PNG)

## See Also

* [How to add dynamic template](./how-to/add-dynamic-template/)

* [How to play an audio before open the toast](./how-to/play-an-audio-before-open-the-toast/)