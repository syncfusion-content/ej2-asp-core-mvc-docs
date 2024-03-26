---
layout: post
title: Form Fields in ##Platform_Name## Document Editor Control | Syncfusion
description: Learn here all about Form Fields in Syncfusion ##Platform_Name## Document Editor control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Form Fields
publishingplatform: ##Platform_Name##
documentation: ug
---


# Form Fields in Document Editor Control

DocumentEditorContainer control provides support for inserting Text, CheckBox, DropDown form fields through in-built toolbar.

![Form Fields](images/toolbar-form-fields.png)

## Insert form field

Form fields can be inserted using `insertFormField` method in editor module.

```typescript
//Insert Text form field
documentEditor.editor.insertFormField('Text');
//Insert Checkbox form field
documentEditor.editor.insertFormField('CheckBox');
//Insert Drop down form field
documentEditor.editor.insertFormField('Dropdown');
```

## Get form field names

All the form fields names from current document can be retrieved using `getFormFieldNames()`.

```typescript
var formFieldsNames = documentEditor.getFormFieldNames();
```

## Get form field properties

Form field properties can be retrieved using `getFormFieldInfo()`.

```typescript
//Text form field
var textfieldInfo = documentEditor.getFormFieldInfo('Text1');
//Checkbox form field
var checkboxfieldInfo = documentEditor.getFormFieldInfo('Check1');
//Dropdown form field
var dropdownfieldInfo = documentEditor.getFormFieldInfo('Drop1');
```

## Set form field properties

Form field properties can be modified using `setFormFieldInfo`.

```typescript
// Set text form field properties
var textfieldInfo = documentEditor.getFormFieldInfo('Text1');
textfieldInfo.defaultValue = "Hello";
textfieldInfo.format = "Uppercase";
textfieldInfo.type = "Text";
documentEditor.setFormFieldInfo('Text1',textfieldInfo);

// Set checkbox form field properties
var checkboxfieldInfo = documentEditor.getFormFieldInfo('Check1');
checkboxfieldInfo.defaultValue = true;
documentEditor.setFormFieldInfo('Check1',checkboxfieldInfo);

// Set checkbox form field properties
var dropdownfieldInfo = documentEditor.getFormFieldInfo('Drop1');
dropdownfieldInfo.dropDownItems = ['One','Two', 'Three']
documentEditor.setFormFieldInfo('Drop1',dropdownfieldInfo);
```

## Export form field data

Data of the all Form fields in the document can be exported using `exportFormData`.

```typescript
var formFieldDate = documentEditor.exportFormData();
```

## Import form field data

Form fields can be prefilled with data using `importFormData`.

```typescript
var textformField = {fieldName: 'Text1', value: 'Hello World'};
var checkformField = {fieldName: 'Check1', value: true};
var dropdownformField = {fieldName: 'Drop1', value: 1};
//Import form field data
documentEditor.importFormData([textformField,checkformField,dropdownformField]);
```

## Reset form fields

Reset all the form fields in current document to default value using `resetFormFields`.

```typescript
documentEditor.resetFormFields();
```

## Protect the document in form filling mode

Document Editor provides support for protecting the document with `FormFieldsOnly` protection. In this protection, user can only fill form fields in the document.

Document editor provides an option to protect and unprotect document using `enforceProtection` and `stopProtection` API.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/protect-unprotect/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Protect-unprotect.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/protect-unprotect/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Protect-unprotect.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}

N> In enforce Protection method, first parameter denotes password and second parameter denotes protection type. Possible values of protection type are `NoProtection |ReadOnly |FormFieldsOnly |CommentsOnly`. In stop protection method, parameter denotes the password.

## Form Field Settings

Document editor provides options to customize the form field settings using [`formFieldSettings`](../../api/document-editor/documentEditorSettingsModel/#formFieldSettings) in Document editor settings.This functionality allows users to customize various aspects of form fields. These include customizing shading colors, applying these custom colors to form fields, adjusting the color used for selecting form fields, defining the form filling mode, and specifying formatting exceptions for form fields"

### Shading color

By default, the shading color [`shadingColor`](../../api/document-editor/documentEditorSettingsModel/formFieldSettings/#shadingcolor) for form fields is '#cfcfcf'. To change it, simply specify a different hexadecimal color value in the shading color property of formFieldSettings.

The following example code illustrates how to customize the shading color property of formFieldSettings in Document editor container.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/form-field-settings/shading-color/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="form-field-settings.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/form-field-settings/shading-color/razor %}
{% endhighlight %}
{% highlight c# tabtitle="form-field-settings.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}

>Note: You can customize shading color in application level, but cannot be exported in file level

### Apply shading

By default, the apply shading [`applyshading`](../../api/document-editor/documentEditorSettingsModel/formFieldSettings/#applyshading) for form fields is true. To toggle the default shading for form fields, simply switch between true and false.

The following example code illustrates how to customize the apply shading property of form field settings in Document editor container.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/form-field-settings/apply-shading/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="form-field-settings.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/form-field-settings/apply-shading/razor %}
{% endhighlight %}
{% highlight c# tabtitle="form-field-settings.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}


### Selection color

By default, the selection color [`selectioncolor`](../../api/document-editor/documentEditorSettingsModel/formFieldSettings/#selectioncolor) for form fields is '#cccccc'. To change it, simply specify a different hexadecimal color value in the shadingColor property of form field settings.

The following example code illustrates how to customize the selection color property of form field settings in Document editor container.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/form-field-settings/selection-color/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="form-field-settings.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/form-field-settings/selection-color/razor %}
{% endhighlight %}
{% highlight c# tabtitle="form-field-settings.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}

### Form filling mode 

The default form filling mode [`formfillingmode`](../../api/document-editor/documentEditorSettingsModel/formFieldSettings/#formfillingmode) for form fields is 'Popup'. To change this default behavior, switch between 'Inline' and 'Popup' as needed.

The following example code illustrates how to customize the form filling mode property of form field settings in Document editor container.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/form-field-settings/form-filling-mode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="form-field-settings.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/form-field-settings/form-filling-mode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="form-field-settings.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}

### Formatting exceptions

The default formatting exceptions [`formattingexceptions`](../../api/document-editor/documentEditorSettingsModel/formFieldSettings/#formattingexceptions) for form fields are an empty array, indicating no exceptions. To modify this default behavior, specify the desired formatting exceptions in the array assigned to the formattingExceptions property, utilizing the provided list of acceptable values.

The customizable options for formatting exceptions in form fields include: 'Bold', 'Italic', 'FontSize', 'FontFamily', 'HighlightColor', 'BaselineAlignment', 'Strikethrough', 'Underline', 'FontColor', 'TextAlignment', 'LeftIndent', 'RightIndent', 'LineSpacing', 'LineSpacingType', 'FirstLineIndent', 'AfterSpacing', 'BeforeSpacing', 'ContextualSpacing', and 'ListFormat'.

The following example code illustrates how to customize the formatting exceptions property of form field settings in Document editor container.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/form-field-settings/formatting-exceptions/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="form-field-settings.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/form-field-settings/formatting-exceptions/razor %}
{% endhighlight %}
{% highlight c# tabtitle="form-field-settings.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}

>Note: You can customize formatting exceptions in application level, but cannot be exported in file level