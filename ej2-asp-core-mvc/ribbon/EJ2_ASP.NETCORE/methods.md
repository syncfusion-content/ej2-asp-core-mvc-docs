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

To add an tab dynamically, use the [addTab] method in the ribbon control. The following are the arguments for this method.

|   Argument name      |   Description                            |
|----------------------| -----------------------------------------|
|     tab              |    Gets the tab data to add.|
|     targetId (optional)|    Gets the ID of the target tab to add the new tab.|
|     isAfter (optional)|     Defines whether the tab is added before or after the target.|

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

<ejs-button id="addTab" content="AddTab" onclick="addTab()" isPrimary="true"></ejs-button>

<ejs-ribbon id="ribbon">
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

<script>
    function addTab() {
        var ribbonObj = document.getElementById("ribbon").ej2_instances[0];
        let newTab = {
            header: "Insert",
            id: "tab"
        };
        ribbonObj.addTab(newTab);
    }
</script>

{% endhighlight %}
{% endtabs %}

## addGroup

To add an group dynamically, use the [addGroup] method in the ribbon control. The following are the arguments for this method.

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

<ejs-button id="addGroup" content="AddGroup" onclick="addGroup()" isPrimary="true"></ejs-button>

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home" id="homeTab">
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

<script>
    function addGroup() {
        var ribbonObj = document.getElementById("ribbon").ej2_instances[0];
        let newGroup = {
            header: "newGroup",
            id: "insertGroup"
        }
        ribbonObj.addGroup("homeTab", newGroup);
    }
</script>

{% endhighlight %}
{% endtabs %}

## addCollection

To add an collection dynamically, use the [addCollection] method in the ribbon control. The following are the arguments for this method.

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

