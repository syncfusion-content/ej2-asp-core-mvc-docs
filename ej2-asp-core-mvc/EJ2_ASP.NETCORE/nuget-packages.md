---
layout: post
title: Nuget Packages in ##Platform_Name## Ej2_asp.netcore Component
description: Learn here all about Nuget Packages in Syncfusion ##Platform_Name## Ej2_asp.netcore component and more.
platform: ej2-asp-core-mvc
control: Nuget Packages
publishingplatform: ##Platform_Name##
documentation: ug
---

# NuGet Packages for ASP.NET Core

> You can use the Syncfusion ASP.NET Core NuGet packages without installing the Essential Studio or ASP.NET Core platform installation to implement the Syncfusion ASP.NET Core controls.

## Installing NuGet Packages

### Using NuGet Package Manager

1. The NuGet Package Manager can be used to search and install NuGet packages in the Visual Studio solution or project:

2. Right-click the project/solution in the Solution Explorer tab, and choose **Manage NuGet Packages**

    ![img3](images/manage-nuget.png)

    Alternatively, click **Tools**, menu, NuGet Package Manager -> Manage NuGet Packages for Solution.

3. By default, the `NuGet.org` package is selected in the **Package source** drop-down. Select your appropriate feed name that you configured.

     ![core4](images/package-manager.png)

4. The Syncfusion ASP.NET Core NuGet Packages are listed and available in the package source feed URL. Search and install the required packages in your application, by clicking **Install** button.

### Using Package Manager Console

To reference the Syncfusion ASP.NET Core component using the Package Manager Console as NuGet packages, follow the below steps

1. On the **Tools** menu, select **NuGet Package Manager** and then **Package Manager Console**.

2. Run the following NuGet installation commands:

    ```
    #install specified package in default project
    Install-Package <Package Name>

    #install specified package in default project with specified package source
    Install-Package <Package Name> -Source <Source Location>

    #install specified package in specified project
    Install-Package <Package Name> - ProjectName <Project Name>
    ```

    **For example:**

    ```
    #install specified package in default project
    Install-Package Syncfusion.EJ2.AspNet.Core

    #install specified package in default project with specified Package Source
    Install-Package Syncfusion.EJ2.AspNet.Core -Source “http://nuget.syncfusion.com/nuget_aspnetcore-js2/nuget/getsyncfusionpackages/aspnetcore-js2”

    #install specified package in specified project
    Install-Package Syncfusion.EJ2.AspNet.Core -ProjectName SyncfusionDemoApplication
    ```

### Using Visual Studio for macOS

Add packages can be used to search and install NuGet packages to the Visual Studio project in macOS:

1. Right-click the folder in the project, and then select **Add Packages…**

    ![img1](images/add-packages.png)

2. By default, the `NuGet.org` package is selected in the **Package source** drop-down.

3. The Syncfusion ASP.NET Core NuGet Packages available in the package source location will be listed. Search and install the required packages in your application, by clicking **Add Package** button.

## Managing NuGet package using NuGet CLI

The NuGet Command Line Interface (CLI), `nuget.exe`, provides the full extent of NuGet functionality to install, create, publish, and manage packages without making any change to the project files.

1. Download the latest NuGet CLI from [here](https://dist.nuget.org/win-x86-commandline/latest/nuget.exe).

    > To update the existing `nuget.exe` to latest version use the following command:

    ```
    nuget update -self
    ```

2. Open the downloaded executable location in the command window, and run the following commands to download and install the required NuGet packages to a project specified in the `package.config`.

```
#install specified package in default project from specified package source for Windows Platform
nuget.exe install <Package name | ConfigFilePath > <Options>

#install specified package in default project from specified package source for MAC/Linux Platform
mono nuget.exe install <Package name | ConfigFilePath > <Options>
```

> `configPath` is optional. This identifies the `package.config` or solutions file that lists the packages utilized in the project.

**For example:**

```
#install specific package for Windows
nuget.exe install Syncfusion.EJ2.AspNet.Core”

#install all package which mention in package.config path for Windows
nuget.exe install “C:\Users\SyncfusionApplication\package.config”

#install specific package for Mac and Linux
mono nuget.exe install “ Syncfusion.EJ2.AspNet.Core”

#install all package which mention in package.config path for Mac and Linux
mono nuget.exe install “C:\Users\SyncfusionApplication\package.config”

```

## Upgrading NuGet packages

### Using NuGet Package Manger

1. NuGet packages can be updated to their specific version or latest version available in the Visual Studio solution or project:

2. Right-click the project/solution in the Solution Explorer tab, and choose **Manage NuGet Packages**. Alternatively, click **Tools** menu, `NuGet Package Manager | Manage NuGet Packages for Solution`.

3. Select the **Updates** tab to see the packages available for update from the desired package sources. Select the required packages and the specific version from the dropdown, and click the **Update** button.

<!-- markdownlint-disable MD024 -->

### Using Visual Studio for macOS

1. Using **Update** context menu from Visual Studio for Mac application, NuGet packages can be updated.

2. Right-click on the Packages folder in the project, and select **Update**.

    ![img4](images/package-update.png)

3. This will update the NuGet package to the latest version. You can double-click the Add packages and choose the specific version.

> To update all the projects from solution, use update option in the solution level.

### Using Package Manger Console

To update the installed Syncfusion ASP.NET Core NuGet packages using the Package Manager Console, follow the below steps

1. On the **Tools** menu, select **NuGet Package Manager**, and then **Package Manager Console.**

2. Run the following NuGet installation commands:

    ```
    #Update specific NuGet package in default project
    Update-Package <Package Name>

    #Update all the packages in default project
    Update-Package

    #Update specified package in default project with specified package source
    Update-Package <Package Name> -Source <Source Location>

    #Update specified package in specified project
    Update-Package <Package Name> - ProjectName <Project Name>
    ```

    **For example:**

    ```
    #Update specified Syncfusion ASP.NET Core NuGet package
    Update-Package Syncfusion.EJ2.AspNet.Core

    #Update specified package in specified project
    Update-Package Syncfusion.EJ2.AspNet.Core -ProjectName SyncfusionDemoApplication
    ```

### Using NuGet CLI

Using the NuGet CLI, all the NuGet packages in the project can be updated to the available latest version.

1. Download the latest NuGet CLI from [here](https://dist.nuget.org/win-x86-commandline/latest/nuget.exe).

    > To update the existing `nuget.exe` to latest version use the following command:

    ```
    nuget update -self
    ```

2. Open the downloaded executable location in the command window. Run the following “update commands” to update the Syncfusion ASP.NET Core NuGet packages.

    ```
    #update all NuGet packages from config file
    nuget update <configPath> [options]

    #update all NuGet packages from specified Packages Source
    nuget update -Source <Source Location> [optional]
    ```

    > `configPath` is optional. This identifies the `package.config` or solutions file lists the packages utilized in the project.

    **For example:**

    ```
    #Update all NuGet packages from config file
    nuget update “C:\Users\SyncfusionApplication\package.config”
    ```

    > Update command is not working as expected in Mono (Mac and Linux) and projects using PackageReference format.
