---
title: "Getting Started"
component: "Sidebar"
description: "This getting started section briefly explains how to create a sidebar component in application."
---

# Getting Started

This section briefly explains how to include simple Sidebar control in your ASP.NET MVC application. You can refer to [ASP.NET MVC Getting Started documentation](../../getting-started/) page for system requirements, and configure common specifications.

> Starting with v16.2.0.x, if you reference Syncfusion assemblies from trial setup or from the NuGet feed, you also have to include a license key in your projects. Please refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key#aspnet-mvc) to know about registering Syncfusion license key in your ASP.NET MVC application to use our components.

## Adding component to the Application

* Now open your view page to render Sidebar components.

```cs

 <!-- sidebar element declaration -->
@{Html.EJS().Sidebar("default-sidebar").CloseOnDocumentClick(false).ContentTemplate(@<div>
        <div class="title-header">
            <div style="display:inline-block"> Sidebar </div>
        </div>
</div>).Render();
}
<!-- end of sidebar element -->
<!--  Main Content declaration -->
<div>
    <div class="title default">Main content</div>
    <div class="sub-title">
        Place your primary content here.
    </div>
</div>

```

## Run the application

After successful compilation of your application, simply press `F5` to run the application.

The following example shows a basic Sidebar component.

{% aspTab template="sidebar/getting-started/getting-started", sourceFiles="getting-started.cs" %}

{% endaspTab %}

Output be like the below.

![Sidebar Sample](./images/getting_Started.png)

## Enable backdrop

Enabling the `showBackdrop` in the Sidebar component will prevent
the main content from user interactions.
Here, the DOM elements will not get changed. It only closes the main content by covering with a black backdrop overlay and focuses the Sidebar in the screen. Sidebar can be rendered with specific width by setting [`width`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Sidebar~Width.html) property.

The following example shows a Sidebar component with enabled backdrop.

{% aspTab template="sidebar/getting-started/backdrop/", sourceFiles="backdrop.cs" %}

{% endaspTab %}

Output be like the below.

![Sidebar Sample](./images/backdrop.png)

## Position

Positioning the Sidebar to the right or left of the main content can be achieved by using the `position` property.
If the position is not set, the Sidebar will expand from the left to the body element.[`enablePersistence`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Sidebar~EnablePersistence.html) will persist the component's state between page reloads. [`change`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Sidebar~Change.html) event will be triggered when the state(expand/collapse) of the component is changed.

In the following sample, the sidebar is rendered with position property.

{% aspTab template="sidebar/getting-started/position/", sourceFiles="position.cs" %}

{% endaspTab %}

Output be like the below.

![Sidebar Sample](./images/position.png)

## Animate

Animation transitions can be set while expanding or collapsing the Sidebar using the [`animate`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Sidebar~Animate.html) property. By default , [`animate`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Sidebar~Animate.html) property is set to true. [`enableRTL`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Sidebar~EnableRtl.html) will display the sidebar in the right-to-left direction.

{% aspTab template="sidebar/animate", sourceFiles="animate.cs" %}

{% endaspTab %}

Output be like the below.

![Sidebar Sample](./images/backdrop.png)

## Close on document click

Sidebar can be closed on document click by setting [`closeOnDocumentClick`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Sidebar~CloseOnDocumentClick.html) to true. If this property is not set, the Sidebar will not close on document click since its default value is false. Sidebar can be kept opened during rendering using [`isOpen`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Sidebar~IsOpen.html) property.

{% aspTab template="sidebar/document_click", sourceFiles="document_click.cs" %}

{% endaspTab %}

Output be like the below.

![Sidebar Sample](./images/document_click.png)

## Enable gestures

Expand or collapse the Sidebar while swiping in touch devices using [`enableGestures`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Sidebar~EnableGestures.html) property. By default, [`enableGestures`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Sidebar~EnableGestures.html) is set to true.

{% aspTab template="sidebar/gestures", sourceFiles="gestures.cs" %}

{% endaspTab %}

Output be like the below.

![Sidebar Sample](./images/backdrop.png)

## See Also

* [Sidebar with Menu Component](https://ej2.syncfusion.com/aspnetmvc/Sidebar/SidebarWithMenu#/material)
* [Sidebar Responsive Panel](https://ej2.syncfusion.com/aspnetmvc/Sidebar/PanelWithResponsive#/material)
* [Usecase Sample](https://ej2.syncfusion.com/showcase/aspnetmvc/webmail/ )
