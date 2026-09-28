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

{% if page.publishingplatform == "aspnet-mvc" %}

Templates can be added to the Form Builder by configuring the `ToolboxItemSetting` instance and passing it to the `ToolboxItems` property. Each `ToolboxItemSetting` is mapped to a form field by setting its `Type` property and supplies the template for the third-party component through its `Template` property.

Add any number of `ToolboxItemSetting` instances to the `ToolboxItems` collection to render multiple templates in the Form Builder toolbox.

{% elsif page.publishingplatform == "aspnet-core" %}

Templates can be added to the Form Builder by configuring the `e-form-builder-toolbox-item`. Each `e-form-builder-toolbox-item` is mapped to a form field by setting its `type` property and supplies the template for the third-party component through its `template` property.

Add any number of `e-form-builder-toolbox-item` elements to the `e-form-builder-toolbox-items` to render multiple templates in the Form Builder toolbox.

{% endif %}

After you drag and drop the form field onto the central design canvas, the third-party component is rendered automatically.

{% if page.publishingplatform == "aspnet-mvc" %}

{% tabs %}

{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/form-builder/template/razor %}
{% endhighlight %}

{% highlight c# tabtitle="FormBuilderController.cs" %}
{% include code-snippet/form-builder/template/controller.cs %}
{% endhighlight %}

{% endtabs %}

{% elsif page.publishingplatform == "aspnet-core" %}

{% tabs %}

{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/form-builder/template/tagHelper %}
{% endhighlight %}

{% highlight c# tabtitle="template.cs" %}
{% include code-snippet/form-builder/template/controller.cs %}
{% endhighlight %}

{% endtabs %}

{% endif %}

In the Preview tab, the templates are displayed so that you can validate the created form.

## Adding properties of the template in property panel

The properties of the third party components can be added to the property panel using the `setProperty` method in the Form Builder. For more details, see this [documentation](./property-panel#adding-a-new-property-in-the-property-panel)


## Exporting templates

{% if page.publishingplatform == "aspnet-mvc" %}

When the form schema is exported, the template itself is not included in the schema. However, a `templateId` property is added to the form schema to notify Form Renderer that a template is mapped to the corresponding element. This value is set through the `TemplateId` property of `ToolboxItems`.

In Form Renderer, additional configuration is required as described in the [documentation](https://ej2.syncfusion.com/aspnetmvc/documentation/form-renderer/template) to render templates in the form.

{% elsif page.publishingplatform == "aspnet-core" %}

When the form schema is exported, the template itself is not included in the schema. However, a `templateId` property is added to the form schema to notify Form Renderer that a template is mapped to the corresponding element. This value is set through the `templateId` property of `toolboxItems`.

In Form Renderer, additional configuration is required as described in the [documentation](https://ej2.syncfusion.com/aspnetcore/documentation/form-renderer/template) to render templates in the form.

{% endif %}