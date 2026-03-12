---
layout: post
title: Project Conversion | ASP.NET Core (Essential JS 2) | Syncfusion
description: Project Conversion is a add-in that converts ASP.NET Core application into a Syncfusion ASP.NET Core application by adding required Essential JS 2 components
platform: ej2-asp-core-mvc
control: Syncfusion Extensions
publishingplatform: ##Platform_Name##
documentation: ug
---

# Syncfusion<sup style="font-size:70%">&reg;</sup> Project Conversion

Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core conversion is a Visual Studio add-in that converts an existing ASP.NET Core application into a Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core (Essential<sup style="font-size:70%">&reg;</sup> JS 2) Web application by adding the required assemblies and resource files.

> The Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core (Essential<sup style="font-size:70%">&reg;</sup> JS 2) Web Application Project conversion utility is available from v16.3.0.17. Before use, the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Project Conversion, check whether the **ASP.NET Core Extensions - Syncfusion<sup style="font-size:70%">&reg;</sup>** installed or not in Visual Studio Extension Manager by clicking on the Tools -> Extensions and Updates -> Installed for Visual Studio 2022 or later by clicking on the Extensions -> Manage Extensions -> Installed. If this extension not installed, please install the extension by follow the steps from the [download and installation](https://ej2.syncfusion.com/aspnetcore/documentation/visual-studio-integration/download-and-installation) help topic. Also, check whether the corresponding Essential Studio<sup style="font-size:70%">&reg;</sup> version build installed or not. If the Essential Studio<sup style="font-size:70%">&reg;</sup> version is not same for both the Extension and build, then the Project Conversion will not be shown.

The steps below help you to convert the ASP.NET Core application to the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core application via the Visual Studio:

1. Open an existing Microsoft ASP.NET Core Web Application or create a new Microsoft ASP.NET Core Web Application.

2. To open the Syncfusion<sup style="font-size:70%">&reg;</sup> Project Conversion Wizard, follow either one of the options below:

    **Option 1:**

    Click **Extensions > Syncfusion<sup style="font-size:70%">&reg;</sup>** and choose **Essential Studio<sup style="font-size:70%">&reg;</sup> for ASP.NET Core > Convert to Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Application…** in **Visual Studio Menu**.

    ![convert project](images/convert-new-app.png)

    **Option 2:**

    Right-click the **Project** from Solution Explorer, select **Syncfusion<sup style="font-size:70%">&reg;</sup> Web**, and choose the **Convert to Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Application…**

    ![convert to syncfusion](images/convert-to-syncfusion-ASpnet-core.png)

3. The Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Project Conversion window will appear. You can choose the required version of Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core, Assets from, and Themes to convert the application.

    ![project conversion wizard](images/project-conversion-wizard.png)

    The following configurations are used in the Project conversion wizard.

    **Assets From:** Load the Syncfusion<sup style="font-size:70%">&reg;</sup> Essential<sup style="font-size:70%">&reg;</sup> JS 2 assets to ASP.NET Core Project, from either NPM, CDN, or Installed Location.

    > Installed location option will be available only when the Syncfusion<sup style="font-size:70%">&reg;</sup> Essential<sup style="font-size:70%">&reg;</sup> JavaScript 2 setup has been installed.

    **Choose the Theme:** Choose the required theme.

4. Check the **“Enable a backup before converting”** checkbox if you want to take the project backup and choose the location.

5. The required Syncfusion<sup style="font-size:70%">&reg;</sup> NuGet packages, Scripts and CSS are included in the ASP.NET Core Web application. Refer to the following screenshots for more information.

    ![dependencies](images/dependencies.png)

    ![project structure](images/project-structure.png)

    ![css-reference](images/css-reference.png)

    If you enabled project backup before converting, the old project was saved in the specified backup path location, as shown below once the conversion process completed.

    ![BackupLocation](images/BackupLocation.png)

6. If you installed the trial setup or NuGet packages from nuget.org you must register the Syncfusion<sup style="font-size:70%">&reg;</sup> license key to your application since Syncfusion<sup style="font-size:70%">&reg;</sup> introduced the licensing system from 2018 Volume 2 (v16.2.0.41) Essential Studio<sup style="font-size:70%">&reg;</sup> release. Navigate to the [help topic](https://help.syncfusion.com/common/essential-studio/licensing/overview#how-to-generate-syncfusion-license-key) to generate and register the Syncfusion<sup style="font-size:70%">&reg;</sup> license key to your project. Refer to this [blog](https://www.syncfusion.com/blogs/post/whats-new-in-2018-volume-2.aspx) post for understanding the licensing changes introduced in Essential Studio<sup style="font-size:70%">&reg;</sup>.