---
layout: post
title: Install Through Nuget Packages in ##Platform_Name## Component
description: Learn here all about Install Through Nuget Packages in Syncfusion ##Platform_Name## component and more.
platform: ej2-asp-core-mvc
control: Install Through Nuget Packages
publishingplatform: ##Platform_Name##
documentation: ug
---

# Install Syncfusion ASP.NET MVC JS2 NuGet packages

## Overview

**NuGet** is a Package management system for Visual Studio. It makes it easy to add, update and remove external libraries in our application. Syncfusion publishing all ASP.NET MVC JS2  NuGet packages in [nuget.org](https://www.nuget.org/packages?q=Tags%3A%22AspNet.MVC%20EJ2%22+syncfusion). The Syncfusion ASP.NET MVC JS2 NuGet packages can be used without installing the Syncfusion setup by Syncfusion Installer. You can simply exploit the Syncfusion ASP.NET MVC JS2 NuGet packages in ASP.NET MVC application to develop with the Syncfusion ASP.NET MVC JS2 components.

> The Syncfusion.EJ2.MVC5 NuGet package, which contains all Syncfusion ASP.NET MVC JS2 components in a single package, is available beginning with v16.1.0.24 (Essential Studio 2018 Volume 1).

## Installation using Package Manager UI

The NuGet **Package Manager UI** allows you to search, install, uninstall, and update Syncfusion ASP.NET MVC JS2 NuGet packages in your applications and solutions. You can find and install the Syncfusion ASP.NET MVC JS2 NuGet packages in your Visual Studio ASP.NET MVC web application and this process is easy with the steps below:

1. To open the Manage NuGet packages UI, follow either one of the options below:

    **Option 1:**

    Right-click on the ASP.NET MVC web application or solution in the Solution Explorer, and choose **Manage NuGet Packages...**

    ![Manage NuGet Packages add-in](images/ManageNuGet.png)

    **Option 2:**

    After opening the ASP.NET MVC web application in Visual Studio, go to the **Tools** menu and after hovering **NuGet Package Manager**, select **Manage NuGet Packages for Solution...**

    ![Manage NuGet Packages add-in](images/ManageNuGetOption2.png)

2. The Manage NuGet Packages window will open. Navigate to the **Browse** tab, then search for the Syncfusion ASP.NET MVC JS2 NuGet packages using a term like **"Syncfusion.EJ2.MVC5"** and select the appropriate Syncfusion ASP.NET MVC NuGet package for your development.

    > The [nuget.org](https://api.nuget.org/v3/index.json) package source is selected by default in the Package source drop-down. If your Visual Studio does not have nuget.org configured, follow the instructions in the [Microsoft documents](https://docs.microsoft.com/en-us/nuget/tools/package-manager-ui#package-sources) to set up the nuget.org feed URL.

    ![ASP.NET MVC NuGet Packages Search](images/NuGetSearch.png)

3. When you select a package, the right side panel will provide more information about it.

4. By default, the package selected with latest version. You can choose the required version and click the **Install** button and accept the license terms. The package will be added to your ASP.NET MVC application.

    ![ASP.NET MVC NuGet Packages Install](images/InstallNuGet.png)

5. At this point, your application has all the required Syncfusion assemblies, and you will be ready to start building high-performance, responsive app with [Syncfusion ASP.NET MVC JS2 components](https://www.syncfusion.com/aspnet-mvc-ui-controls). Also, you can refer to the [ASP.NET MVC JS2 help document](https://ej2.syncfusion.com/aspnetmvc/documentation/introduction/) for development.

## Installation using Package Manager Console

The **Package Manager Console** saves NuGet packages installation time since you don't have to search for the Syncfusion.EJ2.MVC5 NuGet package which you want to install, and you can just type the installation command to install the appropriate Syncfusion ASP.NET MVC JS2 NuGet package. Follow the instructions below to use the Package Manager Console to reference the Syncfusion ASP.NET MVC JS2 component as NuGet packages in your ASP.NET MVC web application.

1. To show the Package Manager Console, open your ASP.NET MVC web application in Visual Studio and navigate to **Tools -> NuGet Package Manager -> Package Manager Console**.

    ![Package Manager Console ](images/console.png)

2. The **Package Manager Console** will be shown at the bottom of the screen. You can install the Syncfusion ASP.NET MVC JS2 NuGet packages by enter the following NuGet installation commands.

    ***Install specified Syncfusion ASP.NET MVC JS2 NuGet package.***

    The below command will install the Syncfusion ASP.NET MVC JS2 NuGet package in the default ASP.NET MVC application.

    ```Install-Package <Package Name>```

    **For example:** Install-Package Syncfusion.EJ2.MVC5

    > You can find the list of Syncfusion ASP.NET MVC JS2 NuGet packages which are published in nuget.org from [here](https://www.nuget.org/packages?q=Tags%3A%22AspNet.Mvc%20EJ2%22+syncfusion)

    ***Install specified Syncfusion ASP.NET MVC JS2 NuGet package in specified ASP.NET MVC application***

    The below command will install the Syncfusion ASP.NET MVC JS2 NuGet package in the given ASP.NET MVC application.

    ```Install-Package <Package Name> -ProjectName <Project Name>```

    **For example:** Install-Package Syncfusion.EJ2.MVC5 -ProjectName SyncfusionMVCWebApplication

3. By default, the package will be installed with latest version. You can give the required version with the -Version term like below to install the Syncfusion ASP.NET MVC JS2 NuGet packages in the appropriate version.

    ```Install-Package Syncfusion.EJ2.MVC5 -Version 19.2.0.57```

    ![Package Manager Console Output ](images/ConsoleInstallationOutput.PNG)

4. The NuGet package manager console will install the Syncfusion ASP.NET MVC JS2 NuGet package as well as the dependencies it has. When the installation is complete, the console will show that your Syncfusion ASP.NET MVC JS2 package has been successfully added to the application.

5. At this point, your application has all the required Syncfusion assemblies, and you will be ready to start building high-performance, responsive app with [Syncfusion ASP.NET MVC JS2 components](https://www.syncfusion.com/aspnet-core-ui-controls). Also, you can refer to the [ASP.NET MVC JS2 help document](https://ej2.syncfusion.com/aspnetcore/documentation/introduction/) for development.