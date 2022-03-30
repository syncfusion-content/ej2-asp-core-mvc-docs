---
layout: post
title: Project Conversion process for ASP.NET MVC- EJ2 platform
description: Project Conversion is a add-in that converts ASP.NET MVC application into a Syncfusion ASP.NET MVC application by adding required Essential JS 2 components
platform: ASP.NET MVC - EJ2
control: Syncfusion VS Extensions
publishingplatform: ##Platform_Name##
documentation: ug
---

# Converting ASP.NET MVC application to Syncfusion ASP.NET MVC application

Syncfusion ASP.NET MVC conversion is a Visual Studio add-in that converts an existing ASP.NET MVC application into a Syncfusion ASP.NET MVC (Essential JS 2) Web application by adding the required assemblies and resource files.

> The Syncfusion ASP.NET MVC (Essential JS 2) Web Application Project conversion utility is available from v16.3.0.17. Before use, the Syncfusion ASP.NET MVC Project Conversion, check whether the **ASP.NET MVC Extensions - Syncfusion** installed or not in Visual Studio Extension Manager by clicking on the **Extensions -> Manage Extensions -> Installed** for Visual Studio 2019 or later and for Visual Studio 2017 or lower by clicking on the **Tools -> Extensions and Updates -> Installed**. If this extension not installed, please install the extension by follow the steps from the [download and installation](download-and-installation) help topic. Also, check whether the corresponding Essential Studio version build installed or not. If the Essential Studio version is not same for both the Extension and build, then the Project Conversion will not be shown.

The steps below help you to convert the ASP.NET MVC application to the Syncfusion ASP.NET MVC application via the Visual Studio:

1. Open an existing Microsoft ASP.NET MVC Web Application or create a new Microsoft ASP.NET MVC Web Application.

2. To open the Syncfusion Project Conversion Wizard, follow either one of the options below:

    **Option 1:**

    Click **Extensions->Syncfusion Menu** and choose **Essential Studio for ASP.NET MVC > Convert to Syncfusion ASP.NET MVC Application…** in **Visual Studio Menu**.

    ![selected microsoft aspmvc](images/selected-microsoft-mvc-application.png)

    > In Visual Studio 2017 or lower, Click Syncfusion Menu and choose Essential Studio for ASP.NET MVC > Convert to Syncfusion ASP.NET MVC Application… in Visual Studio Menu.

    ![convert-to-syncfusion](images/convert-project.png)

    **Option 2:**

    Right-click the **Project** from Solution Explorer, select **Syncfusion Web**, and choose the **Convert to Syncfusion ASP.NET MVC Application…** Refer to the following screenshot for more information.

    ![syncfusion-aspnet mvc](images/convert-syncfusion-aspmvc-application.png)

3. The Syncfusion ASP.NET MVC Project Conversion window will appear. You can choose the required version of Syncfusion ASP.NET MVC, Assets from, and Themes to convert the application.

    ![project conversion wizard](images/project-conversion-wizard.png)

    > The versions are loaded from the Syncfusion ASP.NET MVC NuGet packages which published in [NuGet.org](https://www.nuget.org/packages?q=Tags%3A%22aspnetmvc%22syncfusion) and it requires internet connectivity.

    The following configurations are used in the Project conversion wizard.

    **Assets From**: Load the Syncfusion Essential JS 2 assets to ASP.NET MVC Project, from either NuGet, CDN, or Installed Location.

    > Installed location option will be available only when the Syncfusion Essential JavaScript 2 setup has been installed.

    **Choose the Theme**: Choose the required theme.

4. Check the **“Enable a backup before converting”** checkbox if you want to take the project backup and choose the location.

5. The required Syncfusion ASP.NET MVC NuGet packages with selected version, scripts and styles are included in the ASP.NET MVC Web Application.

    if you enabled project backup before converting, the old project was saved in the specified backup path location, as shown below once the conversion process completed.

    ![BackupLocation](images/BackupLocation.png)

6. If you installed the trial setup or NuGet packages from nuget.org you must register the Syncfusion license key to your project since Syncfusion introduced the licensing system from 2018 Volume 2 (v16.2.0.41) Essential Studio release. Navigate to the [help topic](https://help.syncfusion.com/common/essential-studio/licensing/license-key#how-to-generate-syncfusion-license-key) to generate and register the Syncfusion license key to your project. Refer to this [blog](https://blog.syncfusion.com/post/Whats-New-in-2018-Volume-2-Licensing-Changes-in-the-1620x-Version-of-Essential-Studio.aspx?_ga=2.11237684.1233358434.1587355730-230058891.1567654773) post for understanding the licensing changes introduced in Essential Studio.