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

The [tabSelected](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.Ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_TabSelected) event is triggered after selecting the tab item.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

<ejs-ribbon id="ribbon" tabSelected="tabSelectedEvent">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Clipboard">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type=Button>
                                    <e-ribbon-buttonsettings iconCss="e-icons e-cut" content="Cut"></e-ribbon-buttonsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
        <e-ribbon-tab header="View">
            <e-ribbon-groups>
                <e-ribbon-group header="Views">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type=Button>
                                    <e-ribbon-buttonsettings iconCss="e-icons e-print" content="Print Layout"></e-ribbon-buttonsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>

    function tabSelectedEvent(args) {
        // Here, you can customize your code.
    }

</script>

{% endhighlight %}
{% endtabs %}

## Tab selecting

The [`tabSelecting`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.Ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_TabSelecting) event is triggered before selecting the tab item.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

<ejs-ribbon id="ribbon" tabSelecting="tabSelectingEvent">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Clipboard">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type=Button>
                                    <e-ribbon-buttonsettings iconCss="e-icons e-cut" content="Cut"></e-ribbon-buttonsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
        <e-ribbon-tab header="View">
            <e-ribbon-groups>
                <e-ribbon-group header="Views">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type=Button>
                                    <e-ribbon-buttonsettings iconCss="e-icons e-print" content="Print Layout"></e-ribbon-buttonsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>

    function tabSelectingEvent(args) {
        // Here, you can customize your code.
    }

</script>

{% endhighlight %}
{% endtabs %}

## Ribbon collapsing

The [ribbonCollapsing](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.Ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_RibbonCollapsing) event is triggered before collapsing the ribbon.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

<ejs-ribbon id="ribbon" ribbonCollapsing="ribbonCollapsingEvent">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Clipboard">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type=Button>
                                    <e-ribbon-buttonsettings iconCss="e-icons e-cut" content="Cut"></e-ribbon-buttonsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>

    function ribbonCollapsingEvent(args) {
        // Here, you can customize your code.
    }

</script>

{% endhighlight %}
{% endtabs %}

## Ribbon expanding

The [ribbonExpanding](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.Ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_RibbonExpanding) event is triggered before expanding the ribbon.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

<ejs-ribbon id="ribbon" ribbonExpanding="ribbonExpandingEvent">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Clipboard">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type=Button>
                                    <e-ribbon-buttonsettings iconCss="e-icons e-cut" content="Cut"></e-ribbon-buttonsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>

    function ribbonExpandingEvent(args) {
        // Here, you can customize your code.
    }

</script>

{% endhighlight %}
{% endtabs %}

## Group launcher click

The [launcherIconClick](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.Ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_LauncherIconClick) event is triggered when the launcher icon of the group is clicked.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

<ejs-ribbon id="ribbon" launcherIconClick="launcherIconClickEvent">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Clipboard" showLauncherIcon=true>
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type=Button>
                                    <e-ribbon-buttonsettings iconCss="e-icons e-cut" content="Cut"></e-ribbon-buttonsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>

    function launcherIconClickEvent(args) {
        // Here, you can customize your code.
    }

</script>

{% endhighlight %}
{% endtabs %}

## Overflow popup open

The [overflowPopupOpen](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.Ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_OverflowPopupOpen) event is triggered while opening the overflow popup.

## Overflow popup close

The [overflowPopupClose](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.Ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_OverflowPopupClose) event is triggered while closing the overflow popup.

The following code example demonstrates the ribbon rendered with `overflowPopupOpen` and `overflowPopupClose` events.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

<ejs-ribbon id="ribbon" overflowPopupOpen="overflowPopupOpen" overflowPopupClose="overflowPopupClose" activelayout="Simplified">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Clipboard">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type=Button>
                                    <e-ribbon-buttonsettings iconCss="e-icons e-cut" content="Cut"></e-ribbon-buttonsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

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

