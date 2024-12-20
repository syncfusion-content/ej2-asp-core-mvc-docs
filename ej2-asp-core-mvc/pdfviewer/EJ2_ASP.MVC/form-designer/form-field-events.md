---
layout: post
title:  Form Field Events in EJ2 ASP.NET MVC PDF Viewer | Syncfusion
description: Learn here all about different form field event in ASP.NET MVC PDF Viewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Form Field Events
publishingplatform: ##Platform_Name##
documentation: ug
---

# PDF Viewer Form Field events

The PDF Viewer control provides the support to different Form Field events. The Form Field events supported by the PDF Viewer Control are:

| Form Field events | Description |
|---|---|
| formFieldAdd | Event trigger when a form field is added.|
| formFieldClick | Events trigger when the form field is selected.|
| formFieldDoubleClick | Events trigger when the form field is double-clicked.|
| formFieldFocusOut | Events trigger when focus out from the form fields.|
| formFieldMouseLeave | Events trigger when the mouse cursor leaves the form field.|
| formFieldMouseOver | Events trigger when the mouse cursor is over a form field.|
| formFieldMove | Events trigger when a form field is moved.|
| formFieldPropertiesChange | Events trigger when a property of form field is changed.|
| formFieldRemove | Events trigger when a form field is removed.|
| formFieldResize | Events trigger when a form field is resized.|
| formFieldSelect | Events trigger when a form field is selected.|
| formFieldUnselect | Events trigger when a form field is unselected.|
| validateFormFields | Events trigger when validation is failed.|

## formFieldAdd event

