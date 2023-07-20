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

The Ribbon supports tooltips, which give users more information when they hover over items and improving the user experience.

## Adding Title

The [Title](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonTooltipSettings.html#Syncfusion_EJ2_Ribbon_RibbonTooltipSettings_Title) property is used to set the tooltip title for each Ribbon item.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<MenuItem> pasteMenuOptions = new List<MenuItem>() { new MenuItem { Text = "Keep Source Format" }, new MenuItem { Text = "Merge format" }, new MenuItem { Text = "Keep text only" } };

    var cutOptions = new RibbonTooltipSettings { Title = "Cut" };
    var copyOptions = new RibbonTooltipSettings { Title = "Copy" };
    var pasteOptions = new RibbonTooltipSettings { Title = "Paste" };
    var formatOptions = new RibbonTooltipSettings { Title = "Format Painter" };
}

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Clipboard">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type="SplitButton" ribbonTooltipSettings=pasteOptions>
                                    <e-ribbon-splitButtonsettings iconCss="e-icons e-paste" content="Paste" items=pasteMenuOptions></e-ribbon-splitButtonsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type="Button" ribbonTooltipSettings=cutOptions>
                                    <e-ribbon-buttonsettings iconCss="e-icons e-cut" content="Cut"></e-ribbon-buttonsettings>
                                </e-ribbon-item>
                                <e-ribbon-item type="Button" ribbonTooltipSettings=copyOptions>
                                    <e-ribbon-buttonsettings iconCss="e-icons e-copy" content="Copy"></e-ribbon-buttonsettings>
                                </e-ribbon-item>
                                <e-ribbon-item type="Button" ribbonTooltipSettings=formatOptions>
                                    <e-ribbon-buttonsettings iconCss="e-icons e-format-painter" content="Format Painter"></e-ribbon-buttonsettings>
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

The [Content](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonTooltipSettings.html#Syncfusion_EJ2_Ribbon_RibbonTooltipSettings_Content) property can be used to set the tooltip content for each Ribbon item.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<MenuItem> pasteMenuOptions = new List<MenuItem>() { new MenuItem { Text = "Keep Source Format" }, new MenuItem { Text = "Merge format" }, new MenuItem { Text = "Keep text only" } };

    var cutOptions = new RibbonTooltipSettings { Title = "Cut", Content = "Places the selected text or object on the clipboard so that you can paste it somewhere else." };
    var copyOptions = new RibbonTooltipSettings { Title = "Copy", Content = "Copies the chosen text or object to the clipboard so that you can reuse it elsewhere." };
    var pasteOptions = new RibbonTooltipSettings { Title = "Paste", Content = "Insert the clipboard content where the cursor is currently placed." };
    var formatOptions = new RibbonTooltipSettings { Title = "Format Painter", Content = "Copies the formatting style of a selected text or object and applies it to other content within the document." };
}

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Clipboard">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type="SplitButton" ribbonTooltipSettings=pasteOptions>
                                    <e-ribbon-splitButtonsettings iconCss="e-icons e-paste" content="Paste" items=pasteMenuOptions></e-ribbon-splitButtonsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type="Button" ribbonTooltipSettings=cutOptions>
                                    <e-ribbon-buttonsettings iconCss="e-icons e-cut" content="Cut"></e-ribbon-buttonsettings>
                                </e-ribbon-item>
                                <e-ribbon-item type="Button" ribbonTooltipSettings=copyOptions>
                                    <e-ribbon-buttonsettings iconCss="e-icons e-copy" content="Copy"></e-ribbon-buttonsettings>
                                </e-ribbon-item>
                                <e-ribbon-item type="Button" ribbonTooltipSettings=formatOptions>
                                    <e-ribbon-buttonsettings iconCss="e-icons e-format-painter" content="Format Painter"></e-ribbon-buttonsettings>
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

In addition to the text and content, by using [IconCss](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonTooltipSettings.html#Syncfusion_EJ2_Ribbon_RibbonTooltipSettings_IconCss)  property you can define the custom style for the icons.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<MenuItem> pasteMenuOptions = new List<MenuItem>() { new MenuItem { Text = "Keep Source Format" }, new MenuItem { Text = "Merge format" }, new MenuItem { Text = "Keep text only" } };

    var cutOptions = new RibbonTooltipSettings { Title = "Cut", Content = "Places the selected text or object on the clipboard so that you can paste it somewhere else.", IconCss = "e-icons e-cut"};
    var copyOptions = new RibbonTooltipSettings { Title = "Copy", Content = "Copies the chosen text or object to the clipboard so that you can reuse it elsewhere.", IconCss = "e-icons e-copy" };
    var pasteOptions = new RibbonTooltipSettings { Title = "Paste", Content = "Insert the clipboard content where the cursor is currently placed.", IconCss = "e-icons e-paste" };
    var formatOptions = new RibbonTooltipSettings { Title = "Format Painter", Content = "Copies the formatting style of a selected text or object and applies it to other content within the document.", IconCss = "e-icons e-format-painter"};
}

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Clipboard">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type="SplitButton" ribbonTooltipSettings=pasteOptions>
                                    <e-ribbon-splitButtonsettings iconCss="e-icons e-paste" content="Paste" items=pasteMenuOptions></e-ribbon-splitButtonsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type="Button" ribbonTooltipSettings=cutOptions>
                                    <e-ribbon-buttonsettings iconCss="e-icons e-cut" content="Cut"></e-ribbon-buttonsettings>
                                </e-ribbon-item>
                                <e-ribbon-item type="Button" ribbonTooltipSettings=copyOptions>
                                    <e-ribbon-buttonsettings iconCss="e-icons e-copy" content="Copy"></e-ribbon-buttonsettings>
                                </e-ribbon-item>
                                <e-ribbon-item type="Button" ribbonTooltipSettings=formatOptions>
                                    <e-ribbon-buttonsettings iconCss="e-icons e-format-painter" content="Format Painter"></e-ribbon-buttonsettings>
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

