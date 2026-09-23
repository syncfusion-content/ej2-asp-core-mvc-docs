---
layout: post
title: Preview tab in ##Platform_Name## Form Builder control | Syncfusion
description: Learn how to use the preview tab in the ##Platform_Name## Form Builder control to view the generated form and review the JSON schema.
platform: ej2-asp-core-mvc
control: Preview Tab
publishingplatform: ##Platform_Name##
documentation: ug
---

# Preview Tab in ##Platform_Name## Form Builder component

The Form Builder provides a preview tab that lets you view the generated form as it will appear to end users. It also includes a JSON code preview to review the form schema created by the builder.

## Preview the form

You can switch to the **Preview** tab to see a live preview of the form. This view reflects the current form configuration and helps you validate the layout, labels, and field behavior before exporting or publishing the form.

![Preview in Form Builder](./images/form-builder-preview.gif)

## Disabling the preview

The preview option can be disabling by setting the `enablePreview` property to `false`. The default value is `true`.

{% if page.publishingplatform == "aspnet-mvc" %}
```cshtml
@using Syncfusion.EJ2
@using Syncfusion.EJ2.FormBuilder

<div>
    @Html.EJS().FormBuilder("form-builder-control").EnablePreview(false).Render()
</div>
```
{% elsif page.publishingplatform == "aspnet-core" %}
```cshtml

<ejs-form-builder id="form-builder-control"
                  enablePreview="false">
</ejs-form-builder>

```
{% endif %}

The output will appear as follows:

![Disabling the preview in Form Builder](./images/form-builder-disable-preview.png)

## JSON code preview

You can switch to the **JSON** tab to view the form schema as a JSON object. This code preview is useful for reviewing the generated schema and understanding the structure used by the Form Builder.

The **Copy** button in the JSON code preview copies the created form schema JSON object to the clipboard so that you can reuse it in another application or pass it to the Form Renderer control.

![Code Preview in Form Builder](./images/form-builder-code-preview.gif)

## Build and preview workflow

Use the **Build** tab to create or edit the form, then switch to **Preview** to validate the rendered form. If you need the schema representation, open **JSON** and use **Copy** to copy the generated form schema.
