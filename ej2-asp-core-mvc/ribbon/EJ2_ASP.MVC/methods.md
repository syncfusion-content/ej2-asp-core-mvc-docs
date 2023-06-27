---
layout: post
title: Methods in ##Platform_Name## Ribbon Control | Syncfusion
description: Learn here all about methods in Syncfusion ##Platform_Name## Ribbon control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Ribbon
publishingplatform: ##Platform_Name##
documentation: ug
---

# Methods

The following methods are available in the Ribbon control.

## addTab

To add an tab dynamically, use the `addTab` method in the ribbon control. The following are the arguments for this method.

|   Argument name      |   Description                            |
|----------------------| -----------------------------------------|
|     tab              |    Gets the tab data to add.|
|     targetId (optional)|    Gets the ID of the target tab to add the new tab.|
|     isAfter (optional)|     Defines whether the tab is added before or after the target.|

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@Html.EJS().Button("addTab").Content("AddTab").Click("addTab").IsPrimary(true).Render()
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
                    button.IconCss("e-icons e-cut").Content("cut");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function addTab() {
        var ribbonObj = document.getElementById("ribbon").ej2_instances[0];
        let newTab = {
            header: "Insert",
            id: "tab"
        }
        ribbonObj.addTab(newTab);
     }
</script>

{% endhighlight %}
{% endtabs %}

## addGroup

To add an group dynamically, use the `addGroup` method in the ribbon control. The following are the arguments for this method.

