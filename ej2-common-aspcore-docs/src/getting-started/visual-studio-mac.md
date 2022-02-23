<!-- markdownlint-disable MD024 -->

# Getting Started with Essential JS 2 for ASP.NET Core in Visual Studio for Mac

This article provides a step-by-step introduction to configure Essential JS 2 setup, build and publish a simple .NET Core web application using the [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/).

> Starting with v16.2.0.x, if you reference to Syncfusion assemblies from trial setup or NuGet feed, you should include a license key in your projects. Refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key) to learn about registering Syncfusion license key in your ASP.NET Core application to use the components.

## Getting started with ASP.NET Core 3.x

### Prerequisites

The official prerequisites to create and run an ASP.NET Core 3.x application on Mac environment are described in the [.NET Core documentation website](https://docs.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-3.0&tabs=visual-studio-mac#prerequisites).

### Create ASP.NET core web application

1. Choose **New** from Visual Studio for Mac dashboard.

    ![new project in aspnetcore3.x](images/mac-vs-dashboard.png)

2. Select **Web Application** from the template in App under Web and Console section and click the **Next** button.

    ![web app (mvc)](images/mac-project-template.png)

3. Select **.NET Core 3.1** in Target Framework and then click **Next** button.

    ![aspnetcore3.x target](images/mac-target-version-3.x.png)

4. Now in the project configuration window, fill the **Project Name** and click the **Create** button.

    ![aspnetcore3.x web application project](images/mac-project-config-3x.png)

### Configure Essential JS 2 in the application

1. Add the [`Syncfusion.EJ2.AspNet.Core`](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core/) NuGet package to the new web application by using the Nuget Package Manager. Right-click the project and select **Manage NuGet Packages...**.

    > Refer to [this article](../nuget-packages) to learn more details about installing Essential JS 2 NuGet packages in various OS environment.

    ![aspnetcore3.x manage nuget packages](images/mac-nuget-3x.png)

2. Search the `Syncfusion.EJ2.AspNet` keyword in the **Browse** tab and install **Syncfusion.EJ2.AspNet.Core** NuGet package in the application.

    ![aspnetcore3.x install nuget packages](images/mac-sync-pack-3x.png)

    The Essential JS 2 package will be included in the project, after the installation process is completed.

    > **Note:** The Syncfusion.EJ2.AspNet.Core NuGet package has dependencies, [`Newtonsoft.Json`](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [`Syncfusion.Licensing`](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion license key.

3. Open the `~/Pages/_ViewImports.cshtml` file and import the `Syncfusion.EJ2` package.

    ```html
    @addTagHelper *, Syncfusion.EJ2
    ```

4. Add the client-side resources through [CDN](https://ej2.syncfusion.com/documentation/deployment/#cdn) or [local npm package](https://www.npmjs.com/package/@syncfusion/ej2) in the `<head>` element of `~/Pages/Shared/_Layout.cshtml` layout page.

    ```html
    <head>
        ....
        ....

        <!-- Syncfusion Essential JS 2 Styles -->
        <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/bootstrap4.css" />

        <!-- Syncfusion Essential JS 2 Scripts -->
        <script src="https://cdn.syncfusion.com/ej2/dist/ej2.min.js"></script>
    </head>
    ```

5. Add the Essential JS 2 Script Manager at the end of `<body>` element in the `~/Pages/Shared/_Layout.cshtml` layout page.

    ```html
    <body>
        ....
        ....
        <!-- Syncfusion Essential JS 2 ScriptManager -->
        <ejs-scripts></ejs-scripts>
    </body>
    ```

6. Now, add the Syncfusion Essential JS 2 components in any web page (`cshtml`) in the `Pages` folder.

    For example, add the calendar component in the `~/Pages/Index.cshtml` page.

    ```html
    <div>
        <ejs-calendar id="calendar"></ejs-calendar>
    </div>
    ```

7. Run the application. The Essential JS 2 calendar component will render in the web browser.

    ![aspnetcore3.x calendar component output](images/mac-output.png)

## Getting Started with ASP.NET Core 2.x

### Prerequisites

The official prerequisites to create and run an ASP.NET Core 2.x application on Mac environment are described in the [.NET Core documentation website](https://docs.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-2.0&tabs=visual-studio-mac#prerequisites-1).

### Create ASP.NET Core web application

1. Choose **New** from Visual Studio for Mac dashboard.

    ![new project in aspnetcore2.x](images/mac-vs-dashboard.png)

2. Select **Web Application** from the template in App under Web and Console section and click the **Next** button.

    ![web app (mvc)](images/mac-project-template.png)

3. Select **.NET Core 2.1** in Target Framework and then click **Next** button.

    ![aspnetcore2.x target](images/mac-target-version-2.x.png)

4. Now in the project configuration window, fill the **Project Name** and click the **Create** button.

    ![aspnetcore3.x web application project](images/mac-project-config-2x.png)

### Configure Essential JS 2 in the application

1. Add the [`Syncfusion.EJ2.AspNet.Core`](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core/) NuGet package to the new application by using the Nuget Package Manager. Right-click the project and select **Manage NuGet Packages...**.

    > Refer to [this article](../nuget-packages) to learn more details about installing Essential JS 2 NuGet packages in various OS environment.

    ![aspnetcore2.x manage nuget packages](images/mac-nuget-2x.png)

2. Search the `Syncfusion.EJ2.AspNet` keyword in the **Browse** tab and install **Syncfusion.EJ2.AspNet.Core** NuGet package in the application.

    ![aspnetcore2.x install nuget packages](images/mac-sync-pack-2x.png)

    The Essential JS 2 package will be included in the project, after the installation process is completed.

    > **Note:** The Syncfusion.EJ2.AspNet.Core NuGet package has dependencies, [`Newtonsoft.Json`](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [`Syncfusion.Licensing`](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion license key.

3. Open the `~/Pages/_ViewImports.cshtml` file and import the `Syncfusion.EJ2` package.

    ```html
    @addTagHelper *, Syncfusion.EJ2
    ```

4. Add the client-side resources through [CDN](https://ej2.syncfusion.com/documentation/deployment/#cdn) or [local npm package](https://www.npmjs.com/package/@syncfusion/ej2) in the `<head>` element of `~/Pages/Shared/_Layout.cshtml` layout page.

    ```html
    <head>
        ....
        ....

        <!-- Syncfusion Essential JS 2 Styles -->
        <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/bootstrap4.css" />

        <!-- Syncfusion Essential JS 2 Scripts -->
        <script src="https://cdn.syncfusion.com/ej2/dist/ej2.min.js"></script>
    </head>
    ```

5. Add the Essential JS 2 Script Manager at the end of `<body>` element in the `~/Pages/Shared/_Layout.cshtml` layout page.

    ```html
    <body>
        ....
        ....
        <!-- Syncfusion Essential JS 2 ScriptManager -->
        <ejs-scripts></ejs-scripts>
    </body>
    ```

6. Now, add the Syncfusion Essential JS 2 components in any web page (`cshtml`) in the `Pages` folder.

    For example, add the calendar component in the `~/Pages/Index.cshtml` page.

    ```html
    <div>
        <ejs-calendar id="calendar"></ejs-calendar>
    </div>
    ```

7. Run the application. The Essential JS 2 calendar component will render in the web browser.

    ![aspnetcore3.x calendar component output](images/mac-output.png)