---
layout: post
title: Security Advisories in ##Platform_Name## Document Editor Control | Syncfusion
description: Learn here all about Security Advisories in  ##Platform_Name## Document Editor component of Syncfusion Essential JS 2 and more.
control: Security advisories 
platform: ej2-asp-core-mvc
publishingplatform: ##Platform_Name##
documentation: ug
---

# Security Advisories in Syncfusion<sup style="font-size:70%">&reg;</sup> EJ2 Controls

Syncfusion<sup style="font-size:70%">&reg;</sup> places the utmost priority on the security of our controls. Users can rest assured about the security of our controls, as we have implemented all necessary measures to mitigate security vulnerabilities such as cross-site scripting and insecure dependencies. To meet security standards, Syncfusion<sup style="font-size:70%">&reg;</sup> utilizes the [ESLint](https://eslint.org/) and [ESLint plugin security](https://github.com/eslint-community/eslint-plugin-security#rules) tools for static code analysis. Additionally, Syncfusion<sup style="font-size:70%">&reg;</sup> packages undergo software composition analysis using the [SOOS](https://soos.io/) security tool.

This document provides a description of the security updates available for Syncfusion<sup style="font-size:70%">&reg;</sup> Essential<sup style="font-size:70%">&reg;</sup> JS2 controls for volume release.

## Security Updates

The following security updates are available for Syncfusion<sup style="font-size:70%">&reg;</sup> DocumentEditor control and are listed based on the release version. 

### 2024 Volume 2 (v26.2.4) - July 25, 2024

This release resolves critical and moderate security vulnerabilities affecting the Syncfusion<sup style="font-size:70%">&reg;</sup> Document Editor Docker Image.

**Threat:**

* ASP.NET Core Components: Multiple moderate vulnerabilities in Kestrel’s HTTP request handling could expose applications to access control issues and data leakage.

* Npgsql: A potential SQL injection vulnerability via Protocol Message Size Overflow was detected.

* Dynamic LINQ: Vulnerable to remote code execution via untrusted input manipulation.

**Resolution:**

* Updated affected ASP.NET Core packages.

* The Npgsql package and Dynamic LINQ have been removed, as they are no longer required, to enhance security and mitigate the risk of SQL injection attacks.

## Common Security Updates

{% if page.publishingplatform == "aspnet-core" %}

For details on common security updates related to Syncfusion<sup style="font-size:70%">&reg;</sup> products, please refer to [this link](https://ej2.syncfusion.com/aspnetcore/documentation/common/content-security-policy). This resource provides information on the latest advisories and best practices to help ensure the security and integrity of your applications.

{% elsif page.publishingplatform == "aspnet-mvc" %}

For details on common security updates related to Syncfusion<sup style="font-size:70%">&reg;</sup> products, please refer to [this link](https://ej2.syncfusion.com/aspnetmvc/documentation/common/content-security-policy). This resource provides information on the latest advisories and best practices to help ensure the security and integrity of your applications. 

{% endif %}


## Security Issue

If users discover any security issues or need assistance in resolving them with Syncfusion<sup style="font-size:70%">&reg;</sup> controls, please contact us by creating a support ticket on [our support site](https://syncfusion.com/support) or by posting your query on Stack Overflow with the tag `syncfusion`<sup style="font-size:70%">&reg;</sup>`-ej2`.