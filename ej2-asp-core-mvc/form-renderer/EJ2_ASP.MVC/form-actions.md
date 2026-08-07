---
layout: post
title: Form Actions in ##Platform_Name## Form Renderer Component | Syncfusion
description: Learn here all about Form Actions in Syncfusion ##Platform_Name## Form Renderer control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Form Actions
publishingplatform: ##Platform_Name##
documentation: ug
---

# Form Actions in ASP.NET MVC Form Renderer component

This section explains the form actions that can be performed in the Form Renderer control.

Forms typically include buttons to perform common actions. A submit button submits the form, a reset button restores the form to its initial state, and a plain button can be used to execute custom logic. This page explains how to define each button as a field in `properties` and describes the events raised when users click them.

A button is a regular field in `properties` with `type: "button"`. The kind of button is decided by `buttonType`:

| `buttonType` | What it does | Event raised |
| --- | --- | --- |
| `"submit"` | Validates the form. Raises `submit` if validation passes. | `submit` |
| `"reset"` | Resets every field.| — (native form reset, no event) |
| `"button"` | Plain click button. | `buttonClick` |

## Submitting the form

The form created with the Form Renderer control can be submitted when a submit button is defined in the form schema. To enable form submission, declare a button field in `properties` with `buttonType: "submit"` and include it in the `layout` array.

```csharp
new SubmitButtonProperty
{
    Id         = "submit_button_initial",
    Name       = "defaultFormsubmit",
    Type       = "button",
    Label      = "Submit",
    ButtonType = "submit",
    Widget     = "button",
    Size       = "Bigger"
}
```

When the user clicks the submit button, the renderer validates the form. If validation passes, the `submit` event fires with the current form data and an `isValid` flag.

| Member | Type | Description |
| --- | --- | --- |
| `data` | `Record<string, FieldDataType>` | The current value of every visible, non-disabled field keyed by the field's `name`. Layout-only fields (`button`, `message`, `panel`, `table`, `tabs`, `card`) are excluded. |
| `isValid` | `boolean` | `true` if every required field is filled and every validation rule passes at submit time. |

> The submission `data` object is keyed by the field's **name**, which is the same key you declared in `properties`. This keeps the payload stable when the schema is reorganized in the form builder.

### Code snippet

The following example renders a Form Renderer with email, password, and remember-me fields, along with a submit button. When the user clicks **Submit**, the `submit` event is raised with the form data and the validation status:

```cshtml
@using Syncfusion.EJ2
@using Syncfusion.EJ2.FormRenderer
@using EJ2MVCSampleBrowser.Models

@section ControlsSection {

    <div class="control-section">
        <div class="col-lg-8">
            @Html.EJS().FormRenderer("form-renderer-submit")
                .Schema((ViewData["formSchema"]))
                .Submit("onSubmit")
                .Render()
        </div>
    </div>

    <script>
        function onSubmit(args) {
            // args.data  -> Record<string, FieldDataType>
            // args.isValid -> boolean
            console.log(args);
        }
    </script>
}
```

### Server-side schema

The schema supplied to `ViewData["formSchema"]` is built on the server using strongly typed property classes, then serialized to JSON. Below is a trimmed example that matches the snippet above:

```csharp
using System.Collections.Generic;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.FormRenderer
{
    public partial class FormRendererController : Controller
    {
        public ActionResult SubmitDemo()
        {
            ViewData["formSchema"] = new FormRendererSubmitData().GetData();
            return View();
        }
    }
}
```

