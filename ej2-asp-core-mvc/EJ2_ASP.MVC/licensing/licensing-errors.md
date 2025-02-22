---
layout: post
title: Overview of Syncfusion licensing errors - Syncfusion
description: Learn here about Syncfusion common licensing errors which appears on license validation in Syncfusion ##Platform_Name## applications.
platform: ej2-asp-core-mvc
control: Licensing Errors
publishingplatform: ##Platform_Name##
documentation: ug
---

# Syncfusion Licensing Errors


Licensing error pop up is displayed with various messages under different circumstances. Here are some ways to resolve different issues.

## Licensing errors 

### License key not registered\Trial Expired 

The following error message will be shown if a Syncfusion license key has not been registered in your application or if the trial key has expired after 30 days. 

**Error message :** This application was built using a trial version of Syncfusion Essential Studio. You should include the valid license key to remove the license validation message permanently.

![License key not registered](images/licensing-error-7.png)

**Solution:**

* Generate a valid license key from here [Licensed users](https://www.syncfusion.com/account/downloads) or [Trial users](https://www.syncfusion.com/account/manage-trials/downloads) for a specific version and platform.

* Also, you can generate the license key from claim license key page by clicking the **"Claim your FREE account"** click from the licensing warning message. Refer to this [help topic](https://ej2.syncfusion.com/aspnetmvc/documentation/licensing/how-to-generate#Claim-License-Key) for more details.

* In your application, register the generated license key. Refer to this [help topic](https://ej2.syncfusion.com/aspnetmvc/documentation/licensing/how-to-register-in-an-application) for information on registering the license key.

### Invalid key

If the application is registered with an invalid key, another version of license key, or another platform's license key, the following error message will pop up when launching the application. 

**Error Message:** The included Syncfusion license key is invalid.

![License key not registered](images/licensing-error-6.png)

**Solution:**

* Generate a valid license key from here [Licensed users](https://www.syncfusion.com/account/downloads) or [Trial users](https://www.syncfusion.com/account/manage-trials/downloads) for a specific version and platform.

* Also, you can generate the license key from claim license key page by clicking the **"Claim your FREE account"** click from the licensing warning message. Refer to this [help topic](https://ej2.syncfusion.com/aspnetmvc/documentation/licensing/how-to-generate#Claim-License-Key) for more details.

* In your application, register the generated license key. Refer to this [help topic](https://ej2.syncfusion.com/aspnetmvc/documentation/licensing/how-to-register-in-an-application) for information on registering the license key.

## Licensing errors from version 16.2.0* to 20.3.0*

### License key not registered

The following error message will be shown if a Syncfusion license key has not been registered in your application.

**Error message :** This application was built using a trial version of Syncfusion Essential Studio. Include a valid license to permanently remove this license validation message. You can also obtain a free 30 day evaluation license to temporarily remove this message during the evaluation period. Refer to this [help topic](https://ej2.syncfusion.com/aspnetmvc/documentation/licensing/licensing-errors#license-key-not-registered) for more information.

**Solution:**

* Generate a valid license key from here [Licensed users](https://www.syncfusion.com/account/downloads) or [Trial users](https://www.syncfusion.com/account/manage-trials/downloads) for a specific version and platform.

* In your application, register the generated license key. Refer to this [help topic](https://ej2.syncfusion.com/aspnetmvc/documentation/licensing/how-to-register-in-an-application) for information on registering the license key.

### Invalid key

If the application is registered with an invalid key, another version of license key, or another platform's license key, the following error message will pop up when launching the application.

**Error Message:** The included Syncfusion license is invalid. Refer to this [help topic](https://ej2.syncfusion.com/aspnetmvc/documentation/licensing/licensing-errors/#invalid-key) for more information.

**Solution:**

* Generate a valid license key from here [Licensed users](https://www.syncfusion.com/account/downloads) or [Trial users](https://www.syncfusion.com/account/manage-trials/downloads) for a specific version and platform.

* In your application, register the generated license key. Refer to this [help topic](https://ej2.syncfusion.com/aspnetmvc/documentation/licensing/how-to-register-in-an-application) for information on registering the license key.

### Trial Expired

The following error message will be shown if the trial key has expired after 30 days

**Error Message:** Your Syncfusion trial license has expired. Refer to this [help topic](https://ej2.syncfusion.com/aspnetmvc/documentation/licensing/licensing-errors#trial-expired) for more information.

**Solution:** Purchase from [here](https://www.syncfusion.com/sales/products) to get a valid Syncfusion license.

### Platform Mismatch

If the application is registered with another platform's license key, the following error message will pop up when launching the application.

**Error Message:** The included Syncfusion license is invalid (Platform mismatch). Refer to this [help topic](https://ej2.syncfusion.com/aspnetmvc/documentation/licensing/licensing-errors#platform-mismatch) for more information.

**Solution:**

* Generate a valid license key from here [Licensed users](https://www.syncfusion.com/account/downloads) or [Trial users](https://www.syncfusion.com/account/manage-trials/downloads) for a specific version and platform.

* In your application, register the generated license key. rRefer to this [help topic](https://ej2.syncfusion.com/aspnetmvc/documentation/licensing/how-to-register-in-an-application) for information on registering the license key.

### Version Mismatch

If the application is registered with another version's license key, the following error message will pop up when launching the application.

**Error Message:** The included Syncfusion license ({Registered Version}) is invalid for version {Required Version}. Refer to this [help topic](https://ej2.syncfusion.com/aspnetmvc/documentation/licensing/licensing-errors#version-mismatch) for more information.

**Solution:**

* Generate a valid license key from here [Licensed users](https://www.syncfusion.com/account/downloads) or [Trial users](https://www.syncfusion.com/account/manage-trials/downloads) for a specific version and platform. Follow the [KB](https://support.syncfusion.com/kb/article/7898/how-to-generate-license-key-for-licensed-products) to generate license key.

* In your application, register the generated license key. Refer to this [help topic](https://ej2.syncfusion.com/aspnetmvc/documentation/licensing/how-to-register-in-an-application) for information on registering the license key.

## Could not load Syncfusion.Licensing.dll assembly version

Make sure that all the referenced Syncfusion assemblies are of same version. Try cleaning and rebuilding the application to resolve assembly conflict issues.