## Tooltip Customization

The [CssClass](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonTooltipSettings.html#Syncfusion_EJ2_Ribbon_RibbonTooltipSettings_CssClass) property can be used to customize the appearance of the tooltip with your own custom styles.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}

@using Syncfusion.EJ2
@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@ {
    List<MenuItem> pasteMenuOptions = new List<MenuItem>() { new MenuItem { Text = "Keep Source Format" }, new MenuItem { Text = "Merge format" }, new MenuItem { Text = "Keep text only" } };

    var cutOptions = new RibbonTooltipSettings { Title = "Cut", Content = "Places the selected text or object on the clipboard so that you can paste it somewhere else.", IconCss = "e-icons e-cut", CssClass = "custom-tooltip" };
    var copyOptions = new RibbonTooltipSettings { Title = "Copy", Content = "Copies the chosen text or object to the clipboard so that you can reuse it elsewhere.", IconCss = "e-icons e-copy", CssClass = "custom-tooltip"  };
    var pasteOptions = new RibbonTooltipSettings { Title = "Paste", Content = "Insert the clipboard content where the cursor is currently placed.", IconCss = "e-icons e-paste", CssClass = "custom-tooltip"  };
    var formatOptions = new RibbonTooltipSettings { Title = "Format Painter", Content = "Copies the formatting style of a selected text or object and applies it to other content within the document.", IconCss = "e-icons e-format-painter", CssClass = "custom-tooltip" };
}

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Clipboard">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type="SplitButton" ribbonTooltipSettings=pasteOptions>
                                    <e-ribbon-splitButtonsettings iconCss="e-icons e-paste" content="Paste" items=pasteMenuOptions></e-ribbon-splitButtonsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type="Button" ribbonTooltipSettings=cutOptions>
                                    <e-ribbon-buttonsettings iconCss="e-icons e-cut" content="Cut"></e-ribbon-buttonsettings>
                                </e-ribbon-item>
                                <e-ribbon-item type="Button" ribbonTooltipSettings=copyOptions>
                                    <e-ribbon-buttonsettings iconCss="e-icons e-copy" content="Copy"></e-ribbon-buttonsettings>
                                </e-ribbon-item>
                                <e-ribbon-item type="Button" ribbonTooltipSettings=formatOptions>
                                    <e-ribbon-buttonsettings iconCss="e-icons e-format-painter" content="Format Painter"></e-ribbon-buttonsettings>
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
    :root {
        --borderColor: rgb(72, 72, 72);
        --black: #000000;
    }

    /* To customize the appearance of the tooltip */
    .custom-tooltip.e-ribbon-tooltip.e-popup {
        border: 2px solid var(--borderColor);
        border-radius: 5px;
        background: var(--black);
    }

    /* To customize the arrow of the tooltip */
    .custom-tooltip.e-ribbon-tooltip .e-arrow-tip .e-arrow-tip-inner.e-tip-top,
    .custom-tooltip.e-ribbon-tooltip .e-arrow-tip .e-arrow-tip-inner.e-tip-bottom {
        color: var(--black);
    }

    .custom-tooltip.e-ribbon-tooltip .e-arrow-tip-outer.e-tip-top {
        border-bottom: 8px solid var(--borderColor);
    }

    .custom-tooltip.e-ribbon-tooltip .e-arrow-tip-outer.e-tip-bottom {
        border-top: 8px solid var(--borderColor);
    }

    /* To change the size of the tooltip title */
    .custom-tooltip.e-ribbon-tooltip .e-tip-content .e-ribbon-tooltip-title {
        font-size: 14px;
    }

    /* To change the size of the tooltip content */
    .custom-tooltip.e-ribbon-tooltip .e-tip-content .e-ribbon-text-container .e-ribbon-tooltip-content {
        font-size: 11px;
    }
</style>

{% endhighlight %}
{% endtabs %}