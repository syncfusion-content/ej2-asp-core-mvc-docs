---
layout: post
title: Templates in ##Platform_Name## Form Renderer Component | Syncfusion
description: Learn how to display templates in the ##Platform_Name## Form Renderer to display the third party components in the forms.
platform: ej2-asp-core-mvc
control: Templates
publishingplatform: ##Platform_Name##
documentation: ug
---

# Templates in ##Platform_Name## Form Renderer component

Templates can be displayed in the Form Renderer control to render third-party components within a form.

This section explains how to use templates in the Form Renderer component.

## Adding Templates

{% if page.publishingplatform == "aspnet-mvc" %}

Templates can be added to a form in Form Renderer by setting the `Template` property in `CustomWidgetSettings`. Map the template to a specific form field type by using the `Type` property in `CustomWidgetSettings`.

`CustomWidgetSettings` is an array property, so you can render any number of templates in the form.

The `setFieldValue` method is used to set the value of a form field programmatically. When templates are assigned, this method can be used to pass the value set in the third-party component to the Form Renderer control.

{% elsif page.publishingplatform == "aspnet-core" %}

Templates can be added to a form in Form Renderer by adding `<e-form-renderer-custom-widget-setting>` child tags inside the `<e-form-renderer-custom-widget-settings>` tag of the `<ejs-form-renderer>` tag helper. Map the template to a specific form field type by using the `type` attribute on the `<e-form-renderer-custom-widget-setting>` tag.

You can add any number of `<e-form-renderer-custom-widget-setting>` child tags to render multiple templates in the form.

The `setFieldValue` method is used to set the value of a form field programmatically. When templates are assigned, this method can be used to pass the value set in the third-party component to the Form Renderer control.

{% endif %}

{% if page.publishingplatform == "aspnet-mvc" %}

{% tabs %}

{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/form-renderer/template-cs1/razor %}
{% endhighlight %}

{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/form-renderer/template-cs1/controller.cs %}
{% endhighlight %}

{% endtabs %}

{% elsif page.publishingplatform == "aspnet-core" %}

{% tabs %}

{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/form-renderer/template-cs1/tagHelper %}
{% endhighlight %}

{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/form-renderer/template-cs1/controller.cs %}
{% endhighlight %}

{% endtabs %}

{% endif %}

## Adding a template to a single or specific field

{% if page.publishingplatform == "aspnet-mvc" %}

You can also map a template to a single form field by using the `FieldName` and `TemplateId` properties.

* `FieldName` - This property uses the **name** value of the form field in the schema. If the field name in the schema matches this property during form rendering, the corresponding template is rendered.

* `TemplateId` - If the form field in the schema has a **templateId** property, assign the same value to this property. This maps the template to the corresponding form field.

> In this case, the `Type` property is not required.

{% elsif page.publishingplatform == "aspnet-core" %}

You can also map a template to a single form field by using the `fieldName` and `templateId` properties.

* `fieldName` - This property uses the **name** value of the form field in the schema. If the field name in the schema matches this property during form rendering, the corresponding template is rendered.

* `templateId` - If the form field in the schema has a **templateId** property, assign the same value to this property. This maps the template to the corresponding form field.

> In this case, the `type` property is not required.

{% endif %}

{% if page.publishingplatform == "aspnet-mvc" %}

{% tabs %}

{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/form-renderer/template-cs2/razor %}
{% endhighlight %}

{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/form-renderer/template-cs2/controller.cs %}
{% endhighlight %}

{% endtabs %}

{% elsif page.publishingplatform == "aspnet-core" %}

{% tabs %}

{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/form-renderer/template-cs2/tagHelper %}
{% endhighlight %}

{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/form-renderer/template-cs2/controller.cs %}
{% endhighlight %}

{% endtabs %}

{% endif %}
