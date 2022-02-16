---
layout: post
title: Calculated Field in ##Platform_Name## Pivot Table Component
description: Learn here all about Calculated Field in Syncfusion ##Platform_Name## Pivot Table component and more.
platform: ej2-asp-core-mvc
control: Calculated Field
publishingplatform: ##Platform_Name##
documentation: ug
---


# Calculated Field

Allows end user to create a new calculated field in the pivot table, based on available fields from the bound data source or using simple formula with basic arithmetic operators. It can be added at runtime through the built-in dialog, invoked from Field List UI. To do so, set the [`AllowCalculatedField`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_AllowCalculatedField) property in [`PivotView`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html) class to **true** in the pivot table. End user can now see a "CALCULATED FIELD" button enabled in Field List UI automatically, which on clicking will invoke the calculated field dialog and perform necessary operation.

Calculated field can also be included in the pivot table through code behind using the [`PivotViewCalculatedFieldsSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewCalculatedFieldSetting.html) class. The required properties to create a new calculate field are:
* [`Name`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewCalculatedFieldSetting.html#Syncfusion_EJ2_PivotView_PivotViewCalculatedFieldSetting_Name): It allows to indicate the calculated field with a unique name.
* [`Formula`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewCalculatedFieldSetting.html#Syncfusion_EJ2_PivotView_PivotViewCalculatedFieldSetting_Formula): It allows to set the formula.
* [`Format`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewFormatSetting_Format):  It helps to set the number format for the resultant value.

> The calculated field is applicable only for value fields. Also, calculated field created through code behind will be automatically listed in the UI dialog as well.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/calculatedfield/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Calculatedfield.cs" %}
{% include code-snippet/pivot-table/calculatedfield/calculatedfield.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/calculatedfield/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Calculatedfield.cs" %}
{% include code-snippet/pivot-table/calculatedfield/calculatedfield.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/calculatedfield.png)

Meanwhile, user can also view calculated field dialog in UI by invoking `CreateCalculatedFieldDialog` method on an external button click which is shown in the below code sample.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-core/calculatedfield/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Calculatedfield.cs" %}
{% include code-snippet/pivot-table/getting-start-core/calculatedfield/calculatedfield.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/getting-start-core/calculatedfield/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Calculatedfield.cs" %}
{% include code-snippet/pivot-table/getting-start-core/calculatedfield/calculatedfield.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/calc-field-btn.png)

![output](images/calc-field-btn2.png)

## Editing through the field list and the grouping bar

User can also modify the existing calculated field using the built-in edit option available directly in the field list (or) grouping bar. To do so, click the "Edit" icon available in the calculated field button. Now the calculated field dialog is opened and the current calculated field name, formula and format can be changed at runtime.

![output](images/edit-button.png "Editing the calculated field")
<br/>
<br/>
![output](images/after-edit-button.png "Editing the calculated field formula")

## Renaming the existing calculated field

Existing calculated field can be renamed only through the UI at runtime. To do so, open the calculated field dialog, select the target field and click "Edit" icon. User can now see the existing name getting displayed in the text box at the top of the dialog. Now, change the name based on user requirement and click "OK".

<!-- markdownlint-disable MD012 -->
![output](images/before-edit.png "Editing the calculated field")
<br/>
<br/>
![output](images/after-edit.png "Renaming the calculated field")

## Editing the existing calculated field formula

Existing calculated field formula can be edited only through the UI at runtime. To do so, open the calculated field dialog, select the target field and click "Edit" icon. User can now see the existing formula getting displayed in a multiline text box at the bottom of the dialog. Now, change the formula based on user requirement and click "OK".

![output](images/before-edit.png "Editing the calculated field")
<br/>
<br/>
![output](images/after-change.png "Editing the calculated field formula")

## Reusing the existing formula in a new calculate field

While creating a new calculated field, if user wants to the add the formula of an existing calculated field, it can be done easily. To do so, simply drag-and-drop the existing calculated field to the "Formula" section.

![output](images/before-drag.png "Dragging the existing calculated field")
<br/>
<br/>
![output](images/while-drag.png "Drag field to formula")
<br/>
<br/>
![output](images/after-drag.png "Reusing the existing calculated field formula")

## Apply the format to the calculated field values

The values in the new or existing calculated field can be formatted through its UI and also through code behind. To format the calculated field values at runtime, the built-in textbox is available under the "Format" label where the user can set the desired format. Likewise, in code-behind, you can set the desired format using the [`FormatSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewFormatSettings.html) property as illustrated in the introduction section. For more information about the supported formats [`refer here`](https://ej2.syncfusion.com/aspnetmvc/documentation/pivot-table/number-formatting/).

![output](images/calculatedfield-format.png "Applying format through calculated field dialog UI")

## Supported operators and functions for the calculated field formula

Below is a list of operators and functions that can be used in the formula to create the calculated fields.

* `+` – addition operator.

```typescript
 Syntax: X + Y
```

* `-` – subtraction operator.

```typescript
Syntax: X - Y
```

* `*` – multiplication operator.

```typescript
Syntax: X * Y
```

* `/` – division operator.

```typescript
Syntax: X / Y
```

* `^` – power operator.

```typescript
Syntax: X^2
```

* `<` - less than operator.

```typescript
Syntax: X < Y
```

* `<=` – less than or equal operator.

```typescript
Syntax: X <= Y
```

* `>` – greater than operator.

```typescript
Syntax: X > Y
```

* `>=` – greater than or equal operator.

```typescript
Syntax: X >= Y
```

* `==` – equal operator.

```typescript
Syntax: X == Y
```

* `!=` – not equal operator.

```typescript
Syntax: X != Y
```

* `|` – OR operator.

```typescript
Syntax: X | Y
```

* `&` – AND operator.

```typescript
Syntax: X & Y
```

* `?` – conditional operator.

```typescript
Syntax: condition ? then : else
```

* `isNaN` – function that checks if the value is not a number.

```typescript
Syntax: isNaN(value)
```

* `!isNaN` – function that checks if the value is a number.

```typescript
Syntax: isNaN(value)
```

* `abs` – function that returns the absolute value of a number.

```typescript
Syntax: abs(number)
```

* `min` – function that returns the minimum value.

```typescript
Syntax: min(number1, number2)
```

* `max` – function that returns the maximum value.

```typescript
Syntax: max(number1, number2)
```

 > Also, you can use JavaScript [Math](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Math) object properties and methods directly to the formula.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/calculatedfield-condition/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Calculatedfield.cs" %}
{% include code-snippet/pivot-table/calculatedfield-condition/calculatedfield.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/calculatedfield-condition/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Calculatedfield.cs" %}
{% include code-snippet/pivot-table/calculatedfield-condition/calculatedfield.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/calculatedfield-conditional.png)

## Event

### CalculatedFieldCreate

The event [`CalculatedFieldCreate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_CalculatedFieldCreate) fires while closing the dialog on "OK" button click. It allows to customize the new or existing calculated field information obtained from the dialog. It has the following parameters

* `calculatedField`: It holds the new or existing calculated field information obtained from dialog.

* [`calculatedFieldSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewCalculatedFieldSetting.html): It holds the [`calculatedFieldSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewCalculatedFieldSetting.html) property of the pivot report.

* `cancel`: It is a boolean property and by setting this to true , the customization done in calculated field dialog won’t be applied to calculated field.

In the below sample, creating a calculated field without setting the format is restricted.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/calculatedfieldCreate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CalculatedfieldCreate.cs" %}
{% include code-snippet/pivot-table/calculatedfieldCreate/calculatedfieldCreate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/calculatedfieldCreate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CalculatedfieldCreate.cs" %}
{% include code-snippet/pivot-table/calculatedfieldCreate/calculatedfieldCreate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### ActionBegin

The event [`actionBegin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ActionBegin) triggers when clicking calculated field button, calculated field edit icon and context menu in the tree view inside the calculated field dialog. This allows user to identify the current action being performed at runtime. It has the following parameters:

* `dataSourceSettings`: It holds the current data source settings such as input data source, rows, columns, values, filters, format settings and so on.

* `actionName`: It holds the name of the current action began. The following are the UI actions and their names:

| Action | Action Name|
|------|-------------|
| [`Calculated field button`](./calculated-field/#Calculated-Field)| Open calculated field dialog|
| [`Edit icon in calculated field`](./calculated-field/#Editing-through-the-field-list-and-the-grouping-bar)| Edit calculated field|
| [`Context menu in the tree view inside the calculated field dialog`](./calculated-field/#Calculated-Field)| Calculated field context menu|

* `fieldInfo`: It holds the selected field information.

> This option is applicable only when the field based UI actions are performed such as filtering, sorting, removing field from grouping bar, editing and aggregation type change.

* `cancel`: It allows user to restrict the current action.

In the below sample, the calculated field button click action, that is, opening of the calculated field dialog can be restricted by setting the **args.cancel** option to **true** in the `actionBegin` event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/action-event/actionBegin-calculatedField/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ActionBegin-calculatedField.cs" %}
{% include code-snippet/pivot-table/action-event/actionBegin-calculatedField/actionBegin-calculatedField.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/action-event/actionBegin-calculatedField/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ActionBegin-calculatedField.cs" %}
{% include code-snippet/pivot-table/action-event/actionBegin-calculatedField/actionBegin-calculatedField.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### ActionComplete

The event [`actionComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ActionComplete) triggers when the calculated field is completely created or edited. This allows user to identify the current UI action being completed at runtime. It has the following parameters:  

* `dataSourceSettings`: It holds the current data source settings such as input data source, rows, columns, values, filters, format settings and so on.

* `actionName`: It holds the name of the current action completed. The following are the UI actions and their names:

| Action | Action Name|
|------|-------------|
| [`Calculated field button`](./calculated-field/#Calculated-Field)| Calculated field applied|
| [`Edit icon in calculated field`](./calculated-field/#Editing-through-the-field-list-and-the-grouping-bar)| Calculated field edited|

* `fieldInfo`: It holds the selected field information.

> This option is applicable only when the field based UI actions are performed such as filtering, sorting, removing field from grouping bar, editing and aggregation type change.

* `actionInfo`:  It holds the unique information about the current UI action. For example, if the edit action is completed, this event will be triggered, and the argument will display information such as the entire calculated field information and its formula, including the field name.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/action-event/actionComplete-calculatedField/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ActionComplete-calculatedField.cs" %}
{% include code-snippet/pivot-table/action-event/actionComplete-calculatedField/actionComplete-calculatedField.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/action-event/actionComplete-calculatedField/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ActionComplete-calculatedField.cs" %}
{% include code-snippet/pivot-table/action-event/actionComplete-calculatedField/actionComplete-calculatedField.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### ActionFailure

The event [`actionFailure`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ActionFailure) triggers when the current UI action fails to achieve the desired result. It has the following parameters:

* `actionName`: It holds the name of the current action failed. The following are the UI actions and their names:

| Action | Action Name |
|------|-------------|
| [`Calculated field button`](./calculated-field/#Calculated-Field)| Open calculated field dialog|
| [`Edit icon in calculated field`](./calculated-field/#Editing-through-the-field-list-and-the-grouping-bar)| Edit calculated field|
| [`Context menu in the tree view inside the calculated field dialog`](./calculated-field/#Calculated-Field)| Calculated field context menu|

* `errorInfo`: It holds the error information of the current UI action.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/action-event/actionFailure-calculatedField/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ActionFailure-calculatedField.cs" %}
{% include code-snippet/pivot-table/action-event/actionFailure-calculatedField/actionFailure-calculatedField.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/action-event/actionFailure-calculatedField/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ActionFailure-calculatedField.cs" %}
{% include code-snippet/pivot-table/action-event/actionFailure-calculatedField/actionFailure-calculatedField.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

