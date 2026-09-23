---
layout: post
title: Templates in ##Platform_Name## Form Builder control | Syncfusion
description: Learn how to include Templates in the ##Platform_Name## Form Builder control to display third party components.
platform: ej2-asp-core-mvc
control: Templates
publishingplatform: ##Platform_Name##
documentation: ug
---

# Templates in ##Platform_Name## Form Builder component

Templates can be used in the Form Builder control to display third-party components within the form. This feature lets you configure the form schema with the properties of the third-party component.

This section explains how to use templates in the Form Builder component.

## Adding Templates

Templates can be added to the Form Builder by configuring the `ToolboxItemSetting` instance and passing it to the `ToolboxItems` method. Each `ToolboxItemSetting` is mapped to a form field by setting its Type property (using the `FormWidgetType` enum) and supplies the markup for the third-party control through its `Template` property.

Pass any number of `ToolboxItemSetting` instances to the `ToolboxItems` collection to render that many templates in the Form Builder toolbox.

After you drag and drop the form field onto the central design canvas, the third-party component is rendered automatically.

{% if page.publishingplatform == "aspnet-mvc" %}
{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
@using Syncfusion.EJ2
@using Syncfusion.EJ2.FormBuilder

@{
    List<ToolboxItemSetting> toolboxItems = new List<ToolboxItemSetting>
    {
        new ToolboxItemSetting()
        {
            Type = FormWidgetType.Textbox,
            Template = "#customWidgetTemplate"
        }
    };
}
<div class="control-section">
    <div class="col-lg-12">
        <div>
            @Html.EJS().FormBuilder("form-builder-control").Schema(ViewData["formSchema"]).ToolboxItems(toolboxItems).Render()
        </div>
    </div>
</div>

<script id="customWidgetTemplate" type="text/x-template">
    <input class="e-input"
            id="${fieldData.id}"
            name="${fieldData.name}"
            type="text"
            placeholder="${fieldData.placeholder}"
            data-field-id="${fieldData.id}" />
</script>

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
                ["emailAddress"] = new TextboxProperty { Id = "t1", Name = "emailAddress", Type = "string", Label = "Email Address", TextboxType = "email", Required = true, Widget = "textbox", Placeholder="Enter email address" },
                ["password"] = new TextboxProperty { Id = "t2", Name = "password", Type = "string", Label = "Password", TextboxType = "password", Required = true, MinLength = 6, Widget = "textbox", Placeholder="Enter password" },
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
    [JsonProperty("placeholder")] public string Placeholder { get; set; }
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
public class ToolboxCategories
{
    [JsonProperty("category")] public string Category { get; set; }
    [JsonProperty("items")] public string[] Items { get; set; }
}
public class SchemaSettings { [JsonProperty("name")] public string Name { get; set; } }
public class LayoutNode { [JsonProperty("type")] public string Type { get; set; } [JsonProperty("propertyId")] public string PropertyId { get; set; } }

{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@model IndexModel

<ejs-form-builder schema="Model.FormSchema" id="form-builder-control">
    <e-form-builder-toolbox-items>
        <e-form-builder-toolbox-item type="Textbox" template="#inputTemplate">
        </e-form-builder-toolbox-item>
    </e-form-builder-toolbox-items>
</ejs-form-builder>

<!-- Textbox -->
<script id="inputTemplate" type="text/javascript">
    <input class="e-input"
        id="form-renderer-control-${fieldData.id}"
        name="${fieldData.name}"
        type="text"
        placeholder="${fieldData.placeholder}"
        data-field-id="${fieldData.id}" />
</script>

{% endhighlight %}
{% highlight c# tabtitle="template.cs" %}

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
                ["emailAddress"] = new TextboxProperty { Id = "t1", Name = "emailAddress", Type = "string", Label = "Email Address", TextboxType = "email", Required = true, Widget = "textbox", Placeholder="Enter password"  },
                ["password"] = new TextboxProperty { Id = "t2", Name = "password", Type = "string", Label = "Password", TextboxType = "password", Required = true, MinLength = 6, Widget = "textbox", Placeholder="Enter password"  },
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
    [JsonProperty("placeholder")] public string Placeholder { get; set; }
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
public class ToolboxCategories
{
    [JsonProperty("category")] public string Category { get; set; }
    [JsonProperty("items")] public string[] Items { get; set; }
}
public class SchemaSettings { [JsonProperty("name")] public string Name { get; set; } }
public class LayoutNode { [JsonProperty("type")] public string Type { get; set; } [JsonProperty("propertyId")] public string PropertyId { get; set; } }

{% endhighlight %}
{% endtabs %}
{% endif %}

In the Preview tab, the templates are displayed so that you can validate the created form.

## Adding properties of the template in property panel

The properties of the third party components can be added to the property panel using the `setProperty` method in the Form Builder. For more details, see this [documentation](./property-panel#adding-a-new-property-in-the-property-panel)


## Exporting templates

When the form schema is exported, the template itself is not included in the schema. However, a `templateId` property is added to the form schema to notify Form Renderer that a template is mapped to the corresponding element. This value is set through the `templateId` property of `toolboxItems`.

{% if page.publishingplatform == "aspnet-mvc" %}

In Form Renderer, additional configuration is required as described in the [documentation](https://ej2.syncfusion.com/aspnetmvc/documentation/form-renderer/template) to render templates in the form.

{% elsif page.publishingplatform == "aspnet-core" %}

In Form Renderer, additional configuration is required as described in the [documentation](https://ej2.syncfusion.com/aspnetcore/documentation/form-renderer/template) to render templates in the form.

{% endif %}