|   Argument name      |   Description                            |
|----------------------| -----------------------------------------|
|     tabId            |    Gets the ribbon tab ID.|
|     group            |    Gets the group data to add.|
|     targetId (optional)|    Gets the ID of the target group to add the new group.|
|     isAfter (optional)|     Defines whether the group is added before or after the target.|

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@Html.EJS().Button("addGroup").Content("AddGroup").Click("addGroup").IsPrimary(true).Render()
@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Id("home").Header("Home").Groups(group =>
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

<script>
    function addGroup() {
        var ribbonObj = document.getElementById("ribbon").ej2_instances[0];
        let newGroup = {
            header: "newGroup",
            id: "insertGroup"
        }
        ribbonObj.addGroup("home", newGroup);
     }
</script>

{% endhighlight %}
{% endtabs %}

## addCollection

To add an collection dynamically, use the `addCollection` method in the ribbon control. The following are the arguments for this method.

|   Argument name      |   Description                            |
|----------------------| -----------------------------------------|
|     groupId          |    Gets the ribbon group ID.|
|     collection       |    Gets the collection data to add.|
|     targetId (optional)|    Gets the ID of the target collection to add the new collection.|
|     isAfter (optional)|     Defines whether the collection is added before or after the target.|

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@Html.EJS().Button("addCollection").Content("AddCollection").Click("addCollection").IsPrimary(true).Render()
@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Id("fontGroup").Header("Clipboard").Collections(collection =>
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

<script>
    function addCollection() {
        var ribbonObj = document.getElementById("ribbon").ej2_instances[0];
        let newCollection = {
            id: "insertGroup",
            items: [
                {
                    type: "Button",
                    buttonSettings: {
                        content: "Edit",
                        iconCss: "e-icons e-edit"
                    }
                },
                {
                    type: "ColorPicker",
                    colorPickerSettings: {
                        value: "035a"
                    }
                }
            ]
        }
        ribbonObj.addCollection("fontGroup", newCollection);
     }
</script>

{% endhighlight %}
{% endtabs %}

## addItem

To add an item dynamically, use the `addItem` method in the ribbon control. The following are the arguments for this method.

|   Argument name      |   Description                            |
|----------------------| -----------------------------------------|
|     collectionId     |    Gets the ribbon collection ID.|
|     item             |    Gets the item data to add .|
|     targetId (optional)|    Gets the ID of the target item to add the new item.|
|     isAfter (optional)|     Defines whether the item is added before or after the target.|

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@Html.EJS().Button("addItem").Content("AddItem").Click("addItem").IsPrimary(true).Render()
@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Header("Home").Groups(group =>
    {
        group.Header("Clipboard").Collections(collection =>
        {
            collection.Id("buttonCollection").Items(item =>
            {
                item.Type(RibbonItemType.Button).AllowedSizes(RibbonItemSize.Medium).ButtonSettings(button =>
                {
                    button.IconCss("e-icons e-cut").Content("cut");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function addItem() {
        var ribbonObj = document.getElementById("ribbon").ej2_instances[0];
        let newItem = {
            id: "insertItem",
            type: "ColorPicker",
            colorPickerSettings: {
                value: "035a"
            }

        }
        ribbonObj.addItem("buttonCollection", newItem);
     }
</script>

{% endhighlight %}
{% endtabs %}

## removeTab

The `removeTab` method is used to remove a tab from the ribbon control. This method takes the `tabId` as a parameter.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@Html.EJS().Button("removeTab").Content("RemoveTab").Click("removeTab").IsPrimary(true).Render()
@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Id("homeTab").Header("Home").Groups(group =>
    {
        group.Header("Clipboard").Collections(collection =>
        {
            collection.Id("buttonCollection").Items(item =>
            {
                item.Type(RibbonItemType.Button).ButtonSettings(button =>
                {
                    button.IconCss("e-icons e-cut").Content("cut");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
    tab.Id("insertTab").Header("Insert").Add();
}).Render()

<script>
    function removeTab() {
        var ribbonObj = document.getElementById("ribbon").ej2_instances[0];
        ribbonObj.removeTab("insertTab");
    }
</script>

{% endhighlight %}
{% endtabs %}

## removeGroup

The `removeGroup` method is used to remove a group of items from the ribbon control. This method takes the `groupId` as a parameter.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@Html.EJS().Button("removeGroup").Content("RemoveGroup").Click("removeGroup").IsPrimary(true).Render()
@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Id("homeTab").Header("Home").Groups(group =>
    {
        group.Header("Font").Collections(collection =>
        {
            collection.Id("buttonCollection").Items(item =>
            {
                item.Type(RibbonItemType.Button).ButtonSettings(button =>
                {
                    button.IconCss("e-icons e-cut").Content("cut");
                }).Add();
            }).Add();
        }).Add();
        group.Header("ClipBoard").Id("clipBoard").Add();
    }).Add();
}).Render()

<script>
    function removeGroup() {
        var ribbonObj = document.getElementById("ribbon").ej2_instances[0];
        ribbonObj.removeGroup("clipBoard");
    }
</script>

{% endhighlight %}
{% endtabs %}

## removeCollection

The `removeCollection` method is used to remove a collection of items from the ribbon control. This method takes the `collectionId` as a parameter.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@Html.EJS().Button("removeCollection").Content("RemoveCollection").Click("removeCollection").IsPrimary(true).Render()
@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Id("homeTab").Header("Home").Groups(group =>
    {
        group.Header("Font").Collections(collection =>
        {
            collection.Id("buttonCollection").Items(item =>
            {
                item.Type(RibbonItemType.Button).ButtonSettings(button =>
                {
                    button.IconCss("e-icons e-cut").Content("cut");
                }).Add();
            }).Add();
            collection.Id("colorPicker").Items(item =>
            {
                item.Type(RibbonItemType.ColorPicker).ColorPickerSettings(colorpicker =>
                {
                    colorpicker.Value("035a");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function removeCollection() {
        var ribbonObj = document.getElementById("ribbon").ej2_instances[0];
        ribbonObj.removeCollection("colorPicker");
    }
</script>

{% endhighlight %}
{% endtabs %}

## removeItem

The `removeItem` method is used to remove an item from the ribbon control. This method takes the `itemId` as a parameter.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@Html.EJS().Button("removeItem").Content("RemoveItem").Click("removeItem").IsPrimary(true).Render()
@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Id("homeTab").Header("Home").Groups(group =>
    {
        group.Header("Font").Collections(collection =>
        {
            collection.Id("buttonCollection").Items(item =>
            {
                item.Id("cutItem").Type(RibbonItemType.Button).ButtonSettings(button =>
                {
                    button.IconCss("e-icons e-cut").Content("cut");
                }).Add();
                item.Id("copyItem").Type(RibbonItemType.Button).ButtonSettings(button =>
                {
                    button.IconCss("e-icons e-copy").Content("copy");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function removeItem() {
        var ribbonObj = document.getElementById("ribbon").ej2_instances[0];
        ribbonObj.removeItem("copyItem");
    }
</script>

{% endhighlight %}
{% endtabs %}

## enableItem

The `enableItem` method in a ribbon control is used to enable a specific item in the ribbon control. This method takes the `itemId` as a parameter.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@Html.EJS().Button("enableItem").Content("EnableItem").Click("enableItem").IsPrimary(true).Render()
@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Id("homeTab").Header("Home").Groups(group =>
    {
        group.Header("Font").Collections(collection =>
        {
            collection.Id("buttonCollection").Items(item =>
            {
                item.Id("cutItem").Disabled(true).Type(RibbonItemType.Button).ButtonSettings(button =>
                {
                    button.IconCss("e-icons e-cut").Content("cut");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function enableItem() {
        var ribbonObj = document.getElementById("ribbon").ej2_instances[0];
        ribbonObj.enableItem("cutItem");
    }
</script>

{% endhighlight %}
{% endtabs %}

## disableItem

The `disableItem` method in a ribbon control is used to disable a specific item in the ribbon control. This method takes the items ID as a parameter.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@Html.EJS().Button("disableItem").Content("DisableItem").Click("disableItem").IsPrimary(true).Render()
@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Id("homeTab").Header("Home").Groups(group =>
    {
        group.Header("Font").Collections(collection =>
        {
            collection.Id("buttonCollection").Items(item =>
            {
                item.Id("cutItem").Type(RibbonItemType.Button).ButtonSettings(button =>
                {
                    button.IconCss("e-icons e-cut").Content("cut");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function disableItem() {
        var ribbonObj = document.getElementById("ribbon").ej2_instances[0];
        ribbonObj.disableItem("cutItem");
    }
</script>

{% endhighlight %}
{% endtabs %}

## refreshLayout

The `refreshLayout` method can be used to update the layout and reflect the changes.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@Html.EJS().Button("refresh").Content("Refresh").Click("refreshLayout").IsPrimary(true).Render()
@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Id("homeTab").Header("Home").Groups(group =>
    {
        group.Header("Font").Collections(collection =>
        {
            collection.Id("buttonCollection").Items(item =>
            {
                item.Id("cutItem").Type(RibbonItemType.Button).ButtonSettings(button =>
                {
                    button.IconCss("e-icons e-cut").Content("cut");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
}).Render()

<script>
    function refreshLayout() {
        var ribbonObj = document.getElementById("ribbon").ej2_instances[0];
        ribbonObj.activeLayout = "Simplified";
        ribbonObj.refreshLayout();
    }
</script>

{% endhighlight %}
{% endtabs %}

## selectTab

The `selectTab` method is used to select a tab from the ribbon control. This method takes the `tabId` as a parameter.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@Html.EJS().Button("selectTab").Content("selectTab").Click("selectTab").IsPrimary(true).Render()
@Html.EJS().Ribbon("ribbon").Tabs(tab =>
{
    tab.Id("homeTab").Header("Home").Groups(group =>
    {
        group.Header("Font").Collections(collection =>
        {
            collection.Id("buttonCollection").Items(item =>
            {
                item.Id("cutItem").Type(RibbonItemType.Button).ButtonSettings(button =>
                {
                    button.IconCss("e-icons e-cut").Content("cut");
                }).Add();
            }).Add();
        }).Add();
    }).Add();
    tab.Id("insertTab").Header("Insert").Add();
}).Render()

<script>
    function selectTab() {
        var ribbonObj = document.getElementById("ribbon").ej2_instances[0];
        ribbonObj.selectTab("insertTab");
    }
</script>

{% endhighlight %}
{% endtabs %}