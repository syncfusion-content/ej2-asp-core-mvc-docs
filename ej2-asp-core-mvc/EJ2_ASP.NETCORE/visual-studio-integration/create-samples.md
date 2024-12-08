---
layout: post
title: Sample Creator for ASP.NET Core - EJ2 | Syncfusion
description: Sample Creator is a utility that allows you to create the Syncfusion ASP.NET Core (Essential JS 2) Projects with required Syncfusion controls
platform: ej2-asp-core-mvc
control: Syncfusion Extensions
publishingplatform: ##Platform_Name##
documentation: ug
---

# Create Sample in ASP.NET Core Application

The Syncfusion<sup style="font-size:70%">&reg;</sup> Sample Creator is a tool that lets you to make Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core (Essential<sup style="font-size:70%">&reg;</sup> JS 2) projects with sample code for required Syncfusion<sup style="font-size:70%">&reg;</sup> component features and Syncfusion<sup style="font-size:70%">&reg;</sup> control configuration.

N> The Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Sample Creator utility is available from v16.3.0.17.

The following steps is used to create the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Application by using the Sample Creator utility:

1. Follow one of the options below to launch the ASP.NET Core  Sample Creator application:

    **Option 1:**

    Click **Extensions->Syncfusion<sup style="font-size:70%">&reg;</sup> Menu** and choose **Essential Studio<sup style="font-size:70%">&reg;</sup> for ASP.NET Core (EJ2) > Launch Sample Creator…** in **Visual Studio.**

    ![sample creator](images/sample-creator_latest.png)

    N> In Visual Studio 2017, Click Syncfusion<sup style="font-size:70%">&reg;</sup> Menu and choose Essential Studio<sup style="font-size:70%">&reg;</sup> for ASP.NET Core > Launch Sample Creator…

    ![sample creator](images/sample-creator.png)

    **Option 2:**

    Launch the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Control Panel and click the Sample Creator button to launch the ASP.NET Core Sample Creator utility. For further information, see the screenshot below.

    ![control-panel](images/sample-creator-control-panel.png)

2. Syncfusion<sup style="font-size:70%">&reg;</sup> controls and features are listed in the ASP.NET Core Sample Creator.

    ![controls-list](images/controls-list.png)

    **Controls Selection:** Choose the required controls. The controls are grouped with Syncfusion<sup style="font-size:70%">&reg;</sup> products.

    ![control selection](images/controls-selection.png)

    **Feature Selection:** Based on the controls, the feature is enabled to choose the features of the corresponding controls.

    ![feature selection](images/feature-selection.png)

## Project Configuration

1. You can configure the project with following details.

    **VS Version**: Choose the Visual Studio version and Framework.

    **Project Type**: Select the type of ASP.NET Core Project.

    **ASP.NET Core Version**: Select the version of ASP.NET Core Project.

    ![aspnet core version](images/Aspnet-core-version.png)

   > <table>
	>   <thead>
	>     <tr>
	>       <th>.NET Version</th>
	>       <th>Available From Version</th>
	>       <th>Supported from Visual Studio</th>
	>     </tr>
	>   </thead>
	>   <tbody>
	>     <tr>
	>       <td>.NET 6.0</td>
	>       <td>v19.4.0.38</td>
	>       <td>Visual Studio 2022</td>
	>     </tr>
	>     <tr>
	>       <td>.NET 7.0</td>
	>       <td>v20.4.0.38</td>
	>       <td>Visual Studio 2022</td>
	>     </tr>
	>     <tr>
	>       <td>.NET 8.0</td>
	>       <td>v23.2.4</td>
	>       <td>Visual Studio 2022</td>
	>     </tr>
	>     <tr>
	>       <td>.NET 9.0</td>
	>       <td>v27.2.2</td>
	>       <td>Visual Studio 2022</td>
	>     </tr>
	>   </tbody>
	> </table>

    **Assets From**: Choose the Syncfusion<sup style="font-size:70%">&reg;</sup> Essential<sup style="font-size:70%">&reg;</sup> JS 2 assets to ASP.NET Core Project, either NPM, CDN, or Installed Location.

    N> Installed location option will be available only when the Syncfusion<sup style="font-size:70%">&reg;</sup> Essential<sup style="font-size:70%">&reg;</sup> JavaScript 2 setup has been installed.

    **Name**: Name your Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Application.

    **Location**: Choose the target location of your project.

    **Theme Selection**: Choose the required theme. This section shows the controls preview before creating the Syncfusion<sup style="font-size:70%">&reg;</sup> project.

    ![theme selection](images/theme-selection.png)

2. Click **Create** button. After creating the project, open the project by clicking **Yes**. If you click **No**, the corresponding location of the project will be opened. Refer to the following screenshot for more information.

    ![create](images/create-button.png)

3. The new Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core sample is created. Required controller and view file for selected controls, selected style, scripts and corresponding Syncfusion<sup style="font-size:70%">&reg;</sup> NuGet packages are added in the created sample.