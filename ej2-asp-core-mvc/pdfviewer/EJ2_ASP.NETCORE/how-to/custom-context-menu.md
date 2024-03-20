---
layout: post
title: Customize context menu with EJ2 ASP.NET Core PDF Viewer | Syncfusion
description: Learn here all about Customize context menu in ASP.NET Core Pdfviewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: PDF Viewer
publishingplatform: ##Platform_Name##
documentation: ug
---

# Customize context menu in ASP.NET Core PDF Viewer control

PDF Viewer allows you to add custom option in context menu. It can be achieved by using the `addCustomMenu()` method and custom action is defined using the `customContextMenuSelect()`method.

### Add Custom Option

The following code shows how to add custom option in context menu.
```
<script type="text/javascript">

    var menuItems = [
        {
            text: 'Search In Google',
            id: 'search_in_google',
            iconCss: 'e-icons e-search'
        },
        {
            text: 'Lock Annotation',
            iconCss: 'e-icons e-lock',
            id: 'lock_annotation'
        },
        {
            text: 'Unlock Annotation',
            iconCss: 'e-icons e-unlock',
            id: 'unlock_annotation'
        },
        {
            text: 'Lock Form Fields',
            iconCss: 'e-icons e-lock',
            id: 'read_only_true'
        },
        {
            text: 'Unlock Form Fields',
            iconCss: 'e-icons e-unlock',
            id: 'read_only_false'
        },
    ];

    function documentLoaded(arg) {
        var pdfviewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfviewer.addCustomMenu(menuItems, false, false);
    }
</script>
```

### Customize custom option in context menu

The PDF Viewer feature enables customization of custom options and the ability to toggle the display of the default context menu. When the addCustomMenu parameter is set to `true`, the default menu is hidden; conversely, when it is set to `false`, the default menu items are displayed.

```
<script type="text/javascript">

    var menuItems = [
        {
            text: 'Search In Google',
            id: 'search_in_google',
            iconCss: 'e-icons e-search'
        },
        {
            text: 'Lock Annotation',
            iconCss: 'e-icons e-lock',
            id: 'lock_annotation'
        },
        {
            text: 'Unlock Annotation',
            iconCss: 'e-icons e-unlock',
            id: 'unlock_annotation'
        },
        {
            text: 'Lock Form Fields',
            iconCss: 'e-icons e-lock',
            id: 'read_only_true'
        },
        {
            text: 'Unlock Form Fields',
            iconCss: 'e-icons e-unlock',
            id: 'read_only_false'
        },
    ];

    function documentLoaded(arg) {
        var pdfviewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfviewer.addCustomMenu(menuItems, true);
    }
</script>
```

#### Customize added context menu items

The following code shows how to hide/show added custom option in context menu using the `customContextMenuBeforeOpen()` method.

