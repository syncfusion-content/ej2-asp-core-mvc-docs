---
layout: post
title: ##Platform_Name## Grid Avoid TypeScript Compilation | Syncfusion
description: Learn how to prevent TypeScript compilation in ##Platform_Name## Data Grid by updating the csproj file and avoiding build errors.
platform: ej2-asp-core-mvc
control: Avoid Typescript Compilation
publishingplatform: ##Platform_Name##
documentation: ug
---

# Avoid TypeScript Compilation in ASP.NET MVC Data Grid

**Syncfusion.EJ2.Javascript** includes typescript declaration files. If your application is not configured to compile typescript then exception may occur. To resolve this we need to prevent the typescript compilation during MS build process by adding the below line in **.csproj** file.

```cs

<PropertyGroup>
    <TypeScriptCompileBlocked>True</TypeScriptCompileBlocked>
</PropertyGroup>

```