The [formFieldAdd](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.pdfviewer.pdfviewer.html#Syncfusion_EJ2_PdfViewer_PdfViewer_FormFieldAdd) event is triggered when a new form field is added, either programmatically or through user interaction. The event arguments provide the necessary information about the form field addition.

{% tabs %}
{% highlight html tabtitle="Standalone" %}
```html
    <div style="width:100%;height:600px">
         @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/form-designer.pdf").FormFieldAdd("formFieldAdded").Render()
    </div>
    <script>
       function formFieldAdded(args) {
            console.log('form field page number: ' + args.pageIndex);
            console.log('form field event name: ' + args.name);
            console.log('form field data: ', args.field);
       }
    </script>
```
{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}
```html

    <div style="width:100%;height:600px">
         @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/api/PdfViewer/")).DocumentPath("https://cdn.syncfusion.com/content/pdf/form-designer.pdf").FormFieldAdd("formFieldAdded").Render()
    </div>
    <script>
       function formFieldAdded(args) {
            console.log('form field page number: ' + args.pageIndex);
            console.log('form field event name: ' + args.name);
            console.log('form field data: ', args.field);
       }>
```
{% endhighlight %}
{% endtabs %}

## formFieldClick event

The [formFieldClick](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.pdfviewer.pdfviewer.html#Syncfusion_EJ2_PdfViewer_PdfViewer_FormFieldClick) event is triggered when a form field is clicked. The event arguments provide the necessary information about the form field click event.

{% tabs %}
{% highlight html tabtitle="Standalone" %}
```html
    <div style="width:100%;height:600px">
        @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/form-designer.pdf").FormFieldClick("formFieldClicked").Render()
    </div>
    <script>
       function formFieldClicked(args) {
            console.log('Is form field cancel: ' + args.cancel);
            console.log('form field event name: ' + args.name);
            console.log('form field data: ', args.field);
       }
    </script>
```
{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}
```html

    <div style="width:100%;height:600px">
         @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/api/PdfViewer/")).DocumentPath("https://cdn.syncfusion.com/content/pdf/form-designer.pdf").FormFieldClick("formFieldClicked").Render()
    </div>
    <script>
       function formFieldClicked(args) {
            console.log('Is form field cancel: ' + args.cancel);
            console.log('form field event name: ' + args.name);
            console.log('form field data: ', args.field);
       }>
```
{% endhighlight %}
{% endtabs %}

## formFieldDoubleClick event

The [formFieldDoubleClick](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.pdfviewer.pdfviewer.html#Syncfusion_EJ2_PdfViewer_PdfViewer_FormFieldDoubleClick/) event is triggered when a form field is double-clicked. The event arguments provide the necessary information about the form field double-click event.

{% tabs %}
{% highlight html tabtitle="Standalone" %}
```html
    <div style="width:100%;height:600px">
        @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/form-designer.pdf").FormFieldDoubleClick("formFieldDoubleClicked").Render()
    </div>
    <script>
       function formFieldDoubleClicked(args) {
            console.log('Is form field cancel: ' + args.cancel);
            console.log('form field event name: ' + args.name);
            console.log('form field data: ', args.field);
       }
    </script>
```
{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}
```html

    <div style="width:100%;height:600px">
         @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/api/PdfViewer/")).DocumentPath("https://cdn.syncfusion.com/content/pdf/form-designer.pdf").FormFieldDoubleClick("formFieldDoubleClicked").Render()
    </div>
    <script>
       function formFieldDoubleClicked(args) {
            console.log('Is form field cancel: ' + args.cancel);
            console.log('form field event name: ' + args.name);
            console.log('form field data: ', args.field);
       }>
```
{% endhighlight %}
{% endtabs %}

## formFieldFocusOut event

The [formFieldFocusOut](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.pdfviewer.pdfviewer.html#Syncfusion_EJ2_PdfViewer_PdfViewer_FormFieldFocusOut/) event is triggered when a form field loses focus. The event arguments provide the necessary information about the form field focus out event.

{% tabs %}
{% highlight html tabtitle="Standalone" %}
```html
    <div style="width:100%;height:600px">
        @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/form-designer.pdf").FormFieldFocusOut("FormFieldFocusOuted").Render()
    </div>
    <script>
       function FormFieldFocusOuted(args) {
            console.log('Is form field cancel: ' + args.cancel);
            console.log('form field event name: ' + args.name);
            console.log('form field data: ', args.field);
       }
    </script>
```
{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}
```html

    <div style="width:100%;height:600px">
         @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/api/PdfViewer/")).DocumentPath("https://cdn.syncfusion.com/content/pdf/form-designer.pdf").FormFieldFocusOut("FormFieldFocusOuted").Render()
    </div>
    <script>
       function FormFieldFocusOuted(args) {
            console.log('Is form field cancel: ' + args.cancel);
            console.log('form field event name: ' + args.name);
            console.log('form field data: ', args.field);
       }>
```
{% endhighlight %}
{% endtabs %}

## formFieldMouseLeave event

The [formFieldMouseLeave](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.pdfviewer.pdfviewer.html#Syncfusion_EJ2_PdfViewer_PdfViewer_FormFieldMouseLeave/) event is triggered when the mouse leaves a form field. The event arguments provide the necessary information about the form field mouse leave event.

{% tabs %}
{% highlight html tabtitle="Standalone" %}
```html
    <div style="width:100%;height:600px">
        @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/form-designer.pdf").FormFieldMouseLeave("FormFieldMouseLeaved").Render()
    </div>
    <script>
        function FormFieldMouseLeaved(args) {
            console.log('Is form field cancel: ' + args.cancel);
            console.log('form field event name: ' + args.name);
            console.log('form field data: ', args.field);
       }
    </script>
```
{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}
```html

    <div style="width:100%;height:600px">
         @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/api/PdfViewer/")).DocumentPath("https://cdn.syncfusion.com/content/pdf/form-designer.pdf").FormFieldMouseLeave("FormFieldMouseLeaved").Render()
    </div>
    <script>
       function FormFieldMouseLeaved(args) {
            console.log('Is form field cancel: ' + args.cancel);
            console.log('form field event name: ' + args.name);
            console.log('form field data: ', args.field);
       }>
```
{% endhighlight %}
{% endtabs %}

## formFieldMouseOver event

The [formFieldMouseOver](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.pdfviewer.pdfviewer.html#Syncfusion_EJ2_PdfViewer_PdfViewer_FormFieldMouseover/) event is triggered when the mouse hovers over a form field. The event arguments provide the necessary information about the form field mouse over event.

{% tabs %}
{% highlight html tabtitle="Standalone" %}
```html
    <div style="width:100%;height:600px">
        @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/form-designer.pdf").FormFieldMouseover("FormFieldMouseovered").Render()
    </div>
    <script>
       function FormFieldMouseovered(args) {
            console.log('form field page number: ', args.pageIndex);
            console.log('form field event name: ' + args.name);
            console.log('form field data: ', args.field);
            console.log(' mouse over x position '+ args.X + ' mouse over y position '+ args.Y );
            console.log(' mouse over X position respect to the page '+ args.pageX + ' mouse over Y position respect to the page '+ args.pageY);
        }
    </script>
```
{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}
```html

    <div style="width:100%;height:600px">
         @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/api/PdfViewer/")).DocumentPath("https://cdn.syncfusion.com/content/pdf/form-designer.pdf").FormFieldMouseover("FormFieldMouseovered").Render()
    </div>
    <script>
       function FormFieldMouseovered(args) {
            console.log('form field page number: ', args.pageIndex);
            console.log('form field event name: ' + args.name);
            console.log('form field data: ', args.field);
            console.log(' mouse over x position '+ args.X + ' mouse over y position '+ args.Y );
            console.log(' mouse over X position respect to the page '+ args.pageX + ' mouse over Y position respect to the page '+ args.pageY);
        }
    </script>
```
{% endhighlight %}
{% endtabs %}

## formFieldMove event

The [formFieldMove](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.pdfviewer.pdfviewer.html#Syncfusion_EJ2_PdfViewer_PdfViewer_FormFieldMove/) event is triggered when the mouse moves inside a form field. The event arguments provide the necessary information about the form field mouse move event.

{% tabs %}
{% highlight html tabtitle="Standalone" %}
```html
    <div style="width:100%;height:600px">
        @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/form-designer.pdf").FormFieldMove("FormFieldMoved").Render()
    </div>
    <script>
       function FormFieldMoved(args) {
            console.log('form field page number: ', args.pageIndex);
            console.log('form field event name: ' + args.name);
            console.log('form field data: ', args.field);
            console.log('mouse current position '+ args.currentPosition);
            console.log('mouse current position '+ args.previousPosition);
        }
    </script>
```
{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}
```html

    <div style="width:100%;height:600px">
         @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/api/PdfViewer/")).DocumentPath("https://cdn.syncfusion.com/content/pdf/form-designer.pdf").FormFieldMove("FormFieldMoved").Render()
    </div>
    <script>
       function FormFieldMoved(args) {
            console.log('form field page number: ', args.pageIndex);
            console.log('form field event name: ' + args.name);
            console.log('form field data: ', args.field);
            console.log('mouse current position '+ args.currentPosition);
            console.log('mouse current position '+ args.previousPosition);
        }
    </script>
```
{% endhighlight %}
{% endtabs %}

## formFieldPropertiesChange event

The [formFieldPropertiesChange](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.pdfviewer.pdfviewer.html#Syncfusion_EJ2_PdfViewer_PdfViewer_FormFieldPropertiesChange/)  event is triggered when the properties of a form field are changed. The event arguments provide the necessary information about which property of the form field has been changed.

{% tabs %}
{% highlight html tabtitle="Standalone" %}
```html
    <div style="width:100%;height:600px">
        @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/form-designer.pdf").FormFieldPropertiesChange("FormFieldPropertiesChanged").Render()
    </div>
    <script>
       function FormFieldPropertiesChanged(args) {
            console.log('form field page number: ', args.pageIndex);
            console.log('form field event name: ' + args.name);
            console.log('form field data: ', args.field);
            console.log('Whether form field alignment changed '+ args.isAlignmentChanged);
            console.log('Whether form field backgropund color changed '+ args.isBackgroundColorChanged);
            console.log('Whether form field border color changed '+ args.isBorderColorChanged);
            console.log('Whether form field border width changed '+ args.isBorderWidthChanged);
            console.log('Whether form field color changed changed '+ args.isColorChanged);
            console.log('Whether form field custom data changed '+ args.isCustomDataChanged);
            console.log('Whether form field font family changed '+ args.isFontFamilyChanged);
            console.log('Whether form field font size changed '+ args.isFontSizeChanged);
            console.log('Whether form field font style changed '+ args.isFontStyleChanged);
            console.log('Whether form field maximum length changed '+ args.isMaxLengthChanged);
            console.log('Whether form field name changed '+ args.isNameChanged);
            console.log('Whether form field readonly changed '+ args.isReadOnlyChanged);
            console.log('Whether form field required changed '+ args.isRequiredChanged);
            console.log('Whether form field print changed '+ args.isPrintChanged);
            console.log('Whether form field tool tip changed '+ args.isToolTipChanged);
            console.log('Whether form field visiblity changed '+ args.isVisibilityChanged);
            console.log('Whether form field value changed '+ args.isValueChanged);
            console.log('Whether form field new value changed '+ args.newValue);
            console.log('Whether form field old valuue changed '+ args.oldValue);
        }
    </script>
```
{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}
```html

    <div style="width:100%;height:600px">
         @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/api/PdfViewer/")).DocumentPath("https://cdn.syncfusion.com/content/pdf/form-designer.pdf").FormFieldPropertiesChange("FormFieldPropertiesChanged").Render()
    </div>
    <script>
       function FormFieldPropertiesChanged(args) {
            console.log('form field page number: ', args.pageIndex);
            console.log('form field event name: ' + args.name);
            console.log('form field data: ', args.field);
            console.log('Whether form field alignment changed '+ args.isAlignmentChanged);
            console.log('Whether form field backgropund color changed '+ args.isBackgroundColorChanged);
            console.log('Whether form field border color changed '+ args.isBorderColorChanged);
            console.log('Whether form field border width changed '+ args.isBorderWidthChanged);
            console.log('Whether form field color changed changed '+ args.isColorChanged);
            console.log('Whether form field custom data changed '+ args.isCustomDataChanged);
            console.log('Whether form field font family changed '+ args.isFontFamilyChanged);
            console.log('Whether form field font size changed '+ args.isFontSizeChanged);
            console.log('Whether form field font style changed '+ args.isFontStyleChanged);
            console.log('Whether form field maximum length changed '+ args.isMaxLengthChanged);
            console.log('Whether form field name changed '+ args.isNameChanged);
            console.log('Whether form field readonly changed '+ args.isReadOnlyChanged);
            console.log('Whether form field required changed '+ args.isRequiredChanged);
            console.log('Whether form field print changed '+ args.isPrintChanged);
            console.log('Whether form field tool tip changed '+ args.isToolTipChanged);
            console.log('Whether form field visiblity changed '+ args.isVisibilityChanged);
            console.log('Whether form field value changed '+ args.isValueChanged);
            console.log('Whether form field new value changed '+ args.newValue);
            console.log('Whether form field old valuue changed '+ args.oldValue);
        }
    </script>
```
{% endhighlight %}
{% endtabs %}

## formFieldRemove event

The [formFieldRemove](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.pdfviewer.pdfviewer.html#Syncfusion_EJ2_PdfViewer_PdfViewer_FormFieldRemove) event is triggered when a form field is removed from the PDF. The event arguments provide the necessary information about which form field has been removed.

{% tabs %}
{% highlight html tabtitle="Standalone" %}
```html
    <div style="width:100%;height:600px">
        @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/form-designer.pdf").FormFieldRemove("FormFieldRemoved").Render()
    </div>
    <script>
       function FormFieldRemoved(args) {
            console.log('form field page number: ', args.pageIndex);
            console.log('form field event name: ' + args.name);
            console.log('form field data: ', args.field);
        }
    </script>
```
{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}
```html

    <div style="width:100%;height:600px">
         @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/api/PdfViewer/")).DocumentPath("https://cdn.syncfusion.com/content/pdf/form-designer.pdf").FormFieldRemove("FormFieldRemoved").Render()
    </div>
    <script>
       function FormFieldRemoved(args) {
            console.log('form field page number: ', args.pageIndex);
            console.log('form field event name: ' + args.name);
            console.log('form field data: ', args.field);
        }
    </script>
```
{% endhighlight %}
{% endtabs %}

## formFieldResize event

The [formFieldResize](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.pdfviewer.pdfviewer.html#Syncfusion_EJ2_PdfViewer_PdfViewer_FormFieldResize) events are triggered when a form field in a PDF is resized. These events provide the relevant details about the specific form field that has been resized.

{% tabs %}
{% highlight html tabtitle="Standalone" %}
```html
    <div style="width:100%;height:600px">
        @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/form-designer.pdf").FormFieldResize("FormFieldResized").Render()
    </div>
    <script>
       function FormFieldResized(args) {
            console.log('form field page number: ', args.pageIndex);
            console.log('form field event name: ' + args.name);
            console.log('form field data: ', args.field);
            console.log('form field current position: ', args.currentPosition);
            console.log('form field previous position: ', args.previousPosition);
        }
    </script>
```
{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}
```html

    <div style="width:100%;height:600px">
         @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/api/PdfViewer/")).DocumentPath("https://cdn.syncfusion.com/content/pdf/form-designer.pdf").FormFieldResize("FormFieldResized").Render()
    </div>
    <script>
       function FormFieldResized(args) {
            console.log('form field page number: ', args.pageIndex);
            console.log('form field event name: ' + args.name);
            console.log('form field data: ', args.field);
            console.log('form field current position: ', args.currentPosition);
            console.log('form field previous position: ', args.previousPosition);
        }
    </script>
```
{% endhighlight %}
{% endtabs %}

## formFieldSelect event

The [formFieldSelect](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.pdfviewer.pdfviewer.html#Syncfusion_EJ2_PdfViewer_PdfViewer_FormFieldSelect/) events are triggered when a form field in a PDF is selected. These events provide the necessary details about the specific form field that has been selected.

{% tabs %}
{% highlight html tabtitle="Standalone" %}
```html
    <div style="width:100%;height:600px">
        @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/form-designer.pdf").FormFieldSelect("FormFieldSelected").Render()
    </div>
    <script>
       function FormFieldSelected(args) {
            console.log('form field page number: ', args.pageIndex);
            console.log('form field event name: ' + args.name);
            console.log('form field data: ', args.field);
        }
    </script>
```
{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}
```html

    <div style="width:100%;height:600px">
         @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/api/PdfViewer/")).DocumentPath("https://cdn.syncfusion.com/content/pdf/form-designer.pdf").FormFieldSelect("FormFieldSelected").Render()
    </div>
    <script>
       function FormFieldSelected(args) {
            console.log('form field page number: ', args.pageIndex);
            console.log('form field event name: ' + args.name);
            console.log('form field data: ', args.field);
        }
    </script>
```
{% endhighlight %}
{% endtabs %}

## formFieldUnselect event

The [formFieldUnselect](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.pdfviewer.pdfviewer.html#Syncfusion_EJ2_PdfViewer_PdfViewer_FormFieldUnselect/) events are triggered when a form field in a PDF is unselected. These events provide the necessary details about the specific form field that has been unselected.

{% tabs %}
{% highlight html tabtitle="Standalone" %}
```html
    <div style="width:100%;height:600px">
        @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/form-designer.pdf").FormFieldUnselect("FormFieldUnselected").Render()
    </div>
    <script>
       function FormFieldUnselected(args) {
            console.log('form field page number: ', args.pageIndex);
            console.log('form field event name: ' + args.name);
            console.log('form field data: ', args.field);
        }
    </script>
```
{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}
```html

    <div style="width:100%;height:600px">
         @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/api/PdfViewer/")).DocumentPath("https://cdn.syncfusion.com/content/pdf/form-designer.pdf").FormFieldUnselect("FormFieldUnselected").Render()
    </div>
    <script>
       function FormFieldUnselected(args) {
            console.log('form field page number: ', args.pageIndex);
            console.log('form field event name: ' + args.name);
            console.log('form field data: ', args.field);
        }
    </script>
```
{% endhighlight %}
{% endtabs %}

## validateFormFields event

The [ValidateFormFields](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.pdfviewer.pdfviewer.html#Syncfusion_EJ2_PdfViewer_PdfViewer_ValidateFormFields/) events are triggered when a required form field is left unfilled before downloading the PDF. These events provide the necessary information for validating which form fields are incomplete.

{% tabs %}
{% highlight html tabtitle="Standalone" %}
```html
    <div style="width:100%;height:600px">
        @Html.EJS().PdfViewer("pdfviewer").DocumentPath("https://cdn.syncfusion.com/content/pdf/form-designer.pdf").ValidateFormFields("ValidateFormField").Render()
    </div>
    <script>
       function ValidateFormField(args) {
            console.log('form field event name: ' + args.name);
            console.log('form field document name: ' + args.documentName);
            console.log('form field data: ', args.formField);
            console.log('non fillable form field details: ', args.nonFillableFields);
        }
    </script>
```
{% endhighlight %}
{% highlight html tabtitle="Server-Backed" %}
```html

    <div style="width:100%;height:600px">
         @Html.EJS().PdfViewer("pdfviewer").ServiceUrl(VirtualPathUtility.ToAbsolute("~/api/PdfViewer/")).DocumentPath("https://cdn.syncfusion.com/content/pdf/form-designer.pdf").ValidateFormFields("ValidateFormField").Render()
    </div>
    <script>
       function ValidateFormField(args) {
            console.log('form field event name: ' + args.name);
            console.log('form field document name: ' + args.documentName);
            console.log('form field data: ', args.formField);
            console.log('non fillable form field details: ', args.nonFillableFields);
        }
    </script>
```
{% endhighlight %}
{% endtabs %}