```
<script type="text/javascript">

    var menuItems = [
        {
            text: 'Search In Google',
            id: 'search_in_google',
            iconCss: 'e-icons e-search'
        },
        {
            text: 'Lock Annotation',
            iconCss: 'e-icons e-lock',
            id: 'lock_annotation'
        },
        {
            text: 'Unlock Annotation',
            iconCss: 'e-icons e-unlock',
            id: 'unlock_annotation'
        },
        {
            text: 'Lock Form Fields',
            iconCss: 'e-icons e-lock',
            id: 'read_only_true'
        },
        {
            text: 'Unlock Form Fields',
            iconCss: 'e-icons e-unlock',
            id: 'read_only_false'
        },
    ];

    function documentLoaded(arg) {
        var pdfviewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfviewer.addCustomMenu(menuItems, false, false);
    }

    function customContextMenuSelect(args) {
        switch (args.id) {
            case 'search_in_google':
                var pdfviewer = document.getElementById('pdfviewer').ej2_instances[0];
                for (var i = 0; i < pdfviewer.textSelectionModule.selectionRangeArray.length; i++) {
                    var content = pdfviewer.textSelectionModule.selectionRangeArray[i].textContent;
                    if ((pdfviewer.textSelectionModule.isTextSelection) && (/\S/.test(content))) {
                        window.open('http://google.com/search?q=' + content);
                    }
                }
                break;
            case 'lock_annotation':
                lockAnnotations(args);
                break;
            case 'unlock_annotation':
                unlockAnnotations(args);
                break;
            case 'read_only_true':
                setReadOnlyTrue(args);
                break;
            case 'read_only_false':
                setReadOnlyFalse(args);
                break;
            case 'formfield properties':
                break;
            default:
                break;
        }
    };

   function customContextMenuBeforeOpen(args) {
        for (var i = 0; i < args.ids.length; i++) {
            var search = document.getElementById(args.ids[i]);
            var pdfviewer = document.getElementById('pdfviewer').ej2_instances[0];
            search.style.display = 'none';
            if (search) {
                search.style.display = 'none';
                if (args.ids[i] === 'search_in_google' && (pdfviewer.textSelectionModule) && pdfviewer.textSelectionModule.isTextSelection) {
                    search.style.display = 'block';
                } else if (args.ids[i] === "lock_annotation" || args.ids[i] === "unlock_annotation") {
                    var isLockOption = args.ids[i] === "lock_annotation";

                    for (var j = 0; j < pdfviewer.selectedItems.annotations.length; j++) {
                        var selectedAnnotation = pdfviewer.selectedItems.annotations[j];
                        if (selectedAnnotation && selectedAnnotation.annotationSettings) {
                            var shouldDisplay = (isLockOption && !selectedAnnotation.annotationSettings.isLock) ||
                                (!isLockOption && selectedAnnotation.annotationSettings.isLock);
                            search.style.display = shouldDisplay ? 'block' : 'none';
                        }
                    }
                } else if ((args.ids[i] === "read_only_true" || args.ids[i] === "read_only_false") && pdfviewer.selectedItems.formFields.length !== 0) {
                    var isReadOnlyOption = args.ids[i] === "read_only_true";
                    for (var j = 0; j < pdfviewer.selectedItems.formFields.length; j++) {
                        var selectedFormFields = pdfviewer.selectedItems.formFields[j];
                        if (selectedFormFields) {
                            var selectedFormField = pdfviewer.selectedItems.formFields[j].isReadonly;
                            var displayMenu = (isReadOnlyOption && !selectedFormField) || (!isReadOnlyOption && selectedFormField);
                            search.style.display = displayMenu ? 'block' : 'none';
                        }
                    }
                } else if (args.ids[i] === 'formfield properties' && pdfviewer.selectedItems.formFields.length !== 0) {
                    search.style.display = 'block';
                }
            }
        }
    };

</script>   
```

The following is the output of custom context menu with customization. 

