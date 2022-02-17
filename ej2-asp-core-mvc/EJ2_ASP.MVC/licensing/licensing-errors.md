---
layout: post
title: Licensing Errors in ##Platform_Name## Component
description: Learn here all about Licensing Errors in Syncfusion ##Platform_Name## component and more.
platform: ej2-asp-core-mvc
control: Licensing Errors
publishingplatform: ##Platform_Name##
documentation: ug
---

# Licensing Errors

Licensing error pop up is displayed with various messages under different circumstances. Here are some ways to resolve different issues.

## License key not registered

The following error message will be shown if a Syncfusion license key has not been registered in your application.

**Error message :** This application was built using a trial version of Syncfusion Essential Studio. Please include a valid license to permanently remove this license validation message. You can also obtain a free 30 day evaluation license to temporarily remove this message during the evaluation period. Please refer to this [help topic](https://ej2.syncfusion.com/aspnetmvc/documentation/licensing/licensing-errors/#license-key-not-registered) for more information.

**Solution:** Generate a valid license key from here [Licensed users](https://www.syncfusion.com/account/downloads) or [Trial users](https://www.syncfusion.com/account/manage-trials/downloads) for a specific version and platform.

## Invalid key

If the application is registered with an invalid key, another version of license key, or another platform's license key, the following error message will pop up when launching the application.

**Error Message:** The included Syncfusion license is invalid. Please refer to this [help topic](https://ej2.syncfusion.com/aspnetmvc/documentation/licensing/licensing-errors/#invalid-key) for more information.

**Solution:** Generate a valid license key from here [Licensed users](https://www.syncfusion.com/account/downloads) or [Trial users](https://www.syncfusion.com/account/manage-trials/downloads) for a specific version and platform.

## Trial Expired

The following error message will be shown if the trial key has expired after 30 days

**Error Message:** Your Syncfusion trial license has expired. Please refer to this [help topic](https://ej2.syncfusion.com/aspnetmvc/documentation/licensing/licensing-errors/#trial-expired) for more information.

**Solution:** Purchase from [here](https://www.syncfusion.com/sales/products) to get a valid Syncfusion license.

## Platform Mismatch

If the application is registered with another platform's license key, the following error message will pop up when launching the application.

**Error Message:** The included Syncfusion license is invalid (Platform mismatch). Please refer to this [help topic](https://ej2.syncfusion.com/aspnetmvc/documentation/licensing/licensing-errors/#platform-mismatch) for more information.

**Solution:** Generate a valid license key from here [Licensed users](https://www.syncfusion.com/account/downloads) or [Trial users](https://www.syncfusion.com/account/manage-trials/downloads) for a specific version and platform.

## Version Mismatch

If the application is registered with another version's license key, the following error message will pop up when launching the application.

**Error Message:** The included Syncfusion license ({Registered Version}) is invalid for version {Required Version}. Please refer to this [help topic](https://ej2.syncfusion.com/aspnetmvc/documentation/licensing/licensing-errors/#version-mismatch) for more information.

**Solution:** Generate a valid license key from here [Licensed users](https://www.syncfusion.com/account/downloads) or [Trial users](https://www.syncfusion.com/account/manage-trials/downloads) for a specific version and platform. Kindly follow the [KB](https://www.syncfusion.com/kb/8976/how-to-generate-license-key-for-essential-studio-products) to generate license key.

## Could not load Syncfusion.Licensing.dll assembly version

Make sure that all the referenced Syncfusion assemblies are of same version. Try cleaning and rebuilding the application to resolve assembly conflict issues.