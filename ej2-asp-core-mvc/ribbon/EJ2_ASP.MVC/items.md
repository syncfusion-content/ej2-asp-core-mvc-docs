---
layout: post
title: Items in ##Platform_Name## Ribbon Control | Syncfusion
description: Learn here all about Items in Syncfusion ##Platform_Name## Ribbon control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Ribbon
publishingplatform: ##Platform_Name##
documentation: ug
---

# Ribbon Items in ASP.NET MVC Ribbon Control

## Built-in Ribbon items

You can define each ribbon item using the [Items](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonCollection.html#Syncfusion_EJ2_Ribbon_RibbonCollection_Items) property, the type should be specified in the [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_Type) property to define built-in items.

The following items can be rendered as built in items

| Built-in Ribbon Items | Actions |
|------------------------|---------|
| Button | Renders button as ribbon item.|
| CheckBox | Renders checkbox as ribbon item.|
| DropDown | Renders dropdownbutton as ribbon item.|
| SplitButton | Renders splitbutton as ribbon item.|
| ComboBox | Renders combobox as ribbon item.|
| ColorPicker | Renders color picker as ribbon item.|

### Button

You can render a Button item by setting the [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_Type) property to `Button`. You can further customize the button item through [RibbonButtonSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonButtonSettings.html) which provides options such as `IconCss`, `Content`, `IsToggle` and more.

#### Toggle Button

You can make use of [IsToggle](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonButtonSettings.html#Syncfusion_EJ2_Ribbon_RibbonButtonSettings_IsToggle) property to define whether the button is a toggle button or not. By default the value is `false`.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Clipboard").Collections(collection =>
        {
            collection.Items(item =>
            {
                item.Type(RibbonItemType.Button).ButtonSettings(button =>
                {
                    button.IconCss("e-icons e-cut").Content("cut").IsToggle(true);
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

{% endhighlight %}
{% endtabs %}

### CheckBox

You can render a CheckBox item by setting the [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_Type) property to `CheckBox`. You can further customize the CheckBox item through [RibbonCheckBoxSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonCheckBoxSettings.html) which provides options such as `LabelPosition`, `Label`, `Checked` and more.

#### CheckBox State

You can make use of [Checked](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonCheckBoxSettings.html#Syncfusion_EJ2_Ribbon_RibbonCheckBoxSettings_Checked) property to define whether the checkbox is checked or not. A tick mark will be added to the visualization of CheckBox in checked state. By default the value is `false`.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("View").Collections(collection =>
        {
            collection.Items(item =>
            {
                item.Type(RibbonItemType.CheckBox).CheckBoxSettings(checkBox =>
                {
                    checkBox.Checked(true).Label("Ruler");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

{% endhighlight %}
{% endtabs %}

#### Label and label Position

You can define the caption for a CheckBox, by utilizing the [Label](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonCheckBoxSettings.html#Syncfusion_EJ2_Ribbon_RibbonCheckBoxSettings_Label) property. This helps in reducing the need for manually adding a separate label element. 
You can customize the position of the label relative to the CheckBox by using the [LabelPosition](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonCheckBoxSettings.html#Syncfusion_EJ2_Ribbon_RibbonCheckBoxSettings_LabelPosition) property, which allows you to specify whether the label should appear before or after the CheckBox.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("View").Collections(collection =>
        {
            collection.Items(item =>
            {
                item.Type(RibbonItemType.CheckBox).CheckBoxSettings(checkBox =>
                {
                    checkBox.Checked(true).Label("Ruler").LabelPosition("Before");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

{% endhighlight %}
{% endtabs %}

### DropDown

You can render a DropDown item by setting the [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_Type) property to `DropDown`. You can further customize the DropDown item through [RibbonDropDownSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonDropDownSettings.html) which provides options such as `IconCss`, `Content`, `Target` and more.

#### Target

You can make use of [Target](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonDropDownSettings.html#Syncfusion_EJ2_Ribbon_RibbonDropDownSettings_Target) property which specifies the selector for an element to be shown in the DropDownButton popup.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{ 
    string[] pictureOptions = new string[] { "This device", "Stock Images", "Online Images" };
}

@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Illustrations").Collections(collection =>
        {
            collection.Items(item =>
            {
                item.Type(RibbonItemType.DropDown).DropDownSettings(dropdown =>
                {
                    dropdown.IconCss("e-icons e-image").Content("Pictures").Target("#listView");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()
@Html.EJS().ListView("listView").ShowHeader(true).HeaderTitle("Insert Picture From").DataSource(pictureOptions).Render()

{% endhighlight %}
{% endtabs %}

### SplitButton

You can render a SplitButton item by setting the [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_Type) property to `SplitButton`. You can further customize the SplitButton item through [RibbonSplitButtonSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonSplitButtonSettings.html#properties) which provides options such as `IconCss`, `Items`, `Target` and more.

#### Target

You can make use of [Target](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonSplitButtonSettings.html#Syncfusion_EJ2_Ribbon_RibbonSplitButtonSettings_Target) property which specifies the selector for the element to be shown in the SplitButton popup.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{ 
    string[] pictureOptions = new string[] { "This device", "Stock Images", "Online Images" };
}

@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Illustrations").Collections(collection =>
        {
            collection.Items(item =>
            {
                item.Type(RibbonItemType.SplitButton).SplitButtonSettings(splitbutton =>
                {
                    splitbutton.IconCss("e-icons e-image").Content("Pictures").Target("#listView");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()
@Html.EJS().ListView("listView").ShowHeader(true).HeaderTitle("Insert Picture From").DataSource(pictureOptions).Render()

{% endhighlight %}
{% endtabs %}

### ComboBox

You can render a ComboBox item, by setting the [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_Type) property to `ComboBox`. You can further customize the ComboBox item through [RibbonComboBoxSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonComboBoxSettings.html) which provides options such as `AllowFiltering`, `AutoFill`, `Index`, `SortOrder` and more.

#### Filtering

You can make use of [AllowFiltering](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonComboBoxSettings.html#Syncfusion_EJ2_Ribbon_RibbonComboBoxSettings_AllowFiltering) property which provides built-in support for filtering data items. As soon as you start typing characters in the control, the filter operation initiates automatically. If no match is found, the value of the `noRecordsTemplate` property will be displayed. By default the value is `false`.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{ 
    List<string> fontStyle = new List<string>() { "Algerian", "Arial", "Calibri", "Cambria", "Cambria Math", "Courier New", "Candara", "Georgia" };
}

@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("View").Collections(collection =>
        {
            collection.Items(item =>
            {
                item.Type(RibbonItemType.ComboBox).ComboBoxSettings(combobox =>
                {
                    combobox.DataSource(fontStyle).AllowFiltering(true);
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

{% endhighlight %}
{% endtabs %}

#### Index

You can make use of [Index](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonComboBoxSettings.html#Syncfusion_EJ2_Ribbon_RibbonComboBoxSettings_Index) property which specifies the index of the selected item in the combobox.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{ 
    List<string> fontStyle = new List<string>() { "Algerian", "Arial", "Calibri", "Cambria", "Cambria Math", "Courier New", "Candara", "Georgia" };
}

@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("View").Collections(collection =>
        {
            collection.Items(item =>
            {
                item.Type(RibbonItemType.ComboBox).ComboBoxSettings(combobox =>
                {
                    combobox.DataSource(fontStyle).Index(3);
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

{% endhighlight %}
{% endtabs %}

#### SortOrder

You can make use of [SortOrder](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonComboBoxSettings.html#Syncfusion_EJ2_Ribbon_RibbonComboBoxSettings_SortOrder) property which specifies the order in which the data source needs to be sorted. The available type of sort orders are `None` - The data source is not sorted. `Ascending` - The data source is sorted in ascending order. `Descending` - The data source is sorted in descending order.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<string> fontStyle = new List<string>() { "Algerian", "Arial", "Calibri", "Cambria", "Cambria Math", "Courier New", "Candara", "Georgia" };
}

@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("View").Collections(collection =>
        {
            collection.Items(item =>
            {
                item.Type(RibbonItemType.ComboBox).ComboBoxSettings(combobox =>
                {
                    combobox.DataSource(fontStyle).SortOrder("Descending");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

{% endhighlight %}
{% endtabs %}

### ColorPicker

You can render a ColorPicker item by setting the [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_Type) property to `ColorPicker`. You can further customize the ColorPicker item through [RibbonColorPickerSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonColorPickerSettings.html) which provides options such as `Value`, `Columns`, `ShowButtons` and more.

#### Value

You can specify the value color, by using the [Value](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonColorPickerSettings.html#Syncfusion_EJ2_Ribbon_RibbonColorPickerSettings_Value) property. The value should be a valid hex color code.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Inputs
@using Syncfusion.EJ2.Navigations

@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("View").Collections(collection =>
        {
            collection.Items(item =>
            {
                item.Type(RibbonItemType.ColorPicker).ColorPickerSettings(colorpicker =>
                {
                    colorpicker.Value("035a");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()


{% endhighlight %}
{% endtabs %}

## Custom Ribbon items

You can use the [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_Type) property and set it to `Template` to customize ribbon items with non-built-in items. This allows you to define your own custom template for the ribbon item, giving you the flexibility to create unique and personalized content.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("View").Collections(collection =>
        {
            collection.Items(item =>
            {
                item.Type(RibbonItemType.Template).ItemTemplate("<span class='ribbonTemplate ${activeSize}'><span class='e-icons e-video'></span><span class='text'>Video</span></span>").Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<style>

    .ribbonTemplate {
        display: flex;
        align-items: center;
        justify-content: center;
        cursor: pointer;
    }

        .ribbonTemplate.Large {
            flex-direction: column;
        }

            .ribbonTemplate.Large .e-icons {
                font-size: 35px;
            }

        .ribbonTemplate.Medium .e-icons,
        .ribbonTemplate.Small .e-icons {
            font-size: 20px;
            margin: 15px 5px;
        }

        .ribbonTemplate.Small .text {
            display: none;
        }
</style >

{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control with Custom Ribbon items](./images/customRibbonItem.png)

## Display Mode

### Display Options

By setting the [displayOptions](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_DisplayOptions) property you can determines how an item is displayed in different ribbon layouts.

`Auto` - The item is displayed in the classic layout group, simplified layout group, and overflow popup based on the ribbon's overflow state.
`Classic` - The item is displayed only in the classic layout group.
`Overflow` - The item is displayed only in the overflow popup.
`Simplified` - The item is displayed only in the simplified layout group.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Clipboard").Collections(collection =>
        {
            collection.Items(item =>
            {
                item.Type(RibbonItemType.Button).DisplayOptions(Syncfusion.EJ2.Ribbon.DisplayMode.Simplified).ButtonSettings(button =>
                {
                    button.IconCss("e-icons e-cut").Content("cut");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

{% endhighlight %}
{% endtabs %}

## Enable or disable items

You can use the [Disabled](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_Disabled) property to disable an item. When set to `true`, the item will be disabled and prevents the user interaction with it. By default the value is `false`.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Clipboard").Collections(collection =>
        {
            collection.Items(item =>
            {
                item.Type(RibbonItemType.Button).Disabled(true).ButtonSettings(button =>
                {
                    button.IconCss("e-icons e-cut").Content("cut");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

{% endhighlight %}
{% endtabs %}