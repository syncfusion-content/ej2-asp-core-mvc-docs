---
layout: post
title: Template Editing in ##Platform_Name## Tree Grid Component
description: Learn here all about Template Editing in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Template Editing
publishingplatform: ##Platform_Name##
documentation: ug
---


# Template Editing

## Cell Edit Template

The cell edit template is used to add a custom component for a particular column by invoking the following functions:

* **create** - It is used to create the element at the time of initialization.

* **write** - It is used to create the custom component or assign default value at the time of editing.

* **read** - It is used to read the value from the component at the time of save.

* **destroy** - It is used to destroy the component.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/edit-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="EditTemplate.cs" %}
{% include code-snippet/tree-grid/editing/edit-template/editTemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/edit-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="EditTemplate.cs" %}
{% include code-snippet/tree-grid/editing/edit-template/editTemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Dialog template

The dialog template editing provides an option to customize the default behavior of dialog editing. Using the dialog template, you can render your own editors by defining the [`mode`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridEditSettings~Mode.html) as **Dialog** and [`template`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridEditSettings~Template.html) as SCRIPT element ID or HTML string which holds the template.

In some cases, you need to add the new field editors in the dialog which are not present in the column model. In that situation, the dialog template will help you to customize the default edit dialog.

In the following sample, treegrid enabled with dialog template editing.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/dialog-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DialogTemplate.cs" %}
{% include code-snippet/tree-grid/editing/dialog-template/dialogTemplate.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Editpartial.cs" %}
{% include code-snippet/tree-grid/editing/dialog-template/editpartial.cs %}
{% endhighlight %}
{% highlight c# tabtitle="EditpartialMVC.cs" %}
{% include code-snippet/tree-grid/editing/dialog-template/editpartialMVC.cs %}
{% endhighlight %}
{% highlight c# tabtitle="TemplateModel.cs" %}
{% include code-snippet/tree-grid/editing/dialog-template/templateModel.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/dialog-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DialogTemplate.cs" %}
{% include code-snippet/tree-grid/editing/dialog-template/dialogTemplate.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Editpartial.cs" %}
{% include code-snippet/tree-grid/editing/dialog-template/editpartial.cs %}
{% endhighlight %}
{% highlight c# tabtitle="EditpartialMVC.cs" %}
{% include code-snippet/tree-grid/editing/dialog-template/editpartialMVC.cs %}
{% endhighlight %}
{% highlight c# tabtitle="TemplateModel.cs" %}
{% include code-snippet/tree-grid/editing/dialog-template/templateModel.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> The template form editors should have **name** attribute.

### Get value from editor

You can read, format, and update the current editor value in the [`actionBegin`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~ActionBegin.html) event at the time of setting **requestType** to **save**.

In the following code example, the **progress** value has been formatted and updated.

``` typescript
    function actionBegin(args) {
        if (args.requestType === 'save') {
            // cast string to integer value.
            args.data['progress'] = parseFloat(args.form.querySelector("#progress").value);
        }
    }

```

### Set focus to editor

By default, the first input element in the dialog will be focused while opening the dialog.
If the first input element is in disabled or hidden state, focus the valid input element in the [`actionComplete`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~ActionComplete.html) event based on **requestType** as **beginEdit**.

```typescript

    function actionComplete(args) {
        // Set initail Focus
        if (args.requestType === 'beginEdit') {
            (args.form.elements.namedItem('taskName')as HTMLInputElement).focus();
        }
    }

```

### Adding validation rules for custom editors

If you have used additional fields that are not present in the column model, then add the validation rules to the [`actionComplete`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~ActionComplete.html) event.

```typescript

    function actionComplete(args: DialogEditEventArgs) {
        if ((args.requestType === 'beginEdit' || args.requestType === 'add')) {
            // Add Validation Rules
            args.form.ej2_instances[0].addRules('progress', {max: 100});
        }
    }

```



> You can refer to our  [`ASP.NET Core Tree Grid`](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our ASP.NET Core Tree Grid example [`ASP.NET Core Tree Grid example`](https://ej2.syncfusion.com/aspnetcore/TreeGrid/Overview#/material) to knows how to present and manipulate data.