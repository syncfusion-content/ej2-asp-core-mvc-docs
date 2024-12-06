---
layout: post
title: Project Templates | ASP.NET Core (Essential JS 2) | Syncfusion
description: Syncfusion provides project templates for ASP.NET Core to create the Syncfusion ASP.NET Core application using EJ2 Core components from Visual Studio Code.
platform: ej2-asp-core-mvc
control: Syncfusion Extensions
publishingplatform: ##Platform_Name##
documentation: ug
---

# Creating a Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Application

Syncfusion<sup style="font-size:70%">&reg;</sup> provides **Visual Studio Code project templates** for creating Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core application. Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core generates application that includes the necessary Syncfusion<sup style="font-size:70%">&reg;</sup> NuGet packages, namespaces, and component render code for the Calendar, Button, and DataGrid components, as well as the style for making Syncfusion<sup style="font-size:70%">&reg;</sup> component development easier.

N> The Syncfusion<sup style="font-size:70%">&reg;</sup> Visual Studio Code project template provides support for ASP.NET Core project templates from v20.1.0.47.

The following instructions assist you in creating **Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Applications** using **Visual Studio Code**:

1. To create a Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core application in Visual Studio Code, open the command palette by pressing **Ctrl+Shift+P**. Search for the word **Syncfusion** in the Visual Studio Code palette to get the templates provided by Syncfusion.

     ![command-palette](images/command-palette.png)

2. Select **Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Template Studio: Launch**, then press **Enter** key. The template studio wizard for configuring the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core application is launched. Then, provide the Project Name and Project Path.
 
     ![core-wizard](images/launch-window.png)

3. Select either **Next** or the **Project Type** tab. Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Project Types will be displayed. Select one of the following Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core project types:

    * Syncfusion<sup style="font-size:70%">&reg;</sup> Web Application (Model-View-Controller)
    * Syncfusion<sup style="font-size:70%">&reg;</sup> Angular
    * Syncfusion<sup style="font-size:70%">&reg;</sup> React.js

    ![project-type](images/project-type.png)

4. The configuration section is displayed when you click either Next or the Configuration tab. Here, you have the option for selecting the required .NET Core version, themes, https configuration, and assets from (NPM, CDN, Installed Location).

    ![project-configuration](images/project-configuration.png)

    N> In assets from the Installed location option will be available when the Syncfusion<sup style="font-size:70%">&reg;</sup> Essential<sup style="font-size:70%">&reg;</sup> JavaScript 2 build has been installed.

5. Click the **Create** button. The Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core application will be created. The created Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core application has the Syncfusion<sup style="font-size:70%">&reg;</sup> NuGet packages, NPM Packages, styles, and the component render code for the Syncfusion<sup style="font-size:70%">&reg;</sup> component added to the index page.T

6. You can run the application to see the Syncfusion<sup style="font-size:70%">&reg;</sup> components. Click **F5** or go to **Run>Start Debugging**.

    ![debugging](images/debugging.png)

7. If you installed the trial setup or NuGet packages from nuget.org, you must register the Syncfusion<sup style="font-size:70%">&reg;</sup> license key to your application since Syncfusion<sup style="font-size:70%">&reg;</sup> introduced the licensing system from 2018 Volume 2 (v16.2.0.41) Essential Studio&reg; release. Navigate to the [help topic](https://help.syncfusion.com/common/essential-studio/licensing/license-key#how-to-generate-syncfusion-license-key) to generate and register the Syncfusion<sup style="font-size:70%">&reg;</sup> license key to your application. Refer to this [blog](https://blog.syncfusion.com/post/Whats-New-in-2018-Volume-2-Licensing-Changes-in-the-1620x-Version-of-Essential-Studio.aspx?_ga=2.11237684.1233358434.1587355730-230058891.1567654773) post for understanding the licensing changes introduced in Essential Studio&reg; 
