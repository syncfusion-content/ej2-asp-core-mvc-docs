---
layout: post
title: Customize Ribbon in ##Platform_Name## Document Editor | Syncfusion
description: Learn how to customize the ribbon in Syncfusion ##Platform_Name## Document Editor - file menu, backstage, tabs, groups, and items.
platform: ej2-asp-core-mvc
control: Ribbon Customization
publishingplatform: ##Platform_Name##
documentation: ug
domainurl: ##DomainURL##
---

# Customize Ribbon in ##Platform_Name## Document Editor

The Syncfusion Document Editor provides an extensive and flexible API to customize the built-in ribbon UI. You can:

- Customize the File menu.
- Add the Backstage menu instead of File menu.
- Show, hide, or add Ribbon tabs.
- Show, hide, or add groups within tabs.
- Show, hide, add, enable, or disable items within groups.

Below are detailed examples for each ribbon customization scenario.

## File Menu Customization

Document Editor provides APIs to remove existing File menu items and add new custom items based on your requirements. You can modify the File menu using the `fileMenuItems` property.

In below code example, In the example below, the "Open" and "Export" items have been removed from the File Menu Items, and new custom items have been added.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/customize-ribbon-file/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Customize-ribbon-file.cs" %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/customize-ribbon-file/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Customize-ribbon-file.cs" %}
{% endhighlight %}
{% endtabs %}

{% endif %}

## Backstage Menu Customization

The Document Editor provides an `backStageMenu` API to add a backstage menu. When the backstage menu is enabled, the default File menu items are automatically hidden.

The following code example shows how to add the backstage menu items.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/customize-ribbon-backstage/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Customize-ribbon-backstage.cs" %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/customize-ribbon-backstage/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Customize-ribbon-backstage.cs" %}
{% endhighlight %}
{% endtabs %}

{% endif %}

