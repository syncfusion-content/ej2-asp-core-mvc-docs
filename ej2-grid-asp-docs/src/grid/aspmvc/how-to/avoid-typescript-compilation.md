---
title: "Avoid TypeScript Compilation"
component: "Grid"
description: "Learn how to avoid Typescript Compilation."
---

# Avoid TypeScript Compilation

**Syncfusion.EJ2.Javascript** includes typescript declaration files. If your application is not configured to compile typescript then exception may occur. To resolve this we need to prevent the typescript compilation during MS build process by adding the below line in **.csproj** file.

```cs

<PropertyGroup>
    <TypeScriptCompileBlocked>True</TypeScriptCompileBlocked>
</PropertyGroup>

```