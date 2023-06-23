---
layout: post
title: HelpPaneTemplate in ##Platform_Name## Ribbon Control | Syncfusion
description: Learn here all about HelpPaneTemplate in Syncfusion ##Platform_Name## Ribbon control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Ribbon
publishingplatform: ##Platform_Name##
documentation: ug
---

# HelpPaneTemplate

The [helpPaneTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.ribbon.ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_HelpPaneTemplate) property in the Ribbon Control allows you to customize the appearance and functionality of the help pane. The pane is positioned on the right side of the ribbon header row and can be customized by providing a template for its content.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

<ejs-ribbon id="ribbon" helpPaneTemplate="#helpPaneTemplate">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Font">
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

<style>
    .action_btn{
        margin: 0px 5px;
        border: none;
        color: #ffffff;
        background-color: #0d6efd;
    }
</style>

<script type="text/x-jsrender" id="helpPaneTemplate">
    <button class="action_btn"><span id="undo" class="e-icons e-undo"></span> Undo </button>
    <button class="action_btn"><span id="redo" class="e-icons e-redo"></span> Redo </button>
</script>

{% endhighlight %}
{% endtabs %}

![ASP.NET Core Ribbon Control with HelpPaneTemplate](./images/helpPaneTemplate.png)