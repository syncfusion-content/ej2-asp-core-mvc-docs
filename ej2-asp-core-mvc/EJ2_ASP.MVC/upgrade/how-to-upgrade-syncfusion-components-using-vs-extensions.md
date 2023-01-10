---
layout: post
title: Upgrading Syncfusion ##Platform_Name## components to a latest version
description: Learn here about the how upgrade Syncfusion ##Platform_Name## components to a latest version from NuGet manager and migrate.
platform: ej2-asp-core-mvc
control: How To Upgrade Syncfusion Components Using Vs Extensions
publishingplatform: ##Platform_Name##
documentation: ug
---

# Upgrading Syncfusion ASP.NET MVC JS2 components to latest version

The Syncfusion ASP.NET MVC JS2 migration add-in for Visual Studio allows you to migrate an existing Syncfusion ASP.NET MVC web application from one version of Essential Studio version to another version. This reduces the amount of manual work required when migrating the Syncfusion version.

The steps below will assist you to upgrade the Syncfusion version in the Syncfusion ASP.NET MVC application via Visual Studio 2019:

> Before use the Syncfusion ASP.NET MVC Web application Migration, check whether the Syncfusion ASP.NET MVC JS2  Extension installed or not in Visual Studio Extension Manager by clicking on the Extensions -> Manage Extensions -> Installed. If this extension not installed, please install the extension by follow the steps from the [download and installation](https://ej2.syncfusion.com/aspnetmvc/documentation/visual-studio-integration/VS2019-Extensions/download-and-installation/) help topic.

1. Open the Syncfusion ASP.NET MVC Web application that uses the Syncfusion component.

2. Open the Migration Wizard, by right-click the **Syncfusion ASP.NET MVC Application** from Solution Explorer and select **Syncfusion Web**. Choose the **Migrate Syncfusion ASP.NET MVC project from another version...**

    ![MigrationAddin](images/MigrationAddin.png)

3. The Syncfusion Project Migration window will appear. You can choose the required version of Syncfusion ASP.NET MVC to migrate.

    > The versions are loaded from the Syncfusion ASP.NET MVC NuGet packages published in [`NuGet.org`](https://www.nuget.org/packages?q=Tags%3A%22AspNet.MVC%20EJ2%22+syncfusion) and it requires internet connectivity.

    ![MigrationWizard](images/Migration.png)

4. Click **Migrate** button, then the Syncfusion.EJ2.MVC5 NuGet packages will be updated to the respective chosen version in the application.

5. If you installed the trial setup or NuGet packages from nuget.org you must register the Syncfusion license key to your application since Syncfusion introduced the licensing system from 2018 Volume 2 (v16.2.0.41) Essential Studio release. Navigate to the [help topic](https://ej2.syncfusion.com/aspnetmvc/documentation/licensing/how-to-generate) to generate and register the Syncfusion license key to your application. Refer to this [blog](https://blog.syncfusion.com/post/Whats-New-in-2018-Volume-2-Licensing-Changes-in-the-1620x-Version-of-Essential-Studio.aspx?_ga=2.11237684.1233358434.1587355730-230058891.1567654773) post for understanding the licensing changes introduced in Essential Studio.