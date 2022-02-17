---
layout: post
title: Avoid Typescript Compilation in ##Platform_Name## Grid Component
description: Learn here all about Avoid Typescript Compilation in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Avoid Typescript Compilation
publishingplatform: ##Platform_Name##
documentation: ug
---


# Avoid TypeScript Compilation

**Syncfusion.EJ2.Javascript** includes typescript declaration files. If your application is not configured to compile typescript then exception may occur. To resolve this we need to prevent the typescript compilation during MS build process by adding the below line in **.csproj** file.

```cs

<PropertyGroup>
    <TypeScriptCompileBlocked>True</TypeScriptCompileBlocked>
</PropertyGroup>

```