```csharp
public class FormRendererData
{
     public Schema GetData() => new Schema
     {
         Version = "0.1.0",
         Properties = new Dictionary<string, BaseProperty>
         {
             ["emailAddress"] = new TextboxProperty { Id = "t1", Name = "emailAddress", Type = "string", Label = "Email Address", TextboxType = "email", Required = true, Widget = "textbox" },
             ["password"] = new TextboxProperty { Id = "t2", Name = "password", Type = "string", Label = "Password", TextboxType = "password", Required = true, MinLength = 6, Widget = "textbox" },
             ["rememberMe"] = new CheckboxProperty { Id = "c1", Name = "rememberMe", Type = "boolean", Label = "Remember Me", Widget = "checkbox" },
             ["submit"] = new SubmitButtonProperty { Id = "s1", Name = "submit", Type = "button", Label = "Submit", ButtonType = "submit", Widget = "button", Style = "primary", Disabled = false }
         },
         Layout = new List<LayoutNode>
         {
             new LayoutNode{Type="field",PropertyId="emailAddress"},
             new LayoutNode{Type="field",PropertyId="password"},
             new LayoutNode{Type="field",PropertyId="rememberMe"},
             new LayoutNode{Type="field",PropertyId="submit"}
         },
         Settings = new SchemaSettings { Name = "Login Form" }
     };
}
public abstract class BaseProperty
{
     [JsonProperty("id")] public string Id { get; set; }
     [JsonProperty("name")] public string Name { get; set; }
     [JsonProperty("type")] public string Type { get; set; }
     [JsonProperty("label")] public string Label { get; set; }
     [JsonProperty("widget")] public string Widget { get; set; }
     [JsonProperty("size")] public string Size { get; set; }
}


public class TextboxProperty : BaseProperty
{
     [JsonProperty("textboxType")] public string TextboxType { get; set; }
     [JsonProperty("required")] public bool Required { get; set; }
     [JsonProperty("minLength")] public int? MinLength { get; set; }
}
public class CheckboxProperty : BaseProperty { }
public class SubmitButtonProperty : BaseProperty
{
     [JsonProperty("buttonType")] public string ButtonType { get; set; }
     [JsonProperty("style")] public string Style { get; set; }
     [JsonProperty("disabled")] public bool Disabled { get; set; }
}
public class Schema
{
     [JsonProperty("version")] public string Version { get; set; }
     [JsonProperty("properties")] public Dictionary<string, BaseProperty> Properties { get; set; }
     [JsonProperty("layout")] public List<LayoutNode> Layout { get; set; }
     [JsonProperty("settings")] public SchemaSettings Settings { get; set; }
}
public class SchemaSettings { [JsonProperty("name")] public string Name { get; set; } }
public class LayoutNode { [JsonProperty("type")] public string Type { get; set; } [JsonProperty("propertyId")] public string PropertyId { get; set; } }

```

## Resetting the form

A reset button restores the form to its initial state. To enable form reset, declare a button field in `properties` with `buttonType: "reset"` and include it in the `layout` array.

```csharp
new ButtonProperty
{
    Id         = "reset_button_initial",
    Name       = "defaultFormreset",
    Type       = "button",
    Label      = "Reset",
    ButtonType = "reset",
    Widget     = "button",
    Size       = "Bigger"
}
```

The `reset` button does not raise an event. Clicking it triggers the browser's native form-reset behavior, which restores every field to its initial value.

The following example renders a Form Renderer with email, password, and remember-me fields, along with a reset button. When the user clicks **Reset**, every field is restored to its initial state:

```cshtml
@using Syncfusion.EJ2
@using Syncfusion.EJ2.FormRenderer
@using EJ2MVCSampleBrowser.Models

@section ControlsSection {

    <div class="control-section">
        <div class="col-lg-8">
            @Html.EJS().FormRenderer("form-renderer-reset")
                .Schema((ViewData["formSchema"]))
                .Render()
        </div>
    </div>
}
```

## Adding custom click actions

A plain click button is a field in `properties` with `buttonType: "button"`. Use it for any custom logic that should run when the button is clicked.

```csharp
new ButtonProperty
{
    Id         = "cancel_button_initial",
    Name       = "defaultFormcancel",
    Type       = "button",
    Label      = "Cancel",
    ButtonType = "button",
    Widget     = "button",
    Size       = "Bigger"
}
```

When the user clicks a `buttonType: "button"` button, the renderer raises the `buttonClick` event.

| Member | Type | Description |
| --- | --- | --- |
| `fieldName` | `string` | The unique name / identifier of the clicked button. |
| `label` | `string` | The display text / label of the clicked button. |
| `event` | `any` | The original button click event. |

The following example renders a Form Renderer with email, password, and remember-me fields, along with a custom click button. When the user clicks **Cancel**, the `buttonClick` event is raised with the button's name, label, and the original click event:

