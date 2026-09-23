---
layout: post
title: Exporting and Importing in ##Platform_Name## Form Builder control | Syncfusion
description: Learn how to export and import in the ##Platform_Name## Form Builder control. Use export to reuse the generated form schema in Form Renderer, and import to continue editing an existing schema in Form Builder.platform: ej2-asp-core-mvc
platform: ej2-asp-core-mvc
control: Exporting and Importing
publishingplatform: ##Platform_Name##
documentation: ug
---

# Exporting and Importing in ##Platform_Name## Form Builder component

The Form Builder supports exporting the generated form schema for reuse in the Form Renderer control and importing an existing schema back into the builder for further editing.

## Export form schema

You can export the generated form schema by clicking the **Export** button in the toolbar at the top of the Form Builder control. The exported schema includes the form structure, field configuration, and other properties required to recreate the form.

You can use the exported schema in the Form Renderer control to render the same form at runtime.

## Disabling the export

Exporting can be disabled in the Form Builder component by setting the `allowExport` property to `false`. The default value of the property is `true`.

{% if page.publishingplatform == "aspnet-mvc" %}
```cshtml
@using Syncfusion.EJ2
@using Syncfusion.EJ2.FormBuilder

<div>
    @Html.EJS().FormBuilder("form-builder-control").AllowExport(false).Render()
</div>

```
{% elsif page.publishingplatform == "aspnet-core" %}
```cshtml
<ejs-form-builder id="form-builder-control"
                  allowExport="false">
</ejs-form-builder>
```
{% endif %}


The output will appear as follows:

![Disabling the export](./images/form-builder-export.png)

## Import form schema

To import a form, assign the exported schema to the `schema` property of the Form Builder. This loads the form definition into the builder so that you can continue editing it.

The following example shows how to use the same schema for both export and import scenarios.

{% if page.publishingplatform == "aspnet-mvc" %}
{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.FormBuilder
@using EJ2MVCSampleBrowser.Models

<div class="control-section">
    @Html.EJS().FormBuilder("form-builder-control").Schema(ViewData["formSchema"]).Render()
</div>

{% endhighlight %}
{% highlight c# tabtitle="FormBuilderController.cs" %}

public partial class FormBuilderController : Controller
{
    public ActionResult Default()
    {
        ViewData["formSchema"] = GetLoginForm();
        return View();
    }

    public Schema GetLoginForm()
    {
        return new Schema
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
                new LayoutNode { Type="field", PropertyId="emailAddress" },
                new LayoutNode { Type="field", PropertyId="password" },
                new LayoutNode { Type="field", PropertyId="rememberMe" },
                new LayoutNode { Type="field", PropertyId="submit" }
            },
            Settings = new SchemaSettings { Name = "Login Form" }
        };
    }
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

{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
@page
@model IndexModel
@using Syncfusion.EJ2.FormBuilder

<ejs-form-builder id="form-builder-control"
                  schema="Model.FormSchema">
</ejs-form-builder>
{% endhighlight %}
{% highlight c# tabtitle="ExportImport.cs" %}
public class IndexModel : PageModel
{
    public Schema FormSchema { get; set; }

    public void OnGet()
    {
        FormSchema = new Schema
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
                new LayoutNode { Type="field", PropertyId="emailAddress" },
                new LayoutNode { Type="field", PropertyId="password" },
                new LayoutNode { Type="field", PropertyId="rememberMe" },
                new LayoutNode { Type="field", PropertyId="submit" }
            },
            Settings = new SchemaSettings { Name = "Login Form" }
        };
    }
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

{% endhighlight %}
{% endtabs %}
{% endif %}

![Import from schema](./images/form-builder-import-schema.png)