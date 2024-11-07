---
layout: post
title: Events in ##Platform_Name## Ribbon Control | Syncfusion
description: Learn here all about Events in Syncfusion ##Platform_Name## Ribbon control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Ribbon
publishingplatform: ##Platform_Name##
documentation: ug
---

# Events in ##Platform_Name## Ribbon control

This section describes the ribbon events that will be triggered when appropriate actions are performed. The following events are available in the ribbon control.

## Tab selected

The [TabSelected](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.Ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_TabSelected) event is triggered after selecting the tab item.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon

@Html.EJS().Ribbon("ribbon").TabSelected("function(args){tabSelectedEvent(args)}").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Clipboard").Collections(collection =>
        {
            collection.Items(items =>
            {
                items.Type(RibbonItemType.Button).ButtonSettings(button =>
                {
                    button.IconCss("e-icons e-paste").Content("Paste");
                }).Add();
            }).Add();
            collection.Items(items =>
            {
                items.Type(RibbonItemType.Button).ButtonSettings(button =>
                {
                    button.IconCss("e-icons e-cut").Content("Cut");
                }).Add();
                items.Type(RibbonItemType.Button).ButtonSettings(button =>
                {
                    button.IconCss("e-icons e-copy").Content("Copy");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function tabSelectedEvent(args) {
        // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

## Tab selecting

The [TabSelecting](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.Ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_TabSelecting) event is triggered before selecting the tab item.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon

@Html.EJS().Ribbon("ribbon").TabSelecting("function(args){tabSelectingEvent(args)}").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Clipboard").Collections(collection =>
        {
            collection.Items(items =>
            {
                items.Type(RibbonItemType.Button).ButtonSettings(button =>
                {
                    button.IconCss("e-icons e-paste").Content("Paste");
                }).Add();
            }).Add();
            collection.Items(items =>
            {
                items.Type(RibbonItemType.Button).ButtonSettings(button =>
                {
                    button.IconCss("e-icons e-cut").Content("Cut");
                }).Add();
                items.Type(RibbonItemType.Button).ButtonSettings(button =>
                {
                    button.IconCss("e-icons e-copy").Content("Copy");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function tabSelectingEvent(args) {
        // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

## Ribbon collapsing

The [RibbonCollapsing](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.Ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_RibbonCollapsing) event is triggered before collapsing the ribbon.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon

@Html.EJS().Ribbon("ribbon").RibbonCollapsing("function(args){ribbonCollapsingEvent(args)}").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Clipboard").Collections(collection =>
        {
            collection.Items(items =>
            {
                items.Type(RibbonItemType.Button).ButtonSettings(button =>
                {
                    button.IconCss("e-icons e-paste").Content("Paste");
                }).Add();
            }).Add();
            collection.Items(items =>
            {
                items.Type(RibbonItemType.Button).ButtonSettings(button =>
                {
                    button.IconCss("e-icons e-cut").Content("Cut");
                }).Add();
                items.Type(RibbonItemType.Button).ButtonSettings(button =>
                {
                    button.IconCss("e-icons e-copy").Content("Copy");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function ribbonCollapsingEvent(args) {
        // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

## Ribbon expanding

The [RibbonExpanding](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.Ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_RibbonExpanding) event is triggered before expanding the ribbon.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon

@Html.EJS().Ribbon("ribbon").RibbonExpanding("function(args){ribbonExpanding(args)}").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Clipboard").Collections(collection =>
        {
            collection.Items(items =>
            {
                items.Type(RibbonItemType.Button).ButtonSettings(button =>
                {
                    button.IconCss("e-icons e-paste").Content("Paste");
                }).Add();
            }).Add();
            collection.Items(items =>
            {
                items.Type(RibbonItemType.Button).ButtonSettings(button =>
                {
                    button.IconCss("e-icons e-cut").Content("Cut");
                }).Add();
                items.Type(RibbonItemType.Button).ButtonSettings(button =>
                {
                    button.IconCss("e-icons e-copy").Content("Copy");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function ribbonExpanding(args) {
        // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

## Group launcher click

The [LauncherIconClick](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.Ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_LauncherIconClick) event is triggered when the launcher icon of the group is clicked.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon

@Html.EJS().Ribbon("ribbon").LauncherIconClick("function(args){launchClick(args)}").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Clipboard").ShowLauncherIcon(true).Collections(collection =>
        {
            collection.Items(items =>
            {
                items.Type(RibbonItemType.Button).ButtonSettings(button =>
                {
                    button.IconCss("e-icons e-paste").Content("Paste");
                }).Add();
            }).Add();
            collection.Items(items =>
            {
                items.Type(RibbonItemType.Button).ButtonSettings(button =>
                {
                    button.IconCss("e-icons e-cut").Content("Cut");
                }).Add();
                items.Type(RibbonItemType.Button).ButtonSettings(button =>
                {
                    button.IconCss("e-icons e-copy").Content("Copy");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function launchClick(args) {
        // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

## Overflow popup open

The [OverflowPopupOpen](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.Ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_OverflowPopupOpen) event is triggered while opening the overflow popup.

## Overflow popup close

The [OverflowPopupClose](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.Ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_OverflowPopupClose) event is triggered while closing the overflow popup.

The following code example demonstrates the ribbon rendered with `OverflowPopupOpen` and `OverflowPopupClose` events.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon

@Html.EJS().Ribbon("ribbon").OverflowPopupOpen("function(args){overflowPopupOpen(args)}").OverflowPopupClose("function(args){overflowPopupClose(args)}").ActiveLayout(RibbonLayout.Simplified).Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Clipboard").Collections(collection =>
        {
            collection.Items(items =>
            {
                items.Type(RibbonItemType.Button).ButtonSettings(button =>
                {
                    button.IconCss("e-icons e-paste").Content("Paste");
                }).Add();
            }).Add();
            collection.Items(items =>
            {
                items.Type(RibbonItemType.Button).ButtonSettings(button =>
                {
                    button.IconCss("e-icons e-cut").Content("Cut");
                }).Add();
                items.Type(RibbonItemType.Button).ButtonSettings(button =>
                {
                    button.IconCss("e-icons e-copy").Content("Copy");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function overflowPopupOpen(args) {
        // Here, you can customize your code.
    }
    function overflowPopupClose(args) {
    // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

## Button item events

### Clicked

The [Clicked](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.RibbonButtonSettings.html#Syncfusion_EJ2_Ribbon_RibbonButtonSettings_Clicked) event is triggered when the button is clicked.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon

@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Clipboard").Collections(collection =>
        {
            collection.Items(items =>
            {
                items.Type(RibbonItemType.Button).ButtonSettings(button =>
                {
                    button.IconCss("e-icons e-cut").Content("Cut").Clicked("function(){clickedEvent()}");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function clickedEvent() {
        // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

### Created

The [Created](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.RibbonButtonSettings.html#Syncfusion_EJ2_Ribbon_RibbonButtonSettings_Created) event is triggered when the button is created.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon

@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Clipboard").Collections(collection =>
        {
            collection.Items(items =>
            {
                items.Type(RibbonItemType.Button).ButtonSettings(button =>
                {
                    button.IconCss("e-icons e-cut").Content("Cut").Created("function(){createdEvent()}");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function createdEvent() {
        // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

## Checkbox item events

### Change

The [Change](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.RibbonCheckBoxSettings.html#Syncfusion_EJ2_Ribbon_RibbonCheckBoxSettings_Change) event is triggered when the Checkbox state is changed.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon

@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Clipboard").Collections(collection =>
        {
            collection.Items(items =>
            {
                items.Type(RibbonItemType.CheckBox).CheckBoxSettings(checkBox =>
                {
                    checkBox.Label("Ruler").Checked(false).Change("function(){changeEvent()}");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function changeEvent() {
        // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

### Created

The [Created](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.RibbonCheckBoxSettings.html#Syncfusion_EJ2_Ribbon_RibbonCheckBoxSettings_Created) event is triggered once the Checkbox is created.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon

@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Clipboard").Collections(collection =>
        {
            collection.Items(items =>
            {
                items.Type(RibbonItemType.CheckBox).CheckBoxSettings(checkBox =>
                {
                    checkBox.Label("Ruler").Checked(false).Created("function(){createdEvent()}");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function createdEvent() {
        // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

## Colorpicker item events

### Change

The [Change](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.RibbonColorPickerSettings.html#Syncfusion_EJ2_Ribbon_RibbonColorPickerSettings_Change) event is triggered while changing the colors.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon

@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Clipboard").Collections(collection =>
        {
            collection.Items(items =>
            {
                items.Type(RibbonItemType.ColorPicker).ColorPickerSettings(colorPicker =>
                {
                    colorPicker.Value("#123456").Change("function(){changeEvent()}");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function changeEvent() {
        // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

### Created

The [Created](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.RibbonColorPickerSettings.html#Syncfusion_EJ2_Ribbon_RibbonColorPickerSettings_Created) event is triggered once the ColorPicker is created.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon

@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Clipboard").Collections(collection =>
        {
            collection.Items(items =>
            {
                items.Type(RibbonItemType.ColorPicker).ColorPickerSettings(colorPicker =>
                {
                    colorPicker.Value("#123456").Created("function(){createdEvent()}");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function createdEvent() {
        // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

### Open

The [Open](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.RibbonColorPickerSettings.html#Syncfusion_EJ2_Ribbon_RibbonColorPickerSettings_Open) event is triggered while opening the ColorPicker popup.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon

@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Clipboard").Collections(collection =>
        {
            collection.Items(items =>
            {
                items.Type(RibbonItemType.ColorPicker).ColorPickerSettings(colorPicker =>
                {
                    colorPicker.Value("#123456").Open("function(args){openEvent(args)}");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function openEvent(args) {
        // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

### Select

The [Select](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.RibbonColorPickerSettings.html#Syncfusion_EJ2_Ribbon_RibbonColorPickerSettings_Select) event is triggered while selecting the color in picker/palette, when showButtons property is enabled.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon

@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Clipboard").Collections(collection =>
        {
            collection.Items(items =>
            {
                items.Type(RibbonItemType.ColorPicker).ColorPickerSettings(colorPicker =>
                {
                    colorPicker.Value("#123456").Select("function(args){selectEvent(args)}");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function selectEvent(args) {
        // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

### Before close

The [BeforeClose](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.RibbonColorPickerSettings.html#Syncfusion_EJ2_Ribbon_RibbonColorPickerSettings_BeforeClose) event is triggered before closing the ColorPicker popup.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon

@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Clipboard").Collections(collection =>
        {
            collection.Items(items =>
            {
                items.Type(RibbonItemType.ColorPicker).ColorPickerSettings(colorPicker =>
                {
                    colorPicker.Value("#123456").BeforeClose("function(args){beforeCloseEvent(args)}");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function beforeCloseEvent() {
        // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

### Before open

The [BeforeOpen](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.RibbonColorPickerSettings.html#Syncfusion_EJ2_Ribbon_RibbonColorPickerSettings_BeforeOpen) event is triggered before opening the ColorPicker popup.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon

@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Clipboard").Collections(collection =>
        {
            collection.Items(items =>
            {
                items.Type(RibbonItemType.ColorPicker).ColorPickerSettings(colorPicker =>
                {
                    colorPicker.Value("#123456").BeforeOpen("function(args){beforeOpenEvent(args)}");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function beforeOpenEvent(args) {
        // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

### Before tile render

The [BeforeTileRender](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.RibbonColorPickerSettings.html#Syncfusion_EJ2_Ribbon_RibbonColorPickerSettings_BeforeTileRender) event is triggered while rendering each palette tile.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon

@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Clipboard").Collections(collection =>
        {
            collection.Items(items =>
            {
                items.Type(RibbonItemType.ColorPicker).ColorPickerSettings(colorPicker =>
                {
                    colorPicker.Value("#123456").BeforeTileRender("function(args){beforeTileRenderEvent(args)}");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function beforeTileRenderEvent(args) {
        // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

## ComboBox item events

### Change

The [Change](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.RibbonComboBoxSettings.html#Syncfusion_EJ2_Ribbon_RibbonComboBoxSettings_Change) event is triggered when an item in a popup is selected or when the model value is changed by the user.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon

@{ 
    List<string> fontStyle = new List<string>() { "Algerian", "Arial", "Calibri", "Cambria", "Cambria Math", "Courier New", "Candara", "Georgia", "Impact", "Segoe Print", "Segoe Script", "Segoe UI", "Symbol", "Times New Roman", "Verdana", "Windings" };
}
@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Clipboard").Collections(collection =>
        {
            collection.Items(items =>
            {
                items.Type(RibbonItemType.ComboBox).ComboBoxSettings(comboBox =>
                {
                    comboBox.DataSource(fontStyle).Index(2).Change("function(args){changeEvent(args)}");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function changeEvent() {
        // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

### Close

The [Close](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.RibbonComboBoxSettings.html#Syncfusion_EJ2_Ribbon_RibbonComboBoxSettings_Close) event is triggered when the popup is closed.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon

@{ 
    List<string> fontStyle = new List<string>() { "Algerian", "Arial", "Calibri", "Cambria", "Cambria Math", "Courier New", "Candara", "Georgia", "Impact", "Segoe Print", "Segoe Script", "Segoe UI", "Symbol", "Times New Roman", "Verdana", "Windings" };
}
@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Clipboard").Collections(collection =>
        {
            collection.Items(items =>
            {
                items.Type(RibbonItemType.ComboBox).ComboBoxSettings(comboBox =>
                {
                    comboBox.DataSource(fontStyle).Index(2).Close("function(args){closeEvent(args)}");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function closeEvent(args) {
        // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

### Open

The [Open](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.RibbonComboBoxSettings.html#Syncfusion_EJ2_Ribbon_RibbonComboBoxSettings_Open) event is triggered when the popup is opened.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon

@{ 
    List<string> fontStyle = new List<string>() { "Algerian", "Arial", "Calibri", "Cambria", "Cambria Math", "Courier New", "Candara", "Georgia", "Impact", "Segoe Print", "Segoe Script", "Segoe UI", "Symbol", "Times New Roman", "Verdana", "Windings" };
}
@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Clipboard").Collections(collection =>
        {
            collection.Items(items =>
            {
                items.Type(RibbonItemType.ComboBox).ComboBoxSettings(comboBox =>
                {
                    comboBox.DataSource(fontStyle).Index(2).Open("function(args){openEvent(args)}");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function openEvent(args) {
        // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

### Created

The [Created](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.RibbonComboBoxSettings.html#Syncfusion_EJ2_Ribbon_RibbonComboBoxSettings_Created) event is triggered once the Combobox is created.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon

@{ 
    List<string> fontStyle = new List<string>() { "Algerian", "Arial", "Calibri", "Cambria", "Cambria Math", "Courier New", "Candara", "Georgia", "Impact", "Segoe Print", "Segoe Script", "Segoe UI", "Symbol", "Times New Roman", "Verdana", "Windings" };
}
@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Clipboard").Collections(collection =>
        {
            collection.Items(items =>
            {
                items.Type(RibbonItemType.ComboBox).ComboBoxSettings(comboBox =>
                {
                    comboBox.DataSource(fontStyle).Index(2).Created("function(args){createdEvent(args)}");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function createdEvent() {
        // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

### Filtering

The [Filtering](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.RibbonComboBoxSettings.html#Syncfusion_EJ2_Ribbon_RibbonComboBoxSettings_Filtering) event triggers on typing a character in the Combobox.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon

@{ 
    List<string> fontStyle = new List<string>() { "Algerian", "Arial", "Calibri", "Cambria", "Cambria Math", "Courier New", "Candara", "Georgia", "Impact", "Segoe Print", "Segoe Script", "Segoe UI", "Symbol", "Times New Roman", "Verdana", "Windings" };
}
@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Clipboard").Collections(collection =>
        {
            collection.Items(items =>
            {
                items.Type(RibbonItemType.ComboBox).ComboBoxSettings(comboBox =>
                {
                    comboBox.DataSource(fontStyle).Index(2).Filtering("function(args){filteringEvent(args)}");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function filteringEvent(args) {
        // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

### Select

The [Select](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.RibbonComboBoxSettings.html#Syncfusion_EJ2_Ribbon_RibbonComboBoxSettings_Select) event is triggered when an item in the popup is selected.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon

@{ 
    List<string> fontStyle = new List<string>() { "Algerian", "Arial", "Calibri", "Cambria", "Cambria Math", "Courier New", "Candara", "Georgia", "Impact", "Segoe Print", "Segoe Script", "Segoe UI", "Symbol", "Times New Roman", "Verdana", "Windings" };
}
@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Clipboard").Collections(collection =>
        {
            collection.Items(items =>
            {
                items.Type(RibbonItemType.ComboBox).ComboBoxSettings(comboBox =>
                {
                    comboBox.DataSource(fontStyle).Index(2).Select("function(args){selectEvent(args)}");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function selectEvent(args) {
        // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

### Before open

The [BeforeOpen](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.RibbonComboBoxSettings.html#Syncfusion_EJ2_Ribbon_RibbonComboBoxSettings_BeforeOpen) event triggers before opening the popup.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon

@{ 
    List<string> fontStyle = new List<string>() { "Algerian", "Arial", "Calibri", "Cambria", "Cambria Math", "Courier New", "Candara", "Georgia", "Impact", "Segoe Print", "Segoe Script", "Segoe UI", "Symbol", "Times New Roman", "Verdana", "Windings" };
}
@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Clipboard").Collections(collection =>
        {
            collection.Items(items =>
            {
                items.Type(RibbonItemType.ComboBox).ComboBoxSettings(comboBox =>
                {
                    comboBox.DataSource(fontStyle).Index(2).BeforeOpen("function(args){beforeOpenEvent(args)}");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function beforeOpenEvent(args) {
        // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

## DropDown item events

### Before close

The [BeforeClose](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.RibbonDropDownSettings.html#Syncfusion_EJ2_Ribbon_RibbonDropDownSettings_BeforeClose) event is triggered before closing the DropdownButton popup.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<MenuItem> tableOptions = new List<MenuItem>() { new MenuItem { Text = "Insert Table" }, new MenuItem { Text = "This device" }, new MenuItem { Text = "Convert Table" }, new MenuItem { Text = "Excel SpreadSheet" } };
}
@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Tables").Collections(collection =>
        {
            collection.Items(items =>
            {
                items.Type(RibbonItemType.DropDown).DropDownSettings(dropDown =>
                {
                    dropDown.IconCss("e-icons e-table").Content("Table").Items(tableOptions).BeforeClose("function(args){beforeCloseEvent(args)}");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function beforeCloseEvent(args) {
        // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

### Before open

The [BeforeOpen](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.RibbonDropDownSettings.html#Syncfusion_EJ2_Ribbon_RibbonDropDownSettings_BeforeOpen) event is triggered before opening the Dropdown button popup.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<MenuItem> tableOptions = new List<MenuItem>() { new MenuItem { Text = "Insert Table" }, new MenuItem { Text = "This device" }, new MenuItem { Text = "Convert Table" }, new MenuItem { Text = "Excel SpreadSheet" } };
}
@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Tables").Collections(collection =>
        {
            collection.Items(items =>
            {
                items.Type(RibbonItemType.DropDown).DropDownSettings(dropDown =>
                {
                    dropDown.IconCss("e-icons e-table").Content("Table").Items(tableOptions).BeforeOpen("function(args){beforeOpenEvent(args)}");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function beforeOpenEvent(args) {
        // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

### Before item render

The [BeforeItemRender](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.RibbonDropDownSettings.html#Syncfusion_EJ2_Ribbon_RibbonDropDownSettings_BeforeItemRender) event is triggered while rendering each popup item of the Dropdown button.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<MenuItem> tableOptions = new List<MenuItem>() { new MenuItem { Text = "Insert Table" }, new MenuItem { Text = "This device" }, new MenuItem { Text = "Convert Table" }, new MenuItem { Text = "Excel SpreadSheet" } };
}
@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Tables").Collections(collection =>
        {
            collection.Items(items =>
            {
                items.Type(RibbonItemType.DropDown).DropDownSettings(dropDown =>
                {
                    dropDown.IconCss("e-icons e-table").Content("Table").Items(tableOptions).BeforeItemRender("function(args){beforeItemRenderEvent(args)}");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function beforeItemRenderEvent(args) {
        // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

### Open

The [Open](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.RibbonDropDownSettings.html#Syncfusion_EJ2_Ribbon_RibbonDropDownSettings_Open) event is triggered while opening the Dropdown button popup.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<MenuItem> tableOptions = new List<MenuItem>() { new MenuItem { Text = "Insert Table" }, new MenuItem { Text = "This device" }, new MenuItem { Text = "Convert Table" }, new MenuItem { Text = "Excel SpreadSheet" } };
}
@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Tables").Collections(collection =>
        {
            collection.Items(items =>
            {
                items.Type(RibbonItemType.DropDown).DropDownSettings(dropDown =>
                {
                    dropDown.IconCss("e-icons e-table").Content("Table").Items(tableOptions).Open("function(args){openEvent(args)}");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function openEvent(args) {
        // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

### Close

The [Close](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.RibbonDropDownSettings.html#Syncfusion_EJ2_Ribbon_RibbonDropDownSettings_Close) event is triggered while closing the Dropdown button popup.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<MenuItem> tableOptions = new List<MenuItem>() { new MenuItem { Text = "Insert Table" }, new MenuItem { Text = "This device" }, new MenuItem { Text = "Convert Table" }, new MenuItem { Text = "Excel SpreadSheet" } };
}
@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Tables").Collections(collection =>
        {
            collection.Items(items =>
            {
                items.Type(RibbonItemType.DropDown).DropDownSettings(dropDown =>
                {
                    dropDown.IconCss("e-icons e-table").Content("Table").Items(tableOptions).Close("function(args){closeEvent(args)}");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function closeEvent(args) {
        // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

### Created

The [Created](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.RibbonDropDownSettings.html#Syncfusion_EJ2_Ribbon_RibbonDropDownSettings_Created) event is triggered when the DropDown is created.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<MenuItem> tableOptions = new List<MenuItem>() { new MenuItem { Text = "Insert Table" }, new MenuItem { Text = "This device" }, new MenuItem { Text = "Convert Table" }, new MenuItem { Text = "Excel SpreadSheet" } };
}
@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Tables").Collections(collection =>
        {
            collection.Items(items =>
            {
                items.Type(RibbonItemType.DropDown).DropDownSettings(dropDown =>
                {
                    dropDown.IconCss("e-icons e-table").Content("Table").Items(tableOptions).Created("function(args){createdEvent(args)}");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function createdEvent(args) {
        // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

### Select

The [Select](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.RibbonDropDownSettings.html#Syncfusion_EJ2_Ribbon_RibbonDropDownSettings_Select) event is triggered while selecting an action item in the Dropdown button popup.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<MenuItem> tableOptions = new List<MenuItem>() { new MenuItem { Text = "Insert Table" }, new MenuItem { Text = "This device" }, new MenuItem { Text = "Convert Table" }, new MenuItem { Text = "Excel SpreadSheet" } };
}
@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Tables").Collections(collection =>
        {
            collection.Items(items =>
            {
                items.Type(RibbonItemType.DropDown).DropDownSettings(dropDown =>
                {
                    dropDown.IconCss("e-icons e-table").Content("Table").Items(tableOptions).Select("function(args){selectEvent(args)}");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function selectEvent(args) {
        // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

## SplitButton item events

### Before close

The [BeforeClose](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.RibbonSplitButtonSettings.html#Syncfusion_EJ2_Ribbon_RibbonSplitButtonSettings_BeforeClose) event is triggered before closing the SplitButton popup.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations


@{
    List<MenuItem> pasteOptions = new List<MenuItem>() { new MenuItem { Text = "Keep Source Format" }, new MenuItem { Text = "Merge format" }, new MenuItem { Text = "Keep text only" } };
}
@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Clipboard").Collections(collection =>
        {
            collection.Items(items =>
            {
                items.Type(RibbonItemType.SplitButton).SplitButtonSettings(splitButton =>
                {
                    splitButton.IconCss("e-icons e-paste").Items(pasteOptions).Content("Paste").BeforeClose("function(args){beforeCloseEvent(args)}");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function beforeCloseEvent(args) {
        // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

### Before open

The [BeforeOpen](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.RibbonSplitButtonSettings.html#Syncfusion_EJ2_Ribbon_RibbonSplitButtonSettings_BeforeOpen) event is triggered before opening the SplitButton popup.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations


@{
    List<MenuItem> pasteOptions = new List<MenuItem>() { new MenuItem { Text = "Keep Source Format" }, new MenuItem { Text = "Merge format" }, new MenuItem { Text = "Keep text only" } };
}
@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Clipboard").Collections(collection =>
        {
            collection.Items(items =>
            {
                items.Type(RibbonItemType.SplitButton).SplitButtonSettings(splitButton =>
                {
                    splitButton.IconCss("e-icons e-paste").Items(pasteOptions).Content("Paste").BeforeOpen("function(args){beforeOpenEvent(args)}");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function beforeOpenEvent(args) {
        // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

### Before item render

The [BeforeItemRender](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.RibbonSplitButtonSettings.html#Syncfusion_EJ2_Ribbon_RibbonSplitButtonSettings_BeforeItemRender) event is triggered while rendering each popup item of SplitButton.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations


@{
    List<MenuItem> pasteOptions = new List<MenuItem>() { new MenuItem { Text = "Keep Source Format" }, new MenuItem { Text = "Merge format" }, new MenuItem { Text = "Keep text only" } };
}
@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Clipboard").Collections(collection =>
        {
            collection.Items(items =>
            {
                items.Type(RibbonItemType.SplitButton).SplitButtonSettings(splitButton =>
                {
                    splitButton.IconCss("e-icons e-paste").Items(pasteOptions).Content("Paste").BeforeItemRender("function(args){beforeItemRenderEvent(args)}");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function beforeItemRenderEvent(args) {
        // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

### Open

The [Open](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.RibbonSplitButtonSettings.html#Syncfusion_EJ2_Ribbon_RibbonSplitButtonSettings_Open) event is triggered while opening the SplitButton popup.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations


@{
    List<MenuItem> pasteOptions = new List<MenuItem>() { new MenuItem { Text = "Keep Source Format" }, new MenuItem { Text = "Merge format" }, new MenuItem { Text = "Keep text only" } };
}
@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Clipboard").Collections(collection =>
        {
            collection.Items(items =>
            {
                items.Type(RibbonItemType.SplitButton).SplitButtonSettings(splitButton =>
                {
                    splitButton.IconCss("e-icons e-paste").Items(pasteOptions).Content("Paste").Open("function(args){openEvent(args)}");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function openEvent(args) {
        // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

### Close

The [Close](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.RibbonSplitButtonSettings.html#Syncfusion_EJ2_Ribbon_RibbonSplitButtonSettings_Close) event is triggered while closing the SplitButton popup.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations


@{
    List<MenuItem> pasteOptions = new List<MenuItem>() { new MenuItem { Text = "Keep Source Format" }, new MenuItem { Text = "Merge format" }, new MenuItem { Text = "Keep text only" } };
}
@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Clipboard").Collections(collection =>
        {
            collection.Items(items =>
            {
                items.Type(RibbonItemType.SplitButton).SplitButtonSettings(splitButton =>
                {
                    splitButton.IconCss("e-icons e-paste").Items(pasteOptions).Content("Paste").Close("function(args){closeEvent(args)}");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function closeEvent(args) {
        // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

### Created

The [Created](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.RibbonSplitButtonSettings.html#Syncfusion_EJ2_Ribbon_RibbonSplitButtonSettings_Created) event is triggered when the SplitButton is created.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations


@{
    List<MenuItem> pasteOptions = new List<MenuItem>() { new MenuItem { Text = "Keep Source Format" }, new MenuItem { Text = "Merge format" }, new MenuItem { Text = "Keep text only" } };
}
@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Clipboard").Collections(collection =>
        {
            collection.Items(items =>
            {
                items.Type(RibbonItemType.SplitButton).SplitButtonSettings(splitButton =>
                {
                    splitButton.IconCss("e-icons e-paste").Items(pasteOptions).Content("Paste").Created("function(args){createdEvent(args)}");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function createdEvent(args) {
        // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

### Select

The [Select](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.RibbonSplitButtonSettings.html#Syncfusion_EJ2_Ribbon_RibbonSplitButtonSettings_Select) event is triggered while selecting an action item in the SplitButton popup.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations


@{
    List<MenuItem> pasteOptions = new List<MenuItem>() { new MenuItem { Text = "Keep Source Format" }, new MenuItem { Text = "Merge format" }, new MenuItem { Text = "Keep text only" } };
}
@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Clipboard").Collections(collection =>
        {
            collection.Items(items =>
            {
                items.Type(RibbonItemType.SplitButton).SplitButtonSettings(splitButton =>
                {
                    splitButton.IconCss("e-icons e-paste").Items(pasteOptions).Content("Paste").Select("function(args){selectEvent(args)}");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function selectEvent(args) {
        // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

### Click

The [Click](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.RibbonSplitButtonSettings.html#Syncfusion_EJ2_Ribbon_RibbonSplitButtonSettings_Click) event is triggered while clicking the primary button in the SplitButton.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations


@{
    List<MenuItem> pasteOptions = new List<MenuItem>() { new MenuItem { Text = "Keep Source Format" }, new MenuItem { Text = "Merge format" }, new MenuItem { Text = "Keep text only" } };
}
@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Clipboard").Collections(collection =>
        {
            collection.Items(items =>
            {
                items.Type(RibbonItemType.SplitButton).SplitButtonSettings(splitButton =>
                {
                    splitButton.IconCss("e-icons e-paste").Items(pasteOptions).Content("Paste").Click("function(args){clickEvent(args)}");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function clickEvent(args) {
        // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

## GroupButton item events

### BeforeClick

The [BeforeClick](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonGroupButtonItem.html#Syncfusion_EJ2_Ribbon_RibbonGroupButtonItem_BeforeClick) event is triggered before selecting a button from the GroupButton items.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<RibbonGroupButtonItem> events = new List<RibbonGroupButtonItem>() {

      new RibbonGroupButtonItem { IconCss = "e-icons e-bold", Content = "Bold", BeforeClick = "function(args){beforClickEvent(args)}" },
      new RibbonGroupButtonItem {IconCss = "e-icons e-italic", Content = "Italic", Selected = true, BeforeClick = "function(args){beforClickEvent(args)}" },
      new RibbonGroupButtonItem {IconCss = "e-icons e-underline", Content = "Underline", BeforeClick = "function(args){beforClickEvent(args)}" },
      new RibbonGroupButtonItem { IconCss = "e-icons e-strikethrough", Content = "Strikethrough", BeforeClick = "function(args){beforClickEvent(args)}" }
    };
}


@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Paragraph").Collections(collection =>
        {
            collection.Items(items =>
            {
                items.Type(RibbonItemType.GroupButton).AllowedSizes(RibbonItemSize.Small).GroupButtonSettings(groupButton =>
                {
                    groupButton.Selection(RibbonGroupButtonSelection.Multiple).Items(events);
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function beforClickEvent(args) {
        // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

### Click

The [Click](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonGroupButtonItem.html#Syncfusion_EJ2_Ribbon_RibbonGroupButtonItem_Click) event is triggered when selecting a button from the GroupButton items.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<RibbonGroupButtonItem> events = new List<RibbonGroupButtonItem>() {

      new RibbonGroupButtonItem { IconCss = "e-icons e-align-left", Content = "Align Left", Click = "function(args){clickEvent(args)}" },
      new RibbonGroupButtonItem {IconCss = "e-icons e-align-center", Content = "Align Center", Click = "function(args){clickEvent(args)}", Selected = true },
      new RibbonGroupButtonItem {IconCss = "e-icons e-align-right", Content = "Align Right", Click = "function(args){clickEvent(args)}" },
      new RibbonGroupButtonItem { IconCss = "e-icons e-justify", Content = "Justify", Click = "function(args){clickEvent(args)}" }
    };
}


@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Paragraph").Collections(collection =>
        {
            collection.Items(items =>
            {
                items.Type(RibbonItemType.GroupButton).AllowedSizes(RibbonItemSize.Small).GroupButtonSettings(groupButton =>
                {
                    groupButton.Selection(RibbonGroupButtonSelection.Single).Items(events);
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function clickEvent(args) {
        // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

## FileMenu events

### Before close

The [BeforeClose](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.FileMenuSettings.html#Syncfusion_EJ2_Ribbon_FileMenuSettings_BeforeClose) event is triggered before closing the FileMenu popup.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<MenuItem> fileOptions = new List<MenuItem>()
{
        new MenuItem { Text = "New", IconCss = "e-icons e-file-new" },
        new MenuItem { Text = "Open", IconCss = "e-icons e-folder-open", Id="open" },
        new MenuItem { Text = "Rename", IconCss = "e-icons e-rename", Id="rename" },
        new MenuItem { Text = "Save as", IconCss = "e-icons e-save", Id="save" }
    };
}
@Html.EJS().Ribbon("ribbon").FileMenu(file =>
{
    file.Visible(true).MenuItems(fileOptions).BeforeClose("function(args){beforeCloseEvent(args)}");
}).Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Clipboard").Collections(collection =>
        {
            collection.Items(items =>
            {
                items.Type(RibbonItemType.Button).ButtonSettings(button =>
                {
                    button.IconCss("e-icons e-cut").Content("Cut");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function beforeCloseEvent(args) {
        // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

### Before open

The [BeforeOpen](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.FileMenuSettings.html#Syncfusion_EJ2_Ribbon_FileMenuSettings_BeforeOpen) event is triggered before opening the FileMenu popup.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<MenuItem> fileOptions = new List<MenuItem>()
{
        new MenuItem { Text = "New", IconCss = "e-icons e-file-new" },
        new MenuItem { Text = "Open", IconCss = "e-icons e-folder-open", Id="open" },
        new MenuItem { Text = "Rename", IconCss = "e-icons e-rename", Id="rename" },
        new MenuItem { Text = "Save as", IconCss = "e-icons e-save", Id="save" }
    };
}
@Html.EJS().Ribbon("ribbon").FileMenu(file =>
{
    file.Visible(true).MenuItems(fileOptions).BeforeOpen("function(args){beforeOpenEvent(args)}");
}).Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Clipboard").Collections(collection =>
        {
            collection.Items(items =>
            {
                items.Type(RibbonItemType.Button).ButtonSettings(button =>
                {
                    button.IconCss("e-icons e-cut").Content("Cut");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function beforeOpenEvent(args) {
        // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

### Before item render

The [BeforeItemRender](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.FileMenuSettings.html#Syncfusion_EJ2_Ribbon_FileMenuSettings_BeforeItemRender) event is triggered while rendering each ribbon FileMenu item.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<MenuItem> fileOptions = new List<MenuItem>()
{
        new MenuItem { Text = "New", IconCss = "e-icons e-file-new" },
        new MenuItem { Text = "Open", IconCss = "e-icons e-folder-open", Id="open" },
        new MenuItem { Text = "Rename", IconCss = "e-icons e-rename", Id="rename" },
        new MenuItem { Text = "Save as", IconCss = "e-icons e-save", Id="save" }
    };
}
@Html.EJS().Ribbon("ribbon").FileMenu(file =>
{
    file.Visible(true).MenuItems(fileOptions).BeforeItemRender("function(args){beforeItemRenderEvent(args)}");
}).Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Clipboard").Collections(collection =>
        {
            collection.Items(items =>
            {
                items.Type(RibbonItemType.Button).ButtonSettings(button =>
                {
                    button.IconCss("e-icons e-cut").Content("Cut");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function beforeItemRenderEvent(args) {
        // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

### Open

The [Open](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.FileMenuSettings.html#Syncfusion_EJ2_Ribbon_FileMenuSettings_Open) event is triggered when the FileMenu popup is opened.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<MenuItem> fileOptions = new List<MenuItem>()
{
        new MenuItem { Text = "New", IconCss = "e-icons e-file-new" },
        new MenuItem { Text = "Open", IconCss = "e-icons e-folder-open", Id="open" },
        new MenuItem { Text = "Rename", IconCss = "e-icons e-rename", Id="rename" },
        new MenuItem { Text = "Save as", IconCss = "e-icons e-save", Id="save" }
    };
}
@Html.EJS().Ribbon("ribbon").FileMenu(file =>
{
    file.Visible(true).MenuItems(fileOptions).Open("function(args){openEvent(args)}");
}).Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Clipboard").Collections(collection =>
        {
            collection.Items(items =>
            {
                items.Type(RibbonItemType.Button).ButtonSettings(button =>
                {
                    button.IconCss("e-icons e-cut").Content("Cut");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function openEvent(args) {
        // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

### Close

The [Close](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.FileMenuSettings.html#Syncfusion_EJ2_Ribbon_FileMenuSettings_Close) event is triggered when FileMenu popup is closed.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<MenuItem> fileOptions = new List<MenuItem>()
{
        new MenuItem { Text = "New", IconCss = "e-icons e-file-new" },
        new MenuItem { Text = "Open", IconCss = "e-icons e-folder-open", Id="open" },
        new MenuItem { Text = "Rename", IconCss = "e-icons e-rename", Id="rename" },
        new MenuItem { Text = "Save as", IconCss = "e-icons e-save", Id="save" }
    };
}
@Html.EJS().Ribbon("ribbon").FileMenu(file =>
{
    file.Visible(true).MenuItems(fileOptions).Close("function(args){closeEvent(args)}");
}).Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Clipboard").Collections(collection =>
        {
            collection.Items(items =>
            {
                items.Type(RibbonItemType.Button).ButtonSettings(button =>
                {
                    button.IconCss("e-icons e-cut").Content("Cut");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function closeEvent(args) {
        // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

### Select

The [Select](https://help.syncfusion.com/cr/aspnetMVC-js2/Syncfusion.EJ2.Ribbon.FileMenuSettings.html#Syncfusion_EJ2_Ribbon_FileMenuSettings_Select) event is triggered while selecting an item in the ribbon FileMenu.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<MenuItem> fileOptions = new List<MenuItem>()
{
        new MenuItem { Text = "New", IconCss = "e-icons e-file-new" },
        new MenuItem { Text = "Open", IconCss = "e-icons e-folder-open", Id="open" },
        new MenuItem { Text = "Rename", IconCss = "e-icons e-rename", Id="rename" },
        new MenuItem { Text = "Save as", IconCss = "e-icons e-save", Id="save" }
    };
}
@Html.EJS().Ribbon("ribbon").FileMenu(file =>
{
    file.Visible(true).MenuItems(fileOptions).Select("function(args){selectEvent(args)}");
}).Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Clipboard").Collections(collection =>
        {
            collection.Items(items =>
            {
                items.Type(RibbonItemType.Button).ButtonSettings(button =>
                {
                    button.IconCss("e-icons e-cut").Content("Cut");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function selectEvent(args) {
        // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

## Backstage Menu events

### BackStageItemClick

The [BackStageItemClick](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.BackstageItem.html#Syncfusion_EJ2_Ribbon_BackstageItem_BackStageItemClick) event is triggered when backstage item is selected.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<BackstageItem> backstageItems = new List<BackstageItem>() {
        new BackstageItem { Id = "home", Text = "Home", IconCss = "e-icons e-home", Content = processBackstageContent("home"), BackStageItemClick = backStageItemClickEvent(args) },
    };
    BackStageMenu backstageSettings = new BackStageMenu() { Text = "File", Visible = true, BackButton = new BackstageBackButton { Text = "Close" }, Items = backstageItems };
}
@Html.EJS().Ribbon("backstage-ribbon").BackStageMenu(backstageSettings)).Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Clipboard").Collections(collection =>
        {
            collection.Items(items =>
            {
                items.Type(RibbonItemType.Button).ButtonSettings(button =>
                {
                    button.IconCss("e-icons e-cut").Content("Cut");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function backStageItemClickEvent(args) {
        // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

## Gallery events

### popupOpen

The [PopupOpen](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonGallerySettings.html#Syncfusion_EJ2_Ribbon_RibbonGallerySettings_PopupOpen) event is triggered when the gallery popup opens.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
  tab.Header("Home").Groups(group =>

  {
    group.Header("Gallery").Collections(collections =>
    {
      collections.Items(items =>
      {
        items.Type(RibbonItemType.Gallery).GallerySettings(gallery =>
        {
          gallery.PopupOpen("popupOpen").Groups(galleryGroups =>
          {
            galleryGroups.Header("Styles").Items(galleryItems =>
            {
              galleryItems.Content("Normal").Add();
              galleryItems.Content("No Spacing").Add();
              galleryItems.Content("Heading 1").Add();
              galleryItems.Content("Heading 2").Add();
            }).Add();
          });
        }).Add();
      }).Add();
    }).Add();
  }).Add();
}).Render()

<script>
  function popupOpen() {
    // Your required action here
  }
</script>


{% endhighlight %}
{% endtabs %}

### popupClose

The [PopupClose](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonGallerySettings.html#Syncfusion_EJ2_Ribbon_RibbonGallerySettings_PopupClose) event is triggered when the gallery popup closes.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
  tab.Header("Home").Groups(group =>

  {
    group.Header("Gallery").Collections(collections =>
    {
      collections.Items(items =>
      {
        items.Type(RibbonItemType.Gallery).GallerySettings(gallery =>
        {
          gallery.PopupClose("popupClose").Groups(galleryGroups =>
          {
            galleryGroups.Header("Styles").Items(galleryItems =>
            {
              galleryItems.Content("Normal").Add();
              galleryItems.Content("No Spacing").Add();
              galleryItems.Content("Heading 1").Add();
              galleryItems.Content("Heading 2").Add();
            }).Add();
          });
        }).Add();
      }).Add();
    }).Add();
  }).Add();
}).Render()

<script>
  function popupClose() {
    // Your required action here
  }
</script>

`
{% endhighlight %}
{% endtabs %}

### itemHover

The [ItemHover](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonGallerySettings.html#Syncfusion_EJ2_Ribbon_RibbonGallerySettings_ItemHover) event is triggered when hover over the gallery item.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
  tab.Header("Home").Groups(group =>

  {
    group.Header("Gallery").Collections(collections =>
    {
      collections.Items(items =>
      {
        items.Type(RibbonItemType.Gallery).GallerySettings(gallery =>
        {
          gallery.ItemHover("itemHover").Groups(galleryGroups =>
          {
            galleryGroups.Header("Styles").Items(galleryItems =>
            {
              galleryItems.Content("Normal").Add();
              galleryItems.Content("No Spacing").Add();
              galleryItems.Content("Heading 1").Add();
              galleryItems.Content("Heading 2").Add();
            }).Add();
          });
        }).Add();
      }).Add();
    }).Add();
  }).Add();
}).Render()

<script>
  function itemHover() {
    // Your required action here
  }
</script>


{% endhighlight %}
{% endtabs %}

### beforeItemRender

The [BeforeItemRender](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonGallerySettings.html#Syncfusion_EJ2_Ribbon_RibbonGallerySettings_BeforeItemRender) event is triggered while rendering each gallery item.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
  tab.Header("Home").Groups(group =>

  {
    group.Header("Gallery").Collections(collections =>
    {
      collections.Items(items =>
      {
        items.Type(RibbonItemType.Gallery).GallerySettings(gallery =>
        {
          gallery.BeforeItemRender("beforeItemRender").Groups(galleryGroups =>
          {
            galleryGroups.Header("Styles").Items(galleryItems =>
            {
              galleryItems.Content("Normal").Add();
              galleryItems.Content("No Spacing").Add();
              galleryItems.Content("Heading 1").Add();
              galleryItems.Content("Heading 2").Add();
            }).Add();
          });
        }).Add();
      }).Add();
    }).Add();
  }).Add();
}).Render()

<script>
  function beforeItemRender() {
    // Your required action here
  }
</script>


{% endhighlight %}
{% endtabs %}

### beforeSelect

The [BeforeSelect](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonGallerySettings.html#Syncfusion_EJ2_Ribbon_RibbonGallerySettings_BeforeSelect) event is triggered before selecting an item in the Ribbon gallery.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
  tab.Header("Home").Groups(group =>

  {
    group.Header("Gallery").Collections(collections =>
    {
      collections.Items(items =>
      {
        items.Type(RibbonItemType.Gallery).GallerySettings(gallery =>
        {
          gallery.BeforeSelect("beforeSelect").Groups(galleryGroups =>
          {
            galleryGroups.Header("Styles").Items(galleryItems =>
            {
              galleryItems.Content("Normal").Add();
              galleryItems.Content("No Spacing").Add();
              galleryItems.Content("Heading 1").Add();
              galleryItems.Content("Heading 2").Add();
            }).Add();
          });
        }).Add();
      }).Add();
    }).Add();
  }).Add();
}).Render()

<script>
  function beforeSelect() {
    // Your required action here
  }
</script>


{% endhighlight %}
{% endtabs %}

### select

The [Select](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonGallerySettings.html#Syncfusion_EJ2_Ribbon_RibbonGallerySettings_Select) event is triggered while selecting an item in the Ribbon Gallery.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
  tab.Header("Home").Groups(group =>

  {
    group.Header("Gallery").Collections(collections =>
    {
      collections.Items(items =>
      {
        items.Type(RibbonItemType.Gallery).GallerySettings(gallery =>
        {
          gallery.Select("select").Groups(galleryGroups =>
          {
            galleryGroups.Header("Styles").Items(galleryItems =>
            {
              galleryItems.Content("Normal").Add();
              galleryItems.Content("No Spacing").Add();
              galleryItems.Content("Heading 1").Add();
              galleryItems.Content("Heading 2").Add();
            }).Add();
          });
        }).Add();
      }).Add();
    }).Add();
  }).Add();
}).Render()

<script>
  function select() {
    // Your required action here
  }
</script>


{% endhighlight %}
{% endtabs %}