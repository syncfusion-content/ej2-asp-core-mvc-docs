---
layout: post
title: Overview of Syncfusion license and unlock keys - Syncfusion
description: Learn here about the Syncfusion license and unlock keys and difference between license and unlock keys.
platform: ej2-asp-core-mvc
control: Overview
publishingplatform: ##Platform_Name##
documentation: ug
---

# Syncfusion Licensing Overview

We have introduced a new licensing system starting with version 16.2.0.x release of Essential Studio. These modifications apply to all evaluators and only to paid customers who use NuGet packages from [nuget.org](https://www.nuget.org/packages?q=syncfusion). Starting with v16.2.0.x, if you use the evaluation installer or the NuGet feed to reference Syncfusion assemblies, you must also include the corresponding platform and version license key in your projects.

## Difference between unlock key and license key

Note that this license key is different from the installer unlock key that you might have used in the past and needs to be separately generated from Syncfusion website. Refer [this](https://www.syncfusion.com/kb/8950/difference-between-the-unlock-key-and-licensing-key) KB article to know more about difference between the Syncfusion Unlock Key and the Syncfusion License Key.

Following licensing error will be shown if the license key is not registered in your projects, while using assemblies from evaluation installer or from the [nuget.org](https://www.nuget.org/packages?q=syncfusion)

N> This application was built using a trial version of Syncfusion Essential Studio. Include a valid license to permanently remove this license validation message. You can also obtain a free 30 day evaluation license to temporarily remove this message during the evaluation period. Refer to this [help topic](https://ej2.syncfusion.com/aspnetmvc/documentation/licensing/overview) for more information.

## Registering Syncfusion license keys in Build server

| Source of Syncfusion assemblies | Details | License Key needs to be registered? | Where to get license key from |
| ------------- | ------------- | ------------- | ------------- |
| **NuGet package** | If the Syncfusion assemblies used in Build Server were from the Syncfusion NuGet packages, then no need to install any Syncfusion installer. We can directly use the required Syncfusion NuGet packages at [nuget.org](http://nuget.org/). <br><br>But, if using NuGet packages from the [nuget.org](https://www.nuget.org/packages?q=syncfusion), then we should register the Syncfusion license key in the application.| Yes | Use any developer license to [generate](https://ej2.syncfusion.com/aspnetmvc/documentation/licensing/how-to-generate) keys for Build Environments as well. |
| **Trial installer** | If the Syncfusion assemblies used in Build Server were from Trial Installer, we should register the license key in the application for the corresponding version and platforms, to avoid trial license warning. | Yes | Use any developer trial license to [generate](https://ej2.syncfusion.com/aspnetmvc/documentation/licensing/how-to-generate) keys for Build Environments as well. |
| **Licensed installer** |If the Syncfusion assemblies used in Build Server were from Licensed Installer, then there is no need to register the license keys.<r><br>You can [download](https://ej2.syncfusion.com/aspnetmvc/documentation/installation/web-installer/how-to-download#download-the-license-version) and [install](https://ej2.syncfusion.com/aspnetmvc/documentation/installation/web-installer/how-to-install) the licensed version of our installer. | No | Not applicable |


## See Also

* [How to Generate Syncfusion ASP .NET MVC EJ2 License Key?](https://ej2.syncfusion.com/aspnetmvc/documentation/licensing/how-to-generate)
* [How to Register Syncfusion License Key in ASP .NET MVC EJ2 Application?](https://ej2.syncfusion.com/aspnetmvc/documentation/licensing/how-to-register-in-an-application)