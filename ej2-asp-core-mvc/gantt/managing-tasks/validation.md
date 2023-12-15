---
layout: post
title: Validation in Syncfusion ##Platform_Name## Gantt Component
description: Learn here all about Validation Rule in Syncfusion ##Platform_Name## Gantt component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Validating Tasks
publishingplatform: ##Platform_Name##
documentation: ug
---

# Validation in ##Platform_Name## Gantt Component

## Column validation

Column validation validates the editing and adding data and it display errors for invalid fields before saving data. This is effective in both inline and dialog editing.
Gantt uses [`Form Validator`](https://ej2.syncfusion.com/documentation/form-validator/validation-rules) component for column validation. You can set validation rules by defining the [`validationRules`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_ValidationRules) in [`Columns`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_Columns). The value cannot be saved unless the validation rule get satisfied.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/validating/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="validating.cs" %}
{% include code-snippet/gantt/editing/validating/validating.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/validating/razor %}
{% endhighlight %}
{% highlight c# tabtitle="validating.cs" %}
{% include code-snippet/gantt/editing/validating/validating.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Custom validation

You can define your own custom validation rules for the specific columns by using [`Form Validator custom rules`](https://ej2.syncfusion.com/documentation/form-validator/validation-rules#defining-custom-rules).

In the below demo, custom validation applied for **TaskName** column.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/customValidation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="customValidation.cs" %}
{% include code-snippet/gantt/editing/customValidation/customValidation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/customValidation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="customValidation.cs" %}
{% include code-snippet/gantt/editing/customValidation/customValidation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Validation for Dependency and Resource Tab

Validation rules can also be implemented for the dependency and resource grid in the add or edit dialog by employing the event [`ActionBegin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_ActionBegin).
Within the actionBegin event, validationRules can be configured for columns in the grid of the dependency and resource tabs using the requestType **beforeOpenEditDialog** or **beforeOpenAddDialog**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/validating/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="validating.cs" %}
{% include code-snippet/gantt/editing/validating/validating.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/validating/razor %}
{% endhighlight %}
{% highlight c# tabtitle="validating.cs" %}
{% include code-snippet/gantt/editing/validating/validating.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}