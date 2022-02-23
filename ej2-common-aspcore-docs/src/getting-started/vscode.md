<!-- markdownlint-disable MD024 -->

# Getting Started with Essential JS 2 for ASP.NET Core in Visual Studio Code

This article provides a step-by-step introduction to configure Essential JS 2 setup, build and publish a simple .NET Core web application using the [Visual Studio Code](https://code.visualstudio.com/) (VS Code).

> Starting with v16.2.0.x, if you reference to Syncfusion assemblies from trial setup or NuGet feed, you should include a license key in your projects. Refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key) to learn about registering Syncfusion license key in your ASP.NET Core application to use the components.

## Getting Started with ASP.NET Core 5.x

### Prerequisites

The official prerequisites to create and run an ASP.NET Core 5.0 application on Windows environment are described in the [.NET Core documentation website](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net50#dependencies).

* [Visual Studio Code](https://code.visualstudio.com/)

### Created ASP.NET Core web application

1. Create a new folder and open it in the VS Code by **File > Open Folder...**.

    ![aspnetcore5.x vscode open folder](images/aspnetcore-vscode-open.png)

2. Select **View > Integrated Terminal** to open the terminal in VS Code.

    ![aspnetcore5.x vscode integrated terminal](images/aspnetcore-vscode-terminal.png)

3. Select **View > Integrated Terminal** to open the terminal in VS Code.

4. Run the following command line in the terminal to create a new ASP.NET Core web application. 

    ```cmd
    dotnet new mvc
    ```

    ![aspnetcore5.x vscode new web application](images/aspnetcore5x-vscode-web-app.png)

    > Refer to [here](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-new?tabs=net50), to learn more details about `dotnet new` command line. You can run the command line `dotnet new --help`, to learn more options available in the .NET CLI.

### Configure Essential JS 2 in the application

1. Run the following command in the VS Code terminal to add `Syncfusion.EJ2.AspNet.Core` NuGet package in the project.

    ```cmd
    dotnet add package Syncfusion.EJ2.AspNet.Core
    ```

    ![aspnetcore5.x vscode adding syncfusion package in the project](images/dotnetnew-5x.png)

    > Refer to [here](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-add-package), to learn more details about the `dotnet add` command line.

2. Open `~/Views/_ViewImports.cshtml` file and import the `Syncfusion.EJ2` package.

    ```html
    @addTagHelper *, Syncfusion.EJ2
    ```

3. Add the client-side resources through [CDN](https://ej2.syncfusion.com/documentation/base/deployment.html?lang=typescript#cdn) or [local npm package](https://www.npmjs.com/package/@syncfusion/ej2) in the `<head>` element of the `~/Views/Shared/_Layout.cshtml` layout page.

    ```html
    <head>
        ....
        ....

        <!-- Syncfusion Essential JS 2 Styles -->
        <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/material.css" />

        <!-- Syncfusion Essential JS 2 Scripts -->
        <script src="https://cdn.syncfusion.com/ej2/dist/ej2.min.js"></script>
    </head>
    ```

4. Add the Essential JS 2 Script Manager at the end of `<body>` element in the `~/Views/Shared/_Layout.cshtml` layout page.

    ```html
    <body>
        ....
        ....
        <!-- Syncfusion Essential JS 2 ScriptManager -->
        <ejs-scripts></ejs-scripts>
    </body>
    ```

5. Now, you can add the Syncfusion Essential JS 2 components in any web page (`cshtml`) in the `Views` folder.

    For example, the calendar component is added to the `~/Views/Home/Index.cshtml` page.

    ```html
    <div>
        <ejs-calendar id="calendar"></ejs-calendar>
    </div>
    ```

6. Run the application by pressing the <kbd>F5</kbd> key. Set `Select Environment` to `.NET Core`, if settings required for VS Code.

    ![aspnetcore5.x vscode select environment](images/aspnetcore-vscode-core-environment.png)

    The Essential JS 2 calendar component will render in the web browser.

    ![aspnetcore5.x calendar component output](images/aspnetcore-calendar.png)


## Getting Started with ASP.NET Core 3.x

### Prerequisites

The official prerequisites to create and run an ASP.NET Core 3.x application on Windows environment are described in the [.NET Core documentation website](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=netcore31#dependencies).

* [Visual Studio Code](https://code.visualstudio.com/)

### Created ASP.NET Core web application

1. Create a new folder and open it in the VS Code by **File > Open Folder...**.

    ![aspnetcore3.x vscode open folder](images/aspnetcore-vscode-open.png)

2. Select **View > Integrated Terminal** to open the terminal in VS Code.

    ![aspnetcore3.x vscode integrated terminal](images/aspnetcore-vscode-terminal.png)

3. Select **View > Integrated Terminal** to open the terminal in VS Code.

4. Run the following command line in the terminal to create a new ASP.NET Core web application. 

    ```cmd
    dotnet new mvc
    ```

    ![aspnetcore3.x vscode new web application](images/aspnetcore3x-vscode-web-app.png)

    > Refer to [here](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-new?tabs=netcore3x), to learn more details about `dotnet new` command line. You can run the command line `dotnet new --help`, to learn more options available in the .NET CLI.

### Configure Essential JS 2 in the application

1. Run the following command in the VS Code terminal to add `Syncfusion.EJ2.AspNet.Core` NuGet package in the project.

    ```cmd
    dotnet add package Syncfusion.EJ2.AspNet.Core
    ```

    ![aspnetcore3.x vscode adding syncfusion package in the project](images/dotnetnew-3x.png)

    > Refer to [here](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-add-package), to learn more details about the `dotnet add` command line.

2. Open `~/Views/_ViewImports.cshtml` file and import the `Syncfusion.EJ2` package.

    ```html
    @addTagHelper *, Syncfusion.EJ2
    ```

3. Add the client-side resources through [CDN](https://ej2.syncfusion.com/documentation/base/deployment.html?lang=typescript#cdn) or [local npm package](https://www.npmjs.com/package/@syncfusion/ej2) in the `<head>` element of the `~/Views/Shared/_Layout.cshtml` layout page.

    ```html
    <head>
        ....
        ....

        <!-- Syncfusion Essential JS 2 Styles -->
        <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/material.css" />

        <!-- Syncfusion Essential JS 2 Scripts -->
        <script src="https://cdn.syncfusion.com/ej2/dist/ej2.min.js"></script>
    </head>
    ```

4. Add the Essential JS 2 Script Manager at the end of `<body>` element in the `~/Views/Shared/_Layout.cshtml` layout page.

    ```html
    <body>
        ....
        ....
        <!-- Syncfusion Essential JS 2 ScriptManager -->
        <ejs-scripts></ejs-scripts>
    </body>
    ```

5. Now, you can add the Syncfusion Essential JS 2 components in any web page (`cshtml`) in the `Views` folder.

    For example, the calendar component is added to the `~/Views/Home/Index.cshtml` page.

    ```html
    <div>
        <ejs-calendar id="calendar"></ejs-calendar>
    </div>
    ```

6. Run the application by pressing the <kbd>F5</kbd> key. Set `Select Environment` to `.NET Core`, if settings required for VS Code.

    ![aspnetcore3.x vscode select environment](images/aspnetcore-vscode-core-environment.png)

    The Essential JS 2 calendar component will render in the web browser.

    ![aspnetcore3.x calendar component output](images/aspnetcore-calendar.png)


## Getting Started with ASP.NET Core 2.x

### Prerequisites

The official prerequisites to create and run an ASP.NET Core 2.x application on Windows environment are described in the [.NET Core documentation website](https://docs.microsoft.com/en-us/dotnet/core/windows-prerequisites?tabs=netcore2x).

* [Visual Studio Code](https://code.visualstudio.com/)

### Create ASP.NET Core web application

1. Create a new folder and open it in the VS Code by **File > Open Folder...**.

    ![aspnetcore2.x vscode open folder](images/aspnetcore-vscode-open.png)

2. Select **View > Integrated Terminal** to open the terminal in VS Code.

    ![aspnetcore2.x vscode integrated terminal](images/aspnetcore-vscode-terminal.png)

3. Run the following command line in the terminal to create a new ASP.NET Core web application.

    ```cmd
    dotnet new mvc
    ```

    ![aspnetcore2.x vscode new web application](images/aspnetcore2x-vscode-web-app.png)

    > Refer to [here](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-new?tabs=netcore2x), to learn more details about `dotnet new` command line. You can run the command line `dotnet new --help`, to learn more options available in the .NET CLI.

### Configure Essential JS 2 in the application

1. Run the following command in the VS Code terminal to add `Syncfusion.EJ2.AspNet.Core` NuGet package in the project.

    ```cmd
    dotnet add package Syncfusion.EJ2.AspNet.Core
    ```

    ![aspnetcore2.x vscode adding syncfusion package in the project](images/dotnetnew.png)

    > Refer to [here](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-add-package), to learn more details about the `dotnet add` command line.

2. Open `~/Views/_ViewImports.cshtml` file and import the `Syncfusion.EJ2` package.

    ```html
    @addTagHelper *, Syncfusion.EJ2
    ```

3. Add the client-side resources through [CDN](https://ej2.syncfusion.com/documentation/base/deployment.html?lang=typescript#cdn) or [local npm package](https://www.npmjs.com/package/@syncfusion/ej2) in the `<head>` element of the `~/Views/Shared/_Layout.cshtml` layout page.

    ```html
    <head>
        ....
        ....

        <!-- Syncfusion Essential JS 2 Styles -->
        <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/material.css" />

        <!-- Syncfusion Essential JS 2 Scripts -->
        <script src="https://cdn.syncfusion.com/ej2/dist/ej2.min.js"></script>
    </head>
    ```

4. Add the Essential JS 2 Script Manager at the end of `<body>` element in the `~/Views/Shared/_Layout.cshtml` layout page.

    ```html
    <body>
        ....
        ....
        <!-- Syncfusion Essential JS 2 ScriptManager -->
        <ejs-scripts></ejs-scripts>
    </body>
    ```

5. Now, you can add the Syncfusion Essential JS 2 components in any web page (`cshtml`) in the `Views` folder.

    For example, the calendar component is added to the `~/Views/Home/Index.cshtml` page.

    ```html
    <div>
        <ejs-calendar id="calendar"></ejs-calendar>
    </div>
    ```

6. Run the application by pressing the <kbd>F5</kbd> key. Set `Select Environment` to `.NET Core`, if settings required for VS Code.

    ![aspnetcore2.x vscode select environment](images/aspnetcore-vscode-core-environment.png)

    The Essential JS 2 calendar component will render in the web browser.

    ![aspnetcore2.x calendar component output](images/aspnetcore-calendar.png)

## Getting Started with ASP.NET Core 1.x

### Prerequisites

The official prerequisites to create and run an ASP.NET Core 1.x application on Windows environment are described in the [.NET Core documentation website](https://docs.microsoft.com/en-us/dotnet/core/windows-prerequisites?tabs=netcore1x).

* [Visual Studio Code](https://code.visualstudio.com/)

### Create ASP.NET Core web application

1. Create a new folder and open it in VS Code by **File > Open Folder...**.

    ![aspnetcore1.x vscode open folder](images/aspnetcore-vscode-open.png)

2. Select **View > Integrated Terminal** to open the terminal in VS Code.

    ![aspnetcore1.x vscode integrated terminal](images/aspnetcore-vscode-terminal.png)

3. Run the following command line in the VS Code terminal to create a new ASP.NET Core web application.

    ```cmd
    dotnet new -t web
    ```

    ![aspnetcore1.x vscode new web application](images/aspnetcore1x-vscode-web-app.png)

    > Refer [here](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-new?tabs=netcore1x), to learn more details about the `dotnet new` command line.

### Configure Essential JS 2 in the application

1. Add `Syncfusion.EJ2` assembly reference in the `dependencies` of `project.json` file.

    ![aspnetcore1.x vscode project json](images/nugetpackage-version.png)

2. Restore the dependent packages in the application by running the following command line in the VS Code terminal.

    ```cmd
    dotnet restore
    ```

    ![aspnetcore1.x vscode dotnet restore](images/aspnetcore1x-vscode-dotnet-restore.png)

    > Refer to [here](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-restore?tabs=netcore1x), to learn more details about `dotnet restore` command line.

3. Open `~/Views/_ViewImports.cshtml` file and import the `Syncfusion.EJ2` package.

    ```html
    @addTagHelper *, Syncfusion.EJ2
    ```

4. Add the client-side resources through [CDN](https://ej2.syncfusion.com/documentation/base/deployment.html?lang=typescript#cdn) or [local npm package](https://www.npmjs.com/package/@syncfusion/ej2) in the `<head>` element of `~/Views/Shared/_Layout.cshtml` layout page.

    ```html
    <head>
        ....
        ....

        <!-- Syncfusion Essential JS 2 Styles -->
        <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/material.css" />

        <!-- Syncfusion Essential JS 2 Scripts -->
        <script src="https://cdn.syncfusion.com/ej2/dist/ej2.min.js"></script>
    </head>
    ```

5. Add the Essential JS 2 Script Manager at the end of `<body>` element in the `~/Views/Shared/_Layout.cshtml` layout page.

    ```html
    <body>
        ....
        ....
        <!-- Syncfusion Essential JS 2 ScriptManager -->
        <ejs-scripts></ejs-scripts>
    </body>
    ```

6. Now, you can add the Syncfusion Essential JS 2 components in any web page (`cshtml`) in the `Views` folder.

    For example, the calendar component is added to the `~/Views/Home/Index.cshtml` page.

    ```html
    <div>
        <ejs-calendar id="calendar"></ejs-calendar>
    </div>
    ```

7. Run the application by pressing <kbd>F5</kbd> key. Set `Select Environment` to `.NET Core`, if settings required for VS Code.

    ![aspnetcore1.x vscode select environment](images/aspnetcore-vscode-core-environment.png)

    The Essential JS 2 calendar component will render in the web browser.

    ![aspnetcore1.x calendar component output](images/aspnetcore-calendar.png)
