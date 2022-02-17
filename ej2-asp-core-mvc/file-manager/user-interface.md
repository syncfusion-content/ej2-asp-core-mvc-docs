---
layout: post
title: User Interface in ##Platform_Name## File Manager Component
description: Learn here all about User Interface in Syncfusion ##Platform_Name## File Manager component and more.
platform: ej2-asp-core-mvc
control: User Interface
publishingplatform: ##Platform_Name##
documentation: ug
---


# User Interface Structure

The file manager UI is comprised of several sections like view, toolbar, breadcrumb, context menu, and so on. The UI of the file manager is enhanced with injectable modules like `Details View` for browsing files and folders in a grid, `Navigation Pane` for folder navigation, and `Toolbar` for file operations. The file manager with all feature modules have the following sections in its UI.

* [Toolbar](#toolbar) (For direct access to file operations)
* [Navigation Pane](#navigation-pane) (For easy navigation between folders)
* [Breadcrumb](#breadcrumb) (For parent folder navigations)
* [View](#view) (For browsing files and folders using large icon view or details view)
* [Context Menu](#context-menu) (For accessing file operations)

![File Manager Overview](./images/user-interface.png "File Manager Overview")

The basic file manager is a light weight component with all the basic functions. The basic file manager have the following sections in its UI to browse files and folders and manage them with file operations.

* [Breadcrumb](#breadcrumb) (For parent folder navigations)
* [View](#view) (Large Icons view for browsing files and folders)
* [Context Menu](#context-menu) (For accessing file operations)

![Basic File Manager](./images/default-ui.png "Basic File Manager")

## Toolbar

The `Toolbar` provides easy access to the file operations using different buttons and it is presented at the top of the file manager.

If the toolbar items exceed the size of the toolbar, then the exceeding toolbar size will be moved to toolbar popup with a dropdown button at the end of toolbar.

*Refer [Toolbar](./file-operations/#toolbar) section in file operations to know more about the buttons present in toolbar*.

![Toolbar](./images/toolbar.png "Responsiveness of Toolbar")

## Files and folders navigation

The file manager provides navigation between files and folders using the following two options.

* [Navigation Pane](#navigation-pane)
* [Breadcrumb](#breadcrumb)

### Navigation pane

FileManager provides navigation pane, it displays the folder hierarchy of the file system and provides easy navigation to the desired folder. Using `navigationPaneSettings` minimum and maximum width of the navigation pane can be changed.
The navigation pane can be shown or hidden using the `visible` option in the `navigationPaneSettings`.

### BreadCrumb

The file manager provides breadcrumb for navigating to the parent folders. The breadcrumb the in file manager is responsible for resizing.
Whenever the path length exceeds the breadcrumb length, a dropdown button will be added at the starting of the breadcrumb to hold the parent folders adjacent to root.

![BreadCrumb](./images/breadcrumb.png "Responsiveness of BreadCrumb Bar")

## View

View is the section where the files and folders are displayed for the user to browse. The file manager has two types of views to display the files and folders.

* [Large Icons View](#large-icons-view)
* [Details View](#details-view)

The `large icons view` is the default starting view in the file manager. The view can be changed by using the [toolbar](#toolbar) view button or by using the view menu in [context menu](#context-menu). The `view` API can also be used to change the initial view of the file manager.

### Large icons view

In the large icons view, the thumbnail icons will be shown in a larger size, which displays the data in a form that best suits their content.  For image and video type files, a **preview** will be displayed. Extension thumbnails will be displayed for other type files.

![LargeIconView](./images/largeiconsview.png "File Manager Large Icon View")

### Details view

FileManager can be changed from large icon to details view by using `View` property. In the details view, the files are displayed in a sorted list order. This file list comprises of several columns of information about the files such as **Name**, **Date Modified**, **Type**, and **Size**. Each file has its own small icon representing the file type. Additional columns can be added using `detailsViewSettings` API. The details view allows you to perform sorting using column header.

![DetailsView](./images/detailsview.png "File Manager Details View")

## Context menu

The context menu appears on user interaction such as right-click. The file manager is provided with context menu support to perform list of file operations with the files and folders. Context menu appears with varying menu items based on the targets such as file, folder (including navigation pane folders),  and layout (empty area in view).

Context menu can be customized using the `contextMenuSettings`, `menuOpen`, and `menuClick` events.

*Refer [Context Menu](./file-operations/#context-menu) section in file operations to know more about the menu items present in context menu*.

![Context Menu](./images/contextmenu.png "Context Menu")