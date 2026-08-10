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

The help pane is dedicated area where the users can define help contents like controlling document permissions, sharing features, and more which appears on the right side of the Ribbon. You can use the [HelpPaneTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.ribbon.ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_HelpPaneTemplate) property to set the help pane contents.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@Html.EJS().Ribbon("ribbon").HelpPaneTemplate("#helpPaneTemplate").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Clipboard").Collections(collection =>
        {
            collection.Items(item =>
            {
                item.Type(RibbonItemType.Button).ButtonSettings(button =>
                {
                    button.IconCss("e-icons e-cut").Content("cut");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

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

![ASP.NET MVC Ribbon Control with HelpPaneTemplate](./images/helpPaneTemplate.png)