```cshtml
@using Syncfusion.EJ2
@using Syncfusion.EJ2.FormRenderer
@using EJ2MVCSampleBrowser.Models

@section ControlsSection {

    <div class="control-section">
        <div class="col-lg-8">
            @Html.EJS().FormRenderer("form-renderer-button-click")
                .Schema((ViewData["formSchema"]))
                .ButtonClick("onButtonClick")
                .Render()
        </div>
    </div>

    <script>
        function onButtonClick(args) {
            // args.fieldName -> string
            // args.label     -> string
            // args.event     -> original button click event
            console.log(args);
        }
    </script>
}
```

## Detecting the field change

When the value of any field changes, the renderer raises the `change` event. Typing into the `email` or `password` field, picking a date, toggling a switch, picking a value from a dropdown, and program-driven changes from expression evaluation all raise it.

| Member | Type | Description |
| --- | --- | --- |
| `fieldName` | `string` | The unique name / identifier of the changed field. |
| `label` | `string` | The display text / label of the form field. |
| `value` | `FieldDataType` | The new value of the field. The type matches the field's `type`: `string` for text-like widgets, `number` for numeric widgets, `boolean` for checkbox / switch, and `any[]` for `multiselect` / `checkboxGroup`. |

`change` is **not** fired for layout-only nodes (`panel`, `table`, `tabs`, `card`) or for presentation-only widgets like `staticHtml` and `message`. Buttons do not raise `change` — clicking them raises `submit`, `buttonClick`, or nothing (for reset).

When the value of a field changes, the renderer:

1. Updates the value of that field in the form state.
2. Re-evaluates every `expressionValue` that references that field.
3. Re-runs any `customValidation` rules that depend on the field.
4. Emits the `change` event with `{ fieldName, label, value }`.

The following example renders a Form Renderer with textbox and checkbox fields. Whenever the value of any field changes, the `change` event is raised with the changed field's name, label, and new value:

```cshtml
@using Syncfusion.EJ2
@using Syncfusion.EJ2.FormRenderer
@using EJ2MVCSampleBrowser.Models

@section ControlsSection {

    <div class="control-section">
        <div class="col-lg-8">
            @Html.EJS().FormRenderer("form-renderer-change")
                .Schema((ViewData["formSchema"]))
                .Change("onChange")
                .Render()
        </div>
    </div>

    <script>
        function onChange(args) {
            // args.fieldName -> string
            // args.label     -> string
            // args.value     -> FieldDataType
            console.log(args);
        }
    </script>
}
```

## Customizing the form once the control is rendered

The `created` event fires **once**, after the form has finished rendering and every input is in the DOM. Use it for any setup that needs the renderer to be ready — for example, calling `getComponent` to obtain an input instance, attaching a third-party mask, or wiring up toolbar buttons that operate on the form.

The following example renders a Form Renderer with email, password, and remember-me fields. Once the form has finished rendering, the `created` event is raised with an empty payload:

```cshtml
@using Syncfusion.EJ2
@using Syncfusion.EJ2.FormRenderer
@using EJ2MVCSampleBrowser.Models

@section ControlsSection {

    <div class="control-section">
        <div class="col-lg-8">
            @Html.EJS().FormRenderer("form-renderer-created")
                .Schema((ViewData["formSchema"]))
                .Created("onCreated")
                .Render()
        </div>
    </div>

    <script>
        function onCreated() {
            // Fires once after the form has finished rendering.
            // Useful for getComponent(), masks, toolbar wiring, etc.
            var formRenderer = document.getElementById('form-renderer-created')
                .ej2_instances[0];
            console.log('Form is created', formRenderer);
        }
    </script>
}
```

## Wiring up multiple events

The MVC tag helper exposes every renderer event as a fluent method. You can chain as many as you need on a single `FormRenderer` call:

```cshtml
@Html.EJS().FormRenderer("form-renderer-all-events")
    .Schema((ViewData["formSchema"]))
    .Created("onCreated")
    .Change("onChange")
    .Submit("onSubmit")
    .ButtonClick("onButtonClick")
    .Render()
```
