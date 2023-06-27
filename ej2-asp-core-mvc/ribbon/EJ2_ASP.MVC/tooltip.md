---
layout: post
title: Tooltip in ##Platform_Name## Ribbon Control | Syncfusion
description: Learn here all about Tooltip in Syncfusion ##Platform_Name## Ribbon control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Ribbon
publishingplatform: ##Platform_Name##
documentation: ug
---

# Tooltip

## Adding Title

To provide a title for the tooltip, you can utilize the [Title](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonTooltipSettings.html#Syncfusion_EJ2_Ribbon_RibbonTooltipSettings_Title) property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    var cutOptions = new RibbonTooltipSettings { Title = "Cut" };
    var copyOptions = new RibbonTooltipSettings { Title = "Copy" };
    var pasteOptions = new RibbonTooltipSettings { Title = "Paste" };
}

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
                    button.IconCss("e-icons e-cut").Content("Cut");
                }).RibbonTooltipSettings(cutOptions).Add();
            }).Add();
            collection.Items(item =>
            {
                item.Type(RibbonItemType.Button).ButtonSettings(button =>
                {
                    button.IconCss("e-icons e-copy").Content("Copy");
                }).RibbonTooltipSettings(copyOptions).Add();
                item.Type(RibbonItemType.Button).ButtonSettings(button =>
                {
                    button.IconCss("e-icons e-paste").Content("Paste");
                }).RibbonTooltipSettings(pasteOptions).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

{% endhighlight %}
{% endtabs %}

## Adding Content

You can define the specific content to be displayed within the tooltip using the [Content](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonTooltipSettings.html#Syncfusion_EJ2_Ribbon_RibbonTooltipSettings_Content) property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    var cutOptions = new RibbonTooltipSettings { Title = "Cut", Content = "Cut selected text or objects" };
    var copyOptions = new RibbonTooltipSettings { Title = "Copy", Content = "Copy selected text or objects" };
    var pasteOptions = new RibbonTooltipSettings { Title = "Paste", Content = "Paste copied or cut content" };
}

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
                    button.IconCss("e-icons e-cut").Content("Cut");
                }).RibbonTooltipSettings(cutOptions).Add();
            }).Add();
            collection.Items(item =>
            {
                item.Type(RibbonItemType.Button).ButtonSettings(button =>
                {
                    button.IconCss("e-icons e-copy").Content("Copy");
                }).RibbonTooltipSettings(copyOptions).Add();
                item.Type(RibbonItemType.Button).ButtonSettings(button =>
                {
                    button.IconCss("e-icons e-paste").Content("Paste");
                }).RibbonTooltipSettings(pasteOptions).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

{% endhighlight %}
{% endtabs %}

## Adding Icon

In addition to the text and content, you can also define CSS class for the icons to show in the tooltip using [IconCss](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Ribbon.RibbonTooltipSettings.html#Syncfusion_EJ2_Ribbon_RibbonTooltipSettings_IconCss) property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    var cutOptions = new RibbonTooltipSettings { Title = "Cut", Content = "Cut selected text or objects", IconCss = "e-icons e-cut" };
    var copyOptions = new RibbonTooltipSettings { Title = "Copy", Content = "Copy selected text or objects", IconCss = "e-icons e-copy" };
    var pasteOptions = new RibbonTooltipSettings { Title = "Paste", Content = "Paste copied or cut content", IconCss = "e-icons e-paste" };
}

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
                    button.IconCss("e-icons e-cut").Content("Cut");
                }).RibbonTooltipSettings(cutOptions).Add();
            }).Add();
            collection.Items(item =>
            {
                item.Type(RibbonItemType.Button).ButtonSettings(button =>
                {
                    button.IconCss("e-icons e-copy").Content("Copy");
                }).RibbonTooltipSettings(copyOptions).Add();
                item.Type(RibbonItemType.Button).ButtonSettings(button =>
                {
                    button.IconCss("e-icons e-paste").Content("Paste");
                }).RibbonTooltipSettings(pasteOptions).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

{% endhighlight %}
{% endtabs %}