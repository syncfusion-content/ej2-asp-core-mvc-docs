---
layout: post
title: Project migration process for ASP.NET MVC platform | Syncfusion
description: Project Migration is a add-in that allows you to migrate the existing Syncfusion ASP.NET MVC Application from one Essential Studio version to another version.
platform: ej2-asp-core-mvc
control: Syncfusion Extensions
publishingplatform: ##Platform_Name##
documentation: ug
---

# Upgrading Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC application to latest version

The Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC migration add-in for Visual Studio allows you to migrate an existing Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC application from one version of Essential Studio<sup style="font-size:70%">&reg;</sup> version to another version. This reduces the amount of manual work required when migrating the Syncfusion<sup style="font-size:70%">&reg;</sup> version.

## IMPORTANT

The Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC (Essential<sup style="font-size:70%">&reg;</sup> JS 2) Web Application Project Migration utility is available from v16.3.0.17.

N> Before use, the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Project Migration, check whether the **ASP.NET MVC Extensions - Syncfusion** installed or not in Visual Studio Extension Manager by clicking on the **Extensions -> Manage Extensions -> Installed** for Visual Studio 2019 or later and for Visual Studio 2017 or lower by clicking on the **Tools -> Extensions and Updates -> Installed**. If this extension not installed, install the extension by follow the steps from the [download and installation](download-and-installation) help topic. Also, check whether the corresponding Essential Studio<sup style="font-size:70%">&reg;</sup> version build installed or not. If the Essential Studio<sup style="font-size:70%">&reg;</sup> version is not same for both the Extension and build, then the Project Migration will not be shown.

The steps below will assist you to upgrade the Syncfusion<sup style="font-size:70%">&reg;</sup> version in the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC application via Visual Studio 2019:

1. Open the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC application that uses the Syncfusion<sup style="font-size:70%">&reg;</sup> component.

2. To open the Migration Wizard, either one of the following options should be followed:

    **Option 1**:

    Click **Extensions->Syncfusion<sup style="font-size:70%">&reg;</sup> Menu** and choose **Essential Studio<sup style="font-size:70%">&reg;</sup> for ASP.NET MVC > Migrate Project…** in **Visual Studio Menu**.

    ![migrate project](images/migrate-project-latest.png)

    N> In Visual Studio 2017 or lower, Click Syncfusion<sup style="font-size:70%">&reg;</sup> Menu and choose Essential Studio<sup style="font-size:70%">&reg;</sup> for ASP.NET MVC > Migrate Project… in Visual Studio Menu.

    ![migrate project](images/migrate-project.png)

    **Option 2**:

    Right-click the **Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Application** from Solution Explorer and select **Syncfusion<sup style="font-size:70%">&reg;</sup> Web**. Choose **Migrate the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC Project to Another Version…**

    ![migrate the essential js2](images/migrate-essentialJs2.png)

3. The Syncfusion<sup style="font-size:70%">&reg;</sup> Project Migration window will appear. You can choose the required version of Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC to migrate.

    ![project migration](images/project-migration.png)

    N> The versions are loaded from the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC NuGet packages which published in [NuGet.org](https://www.nuget.org/packages?q=Tags%3A%22aspnetmvc%22syncfusion) and it requires internet connectivity.

    **Assets From:** Load the Syncfusion<sup style="font-size:70%">&reg;</sup> Essential<sup style="font-size:70%">&reg;</sup> JS 2 assets to ASP.NET MVC Project, from either NuGet, CDN or Installed Location.

    N> Installed location option will be available only when the Syncfusion<sup style="font-size:70%">&reg;</sup> Essential JavaScript 2 setup has been installed.

4. Check the **“Enable a backup before migrating”** checkbox if you want to take the project backup and choose location.

5. The Syncfusion<sup style="font-size:70%">&reg;</sup> Reference Assemblies, Scripts, and CSS are updated to the selected version in the project.

    if you enabled project backup before migrating, the old project was saved in the specified backup path location, as shown below once the migration process completed

    ![BackupLocation](images/BackupLocation.png)

6. If you installed the trial setup or NuGet packages from nuget.org you must register the Syncfusion<sup style="font-size:70%">&reg;</sup> license key to your project since Syncfusion<sup style="font-size:70%">&reg;</sup> introduced the licensing system from 2018 Volume 2 (v16.2.0.41) Essential Studio<sup style="font-size:70%">&reg;</sup> release. Navigate to the [help topic](https://help.syncfusion.com/common/essential-studio/licensing/license-key#how-to-generate-syncfusion-license-key) to generate and register the Syncfusion<sup style="font-size:70%">&reg;</sup> license key to your project. Refer to this [blog](https://blog.syncfusion.com/post/Whats-New-in-2018-Volume-2-Licensing-Changes-in-the-1620x-Version-of-Essential-Studio.aspx?_ga=2.11237684.1233358434.1587355730-230058891.1567654773) post for understanding the licensing changes introduced in Essential Studio<sup style="font-size:70%">&reg;</sup>