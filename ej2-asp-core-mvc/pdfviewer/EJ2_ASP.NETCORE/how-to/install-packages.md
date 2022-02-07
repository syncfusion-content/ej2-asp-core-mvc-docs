---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Install Packages of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Install Packages
publishingplatform: ##Platform_Name##
documentation: ug
---

# Install EJ2 PDF Viewer packages automatically based on the operating system

You can install the EJ2 PDF Viewer packages automatically based on the operating system by adding all the PDF Viewer NuGet packages in your csproj file. When building the project, the required NuGet will be installed based on the operating system.

```cs
<PackageReference Include="Syncfusion.EJ2.PdfViewer.AspNet.Core.Linux" Version="19.1.0.56" Condition="$([MSBuild]::IsOsPlatform('Linux'))"/>
<PackageReference Include="Syncfusion.EJ2.PdfViewer.AspNet.Core.Osx" Version="19.1.0.56" Condition="$([MSBuild]::IsOsPlatform('OSX'))"/>
<PackageReference Include="Syncfusion.EJ2.PdfViewer.AspNet.Core.Windows" Version="19.1.0.56" Condition="$([MSBuild]::IsOsPlatform('Windows'))"/>
```