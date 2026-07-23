---
layout: post
title: Project Migration | ASP.NET Core (Essential JS 2) | Syncfusion
description: Project Migration is a add-in that allows you to migrate the existing Syncfusion ASP.NET Core Application from one Essential Studio version to another version
platform: ej2-asp-core-mvc
control: Syncfusion Extensions
publishingplatform: ##Platform_Name##
documentation: ug
---

# Upgrading Syncfusion® ASP.NET Core application to latest version

The Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core migration add-in for Visual Studio allows you to migrate an existing Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core application from one version of Essential Studio<sup style="font-size:70%">&reg;</sup> version to another version. This reduces the amount of manual work required when migrating the Syncfusion<sup style="font-size:70%">&reg;</sup> version.

## IMPORTANT

The Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core (Essential<sup style="font-size:70%">&reg;</sup> JS 2) Web Application Project Migration utility is available from v16.3.0.17.

> Before using the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Project Migration, check whether the **ASP.NET Core Extensions - Syncfusion<sup style="font-size:70%">&reg;</sup>** is installed in the Visual Studio Extension Manager. For Visual Studio 2022 or later, click **Extensions -> Manage Extensions -> Installed**. If this extension is not installed, please install it by following the steps in the [download and installation](https://ej2.syncfusion.com/aspnetcore/documentation/visual-studio-integration/download-and-installation) help topic. Also, check whether the corresponding Essential Studio<sup style="font-size:70%">&reg;</sup> version build is installed. If the Essential Studio<sup style="font-size:70%">&reg;</sup> version is not the same for both the Extension and the build, the Project Migration option will not be shown.

The steps below will assist you to upgrade the Syncfusion<sup style="font-size:70%">&reg;</sup> version in the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core application via Visual Studio:

1. Open the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core application that uses the Syncfusion<sup style="font-size:70%">&reg;</sup> component.

2. To open the Migration Wizard, either one of the following options should be followed:

    **Option 1**

    Click **Extensions > Syncfusion<sup style="font-size:70%">&reg;</sup>** and choose **Essential Studio<sup style="font-size:70%">&reg;</sup> for ASP.NET Core > Migrate Project…** in **Visual Studio Menu**.

    ![migrate project](images/migrate-project.png)

    **Option 2**

    Right-click the **Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Application** from Solution Explorer and select **Syncfusion<sup style="font-size:70%">&reg;</sup> Web**. Choose **Migrate the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Project to Another Version…**

    ![migrate syncfuion project](images/migrate-syncfusion-EJ2.png)

3. The Syncfusion<sup style="font-size:70%">&reg;</sup> Project Migration window will appear. You can choose the required version of Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core to migrate. The list contains all Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core versions published on NuGet.org.

    ![project migration](images/project-migration.png)

    > The versions are loaded from the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core NuGet packages which are published on [NuGet.org](https://www.nuget.org/packages?q=Tags%3A%22aspnetcore%22syncfusion), and an active internet connection is required.

    **Assets From:** Load the Syncfusion<sup style="font-size:70%">&reg;</sup> Essential<sup style="font-size:70%">&reg;</sup> JS 2 assets to ASP.NET Core Project, from either NPM, CDN or Installed Location.

    > Installed location option will be available only when the Syncfusion<sup style="font-size:70%">&reg;</sup> Essential<sup style="font-size:70%">&reg;</sup> JavaScript 2 setup has been installed.

4. Check the **“Enable a backup before migrating”** checkbox if you want to take the project backup and choose location.

5. The Syncfusion<sup style="font-size:70%">&reg;</sup> Reference Assemblies, NuGet packages, Scripts, and CSS are updated to the corresponding version in the project. The specific changes include:

    * The `Syncfusion.EJ2.AspNet.Core` NuGet package is upgraded to the selected version.
    * The `ej2.min.css` and `ej2.min.js` script and style references in `_Layout.cshtml` are updated.
    * Any Syncfusion<sup style="font-size:70%">&reg;</sup> configuration files (such as `SyncfusionLicensing`) are updated to the new version.

    If you enabled the project backup before migrating, the old project was saved in the specified backup path location, as shown below once the migration process is completed.

    ![BackupLocation](images/BackupLocation.png)

6. If you have installed the trial setup or NuGet packages from nuget.org, you must register the Syncfusion<sup style="font-size:70%">&reg;</sup> license key to your project since Syncfusion<sup style="font-size:70%">&reg;</sup> introduced the licensing system from the 2018 Volume 2 (v16.2.0.41) Essential Studio<sup style="font-size:70%">&reg;</sup> release. Navigate to the [help topic](https://help.syncfusion.com/common/essential-studio/licensing/overview#how-to-generate-syncfusion-license-key) to generate and register the Syncfusion<sup style="font-size:70%">&reg;</sup> license key to your project. Refer to this [blog](https://blog.syncfusion.com/post/whats-new-in-2018-volume-2-licensing-changes-in-the-1620x-version-of-essential-studio.aspx) post for understanding the licensing changes introduced in Essential Studio<sup style="font-size:70%">&reg;</sup>.