Refer this documentation know more about [`backstage items`](https://ej2.syncfusion.com/documentation/ribbon/backstage)

## Tab Customization

You can customize the ribbon tabs in the Document Editor by showing, hiding, or adding tabs according to your application's requirements.

### Show/Hide Tab

Document editor provides the `showTab` API to show and hide the existing tab using existing `RibbonTabType` and `tabId`.

The following code example how to show/hide existing tab using existing tab type and tab id.

```typescript

// To hide the Home tab using the built-in `RibbonTabType`
container.ribbon.showTab('Home', false);

// To hide a tab by its tab id (for example, a custom tab)
container.ribbon.showTab('custom_tab', false);
```

### Add Tab

The Document Editor provides the `addTab` API, which allows you to insert a new custom tab either between existing tabs or at the end of the ribbon tabs.

```typescript

<script>
    ej.documenteditor.DocumentEditorContainer.Inject(ej.documenteditor.Toolbar, ej.documenteditor.Ribbon);
        
        // For initialization before adding ribbon tab
        setTimeout(function () {
            var container = document.getElementById('container').ej2_instances[0];
            // To add the tab at end of tab
            var ribbonTab = {
                header: 'Custom Tab',
                id: 'custom_tab',
                groups: [{
                    header: 'Custom Group',
                    collections: [{
                        items: [{
                            type: 'Button',
                            buttonSettings: {
                                content: 'New',
                                iconCss: 'e-icons e-de-ctnr-new',
                                clicked: function () {
                                    container.documentEditor.openBlank();
                                }
                            }
                        }]
                    }]
                }]
            };
            container.ribbon.addTab(ribbonTab);

            // To add the tab before the Insert tab(exising tab)
            container.ribbon.addTab(ribbonTab, 'Insert');
        }, 100);
</script>

```

## Group Customization

You can also customize ribbon groups within a tab to better organize commands or add new functionalities as per your needs.

### Show/Hide Group 

Document Editor provides an `showGroup` API to show or hide existing groups within a ribbon tab.

The following code example show how to show/hide the group using group Id or `RibbonGroupInfo`.

```typescript

// To hide the clipboard group using group index
container.ribbon.showGroup({tabId: 'Home', index: 1} , false);

// To show the clipboard group using group index
container.ribbon.showGroup({tabId: 'Home', index: 1} , true);

// To hide the group using id
container.ribbon.showGroup('custom_group', false);

```

### Add Group

To extend the ribbon's functionality, you can add custom groups to any tab. This allows you to organize related commands together within a tab.

```typescript

<script>
    ej.documenteditor.DocumentEditorContainer.Inject(ej.documenteditor.Toolbar, ej.documenteditor.Ribbon);
        
        // For initialization before adding ribbon tab
        setTimeout(function () {
            var container = document.getElementById('container').ej2_instances[0];
            // Add the new group at the end of the Home tab
            var ribbonGroup = {
                header: 'Custom Group',
                collections: [{
                    items: [{
                        type: 'Button',
                        buttonSettings: {
                            content: 'New',
                            iconCss: 'e-icons e-de-ctnr-new',
                            clicked: function () {
                                container.documentEditor.openBlank();
                            }
                        }
                    }]
                }]
            };
            container.ribbon.addGroup('Home', ribbonGroup);

            // Add the new group at the specified index of the Home tab (before the Clipboard group)

            container.ribbon.addGroup('Home', ribbonGroup, 1);
        }, 100);
</script>

```

## Item Customization

You can customize individual items within ribbon groups. This includes showing, hiding, enabling, disabling, or adding new items to any group within a ribbon tab.

### Show/Hide Item

Using `showItems` API in Document editor ribbon to enable/disable the existing item. Here, you can specify the item Id or `RibbonItemInfo`.

The following code example show how to show/hide the item using item Id or `RibbonItemInfo`.

```typescript
// To hide the Bold and Italic items using ribbon item information
container.ribbon.showItems({ tabId: 'Home', groupIndex: 2, itemIndexes: [5, 6] } , false);

// To show the Bold and Italic items using ribbon item information
container.ribbon.showItems({ tabId: 'Home', groupIndex: 2, itemIndexes: [5, 6] } , true);

// To hide the item using item id
container.ribbon.showItems('custom_item', false);
```

### Enable/Disable Item

Using `enableItems` API in Document editor ribbon to enable/disable the existing item.

```typescript
// To disable the underline using ribbon item info
container.ribbon.enableItems({ tabId: 'Home', groupIndex: 2, itemIndexes: [7] },false);

// To enable the underline using ribbon item info
container.ribbon.enableItems({ tabId: 'Home', groupIndex: 2, itemIndexes: [7] },true);

// To disable the item using id
container.ribbon.enableItems('custom_item', false);

```

### Add Item

You can use the `addItem` API in the Document Editor ribbon to add a new item. Additionally, you can specify the target tab and group where the new item should be placed.

```typescript

<script>
    ej.documenteditor.DocumentEditorContainer.Inject(ej.documenteditor.Toolbar, ej.documenteditor.Ribbon);

    // For initialization before adding ribbon tab
    setTimeout(function () {
        var container = document.getElementById('container').ej2_instances[0];
        
        // To add the item at the end of the specified group (the item will be added at the end of the Undo group)
        var ribbonItem = {
            type: 'Button',
            buttonSettings: {
                content: 'New',
                iconCss: 'e-icons e-de-ctnr-new',
                clicked: function () {
                    container.documentEditor.openBlank();
                }
            }
        };
        container.ribbon.addItem({ tabId: 'Home', index: 0 }, ribbonItem);

        // To add the item before the specified item index (the item will be added before the Redo item in the Undo group)

        container.ribbon.addItem({ tabId: 'Home', index: 0 }, ribbonItem, 1);
    }, 100);
</script>

```


## Related Links

- [File menu Customization Demo](https://ej2.syncfusion.com/demos/#/material/document-editor/ribbon-customization)