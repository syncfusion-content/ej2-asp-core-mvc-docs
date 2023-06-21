---
layout: post
title: Items in ##Platform_Name## Ribbon Control | Syncfusion
description: Learn here all about Items in Syncfusion ##Platform_Name## Ribbon control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Ribbon
publishingplatform: ##Platform_Name##
documentation: ug
---

# Ribbon Items in ASP.NET Core Ribbon Control

## Built-in Ribbon items


You can define each ribbon item using the `e-ribbon-item` tag helper, the type should be specified in the [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonItemType.html) property to define built-in items.

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
To render a Button item, you should set the [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonItemType.html) property to `Button`. You can further customize the button item through [`RibbonButtonSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonButtonSettings.html) by using the `e-ribbon-buttonsettings` tag helper, which provides options such as `iconCss`, `content`, `isToggle` and more.

#### Toggle Button
You can make use of [`isToggle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonButtonSettings.html#Syncfusion_EJ2_Ribbon_RibbonButtonSettings_IsToggle) property to define whether the button is toggle button or not. By default value is false.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Clipboard">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type=Button>
                                    <e-ribbon-buttonsettings iconCss="e-icons e-cut" content="Cut" isToggle=true></e-ribbon-buttonsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

{% endhighlight %}
{% endtabs %}

### CheckBox

To render a CheckBox item, you should set the [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonItemType.html) property to `CheckBox` . You can further customize the CheckBox item through [`RibbonCheckBoxSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonCheckBoxSettings.html) by using the `e-ribbon-checkboxsettings` tag helper, which provides options such as `labelPosition`, `label`, `checked` and more.

#### CheckBox State

You can make use of [`checked`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonCheckBoxSettings.html#Syncfusion_EJ2_Ribbon_RibbonCheckBoxSettings_Checked) property to define whether the checkbox is checked or not. A tick mark will be added to the visualization of CheckBox in checked state. By default value is false.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="View">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type=CheckBox>
                                    <e-ribbon-checkboxsettings checked=true label="Ruler"></e-ribbon-checkboxsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

{% endhighlight %}
{% endtabs %}

#### Label and label Position

You can define the caption for a CheckBox, by utilizing the [`label`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonCheckBoxSettings.html#Syncfusion_EJ2_Ribbon_RibbonCheckBoxSettings_Label) property. This helps in reducing the need for manually adding a separate label element. 
You can customize the position of the label relative to the CheckBox by using the [`labelPosition`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonCheckBoxSettings.html#Syncfusion_EJ2_Ribbon_RibbonCheckBoxSettings_LabelPosition) property, which allows you to specify whether the label should appear before or after the CheckBox.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Buttons
@using Syncfusion.EJ2.Navigations

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="View">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type=CheckBox>
                                    <e-ribbon-checkboxsettings checked=true label="Ruler" labelPosition=LabelPosition.Before></e-ribbon-checkboxsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

{% endhighlight %}
{% endtabs %}

### DropDown

To render a DropDown item, you should set the [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonItemType.html) property to `DropDown` . You can further customize the DropDown item through [`RibbonDropDownSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonDropDownSettings.html) by using the `e-ribbon-dropdownsettings` tag helper, which provides options such as `iconCss`, `content`, `target` and more.

#### Target

You can make use of [`target`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonDropDownSettings.html#Syncfusion_EJ2_Ribbon_RibbonDropDownSettings_Target) property which specifies the selector for the element to be shown in the DropDownButton popup.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    string[] pictureOptions = new string[] { "This device", "Stock Images", "Online Images" };
}

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Illustrations">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type=DropDown>
                                    <e-ribbon-dropdownsettings iconCss="e-icons e-image" content="Pictures" target="#pictureList"></e-ribbon-dropdownsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>
<ejs-listview id="pictureList" showHeader=true headerTitle="Insert Picture From" dataSource=pictureOptions></ejs-listview>

{% endhighlight %}
{% endtabs %}


### SplitButton

To render a SplitButton item, you should set the [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonItemType.html) property to `SplitButton` . You can further customize the SplitButton item through [`RibbonSplitButtonSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonSplitButtonSettings.html#properties) by using the `e-ribbon-splitbuttonsettings` tag helper, which provides options such as `iconCss`, `items`, `target` and more.

#### Target

You can make use of [`target`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonSplitButtonSettings.html#Syncfusion_EJ2_Ribbon_RibbonSplitButtonSettings_Target) property which specifies the selector for the element to be shown in the SplitButton popup.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    string[] pictureOptions = new string[] { "This device", "Stock Images", "Online Images" };
}

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Header & Footer">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type=SplitButton>
                                    <e-ribbon-splitbuttonsettings iconCss="e-icons e-paste" content="Paste" target="#pictureList"></e-ribbon-splitbuttonsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>
<ejs-listview id="pictureList" showHeader=true headerTitle="Insert Picture From" dataSource=pictureOptions></ejs-listview>

{% endhighlight %}
{% endtabs %}

### ComboBox

To render a ComboBox item, you should set the [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonItemType.html) property to `ComboBox` . You can further customize the ComboBox item through [`RibbonComboBoxSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonComboBoxSettings.html) by using the `e-ribbon-comboboxsettings` tag helper, which provides options such as `allowFiltering`, `autoFill`, `index`, `sortOrder` and more.

#### Filtering

You can make use of [`AllowFiltering`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonComboBoxSettings.html#Syncfusion_EJ2_Ribbon_RibbonComboBoxSettings_AllowFiltering) property which provides built-in support for filtering data items. As soon as you start typing characters in the control, the filter operation initiates automatically. If no match is found, the value of the noRecordsTemplate property will be displayed. By default the value is false.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<string> fontStyle = new List<string>() { "Algerian", "Arial", "Calibri", "Cambria", "Cambria Math", "Courier New", "Candara", "Georgia" };
}

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Font">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type=ComboBox>
                                    <e-ribbon-comboboxsettings dataSource=fontStyle allowFiltering=true></e-ribbon-comboboxsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

{% endhighlight %}
{% endtabs %}

#### Filter type 

You can specify the filter type to be applied during the search action. When performing filtering, you have the flexibility to modify the filter type to "contains", "startsWith", or "endsWith" specifically for string types by enabling [`filterType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonComboBoxSettings.html#Syncfusion_EJ2_Ribbon_RibbonComboBoxSettings_FilterType) Property.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.DropDowns
@using Syncfusion.EJ2.Navigations

@{
    List<string> fontStyle = new List<string>() { "Algerian", "Arial", "Calibri", "Cambria", "Cambria Math", "Courier New", "Candara", "Georgia" };
}

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Font">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type=ComboBox>
                                    <e-ribbon-comboboxsettings dataSource=fontStyle index=3 filterType=FilterType.EndsWith></e-ribbon-comboboxsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

{% endhighlight %}
{% endtabs %}

#### Index

You can make use of [`index`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonComboBoxSettings.html#Syncfusion_EJ2_Ribbon_RibbonComboBoxSettings_Index) property which specifies the index of the selected item in the combobox.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<string> fontStyle = new List<string>() { "Algerian", "Arial", "Calibri", "Cambria", "Cambria Math", "Courier New", "Candara", "Georgia" };
}

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Font">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type=ComboBox>
                                    <e-ribbon-comboboxsettings dataSource=fontStyle index=3></e-ribbon-comboboxsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

{% endhighlight %}
{% endtabs %}

#### SortOrder

You can make use of [`sortOrder`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonComboBoxSettings.html#Syncfusion_EJ2_Ribbon_RibbonComboBoxSettings_Index) property which specifies the order in which the data source needs to be sorted. The available type of sort orders are None - The data source is not sorted. Ascending - The data source is sorted in ascending order. Descending - The data source is sorted in descending order.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<string> fontStyle = new List<string>() { "Algerian", "Arial", "Calibri", "Cambria", "Cambria Math", "Courier New", "Candara", "Georgia" };
}

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Font">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type=ComboBox>
                                    <e-ribbon-comboboxsettings dataSource=fontStyle sortOrder=SortOrder.Descending></e-ribbon-comboboxsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

{% endhighlight %}
{% endtabs %}

### ColorPicker

To render a ColorPicker item, you should set the [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonItemType.html) property to `ColorPicker` . You can further customize the ColorPicker item through [`RibbonColorPickerSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonColorPickerSettings.html) by using the `e-ribbon-colorpickersettings` tag helper, which provides options such as `allowFiltering`, `autoFill`, `index`, `sortOrder` and more.

#### Mode and Values

To define the rendering mode of the ColorPicker, you can set the [`mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonColorPickerSettings.html#Syncfusion_EJ2_Ribbon_RibbonColorPickerSettings_Mode) property to either "picker" or "palette".

You can specify the value color you can use [`value`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonColorPickerSettings.html#Syncfusion_EJ2_Ribbon_RibbonColorPickerSettings_Value) property. The value should be a valid hex color code.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Inputs
@using Syncfusion.EJ2.Navigations

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Font">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type=ColorPicker>
                                    <e-ribbon-colorpickersettings value="035a" mode=ColorPickerMode.Palette></e-ribbon-colorpickersettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

{% endhighlight %}
{% endtabs %}

## Custom Ribbon items

To customize ribbon items with non-built-in items, you can utilize the [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonItemType.html) property and set it to `Template`. This allows you to define your own custom template for the ribbon item, giving you the flexibility to create unique and personalized content.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Font">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type=Template itemTemplate='<span class="ribbonTemplate ${activeSize}"><span class="e-icons e-video"></span><span class="text">Video</span></span>'>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

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

</style>

{% endhighlight %}
{% endtabs %}