The [clicked](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonButtonSettings.html#Syncfusion_EJ2_Ribbon_RibbonButtonSettings_Clicked) event is triggered when the button is clicked.

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
                                    <e-ribbon-buttonsettings iconCss="e-icons e-cut" content="Cut" clicked="clickedEvent"></e-ribbon-buttonsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>

    function clickedEvent() {
        // Here, you can customize your code.
    }

</script>

{% endhighlight %}
{% endtabs %}

### Created

The [created](../api/ribbon/ribbonButtonSettings/#created) event is triggered when the button is created.

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
                                    <e-ribbon-buttonsettings iconCss="e-icons e-cut" content="Cut" created="createdEvent"></e-ribbon-buttonsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>

    function createdEvent() {
        // Here, you can customize your code.
    }

</script>

{% endhighlight %}
{% endtabs %}

## Checkbox item events

### Change

The [change](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonCheckBoxSettings.html#Syncfusion_EJ2_Ribbon_RibbonCheckBoxSettings_Change) event is triggered when the Checkbox state is changed.

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
                                    <e-ribbon-checkboxsettings checked=false label="Ruler" change="changeEvent"></e-ribbon-checkboxsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>

    function changeEvent() {
        // Here, you can customize your code.
    }

</script>

{% endhighlight %}
{% endtabs %}

### Created

The [created](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonCheckBoxSettings.html#Syncfusion_EJ2_Ribbon_RibbonCheckBoxSettings_Created) event is triggered once the Checkbox is created.

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
                                    <e-ribbon-checkboxsettings checked=false label="Ruler" created="createdEvent"></e-ribbon-checkboxsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>

    function createdEvent() {
        // Here, you can customize your code.
    }

</script>

{% endhighlight %}
{% endtabs %}

## Colorpicker item events

### Change

The [change](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonColorPickerSettings.html#Syncfusion_EJ2_Ribbon_RibbonColorPickerSettings_Change) event is triggered while changing the colors.

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
                                <e-ribbon-item type=ColorPicker>
                                    <e-ribbon-colorpickersettings value="#fff" change="changeEvent"></e-ribbon-colorpickersettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>

    function changeEvent() {
        // Here, you can customize your code.
    }

</script>

{% endhighlight %}
{% endtabs %}

### Created

The [created](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonColorPickerSettings.html#Syncfusion_EJ2_Ribbon_RibbonColorPickerSettings_Created) event is triggered once the ColorPicker is created.

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
                                <e-ribbon-item type=ColorPicker>
                                    <e-ribbon-colorpickersettings value="#fff" created="createdEvent"></e-ribbon-colorpickersettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>

    function createdEvent() {
        // Here, you can customize your code.
    }

</script>

{% endhighlight %}
{% endtabs %}

### Open

The [open](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonColorPickerSettings.html#Syncfusion_EJ2_Ribbon_RibbonColorPickerSettings_Open) event is triggered while opening the ColorPicker popup.

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
                                <e-ribbon-item type=ColorPicker>
                                    <e-ribbon-colorpickersettings value="#fff" open="openEvent"></e-ribbon-colorpickersettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>

    function openEvent(args) {
        // Here, you can customize your code.
    }

</script>

{% endhighlight %}
{% endtabs %}

### Select

The [select](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonColorPickerSettings.html#Syncfusion_EJ2_Ribbon_RibbonColorPickerSettings_Select) event is triggered while selecting the color in picker/palette, when showButtons property is enabled.

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
                                <e-ribbon-item type=ColorPicker>
                                    <e-ribbon-colorpickersettings value="#fff" select="selectEvent"></e-ribbon-colorpickersettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>

    function selectEvent(args) {
        // Here, you can customize your code.
    }

</script>

{% endhighlight %}
{% endtabs %}

### Before close

The [beforeClose](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonColorPickerSettings.html#Syncfusion_EJ2_Ribbon_RibbonColorPickerSettings_BeforeClose) event is triggered before closing the ColorPicker popup.

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
                                <e-ribbon-item type=ColorPicker>
                                    <e-ribbon-colorpickersettings value="#fff" beforeClose="beforeCloseEvent"></e-ribbon-colorpickersettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>

    function beforeCloseEvent(args) {
        // Here, you can customize your code.
    }

</script>

{% endhighlight %}
{% endtabs %}

### Before open

The [beforeOpen](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonColorPickerSettings.html#Syncfusion_EJ2_Ribbon_RibbonColorPickerSettings_BeforeOpen) event is triggered before opening the ColorPicker popup.

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
                                <e-ribbon-item type=ColorPicker>
                                    <e-ribbon-colorpickersettings value="#fff" beforeOpen="beforeOpenEvent"></e-ribbon-colorpickersettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>

    function beforeOpenEvent(args) {
        // Here, you can customize your code.
    }

</script>

{% endhighlight %}
{% endtabs %}

### Before tile render

The [beforeTileRender](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonColorPickerSettings.html#Syncfusion_EJ2_Ribbon_RibbonColorPickerSettings_BeforeTileRender) event is triggered while rendering each palette tile.

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
                                <e-ribbon-item type=ColorPicker>
                                    <e-ribbon-colorpickersettings value="#fff" beforeTileRender="beforeTileRenderEvent"></e-ribbon-colorpickersettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>

    function beforeTileRenderEvent(args) {
        // Here, you can customize your code.
    }

</script>

{% endhighlight %}
{% endtabs %}

## ComboBox item events

### Change

The [change](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonComboBoxSettings.html#Syncfusion_EJ2_Ribbon_RibbonComboBoxSettings_Change) event is triggered when an item in a popup is selected or when the model value is changed by the user.

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
                                    <e-ribbon-comboboxsettings dataSource=fontStyle index=3 change="changeEvent"></e-ribbon-comboboxsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>

    function changeEvent() {
        // Here, you can customize your code.
    }

</script>

{% endhighlight %}
{% endtabs %}

### Close

The [close](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonComboBoxSettings.html#Syncfusion_EJ2_Ribbon_RibbonComboBoxSettings_Close) event is triggered when the popup is closed.

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
                                    <e-ribbon-comboboxsettings dataSource=fontStyle index=3 close="closeEvent"></e-ribbon-comboboxsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>

    function closeEvent(args) {
        // Here, you can customize your code.
    }

</script>

{% endhighlight %}
{% endtabs %}

### Open

The [open](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonComboBoxSettings.html#Syncfusion_EJ2_Ribbon_RibbonComboBoxSettings_Open) event is triggered when the popup is opened.

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
                                    <e-ribbon-comboboxsettings dataSource=fontStyle index=3 open="openEvent"></e-ribbon-comboboxsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>

    function openEvent(args) {
        // Here, you can customize your code.
    }

</script>

{% endhighlight %}
{% endtabs %}

### Created

The [created](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonComboBoxSettings.html#Syncfusion_EJ2_Ribbon_RibbonComboBoxSettings_Created) event is triggered once the Combobox is created.

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
                                    <e-ribbon-comboboxsettings dataSource=fontStyle index=3 created="createdEvent"></e-ribbon-comboboxsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>

    function createdEvent() {
        // Here, you can customize your code.
    }

</script>

{% endhighlight %}
{% endtabs %}

### Filtering

The [filtering](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonComboBoxSettings.html#Syncfusion_EJ2_Ribbon_RibbonComboBoxSettings_Filtering) event triggers on typing a character in the Combobox.

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
                                    <e-ribbon-comboboxsettings dataSource=fontStyle index=3 allowFiltering="true" filtering="filteringEvent"></e-ribbon-comboboxsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>

    function filteringEvent(args) {
        // Here, you can customize your code.
    }

</script>

{% endhighlight %}
{% endtabs %}

### Select

The [select](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonComboBoxSettings.html#Syncfusion_EJ2_Ribbon_RibbonComboBoxSettings_Select) event is triggered when an item in the popup is selected.

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
                                    <e-ribbon-comboboxsettings dataSource=fontStyle index=3 select="selectEvent"></e-ribbon-comboboxsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>

    function selectEvent(args) {
        // Here, you can customize your code.
    }

</script>

{% endhighlight %}
{% endtabs %}

### Before open

The [beforeOpen](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonComboBoxSettings.html#Syncfusion_EJ2_Ribbon_RibbonComboBoxSettings_BeforeOpen) event triggers before opening the popup.

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
                                    <e-ribbon-comboboxsettings dataSource=fontStyle index=3 beforeOpen="beforeOpenEvent"></e-ribbon-comboboxsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>

    function beforeOpenEvent(args) {
        // Here, you can customize your code.
    }

</script>

{% endhighlight %}
{% endtabs %}

## DropDown item events

### Before close

The [beforeClose](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonDropDownSettings.html#Syncfusion_EJ2_Ribbon_RibbonDropDownSettings_BeforeClose) event is triggered before closing the DropdownButton popup.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<MenuItem> headerOptions = new List<MenuItem>() { new MenuItem { Text = "Insert Header" }, new MenuItem { Text = "Edit Header" }, new MenuItem { Text = "Remove Header" } };
}

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Header & Footer">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type=DropDown>
                                    <e-ribbon-dropdownsettings iconCss="e-icons e-header" content="Header" items="headerOptions" beforeClose="beforeCloseEvent"></e-ribbon-dropdownsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>

    function beforeCloseEvent(args) {
        // Here, you can customize your code.
    }

</script>

{% endhighlight %}
{% endtabs %}

### Before open

The [beforeOpen](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonDropDownSettings.html#Syncfusion_EJ2_Ribbon_RibbonDropDownSettings_BeforeOpen) event is triggered before opening the Dropdown button popup.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<MenuItem> headerOptions = new List<MenuItem>() { new MenuItem { Text = "Insert Header" }, new MenuItem { Text = "Edit Header" }, new MenuItem { Text = "Remove Header" } };
}

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Header & Footer">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type=DropDown>
                                    <e-ribbon-dropdownsettings iconCss="e-icons e-header" content="Header" items="headerOptions" beforeOpen="beforeOpenEvent"></e-ribbon-dropdownsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>

    function beforeOpenEvent(args) {
        // Here, you can customize your code.
    }

</script>

{% endhighlight %}
{% endtabs %}

### Before item render

The [beforeItemRender](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonDropDownSettings.html#Syncfusion_EJ2_Ribbon_RibbonDropDownSettings_BeforeItemRender) event is triggered while rendering each popup item of the Dropdown button.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<MenuItem> headerOptions = new List<MenuItem>() { new MenuItem { Text = "Insert Header" }, new MenuItem { Text = "Edit Header" }, new MenuItem { Text = "Remove Header" } };
}

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Header & Footer">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type=DropDown>
                                    <e-ribbon-dropdownsettings iconCss="e-icons e-header" content="Header" items="headerOptions" beforeItemRender="beforeItemRenderEvent"></e-ribbon-dropdownsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>

    function beforeItemRenderEvent(args) {
        // Here, you can customize your code.
    }

</script>

{% endhighlight %}
{% endtabs %}

### Open

The [open](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonDropDownSettings.html#Syncfusion_EJ2_Ribbon_RibbonDropDownSettings_Open) event is triggered while opening the Dropdown button popup.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<MenuItem> headerOptions = new List<MenuItem>() { new MenuItem { Text = "Insert Header" }, new MenuItem { Text = "Edit Header" }, new MenuItem { Text = "Remove Header" } };
}

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Header & Footer">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type=DropDown>
                                    <e-ribbon-dropdownsettings iconCss="e-icons e-header" content="Header" items="headerOptions" open="openEvent"></e-ribbon-dropdownsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>

    function openEvent(args) {
        // Here, you can customize your code.
    }

</script>

{% endhighlight %}
{% endtabs %}

### Close

The [close](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonDropDownSettings.html#Syncfusion_EJ2_Ribbon_RibbonDropDownSettings_Close) event is triggered while closing the Dropdown button popup.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<MenuItem> headerOptions = new List<MenuItem>() { new MenuItem { Text = "Insert Header" }, new MenuItem { Text = "Edit Header" }, new MenuItem { Text = "Remove Header" } };
}

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Header & Footer">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type=DropDown>
                                    <e-ribbon-dropdownsettings iconCss="e-icons e-header" content="Header" items="headerOptions" close="closeEvent"></e-ribbon-dropdownsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>

    function closeEvent(args) {
        // Here, you can customize your code.
    }

</script>

{% endhighlight %}
{% endtabs %}

### Created

The [created](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonDropDownSettings.html#Syncfusion_EJ2_Ribbon_RibbonDropDownSettings_Created) event is triggered when the DropDown is created.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<MenuItem> headerOptions = new List<MenuItem>() { new MenuItem { Text = "Insert Header" }, new MenuItem { Text = "Edit Header" }, new MenuItem { Text = "Remove Header" } };
}

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Header & Footer">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type=DropDown>
                                    <e-ribbon-dropdownsettings iconCss="e-icons e-header" content="Header" items="headerOptions" created="createdEvent"></e-ribbon-dropdownsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>

    function createdEvent() {
        // Here, you can customize your code.
    }

</script>

{% endhighlight %}
{% endtabs %}

### Select

The [select](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonDropDownSettings.html#Syncfusion_EJ2_Ribbon_RibbonDropDownSettings_Select) event is triggered while selecting an action item in the Dropdown button popup.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<MenuItem> headerOptions = new List<MenuItem>() { new MenuItem { Text = "Insert Header" }, new MenuItem { Text = "Edit Header" }, new MenuItem { Text = "Remove Header" } };
}

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Header & Footer">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type=DropDown>
                                    <e-ribbon-dropdownsettings iconCss="e-icons e-header" content="Header" items="headerOptions" select="selectEvent"></e-ribbon-dropdownsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>

    function selectEvent(args) {
        // Here, you can customize your code.
    }

</script>

{% endhighlight %}
{% endtabs %}

## SplitButton item events

### Before close

The [beforeClose](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonSplitButtonSettings.html#Syncfusion_EJ2_Ribbon_RibbonSplitButtonSettings_BeforeClose) event is triggered before closing the SplitButton popup.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<MenuItem> headerOptions = new List<MenuItem>() { new MenuItem { Text = "Insert Header" }, new MenuItem { Text = "Edit Header" }, new MenuItem { Text = "Remove Header" } };
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
                                    <e-ribbon-splitbuttonsettings iconCss="e-icons e-paste" content="Paste" items=headerOptions beforeClose="beforeCloseEvent"></e-ribbon-splitbuttonsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>

    function beforeCloseEvent(args) {
        // Here, you can customize your code.
    }

</script>

{% endhighlight %}
{% endtabs %}

### Before open

The [beforeOpen](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonSplitButtonSettings.html#Syncfusion_EJ2_Ribbon_RibbonSplitButtonSettings_BeforeOpen) event is triggered before opening the SplitButton popup.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<MenuItem> headerOptions = new List<MenuItem>() { new MenuItem { Text = "Insert Header" }, new MenuItem { Text = "Edit Header" }, new MenuItem { Text = "Remove Header" } };
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
                                    <e-ribbon-splitbuttonsettings iconCss="e-icons e-paste" content="Paste" items=headerOptions beforeOpen="beforeOpenEvent"></e-ribbon-splitbuttonsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>

    function beforeOpenEvent(args) {
        // Here, you can customize your code.
    }

</script>

{% endhighlight %}
{% endtabs %}

### Before item render

The [beforeItemRender](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonSplitButtonSettings.html#Syncfusion_EJ2_Ribbon_RibbonSplitButtonSettings_BeforeItemRender) event is triggered while rendering each popup item of SplitButton.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<MenuItem> headerOptions = new List<MenuItem>() { new MenuItem { Text = "Insert Header" }, new MenuItem { Text = "Edit Header" }, new MenuItem { Text = "Remove Header" } };
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
                                    <e-ribbon-splitbuttonsettings iconCss="e-icons e-paste" content="Paste" items=headerOptions beforeItemRender="beforeItemRenderEvent"></e-ribbon-splitbuttonsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>

    function beforeItemRenderEvent(args) {
        // Here, you can customize your code.
    }

</script>

{% endhighlight %}
{% endtabs %}

### Open

The [open](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonSplitButtonSettings.html#Syncfusion_EJ2_Ribbon_RibbonSplitButtonSettings_Open) event is triggered while opening the SplitButton popup.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<MenuItem> headerOptions = new List<MenuItem>() { new MenuItem { Text = "Insert Header" }, new MenuItem { Text = "Edit Header" }, new MenuItem { Text = "Remove Header" } };
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
                                    <e-ribbon-splitbuttonsettings iconCss="e-icons e-paste" content="Paste" items=headerOptions open="openEvent"></e-ribbon-splitbuttonsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>

    function openEvent(args) {
        // Here, you can customize your code.
    }

</script>

{% endhighlight %}
{% endtabs %}

### Close

The [close](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonSplitButtonSettings.html#Syncfusion_EJ2_Ribbon_RibbonSplitButtonSettings_Close) event is triggered while closing the SplitButton popup.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<MenuItem> headerOptions = new List<MenuItem>() { new MenuItem { Text = "Insert Header" }, new MenuItem { Text = "Edit Header" }, new MenuItem { Text = "Remove Header" } };
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
                                    <e-ribbon-splitbuttonsettings iconCss="e-icons e-paste" content="Paste" items=headerOptions close="closeEvent"></e-ribbon-splitbuttonsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>

    function closeEvent(args) {
        // Here, you can customize your code.
    }

</script>

{% endhighlight %}
{% endtabs %}

### Created

The [created](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonSplitButtonSettings.html#Syncfusion_EJ2_Ribbon_RibbonSplitButtonSettings_Created) event is triggered when the SplitButton is created.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<MenuItem> headerOptions = new List<MenuItem>() { new MenuItem { Text = "Insert Header" }, new MenuItem { Text = "Edit Header" }, new MenuItem { Text = "Remove Header" } };
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
                                    <e-ribbon-splitbuttonsettings iconCss="e-icons e-paste" content="Paste" items=headerOptions created="createdEvent"></e-ribbon-splitbuttonsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>

    function createdEvent() {
        // Here, you can customize your code.
    }

</script>

{% endhighlight %}
{% endtabs %}

### Select

The [select](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonSplitButtonSettings.html#Syncfusion_EJ2_Ribbon_RibbonSplitButtonSettings_Select) event is triggered while selecting an action item in the SplitButton popup.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<MenuItem> headerOptions = new List<MenuItem>() { new MenuItem { Text = "Insert Header" }, new MenuItem { Text = "Edit Header" }, new MenuItem { Text = "Remove Header" } };
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
                                    <e-ribbon-splitbuttonsettings iconCss="e-icons e-paste" content="Paste" items=headerOptions select="selectEvent"></e-ribbon-splitbuttonsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>

    function selectEvent(args) {
        // Here, you can customize your code.
    }

</script>

{% endhighlight %}
{% endtabs %}

### Click

The [click](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonSplitButtonSettings.html#Syncfusion_EJ2_Ribbon_RibbonSplitButtonSettings_Click) event is triggered while clicking the primary button in the SplitButton.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<MenuItem> headerOptions = new List<MenuItem>() { new MenuItem { Text = "Insert Header" }, new MenuItem { Text = "Edit Header" }, new MenuItem { Text = "Remove Header" } };
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
                                    <e-ribbon-splitbuttonsettings iconCss="e-icons e-paste" content="Paste" items=headerOptions click="clickEvent"></e-ribbon-splitbuttonsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>

    function clickEvent() {
        // Here, you can customize your code.
    }

</script>

{% endhighlight %}
{% endtabs %}

## GroupButton item events

### BeforeClick

The [BeforeClick](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonGroupButtonItem.html#Syncfusion_EJ2_Ribbon_RibbonGroupButtonItem_BeforeClick) event is triggered before selecting a button from the GroupButton items.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<RibbonGroupButtonItem> events = new List<RibbonGroupButtonItem>() {

      new RibbonGroupButtonItem { IconCss = "e-icons e-bold", Content = "Bold", BeforeClick="beforeClickEvent" },
      new RibbonGroupButtonItem {IconCss = "e-icons e-italic", Content = "Italic", Selected = true, BeforeClick="beforeClickEvent" },
      new RibbonGroupButtonItem {IconCss = "e-icons e-underline", Content = "Underline", BeforeClick="beforeClickEvent" },
      new RibbonGroupButtonItem { IconCss = "e-icons e-strikethrough", Content = "Strikethrough", BeforeClick="beforeClickEvent" }
    };
}

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Paragraph">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type=GroupButton allowedSizes=Small>
                                    <e-ribbon-groupbuttonsettings selection=Multiple items=events></e-ribbon-groupbuttonsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>


<script>
    function beforeClickEvent() {
        // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

### Click

The [Click](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonGroupButtonItem.html#Syncfusion_EJ2_Ribbon_RibbonGroupButtonItem_Click) event is triggered when selecting a button from the GroupButton items.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<RibbonGroupButtonItem> events = new List<RibbonGroupButtonItem>() {

      new RibbonGroupButtonItem { IconCss = "e-icons e-align-left", Content = "Align Left", Click="clickEvent" },
      new RibbonGroupButtonItem {IconCss = "e-icons e-align-center", Content = "Align Center", Click="clickEvent", Selected = true },
      new RibbonGroupButtonItem {IconCss = "e-icons e-align-right", Content = "Align Right", Click="clickEvent" },
      new RibbonGroupButtonItem { IconCss = "e-icons e-justify", Content = "Justify", Click="clickEvent" }
    };
}

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Paragraph">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type=GroupButton allowedSizes=Small>
                                    <e-ribbon-groupbuttonsettings selection=Single items=events></e-ribbon-groupbuttonsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>


<script>
    function clickEvent() {
        // Here, you can customize your code.
    }
</script>

{% endhighlight %}
{% endtabs %}

## FileMenu events

### Before close

The [beforeClose](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.FileMenuSettings.html#Syncfusion_EJ2_Ribbon_FileMenuSettings_BeforeClose) event is triggered before closing the FileMenu popup.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<MenuItem> fileMenuOptions = new List<MenuItem>() {
        new MenuItem { Text = "New", IconCss = "e-icons e-file-new", Id="new" },
        new MenuItem { Text = "Open", IconCss = "e-icons e-folder-open", Id="open" },
        new MenuItem { Text = "Rename", IconCss = "e-icons e-rename", Id="rename" },
        new MenuItem { Text = "Save", IconCss = "e-icons e-save", Id="save" }
    };
}

<ejs-ribbon id="ribbon">
    <e-ribbon-filemenusettings text="File" visible="true" menuItems=fileMenuOptions beforeClose="beforeCloseEvent"></e-ribbon-filemenusettings>
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Header & Footer">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type=Button>
                                    <e-ribbon-buttonsettings iconCss="e-icons e-cut" content="Cut"></e-ribbon-buttonsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>

    function beforeCloseEvent(args) {
        // Here, you can customize your code.
    }

</script>

{% endhighlight %}
{% endtabs %}

### Before open

The [beforeOpen](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.FileMenuSettings.html#Syncfusion_EJ2_Ribbon_FileMenuSettings_BeforeOpen) event is triggered before opening the FileMenu popup.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<MenuItem> fileMenuOptions = new List<MenuItem>() {
        new MenuItem { Text = "New", IconCss = "e-icons e-file-new", Id="new" },
        new MenuItem { Text = "Open", IconCss = "e-icons e-folder-open", Id="open" },
        new MenuItem { Text = "Rename", IconCss = "e-icons e-rename", Id="rename" },
        new MenuItem { Text = "Save", IconCss = "e-icons e-save", Id="save" }
    };
}

<ejs-ribbon id="ribbon">
    <e-ribbon-filemenusettings text="File" visible="true" menuItems=fileMenuOptions beforeOpen="beforeOpenEvent"></e-ribbon-filemenusettings>
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Header & Footer">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type=Button>
                                    <e-ribbon-buttonsettings iconCss="e-icons e-cut" content="Cut"></e-ribbon-buttonsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>

    function beforeOpenEvent(args) {
        // Here, you can customize your code.
    }

</script>

{% endhighlight %}
{% endtabs %}

### Before item render

The [beforeItemRender](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.FileMenuSettings.html#Syncfusion_EJ2_Ribbon_FileMenuSettings_BeforeItemRender) event is triggered while rendering each ribbon FileMenu item.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<MenuItem> fileMenuOptions = new List<MenuItem>() {
        new MenuItem { Text = "New", IconCss = "e-icons e-file-new", Id="new" },
        new MenuItem { Text = "Open", IconCss = "e-icons e-folder-open", Id="open" },
        new MenuItem { Text = "Rename", IconCss = "e-icons e-rename", Id="rename" },
        new MenuItem { Text = "Save", IconCss = "e-icons e-save", Id="save" }
    };
}

<ejs-ribbon id="ribbon">
    <e-ribbon-filemenusettings text="File" visible="true" menuItems=fileMenuOptions beforeItemRender="beforeItemRenderEvent"></e-ribbon-filemenusettings>
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Header & Footer">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type=Button>
                                    <e-ribbon-buttonsettings iconCss="e-icons e-cut" content="Cut"></e-ribbon-buttonsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>

    function beforeItemRenderEvent(args) {
        // Here, you can customize your code.
    }

</script>

{% endhighlight %}
{% endtabs %}

### Open

The [open](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.FileMenuSettings.html#Syncfusion_EJ2_Ribbon_FileMenuSettings_Open) event is triggered when the FileMenu popup is opened.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<MenuItem> fileMenuOptions = new List<MenuItem>() {
        new MenuItem { Text = "New", IconCss = "e-icons e-file-new", Id="new" },
        new MenuItem { Text = "Open", IconCss = "e-icons e-folder-open", Id="open" },
        new MenuItem { Text = "Rename", IconCss = "e-icons e-rename", Id="rename" },
        new MenuItem { Text = "Save", IconCss = "e-icons e-save", Id="save" }
    };
}

<ejs-ribbon id="ribbon">
    <e-ribbon-filemenusettings text="File" visible="true" menuItems=fileMenuOptions open="openEvent"></e-ribbon-filemenusettings>
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Header & Footer">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type=Button>
                                    <e-ribbon-buttonsettings iconCss="e-icons e-cut" content="Cut"></e-ribbon-buttonsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>

    function openEvent(args) {
        // Here, you can customize your code.
    }

</script>

{% endhighlight %}
{% endtabs %}

### Close

The [close](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.FileMenuSettings.html#Syncfusion_EJ2_Ribbon_FileMenuSettings_Close) event is triggered when the FileMenu popup is closed.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<MenuItem> fileMenuOptions = new List<MenuItem>() {
        new MenuItem { Text = "New", IconCss = "e-icons e-file-new", Id="new" },
        new MenuItem { Text = "Open", IconCss = "e-icons e-folder-open", Id="open" },
        new MenuItem { Text = "Rename", IconCss = "e-icons e-rename", Id="rename" },
        new MenuItem { Text = "Save", IconCss = "e-icons e-save", Id="save" }
    };
}

<ejs-ribbon id="ribbon">
    <e-ribbon-filemenusettings text="File" visible="true" menuItems=fileMenuOptions close="closeEvent"></e-ribbon-filemenusettings>
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Header & Footer">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type=Button>
                                    <e-ribbon-buttonsettings iconCss="e-icons e-cut" content="Cut"></e-ribbon-buttonsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>

    function closeEvent(args) {
        // Here, you can customize your code.
    }

</script>

{% endhighlight %}
{% endtabs %}

### Select

The [select](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.FileMenuSettings.html#Syncfusion_EJ2_Ribbon_FileMenuSettings_Select) event is triggered while selecting an item in the ribbon FileMenu.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<MenuItem> fileMenuOptions = new List<MenuItem>() {
        new MenuItem { Text = "New", IconCss = "e-icons e-file-new", Id="new" },
        new MenuItem { Text = "Open", IconCss = "e-icons e-folder-open", Id="open" },
        new MenuItem { Text = "Rename", IconCss = "e-icons e-rename", Id="rename" },
        new MenuItem { Text = "Save", IconCss = "e-icons e-save", Id="save" }
    };
}

<ejs-ribbon id="ribbon">
    <e-ribbon-filemenusettings text="File" visible="true" menuItems=fileMenuOptions select="selectEvent"></e-ribbon-filemenusettings>
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Header & Footer">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type=Button>
                                    <e-ribbon-buttonsettings iconCss="e-icons e-cut" content="Cut"></e-ribbon-buttonsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>

    function selectEvent(args) {
        // Here, you can customize your code.
    }

</script>

{% endhighlight %}
{% endtabs %}

## Backstage Menu events

### BackStageItemClick

The [BackStageItemClick](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.BackstageItem.html#Syncfusion_EJ2_Ribbon_BackstageItem_BackStageItemClick) event is triggered when backstage item is selected.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<BackstageItem> backstageItems = new List<BackstageItem>() {
        new BackstageItem { Id = "home", Text = "Home", IconCss = "e-icons e-home", Content = processBackstageContent("home"), BackStageItemClick = backStageItemClickEvent(args) },
    };
    BackStageMenu backstageSettings = new BackStageMenu() { Text = "File", Visible = true, BackButton = new BackstageBackButton { Text = "Close" }, Items = backstageItems };
}

<ejs-ribbon id="ribbon">
    <e-ribbon-backstagemenusettings text="File" visible="true" backButton=backButtonSettings items=backstageItems></e-ribbon-backstagemenusettings>
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Header & Footer">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type=Button>
                                    <e-ribbon-buttonsettings iconCss="e-icons e-cut" content="Cut"></e-ribbon-buttonsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>

    function backStageItemClickEvent(args) {
        // Here, you can customize your code.
    }

</script>

{% endhighlight %}
{% endtabs %}

## Gallery events

### popupOpen

The [popupOpen](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonGallerySettings.html#Syncfusion_EJ2_Ribbon_RibbonGallerySettings_PopupOpen) event is triggered when the gallery popup opens.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Gallery">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type="Gallery">
                                    <e-ribbon-gallerySettings popupOpen="popupOpen">
                                        <e-ribbon-gallery-groups>
                                            <e-ribbon-gallery-group header="Styles">
                                                <e-ribbon-gallery-items>
                                                    <e-ribbon-gallery-item content="Normal"></e-ribbon-gallery-item>
                                                    <e-ribbon-gallery-item content="No Spacing"></e-ribbon-gallery-item>
                                                    <e-ribbon-gallery-item content="Heading 1"></e-ribbon-gallery-item>
                                                    <e-ribbon-gallery-item content="Heading 2"></e-ribbon-gallery-item>
                                                </e-ribbon-gallery-items>
                                            </e-ribbon-gallery-group>
                                        </e-ribbon-gallery-groups>
                                    </e-ribbon-gallerySettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>
  function popupOpen() {
    // Your required action here
  }
</script>

{% endhighlight %}
{% endtabs %}

### popupClose

The [popupClose](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonGallerySettings.html#Syncfusion_EJ2_Ribbon_RibbonGallerySettings_PopupClose) event is triggered when the gallery popup closes.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Gallery">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type="Gallery">
                                    <e-ribbon-gallerySettings popupClose="popupClose">
                                        <e-ribbon-gallery-groups>
                                            <e-ribbon-gallery-group header="Styles">
                                                <e-ribbon-gallery-items>
                                                    <e-ribbon-gallery-item content="Normal"></e-ribbon-gallery-item>
                                                    <e-ribbon-gallery-item content="No Spacing"></e-ribbon-gallery-item>
                                                    <e-ribbon-gallery-item content="Heading 1"></e-ribbon-gallery-item>
                                                    <e-ribbon-gallery-item content="Heading 2"></e-ribbon-gallery-item>
                                                </e-ribbon-gallery-items>
                                            </e-ribbon-gallery-group>
                                        </e-ribbon-gallery-groups>
                                    </e-ribbon-gallerySettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>
  function popupClose() {
    // Your required action here
  }
</script>
`
{% endhighlight %}
{% endtabs %}

### itemHover

The [itemHover](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonGallerySettings.html#Syncfusion_EJ2_Ribbon_RibbonGallerySettings_ItemHover) event is triggered when hover over the gallery item.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Gallery">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type="Gallery">
                                    <e-ribbon-gallerySettings itemHover="itemHover">
                                        <e-ribbon-gallery-groups>
                                            <e-ribbon-gallery-group header="Styles">
                                                <e-ribbon-gallery-items>
                                                    <e-ribbon-gallery-item content="Normal"></e-ribbon-gallery-item>
                                                    <e-ribbon-gallery-item content="No Spacing"></e-ribbon-gallery-item>
                                                    <e-ribbon-gallery-item content="Heading 1"></e-ribbon-gallery-item>
                                                    <e-ribbon-gallery-item content="Heading 2"></e-ribbon-gallery-item>
                                                </e-ribbon-gallery-items>
                                            </e-ribbon-gallery-group>
                                        </e-ribbon-gallery-groups>
                                    </e-ribbon-gallerySettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>
  function itemHover() {
    // Your required action here
  }
</script>

{% endhighlight %}
{% endtabs %}

### beforeItemRender

The [beforeItemRender](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonGallerySettings.html#Syncfusion_EJ2_Ribbon_RibbonGallerySettings_BeforeItemRender) event is triggered while rendering each gallery item.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Gallery">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type="Gallery">
                                    <e-ribbon-gallerySettings beforeItemRender="beforeItemRender">
                                        <e-ribbon-gallery-groups>
                                            <e-ribbon-gallery-group header="Styles">
                                                <e-ribbon-gallery-items>
                                                    <e-ribbon-gallery-item content="Normal"></e-ribbon-gallery-item>
                                                    <e-ribbon-gallery-item content="No Spacing"></e-ribbon-gallery-item>
                                                    <e-ribbon-gallery-item content="Heading 1"></e-ribbon-gallery-item>
                                                    <e-ribbon-gallery-item content="Heading 2"></e-ribbon-gallery-item>
                                                </e-ribbon-gallery-items>
                                            </e-ribbon-gallery-group>
                                        </e-ribbon-gallery-groups>
                                    </e-ribbon-gallerySettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>
  function beforeItemRender() {
    // Your required action here
  }
</script>

{% endhighlight %}
{% endtabs %}

### beforeSelect

The [beforeSelect](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonGallerySettings.html#Syncfusion_EJ2_Ribbon_RibbonGallerySettings_BeforeSelect) event is triggered before selecting an item in the Ribbon gallery.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Gallery">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type="Gallery">
                                    <e-ribbon-gallerySettings beforeSelect="beforeSelect">
                                        <e-ribbon-gallery-groups>
                                            <e-ribbon-gallery-group header="Styles">
                                                <e-ribbon-gallery-items>
                                                    <e-ribbon-gallery-item content="Normal"></e-ribbon-gallery-item>
                                                    <e-ribbon-gallery-item content="No Spacing"></e-ribbon-gallery-item>
                                                    <e-ribbon-gallery-item content="Heading 1"></e-ribbon-gallery-item>
                                                    <e-ribbon-gallery-item content="Heading 2"></e-ribbon-gallery-item>
                                                </e-ribbon-gallery-items>
                                            </e-ribbon-gallery-group>
                                        </e-ribbon-gallery-groups>
                                    </e-ribbon-gallerySettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>
  function beforeSelect() {
    // Your required action here
  }
</script>

{% endhighlight %}
{% endtabs %}

### select

The [select](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonGallerySettings.html#Syncfusion_EJ2_Ribbon_RibbonGallerySettings_Select) event is triggered while selecting an item in the Ribbon Gallery.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Gallery">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type="Gallery">
                                    <e-ribbon-gallerySettings select="select">
                                        <e-ribbon-gallery-groups>
                                            <e-ribbon-gallery-group header="Styles">
                                                <e-ribbon-gallery-items>
                                                    <e-ribbon-gallery-item content="Normal"></e-ribbon-gallery-item>
                                                    <e-ribbon-gallery-item content="No Spacing"></e-ribbon-gallery-item>
                                                    <e-ribbon-gallery-item content="Heading 1"></e-ribbon-gallery-item>
                                                    <e-ribbon-gallery-item content="Heading 2"></e-ribbon-gallery-item>
                                                </e-ribbon-gallery-items>
                                            </e-ribbon-gallery-group>
                                        </e-ribbon-gallery-groups>
                                    </e-ribbon-gallerySettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>
  function select() {
    // Your required action here
  }
</script>

{% endhighlight %}
{% endtabs %}