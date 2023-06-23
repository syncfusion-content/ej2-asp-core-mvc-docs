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

To provide a title for the tooltip, you can utilize the [Title](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonTooltipSettings.html#Syncfusion_EJ2_Ribbon_RibbonTooltipSettings_Title) property.

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

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Clipboard">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type="Button" allowedSizes=Large ribbonTooltipSettings=cutOptions>
                                    <e-ribbon-buttonsettings iconCss="e-icons e-cut" content="Cut"></e-ribbon-buttonsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type="Button" allowedSizes=Medium ribbonTooltipSettings=copyOptions>
                                    <e-ribbon-buttonsettings iconCss="e-icons e-copy" content="Copy"></e-ribbon-buttonsettings>
                                </e-ribbon-item>
                                <e-ribbon-item type="Button" allowedSizes=Medium ribbonTooltipSettings=pasteOptions>
                                    <e-ribbon-buttonsettings iconCss="e-icons e-paste" content="Paste"></e-ribbon-buttonsettings>
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

## Adding Content

You define the specific content that will be displayed within the tooltip using the [Content](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonTooltipSettings.html#Syncfusion_EJ2_Ribbon_RibbonTooltipSettings_Content) property.

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

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Clipboard">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type="Button" allowedSizes=Large ribbonTooltipSettings=cutOptions>
                                    <e-ribbon-buttonsettings iconCss="e-icons e-cut" content="Cut"></e-ribbon-buttonsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type="Button" allowedSizes=Medium ribbonTooltipSettings=copyOptions>
                                    <e-ribbon-buttonsettings iconCss="e-icons e-copy" content="Copy"></e-ribbon-buttonsettings>
                                </e-ribbon-item>
                                <e-ribbon-item type="Button" allowedSizes=Medium ribbonTooltipSettings=pasteOptions>
                                    <e-ribbon-buttonsettings iconCss="e-icons e-paste" content="Paste"></e-ribbon-buttonsettings>
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

## Adding Icon

In addition to text and content, you can also define css class for the icons to show in tooltip using [IconCss](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonTooltipSettings.html#Syncfusion_EJ2_Ribbon_RibbonTooltipSettings_IconCss) property.

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

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Clipboard">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type="Button" allowedSizes=Large ribbonTooltipSettings=cutOptions>
                                    <e-ribbon-buttonsettings iconCss="e-icons e-cut" content="Cut"></e-ribbon-buttonsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type="Button" allowedSizes=Medium ribbonTooltipSettings=copyOptions>
                                    <e-ribbon-buttonsettings iconCss="e-icons e-copy" content="Copy"></e-ribbon-buttonsettings>
                                </e-ribbon-item>
                                <e-ribbon-item type="Button" allowedSizes=Medium ribbonTooltipSettings=pasteOptions>
                                    <e-ribbon-buttonsettings iconCss="e-icons e-paste" content="Paste"></e-ribbon-buttonsettings>
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