```

<script type="text/javascript">

    var menuItems = [
        {
            text: 'Search In Google',
            id: 'search_in_google',
            iconCss: 'e-icons e-search'
        },
        {
            text: 'Lock Annotation',
            iconCss: 'e-icons e-lock',
            id: 'lock_annotation'
        },
        {
            text: 'Unlock Annotation',
            iconCss: 'e-icons e-unlock',
            id: 'unlock_annotation'
        },
        {
            text: 'Lock Form Fields',
            iconCss: 'e-icons e-lock',
            id: 'read_only_true'
        },
        {
            text: 'Unlock Form Fields',
            iconCss: 'e-icons e-unlock',
            id: 'read_only_false'
        },
    ];

    function documentLoaded(arg) {
        var pdfviewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfviewer.addCustomMenu(menuItems, false, false);
    }

    function customContextMenuSelect(args) {
        switch (args.id) {
            case 'search_in_google':
                var pdfviewer = document.getElementById('pdfviewer').ej2_instances[0];
                for (var i = 0; i < pdfviewer.textSelectionModule.selectionRangeArray.length; i++) {
                    var content = pdfviewer.textSelectionModule.selectionRangeArray[i].textContent;
                    if ((pdfviewer.textSelectionModule.isTextSelection) && (/\S/.test(content))) {
                        window.open('http://google.com/search?q=' + content);
                    }
                }
                break;
            case 'lock_annotation':
                lockAnnotations(args);
                break;
            case 'unlock_annotation':
                unlockAnnotations(args);
                break;
            case 'read_only_true':
                setReadOnlyTrue(args);
                break;
            case 'read_only_false':
                setReadOnlyFalse(args);
                break;
            case 'formfield properties':
                break;
            default:
                break;
        }
    };

    function customContextMenuBeforeOpen(args) {
        for (var i = 0; i < args.ids.length; i++) {
            var search = document.getElementById(args.ids[i]);
            var pdfviewer = document.getElementById('pdfviewer').ej2_instances[0];
            search.style.display = 'none';
            if (search) {
                search.style.display = 'none';
                if (args.ids[i] === 'search_in_google' && (pdfviewer.textSelectionModule) && pdfviewer.textSelectionModule.isTextSelection) {
                    search.style.display = 'block';
                } else if (args.ids[i] === "lock_annotation" || args.ids[i] === "unlock_annotation") {
                    var isLockOption = args.ids[i] === "lock_annotation";

                    for (var j = 0; j < pdfviewer.selectedItems.annotations.length; j++) {
                        var selectedAnnotation = pdfviewer.selectedItems.annotations[j];
                        if (selectedAnnotation && selectedAnnotation.annotationSettings) {
                            var shouldDisplay = (isLockOption && !selectedAnnotation.annotationSettings.isLock) ||
                                (!isLockOption && selectedAnnotation.annotationSettings.isLock);
                            search.style.display = shouldDisplay ? 'block' : 'none';
                        }
                    }
                } else if ((args.ids[i] === "read_only_true" || args.ids[i] === "read_only_false") && pdfviewer.selectedItems.formFields.length !== 0) {
                    var isReadOnlyOption = args.ids[i] === "read_only_true";
                    for (var j = 0; j < pdfviewer.selectedItems.formFields.length; j++) {
                        var selectedFormFields = pdfviewer.selectedItems.formFields[j];
                        if (selectedFormFields) {
                            var selectedFormField = pdfviewer.selectedItems.formFields[j].isReadonly;
                            var displayMenu = (isReadOnlyOption && !selectedFormField) || (!isReadOnlyOption && selectedFormField);
                            search.style.display = displayMenu ? 'block' : 'none';
                        }
                    }
                } else if (args.ids[i] === 'formfield properties' && pdfviewer.selectedItems.formFields.length !== 0) {
                    search.style.display = 'block';
                }
            }
        }
    };

    function lockAnnotations(args) {
        var pdfviewer = document.getElementById('pdfviewer').ej2_instances[0];
        for (var i = 0; i < pdfviewer.annotationCollection.length; i++) {
            if (pdfviewer.annotationCollection[i].uniqueKey === pdfviewer.selectedItems.annotations[0].id) {
                pdfviewer.annotationCollection[i].annotationSettings.isLock = true;
                pdfviewer.annotationCollection[i].isCommentLock = true;
                pdfviewer.annotation.editAnnotation(pdfviewer.annotationCollection[i]);
            }
            args.cancel = false;
        }
    }

    function unlockAnnotations(args) {
        var pdfviewer = document.getElementById('pdfviewer').ej2_instances[0];
        for (var i = 0; i < pdfviewer.annotationCollection.length; i++) {
            if (pdfviewer.annotationCollection[i].uniqueKey === pdfviewer.selectedItems.annotations[0].id) {
                pdfviewer.annotationCollection[i].annotationSettings.isLock = false;
                pdfviewer.annotationCollection[i].isCommentLock = false;
                pdfviewer.annotation.editAnnotation(pdfviewer.annotationCollection[i]);
            }
            args.cancel = false;
        }
    }

    function setReadOnlyTrue(args) {
        var pdfviewer = document.getElementById('pdfviewer').ej2_instances[0];
        var selectedFormFields = pdfviewer.selectedItems.formFields;
        for (var i = 0; i < selectedFormFields.length; i++) {
            var selectedFormField = selectedFormFields[i];
            if (selectedFormField) {
                pdfviewer.formDesignerModule.updateFormField(selectedFormField, {
                    isReadOnly: true,
                });
            }
            args.cancel = false;
        }
    }

    function setReadOnlyFalse(args) {
        var pdfviewer = document.getElementById('pdfviewer').ej2_instances[0];
        var selectedFormFields = pdfviewer.selectedItems.formFields;
        for (var i = 0; i < selectedFormFields.length; i++) {
            var selectedFormField = selectedFormFields[i];
            if (selectedFormField) {
                pdfviewer.formDesignerModule.updateFormField(selectedFormField, {
                    isReadOnly: false,
                });
            }
            args.cancel = false;
        }
    }

    function contextmenuHelper(args) {
        var pdfviewer = document.getElementById('pdfviewer').ej2_instances[0];
        pdfviewer.addCustomMenu(menuItems, enable.checked, position.checked);
    }

</script>

```