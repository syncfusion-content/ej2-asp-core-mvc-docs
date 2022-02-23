# NuGet Packages for ASP.NET Core

> You can use the Syncfusion ASP.NET Core NuGet packages without installing the Essential Studio or ASP.NET Core platform installation to implement the Syncfusion ASP.NET Core controls.

## Get the Syncfusion NuGet feed URL

> Starting with v16.2.0.x, if you reference Syncfusion assemblies from trial setup or from the NuGet feed, you also have to include a license key in your projects. Please refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key) to know about registering Syncfusion license key in your ASP.NET Core application to use our components.

You should get the private Syncfusion ASP.NET Core NuGet feed URL to install or upgrade the Syncfusion ASP.NET Core NuGet packages. To get the URL from Syncfusion website use the following steps:

1. Navigate to [`nuget.syncfusion.com`](https://nuget.syncfusion.com/), and select **WEB** tab.

2. Navigate to **WEB(Essential JS 2)**, click the Copy URL label under ASP.NET Core platform to copy the Syncfusion ASP.NET Core platform NuGet feed to clipboard or directly use the following URL:

    [http://nuget.syncfusion.com/nuget_aspnetcore-js2/nuget/getsyncfusionpackages/aspnetcore-js2](http://nuget.syncfusion.com/nuget_aspnetcore-js2/nuget/getsyncfusionpackages/aspnetcore-js2)

    ![core1](images/core1.png)

3. Now, use this NuGet feed URL to access the Syncfusion NuGet Packages in Visual Studio.

## Add the Syncfusion NuGet feed URL

### Windows

1. Open your Visual Studio application.

2. On the **Tools** menu, select **Options**.

3. Expand the **NuGet Package Manager** and select **Package Sources**.

4. Click the **Add** button (green plus), and enter the ‘Package Name’ and ‘Package Source URL’ of the Syncfusion ASP.NET Core NuGet packages.

    **Name:** Name of the package listed in the available package sources.
    **Source:** Syncfusion ASP.NET Core NuGet Feed URL
    [http://nuget.syncfusion.com/nuget_aspnetcore-js2/nuget/getsyncfusionpackages/aspnetcore-js2](http://nuget.syncfusion.com/nuget_aspnetcore-js2/nuget/getsyncfusionpackages/aspnetcore-js2).

5. Click the **Update** button to add the name and source details to package sources.

    ![core2](images/core2.png)

### macOS

1. Open your Visual Studio application.

2. Right-click on the Packages folder in the project, and then select **Add Packages…**

    ![img1](images/img1.png)

3. Choose the **Configure Sources…** from the dropdown that appears in the left corner of the Add Packages dialog.

    ![img2](images/img2.png)

4. At the bottom right corner of the dialog, click the **Add** button to enter the feed name and the URL.

    **Name:** Enter the name (For e.g., Syncfusion ASP.NET Core Packages).

    **Location:** Enter the following URL – [http://nuget.syncfusion.com/nuget_aspnetcore-js2/nuget/getsyncfusionpackages/aspnetcore-js2](http://nuget.syncfusion.com/nuget_aspnetcore-js2/nuget/getsyncfusionpackages/aspnetcore-js2).

    ![core3](images/core3.png)

5. Now, click **Add Source** and then click **OK**.

## Installing NuGet Packages

### Using NuGet Package Manager

The NuGet Package Manager can be used to search and install NuGet packages in the Visual Studio solution or project:

1. On the **Tools**, menu, NuGet `Package Manager | Manage NuGet Packages for Solution...`

    ![img3](images/img3.png)

    Alternatively, right-click on the project/solution in Solution Explorer tab, and choose **Manage NuGet Packages…**

2. By default, the `NuGet.org` package is selected in the **Package source** drop-down. Select your appropriate feed name that you configured.

     ![core4](images/core4.png)

3. The Syncfusion ASP.NET Core NuGet Packages are listed and available in the package source feed URL. Search and install the required packages in your application, by clicking **Install** button.

### Using Package Manager Console

To reference the Syncfusion ASP.NET Core component using the Package Manager Console as NuGet packages,

1. On the **Tools** menu, select **NuGet Package Manager** and then **Package Manager Console**.

2. Run the following NuGet installation commands:

    ```cmd
    #install specified package in default project
    Install-Package <Package Name>

    #install specified package in default project with specified package source
    Install-Package <Package Name> -Source <Source Location>

    #install specified package in specified project
    Install-Package <Package Name> - ProjectName <Project Name>
    ```

    **For example:**

    ```cmd
    #install specified package in default project
    Install-Package Syncfusion.EJ2

    #install specified package in default project with specified Package Source
    Install-Package Syncfusion.EJ2 -Source “http://nuget.syncfusion.com/nuget_aspnetcore-js2/nuget/getsyncfusionpackages/aspnetcore-js2”

    #install specified package in specified project
    Install-Package Syncfusion.EJ2 -ProjectName SyncfusionDemoApplication
    ```

### Using Visual Studio for macOS

Add packages can be used to search and install NuGet packages to the Visual Studio project in macOS:

1. Right-click on the folder in the project, and then select **Add Packages…**

    ![img1](images/img1.png)

2. By default, the `NuGet.org` package is selected in the **Package source** drop-down. Select the appropriate feed name.

    ![core5](images/core5.png)

3. The Syncfusion ASP.NET Core NuGet Packages available in the package source location will be listed. Search and install the required packages in your application, by clicking **Add Package** button.

## Managing NuGet package using NuGet CLI

The NuGet Command Line Interface (CLI), `nuget.exe`, provides the full extent of NuGet functionality to install, create, publish, and manage packages without making any change to the project files.

### Configure NuGet feed URL

1. Download the latest NuGet CLI from [here](https://dist.nuget.org/win-x86-commandline/latest/nuget.exe).

    > To update the existing `nuget.exe` to latest version use the following command:

    ```cmd
    nuget update -self
    ```

2. Open the downloaded executable location in the command window, and run the following commands to configure the Syncfusion ASP.NET Core NuGet packages:

    ```cmd
    #Add specified package source in NuGet.config file for Windows platform
    nuget.exe Sources Add –Name <Source name> –Source <Source location>

    #Add specified Package Source in Nuget.config file for MAC/Linux platform
    mono nuget.exe Sources Add –Name <Source name> –Source <Source location>
    ```

    **For example:**

    ```cmd
    #For Windows platform
    nuget.exe Sources Add –Name “Syncfusion Source” –Source “http://nuget.syncfusion.com/nuget_aspnetcore-js2/nuget/getsyncfusionpackages/aspnetcore-js2”

    #For MAC/Linux platform
    mono nuget.exe Sources Add –Name “Syncfusion Source” –Source “http://nuget.syncfusion.com/nuget_aspnetcore-js2/nuget/getsyncfusionpackages/aspnetcore-js2”
    ```

### NuGet installation

Download and install the required NuGet packages to a project specified in the `package.config`.

```cmd
#install specified package in default project from specified package source for Windows Platform
nuget.exe install <Package name | ConfigFilePath > <Options>

#install specified package in default project from specified package source for MAC/Linux Platform
mono nuget.exe install <Package name | ConfigFilePath > <Options>
```

> `configPath` is optional. This identifies the `package.config` or solutions file that lists the packages utilized in the project.

**For example:**

```cmd
#install specific package for Windows
nuget.exe install “Syncfusion.EJ2”

#install all package which mention in package.config path for Windows
nuget.exe install “C:\Users\SyncfusionApplication\package.config”

#install specific Syncfusion NuGet package with Syncfusion ASP.NET Core NuGet feed for Windows
nuget.exe install “Syncfusion.EJ2”  –Source “http://nuget.syncfusion.com/nuget_aspnetcore-js2/nuget/getsyncfusionpackages/aspnetcore-js2”

#install specific package for Mac and Linux
mono nuget.exe install “ Syncfusion.EJ2”

#install all package which mention in package.config path for Mac and Linux
mono nuget.exe install “C:\Users\SyncfusionApplication\package.config”

#install specific Syncfusion NuGet package with Syncfusion ASP.NET Core NuGet feed for Mac and Linux
mono nuget.exe install “Syncfusion.EJ2”  –Source “http://nuget.syncfusion.com/nuget_aspnetcore-js2/nuget/getsyncfusionpackages/aspnetcore-js2”
```

## Managing NuGet package using Dotnet CLI

The NuGet Command Line Interface (CLI), `Dotnet.exe`, provides the full extent of NuGet functionality to add, restore, pack, publish, and manage packages without making any change to the project files.

1. Open command prompt window with administrator privileges and navigate to your project folder.

2. The specified ASP.NET Core NuGet package command as below,

    **Add**

    ```cmd
    #Add specified package in specified project from Package Source
    dotnet add package <Package name> [-s|--source] <Source location>
    ```

    **For example :**

    ```cmd
    dotnet add package Syncfusion.EJ2  -s “http://nuget.syncfusion.com/nuget_aspnetcore-js2/nuget/getsyncfusionpackages/aspnetcore-js2”
    ```

    **Restore**

    ```cmd
    #Restore all package which specified in project
    dotnet restore
    ```

> To know more command about the dotnet CLI, refer [here](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet?tabs=netcore2x).

## Upgrading NuGet packages

### Using NuGet Package Manger

NuGet packages can be updated to their specific version or latest version available in the Visual Studio solution or project:

1. On the **Tools** menu, `NuGet Package Manager | Manage NuGet Packages for Solution...`
    Alternatively, right-click on project/solution in the Solution Explorer tab, and choose **Manage NuGet Packages…**

2. Select the **Updates** tab to see the packages available for update from the desired package sources. Select the required packages and the specific version from the dropdown, and click the **Update** button.

<!-- markdownlint-disable MD024 -->

### Using Visual Studio for macOS

Using **Update** context menu from Visual Studio for Mac application, NuGet packages can be updated:

1. Right-click on the Packages folder in the project, and select **Update**.

    ![img4](images/img4.png)

2. This will update the NuGet package to the latest version. You can double-click Add packages and choose the specific version.

> To update all the projects from solution, use update option in the solution level.

### Using Package Manger Console

To update the installed Syncfusion ASP.NET Core NuGet packages using the Package Manager Console:

1. On the **Tools** menu, select **NuGet Package Manager**, and then **Package Manager Console.**

2. Run the following NuGet installation commands:

    ```cmd
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

    ```cmd
    #Update specified Syncfusion ASP.NET Core NuGet package
    Update-Package Syncfusion.EJ2

    #Update specified package in default project with specified Package Source
    Update-Package Syncfusion.EJ2 –Source “http://nuget.syncfusion.com/nuget_aspnetcore-js2/nuget/getsyncfusionpackages/aspnetcore-js2”
    #Update specified package in specified project
    Update-Package Syncfusion.EJ2 -ProjectName SyncfusionDemoApplication
    ```

### Using NuGet CLI

Using the NuGet CLI, all the NuGet packages in the project can be updated to the available latest version:

1. Download the latest NuGet CLI from [here](https://dist.nuget.org/win-x86-commandline/latest/nuget.exe).

    > To update the existing `nuget.exe` to latest version use the following command:

    ```cmd
    nuget update -self
    ```

2. Open the downloaded executable location in the command window. Run the following “update commands” to update the Syncfusion ASP.NET Core NuGet packages.

    ```cmd
    #update all NuGet packages from config file
    nuget update <configPath> [options]

    #update all NuGet packages from specified Packages Source
    nuget update -Source <Source Location> [optional]
    ```

    > `configPath` is optional. This identifies the `package.config` or solutions file lists the packages utilized in the project.

    **For example:**

    ```cmd
    #Update all NuGet packages from config file
    nuget update “C:\Users\SyncfusionApplication\package.config”

    #Update all NuGet packages from specified Packages Source
    nuget update -Source “http://nuget.syncfusion.com/nuget_aspnetcore-js2/nuget/getsyncfusionpackages/aspnetcore-js2”
    ```

    > Update command is not working as expected in Mono (Mac and Linux) and projects using PackageReference format.