<ejs-button id="addCollection" content="AddCollection" onclick="addCollection()" isPrimary="true"></ejs-button>

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Font" id="fontGroup">
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
    function addCollection() {
        var ribbonObj = document.getElementById("ribbon").ej2_instances[0];
        let newCollection = {
            id: "insertCollection",
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
    ribbonObj.addCollection("fontGroup", newCollection)
    }
</script>

{% endhighlight %}
{% endtabs %}

## addItem

To add an item dynamically, use the [addItem] method in the ribbon control. The following are the arguments for this method.

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

<ejs-button id="addItem" content="AddItem" onclick="addItem()" isPrimary="true"></ejs-button>

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home" id="homeTab">
            <e-ribbon-groups>
                <e-ribbon-group header="Font" id="fontGroup" orientation="Column">
                    <e-ribbon-collections>
                        <e-ribbon-collection id="buttonCollection">
                            <e-ribbon-items>
                                <e-ribbon-item type=Button allowedSizes="Medium">
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
    function addItem() {
        var ribbonObj = document.getElementById("ribbon").ej2_instances[0];
        let newItem = {
            id: "insertItem",
            type: "ColorPicker",
            colorPickerSettings: {
                value: "035a"
            }
        }
        ribbonObj.addItem("buttonCollection", newItem)
    }
</script>

{% endhighlight %}
{% endtabs %}

## removeTab

The [removeTab] method is used to removes a tab from the ribbon control. This method takes the `tabId` as a parameter.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

<ejs-button id="removeTab" content="RemoveTab" onclick="removeTab()" isPrimary="true"></ejs-button>

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home" id="homeTab">
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
        <e-ribbon-tab header="Insert" id="insertTab">
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>
    function removeTab() {
        var ribbonObj = document.getElementById("ribbon").ej2_instances[0];
        ribbonObj.removeTab("insertTab")
    }
</script>

{% endhighlight %}
{% endtabs %}

## removeGroup

The [removeGroup] method is used to remove a group of items from the ribbon control. This method takes the `groupId` as a parameter.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

<ejs-button id="removeGroup" content="RemoveGroup" onclick="removeGroup()" isPrimary="true"></ejs-button>

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Font" id="buttonGroup">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item displayOptions=Auto type=Button>
                                    <e-ribbon-buttonsettings iconCss="e-icons e-cut" content="Cut"></e-ribbon-buttonsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
                <e-ribbon-group header="ClipBoard" id="clipBoard">
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>
    function removeGroup() {
        var ribbonObj = document.getElementById("ribbon").ej2_instances[0];
        ribbonObj.removeGroup("clipBoard");
    }
</script>

{% endhighlight %}
{% endtabs %}

## removeCollection

The [removeCollection] method is used to remove a collection of items from the ribbon control. This method takes the `collectionId` as a parameter.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

<ejs-button id="removeCollection" content="RemoveCollection" onclick="removeCollection()" isPrimary="true"></ejs-button>

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Font">
                    <e-ribbon-collections>
                        <e-ribbon-collection id="buttonCollection">
                            <e-ribbon-items>
                                <e-ribbon-item type=Button>
                                    <e-ribbon-buttonsettings iconCss="e-icons e-cut" content="Cut"></e-ribbon-buttonsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                        <e-ribbon-collection id="colorPickerCollection">
                            <e-ribbon-items>
                                <e-ribbon-item type=ColorPicker>
                                    <e-ribbon-colorpickersettings value="035a"></e-ribbon-colorpickersettings>
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
    function removeCollection() {
        var ribbonObj = document.getElementById("ribbon").ej2_instances[0];
        ribbonObj.removeCollection("colorPickerCollection");
    }
</script>

{% endhighlight %}
{% endtabs %}

## removeItem

The [removeItem] method is used to removes an items from the ribbon control. This method takes the `itemId` as a parameter.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

<ejs-button id="removeItem" content="RemoveItem" onclick="removeItem()" isPrimary="true"></ejs-button>

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Font">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type=Button id="cutItem">
                                    <e-ribbon-buttonsettings iconCss="e-icons e-cut" content="Cut"></e-ribbon-buttonsettings>
                                </e-ribbon-item>
                                <e-ribbon-item type=Button id="copyItem">
                                    <e-ribbon-buttonsettings iconCss="e-icons e-copy" content="Copy"></e-ribbon-buttonsettings>
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
    function removeItem() {
        var ribbonObj = document.getElementById("ribbon").ej2_instances[0];
        ribbonObj.removeItem("copyItem")
    }
</script>

{% endhighlight %}
{% endtabs %}

## enableItem

The [enableItem] method in a ribbon control is used to enable a specific item in the ribbon control. This method takes the `itemId` as a parameter.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

<ejs-button id="enableItem" content="EnableItem" onclick="enableItem()" isPrimary="true"></ejs-button>

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Font">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type=Button disabled=true id="cutItem">
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
    function enableItem() {
        var ribbonObj = document.getElementById("ribbon").ej2_instances[0];
        ribbonObj.enableItem("cutItem")
    }
</script>

{% endhighlight %}
{% endtabs %}

## disableItem

The [disableItem] method in a ribbon control is used to disable a specific item in the ribbon control. This method takes the item's ID as a parameter.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

<ejs-button id="disableItem" content="DisableItem" onclick="disableItem()" isPrimary="true"></ejs-button>

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Font">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type=Button id="cutItem">
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
    function disableItem() {
        var ribbonObj = document.getElementById("ribbon").ej2_instances[0];
        ribbonObj.disableItem("cutItem")
    }
</script>

{% endhighlight %}
{% endtabs %}

## refreshLayout

The [refreshLayout] method is called to update the layout and reflect these changes.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

<ejs-button id="refresh" content="Refresh" onclick="refreshLayout()" isPrimary="true"></ejs-button>

<ejs-ribbon id="ribbon" activeLayout="Classic">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home" id="homeTab">
            <e-ribbon-groups>
                <e-ribbon-group header="Font" id="fontGroup" orientation="Column">
                    <e-ribbon-collections>
                        <e-ribbon-collection id="buttonCollection">
                            <e-ribbon-items>
                                <e-ribbon-item type=Button id="cutButton" allowedSizes="Medium">
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
    function refreshLayout() {
        var ribbonObj = document.getElementById("ribbon").ej2_instances[0];
        ribbonObj.activeLayout = "Simplified";
        ribbonObj.refreshLayout();
    }
</script>

{% endhighlight %}
{% endtabs %}

## selectTab

The [selectTab] method is used to selects a tab from the ribbon control. This method takes the `tabId` as a parameter.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

<ejs-button id="selectTab" content="selectTab" onclick="selectTab()" isPrimary="true"></ejs-button>

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home" id="homeTab">
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
        <e-ribbon-tab header="Insert" id="insertTab">
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<script>
    function selectTab() {
        var ribbonObj = document.getElementById("ribbon").ej2_instances[0];
        ribbonObj.selectTab("insertTab")
    }
</script>

{% endhighlight %}
{% endtabs %}