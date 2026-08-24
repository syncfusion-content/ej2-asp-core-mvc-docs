---
layout: post
title: Help Pane Template in ##Platform_Name## Ribbon | Syncfusion
description: Learn how to customize the help pane in the ##Platform_Name## Ribbon to display custom content such as document permissions, sharing options, or user information.
control: Ribbon
platform: ej2-asp-core-mvc
publishingplatform: ##Platform_Name##
documentation: ug
---

# Help Pane Template in ##Platform_Name## Ribbon

The help pane is dedicated area where the users can define help contents like controlling document permissions, sharing features, and more which appears on the right side of the Ribbon. You can use the [helpPaneTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.ribbon.ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_HelpPaneTemplate) property to set the help pane contents.

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
    .action_btn {
        margin: 0px 3px;
        border: none;
        color: #ffffff;
        background-color: #0d6efd;
    }

    #undo, #redo{
        padding: 0px 3px ;
    }
</style>

<script type="text/x-jsrender" id="helpPaneTemplate">
    <button class="action_btn"> <label> <span id="undo" class="e-icons e-undo"> </span> Undo </label></button>
    <button class="action_btn"> <label> <span id="redo" class="e-icons e-redo"> </span> Redo </label></button>
</script>

{% endhighlight %}
{% endtabs %}

![ASP.NET Core Ribbon Control with HelpPaneTemplate](./images/helpPaneTemplate.png)