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

{% if page.publishingplatform == "aspnet-mvc" %}

Exporting can be disabled in the Form Builder component by setting the `AllowExport` property to `false`. The default value of the property is `true`.

{% tabs %}

{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/form-builder/disable-export/razor %}
{% endhighlight %}

{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/form-builder/disable-export/controller.cs %}
{% endhighlight %}

{% endtabs %}

{% elsif page.publishingplatform == "aspnet-core" %}

Exporting can be disabled in the Form Builder component by setting the `allowExport` property to `false`. The default value of the property is `true`.

{% tabs %}

{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/form-builder/disable-export/tagHelper %}
{% endhighlight %}

{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/form-builder/disable-export/controller.cs %}
{% endhighlight %}

{% endtabs %}

{% endif %}


The output will appear as follows:

![Disabling the export](./images/form-builder-export.png)

## Import form schema

{% if page.publishingplatform == "aspnet-mvc" %}

To import a form, assign the exported schema to the `Schema` property of the Form Builder. This loads the form definition into the builder so that you can continue editing it.

{% elsif page.publishingplatform == "aspnet-core" %}

To import a form, assign the exported schema to the `schema` property of the Form Builder. This loads the form definition into the builder so that you can continue editing it.

{% endif %}

The following example shows how to use the same schema for both export and import scenarios.

{% if page.publishingplatform == "aspnet-mvc" %}

{% tabs %}

{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/form-builder/import/razor %}
{% endhighlight %}

{% highlight c# tabtitle="FormBuilderController.cs" %}
{% include code-snippet/form-builder/import/controller.cs %}
{% endhighlight %}

{% endtabs %}

{% elsif page.publishingplatform == "aspnet-core" %}

{% tabs %}

{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/form-builder/import/tagHelper %}
{% endhighlight %}

{% highlight c# tabtitle="ExportImport.cs" %}
{% include code-snippet/form-builder/import/controller.cs %}
{% endhighlight %}

{% endtabs %}

{% endif %}

![Import from schema](./images/form-builder-import-schema.png)