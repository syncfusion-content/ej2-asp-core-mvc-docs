---
layout: post
title: Install Nuget Packages in ##Platform_Name## Ej2_asp.netcore Component
description: Learn here all about Install Nuget Packages in Syncfusion ##Platform_Name## Ej2_asp.netcore component and more.
platform: ej2-asp-core-mvc
control: Install Nuget Packages
publishingplatform: ##Platform_Name##
documentation: ug
---

# Install Syncfusion ASP.NET Core JS2 NuGet packages

## Overview

**NuGet** is a Package management system for Visual Studio. It makes it easy to add, update and remove external libraries in our application. Syncfusion publishing all ASP.NET Core JS2  NuGet packages in [nuget.org](https://www.nuget.org/packages?q=Tags%3A%22AspNet.Core%20EJ2%22+syncfusion). The Syncfusion ASP.NET Core JS2 NuGet packages can be used without installing the Syncfusion installation. You can simply exploit the Syncfusion ASP.NET Core JS2 NuGet packages in ASP.NET Core application to develop with the Syncfusion ASP.NET Core JS2 components.

> The Syncfusion.EJ2.AspNet.Core NuGet package, which contains all Syncfusion ASP.NET Core JS2 components in a single package, is available beginning with v16.3.0.21 (Essential Studio 2018 Volume 3).

## Installation using Package Manager UI

The NuGet **Package Manager UI** allows you to search, install, uninstall, and update Syncfusion ASP.NET Core JS2 NuGet packages in your applications and solutions. You can find and install the Syncfusion ASP.NET Core JS2 NuGet packages in your Visual Studio ASP.NET Core web application and this process is easy with the steps below:

1. To open the Manage NuGet packages UI, follow either one of the options below:

    **Option 1:**

    Right-click on the ASP.NET MVC web application or solution in the Solution Explorer, and choose **Manage NuGet Packages...**

    ![Manage NuGet Packages add-in](images/ManageNuGet.png)

    **Option 2:**

    After opening the ASP.NET Core web application in Visual Studio, go to the **Tools** menu and after hovering **NuGet Package Manager**, select **Manage NuGet Packages for Solution...**

    ![Manage NuGet Packages add-in](images/ManageNuGetOption2.png)

2. The Manage NuGet Packages window will open. Navigate to the **Browse** tab, then search for the Syncfusion ASP.NET Core JS2 NuGet packages using a term like **"Syncfusion.EJ2.AspNet.Core"** and select the appropriate Syncfusion ASP.NET Core NuGet package for your development.

    > The [nuget.org](https://api.nuget.org/v3/index.json) package source is selected by default in the Package source drop-down. If your Visual Studio does not have nuget.org configured, follow the instructions in the [Microsoft documents](https://docs.microsoft.com/en-us/nuget/tools/package-manager-ui#package-sources) to set up the nuget.org feed URL.

    ![ASP.NET Core NuGet Packages Search](images/NuGetsearch.png)

3. When you select a package, the right side panel will provide more information about it.

4. By default, the package selected with latest version. You can choose the required version and click the **Install** button and accept the license terms. The package will be added to your ASP.NET Core application.

    ![ASP.NET Core NuGet Packages Install](images/InstallNuGet.png)

5. At this point, your application has all the required Syncfusion assemblies, and you will be ready to start building high-performance, responsive app with [Syncfusion ASP.NET Core JS2 components](https://www.syncfusion.com/aspnet-core-ui-controls). Also, you can refer to the [ASP.NET Core JS2 help document](https://ej2.syncfusion.com/aspnetcore/documentation/introduction/) for development.

## Installation using Dotnet (.NET) CLI

The [dotnet Command Line Interface (CLI)](https://docs.microsoft.com/en-us/nuget/consume-packages/install-use-packages-dotnet-cli), allows you to add, restore, pack, publish, and manage packages without making any changes to your application files. [Dotnet add package](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-add-package?tabs=netcore2x) adds a package reference to the application file, then runs [dotnet restore](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-restore?tabs=netcore2x) to install the package.

Follow the below instructions to use the dotnet CLI command to install the Syncfusion ASP.NET Core JS2 NuGet packages.

1. Open a command prompt and navigate to the directory where your ASP.NET Core web application project file is located.
2. To install a NuGet package, run the following command.

    ```dotnet add package <Package name>```

    **For Example:**
    dotnet add package Syncfusion.EJ2.AspNet.Core

    > If you don’t provide a version flag, this command will be upgrading to the latest version by default. To specify a version, add the -v parameter: dotnet add package Syncfusion.EJ2.AspNet.Core -v 19.2.0.57

3. Examine the ASP.NET Core project file after the command has completed to ensure that the Syncfusion ASP.NET Core JS2 package was installed. To see the added reference, open the .csproj file.

    ![ASP.NET Core Package Entry ](images/packageentry.png)

4. Then run  [dotnet restore](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-restore?tabs=netcore2x) command to restores all the packages listed in the application file.

    > Restoring is done automatically with **dotnet build** and **dotnet run** in .NET Core 2.0 and later.

5. At this point, your application has all the required Syncfusion assemblies, and you will be ready to start building high-performance, responsive app with [Syncfusion ASP.NET Core JS2 components](https://www.syncfusion.com/aspnet-core-ui-controls). Also, you can refer to the [ASP.NET Core JS2 help document](https://ej2.syncfusion.com/aspnetcore/documentation/introduction/) for development.

## Installation using Package Manager Console

The **Package Manager Console** saves NuGet packages installation time since you don't have to search for the Syncfusion.EJ2.AspNet.Core NuGet package which you want to install, and you can just type the installation command to install the appropriate Syncfusion ASP.NET Core JS2 NuGet package. Follow the instructions below to use the Package Manager Console to reference the Syncfusion ASP.NET Core JS2 component as NuGet packages in your ASP.NET Core web application.

1. To show the Package Manager Console, open your ASP.NET Core web application in Visual Studio and navigate to **Tools -> NuGet Package Manager -> Package Manager Console**.

    ![Package Manager Console ](images/console.png)

2. The **Package Manager Console** will be shown at the bottom of the screen. You can install the Syncfusion ASP.NET Core JS2 NuGet packages by enter the following NuGet installation commands.

    ***Install specified Syncfusion ASP.NET Core JS2 NuGet package.***

    The below command will install the Syncfusion ASP.NET Core NuGet package in the default ASP.NET Core application.

    ```Install-Package <Package Name>```

    **For example:** Install-Package Syncfusion.EJ2.AspNet.Core

    > You can find the list of Syncfusion ASP.NET Core NuGet packages which are published in nuget.org from [here](https://www.nuget.org/packages?q=Tags%3A%22AspNet.Core%20EJ2%22+syncfusion)

    ***Install specified Syncfusion ASP.NET Core JS2 NuGet package in specified ASP.NET Core application***

    The below command will install the Syncfusion ASP.NET Core JS2 NuGet package in the given ASP.NET Core application.

    ```Install-Package <Package Name> -ProjectName <Project Name>```

    **For example:** Install-Package Syncfusion.EJ2.AspNet.Core -ProjectName SyncfusionWebApplication

3. By default, the package will be installed with latest version. You can give the required version with the -Version term like below to install the Syncfusion ASP.NET Core JS2 NuGet packages in the appropriate version.

    ```Install-Package Syncfusion.EJ2.AspNet.Core -Version 19.2.0.57```

    ![Package Manager Console Output ](images/ConsoleInstallationOutput.png)

4. The NuGet package manager console will install the Syncfusion ASP.NET Core JS2 NuGet package as well as the dependencies it has. When the installation is complete, the console will show that your Syncfusion ASP.NET Core JS2 package has been successfully added to the application.

5. At this point, your application has all the required Syncfusion assemblies, and you will be ready to start building high-performance, responsive app with [Syncfusion ASP.NET Core JS2 components](https://www.syncfusion.com/aspnet-core-ui-controls). Also, you can refer to the [ASP.NET Core JS2 help document](https://ej2.syncfusion.com/aspnetcore/documentation/introduction/) for development.