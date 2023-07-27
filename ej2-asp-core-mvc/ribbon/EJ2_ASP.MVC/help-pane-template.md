---
layout: post
title: HelpPaneTemplate in ##Platform_Name## Ribbon Control | Syncfusion
description: Learn here all about HelpPaneTemplate in Syncfusion ##Platform_Name## Ribbon control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Ribbon
publishingplatform: ##Platform_Name##
documentation: ug
---

# Help pane

The users can access help content for tasks like controlling document permissions, sharing features, and more using the [HelpPaneTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.ribbon.ribbon.html#Syncfusion_EJ2_Ribbon_Ribbon_HelpPaneTemplate) property, which is located on the right side of the Ribbon.

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

![ASP.NET MVC Ribbon Control with HelpPaneTemplate](./images/helpPaneTemplate.png)