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