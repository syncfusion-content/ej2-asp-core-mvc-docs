---
layout: post
title: Template Editing in ##Platform_Name## Grid Component
description: Learn here all about Template Editing in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core
control: Template Editing
publishingplatform: aspnet-core
documentation: ug
---


# Template Editing

## Inline or dialog template editing

The dialog template editing provides an option to customize the default behavior of dialog editing. Using the dialog template, you can render your own editors by defining the [`mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_Mode) property of [`e-grid-editSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_EditSettings) tag helper as **Dialog/Inline** and [`template`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_Template) property as SCRIPT element ID or HTML string which holds the template.

In some cases, you need to add the new field editors in the dialog which are not present in the column model. In that situation, the template will help you to customize the default edit dialog.

In the below code example, demonstrate the usage of binding a partial view in the dialog template.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/dialogtemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Addpatial.cs" %}
{% include code-snippet/grid/edit/dialogtemplate/addpatial.cs %}
{% endhighlight %}
{% highlight c# tabtitle="AddpatialMVC.cs" %}
{% include code-snippet/grid/edit/dialogtemplate/addpatialMVC.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Dialog.cs" %}
{% include code-snippet/grid/edit/dialogtemplate/dialog.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Dialogtemplatemodel.cs" %}
{% include code-snippet/grid/edit/dialogtemplate/dialogtemplatemodel.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Editpartial.cs" %}
{% include code-snippet/grid/edit/dialogtemplate/editpartial.cs %}
{% endhighlight %}
{% highlight c# tabtitle="EditpartialMVC.cs" %}
{% include code-snippet/grid/edit/dialogtemplate/editpartialMVC.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/dialogtemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Addpatial.cs" %}
{% include code-snippet/grid/edit/dialogtemplate/addpatial.cs %}
{% endhighlight %}
{% highlight c# tabtitle="AddpatialMVC.cs" %}
{% include code-snippet/grid/edit/dialogtemplate/addpatialMVC.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Dialog.cs" %}
{% include code-snippet/grid/edit/dialogtemplate/dialog.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Dialogtemplatemodel.cs" %}
{% include code-snippet/grid/edit/dialogtemplate/dialogtemplatemodel.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Editpartial.cs" %}
{% include code-snippet/grid/edit/dialogtemplate/editpartial.cs %}
{% endhighlight %}
{% highlight c# tabtitle="EditpartialMVC.cs" %}
{% include code-snippet/grid/edit/dialogtemplate/editpartialMVC.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> The Dialog/Inline template form editors should have **name** attribute.

## Get value from editor

You can read, format and update the current editor value in the [`actionBegin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionBegin) event at the time of **requestType** as **save**.

In the below code example, we have format and updated the **Freight** value.

``` typescript
    function actionBegin(args) {
        if (args.requestType === 'save') {
            // cast string to integer value.
            args.data['Freight'] = parseFloat(args.form.querySelector("#Freight").value);
        }
    }

```

## Set focus to editor

By default, the first input element in the dialog will be focused while opening the dialog.
If the first input element is in disabled or hidden state, focus the valid input element in the
[`actionComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionComplete)
event based on **requestType** as **beginEdit**.

```typescript

    function actionComplete(args) {
        // Set initail Focus
        if (args.requestType === 'beginEdit') {
            (args.form.elements.namedItem('CustomerID')).focus();
        }
    }

```

## Adding validation rules for custom editors

If you have used additional fields that are not present in the column model, then add the validation rules to the [`actionComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionComplete) event.

```typescript

    function actionComplete(args) => {
        if ((args.requestType === 'beginEdit' || args.requestType === 'add')) {
            // Add Validation Rules
            args.form.ej2_instances[0].addRules('Freight', {max: 500});
        }
    }

```

## Render tab component inside the dialog template

You can use **tab** component inside dialog edit UI using dialog template feature. The dialog template feature can be enabled by defining [`mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_Mode) as **Dialog** and [`template`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_Template) as SCRIPT element ID or HTML string which holds the template.

The following example demonstrate the usage of tab control inside the dialog template.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/tabediting/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Dialog.cs" %}
{% include code-snippet/grid/edit/tabediting/dialog.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Dialog.cs" %}
{% include code-snippet/grid/edit/tabediting/dialog.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/tabediting/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Dialog.cs" %}
{% include code-snippet/grid/edit/tabediting/dialog.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Dialog.cs" %}
{% include code-snippet/grid/edit/tabediting/dialog.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

