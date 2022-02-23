---
title: "Rich Text Editor How To render rich text editor with razor page"
component: "Rich Text Editor"
description: "This section for Syncfusion ASP.NET Rich Text Editor control explains on how to render rich text editor with razor page."
---

# Model Binding in Razor Pages

This article deals with the model binding of the Razor Pages of the ASP.NET Core platform.
Refer to this [`Page Model`](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/page-model-binding/) section for the detailed instructions on how to create a page model.
The model binding provides data to the page models and Razor pages. OnGet is a handler method that will be executed once the Razor page gets loaded in the browser. `value` in the form tag retrieves data from the OnGet method in the `IndexModel` class using the model binding.

## Form Post Back

This sample explains the form post back properties of the rich text editor rendering with the razor page.
The Rich text editor is rendered within the form tag and the value `post` and attribute `method` has been given into the form tag. Any value into the `Request.Form` in the OnPost method will be considered as a string and those string should be mapped to the name field of the Rich Text Editor.

{% aspTab template="rich-text-editor/how-to/razor-page", sourceFiles="index.cshtml.cs" %}

{% endaspTab %}