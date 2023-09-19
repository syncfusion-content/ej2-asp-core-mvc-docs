---
layout: post
title: Ribbon Items in ##Platform_Name## Ribbon Control | Syncfusion
description: Learn here all about Items in Syncfusion ##Platform_Name## Ribbon control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Ribbon
publishingplatform: ##Platform_Name##
documentation: ug
---

# Ribbon Items

Ribbon renders various built-in items based on the item [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_Type) property. By default, the type property is set as `Button` which renders the Button.

## Built-in items

You can render the built-in Ribbon items by using the [Items](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonCollection.html#Syncfusion_EJ2_Ribbon_RibbonCollection_Items) property, to specify the [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_Type) property.

The following table explains the built-in items and their actions.

| Built-in Ribbon Items | Actions |
|------------------------|---------|
| Button | Renders button as ribbon item.|
| CheckBox | Renders checkbox as ribbon item.|
| DropDown | Renders dropdownbutton as ribbon item.|
| SplitButton | Renders splitbutton as ribbon item.|
| ComboBox | Renders combobox as ribbon item.|
| ColorPicker | Renders color picker as ribbon item.|
| GroupButton | Renders groupbutton as ribbon item.|

### Button items

You can render the built-in button Ribbon item by setting the [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_Type) property as `Button`. You can also customize the button item using the [RibbonButtonSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonButtonSettings.html), which provides options such as `iconCss`, `content`, `isToggle` and more.

#### Toggle button

The [IsToggle](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonButtonSettings.html#Syncfusion_EJ2_Ribbon_RibbonButtonSettings_IsToggle) property can be used to define whether the button act as a toggle button or not. By default the value is `false`.

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

### CheckBox items

You can render the built-in checkBox Ribbon item by setting the [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_Type) property to `CheckBox`. You can also customize the checkBox item using the [RibbonCheckBoxSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonCheckBoxSettings.html), which provides options such as `labelPosition`, `label`, `checked` and more.

#### Checkbox state

You can use the [Checked](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonCheckBoxSettings.html#Syncfusion_EJ2_Ribbon_RibbonCheckBoxSettings_Checked) property to handle the checked or unchecked state. By default, the value is `false`.

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

#### Defining label

You can use the [Label](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonCheckBoxSettings.html#Syncfusion_EJ2_Ribbon_RibbonCheckBoxSettings_Label) property to add a caption for the CheckBox. The label position can be set `Before` or `After`, by using the [LabelPosition](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonCheckBoxSettings.html#Syncfusion_EJ2_Ribbon_RibbonCheckBoxSettings_LabelPosition) property. By default, the labelPosition is `After`.

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

### DropDown button items

You can render the built-in dropDown Ribbon item by setting the [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_Type) property to `DropDown`. You can also customize the dropDown item through [RibbonDropDownSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonDropDownSettings.html), which provides options such as `iconCss`, `content`, `target` and more.

#### Target

The [Target](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonDropDownSettings.html#Syncfusion_EJ2_Ribbon_RibbonDropDownSettings_Target) property specifies the element selector to be displayed in the DropDownButton popup.

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

### Split button items

You can render the built-in splitButton Ribbon item by setting the [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_Type) property to `SplitButton` you can render a splitButton item. You can also customize the SplitButton item through [RibbonSplitButtonSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonSplitButtonSettings.html#properties), which provides options such as `IconCss`, `Items`, `Target` and more.

#### Target

The [Target](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonSplitButtonSettings.html#Syncfusion_EJ2_Ribbon_RibbonSplitButtonSettings_Target) property specifies the element selector to be displayed in the SplitButton popup.

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

### Combobox items

You can render the built-in comboBox Ribbon item by setting the [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_Type) property to `ComboBox` you can render a comboBox item. You can also customize the ComboBox item through [RibbonComboBoxSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonComboBoxSettings.html), which provides options such as `AllowFiltering`, `AutoFill`, `Index`, `SortOrder` and more.

#### Filtering

You can use the [AllowFiltering](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonComboBoxSettings.html#Syncfusion_EJ2_Ribbon_RibbonComboBoxSettings_AllowFiltering) property to filter the data items. The filtering operation is initiated automatically, as soon as you start typing characters. If no match is found, the value of the `noRecordsTemplate` property will be displayed. By default, the value is `false`.

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

You can use the [Index](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonComboBoxSettings.html#Syncfusion_EJ2_Ribbon_RibbonComboBoxSettings_Index) property to get or set the selected item in the combobox.

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

You can use the [SortOrder](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonComboBoxSettings.html#Syncfusion_EJ2_Ribbon_RibbonComboBoxSettings_SortOrder) property to specify the order in which the DataSource should be sorted.

<table>
  <tr>
    <td>`None`</td>
    <td>The data source is not sorted.</td>
  </tr>
  <tr>
    <td>`Ascending`</td>
    <td>The data source is sorted in ascending order.</td>
  </tr>
  <tr>
    <td>`Descending`</td>
    <td>The data source is sorted in descending order.</td>
  </tr>
</table>

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

### Colorpicker items

You can render the built-in colorPicker Ribbon item by setting the [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_Type) property to `ColorPicker`. You can also customize the colorPicker item through [RibbonColorPickerSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonColorPickerSettings.html), which provides options such as `Value`, `Columns`, `ShowButtons` and more.

#### Value

You can use the [Value](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonColorPickerSettings.html#Syncfusion_EJ2_Ribbon_RibbonColorPickerSettings_Value) property to specify the color value. The value should be specified as Hex code.

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

### Groupbutton items

You can render the built-in groupbutton Ribbon item by setting the [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_Type) property to `GroupButton`. You can also customize the groupbutton item using the [RibbonGroupButtonSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonGroupButtonSettings.html), which provides options such as `Selection` and `Items`.

#### Items

You can render the groupbutton items by using [Items](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonGroupButtonSettings.html#Syncfusion_EJ2_Ribbon_RibbonGroupButtonSettings_Items) property. You can also customize the groupbutton items through [RibbonGroupButtonItem](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonGroupButtonItem.html), which provides options such as `Content`, `IconCss`, `Selected` and more.

#### Item content

You can use the [Content](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonGroupButtonItem.html#Syncfusion_EJ2_Ribbon_RibbonGroupButtonItem_Content) property to define the text content for the groupbutton.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ribbon/items/groupButtonContent/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control Groupbutton Item Content](./images/ribbon-groupbutton-content.png)

#### Icon only

You can use the [IconCss](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonGroupButtonItem.html#Syncfusion_EJ2_Ribbon_RibbonGroupButtonItem_IconCss) property to customize the groupbutton icon. If the `IconCss` property is not defined, the groupbutton will not be rendered.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ribbon/items/groupButtonIcon/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control Groupbutton Icon only](./images/ribbon-groupbutton-icon.png)

#### Selection

You can use the [Selected](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonGroupButtonItem.html#Syncfusion_EJ2_Ribbon_RibbonGroupButtonItem_Selected) property to select the groupbutton item initally. When set to `true`, the button will be selected. By default the `Selected` property is false.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ribbon/items/groupButtonSelected/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control Groupbutton Selection](./images/ribbon-groupbutton-selected.png)

#### Single selection

You can set the [Selection](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonGroupButtonSettings.html#Syncfusion_EJ2_Ribbon_RibbonGroupButtonSettings_Selection) property value as `RibbonGroupButtonSelection.Single` to make one selection at a time. It automatically deselects the previous choice when a different item is clicked.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ribbon/items/singleSelection/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control Groupbutton Single selection](./images/ribbon-groupbutton-single-selection.png)

#### Multiple selection

You can set the [Selection](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonGroupButtonSettings.html#Syncfusion_EJ2_Ribbon_RibbonGroupButtonSettings_Selection) property value as `RibbonGroupButtonSelection.Multiple` to select more than one button at a time. Users can select a button one by one to select multiple buttons.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ribbon/items/multipleSelection/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control Groupbutton Multiple selection](./images/ribbon-groupbutton-multiple-selection.png)

#### Groupbutton in simplified mode layout

In simplified mode, the groupbutton will be rendered as a dropdownbutton. The dropdownbutton icon will be updated based on the button item selected. The initial button icon will be the set, if none of the buttons are selected.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/ribbon/items/simplifiedModeGroupButton/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Ribbon Control Groupbutton in simplified mode](./images/ribbon-simplifiedmode-groupbutton.png)

## Custom items

You can customize the ribbon items with non-built-in items or HTML content by setting the [Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_Type) property to `Template`. This provides an option to customize the ribbon items with greater flexibility.

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

## Items display Mode

You can use the [DisplayOptions](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_DisplayOptions) property to display the items in the Ribbon.

<table>
  <tr>
    <td>`Auto`</td>
    <td>The items are displayed in all layouts based on the ribbon's overflow state.</td>
  </tr>
  <tr>
    <td>`Classic`</td>
    <td>The items are displayed only in the classic layout group.</td>
  </tr>
  <tr>
    <td>`Simplified`</td>
    <td>The items are displayed only in the simplified layout group.</td>
  </tr>
  <tr>
    <td>`Overflow`</td>
    <td>The items are displayed only in the overflow popup.</td>
  </tr>
</table>

### Display items in Classic only

To diplay the items only in the classic layout group, set the mode as `DisplayMode.Classic` in the [DisplayOptions](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_DisplayOptions) property.

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
                item.Type(RibbonItemType.Button).DisplayOptions(Syncfusion.EJ2.Ribbon.DisplayMode.Classic).ButtonSettings(button =>
                {
                    button.IconCss("e-icons e-cut").Content("cut");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

{% endhighlight %}
{% endtabs %}

### Display items in Simplified only

To diplay the items only in the simplified layout group, set the mode as `DisplayMode.Simplified` in the [DisplayOptions](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_DisplayOptions) property.

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

### Display items in Overflow popup only

To diplay the items only in the overflow, set the mode as `DisplayMode.Overflow` in the [DisplayOptions](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_DisplayOptions) property.

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
                item.Type(RibbonItemType.Button).DisplayOptions(Syncfusion.EJ2.Ribbon.DisplayMode.Overflow).ButtonSettings(button =>
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

You can use the [Disabled](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_Disabled) property to disable a Ribbon item. It prevents the user interaction when set to `true`. By default, the value is `false`.

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
                item.Type(RibbonItemType.CheckBox).Disabled(true).CheckBoxSettings(checkBox =>
                {
                    checkBox.Checked(true).Label("Ruler");
                }).Add();
                item.Type(RibbonItemType.DropDown).Disabled(true).DropDownSettings(dropdown =>
                {
                    dropdown.IconCss("e-icons e-table").Content("Table");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

{% endhighlight %}
{% endtabs %}
