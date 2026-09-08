---
layout: post
title: Release Notes - Syncfusion AspNetCore AI Coding Assistants
description: Explore the release notes for Syncfusion AspNetCore AI Coding Assistants, covering MCP Server and Skills updates across all versions.
control: Syncfusion AspNetCore AI Coding Assistants Release Notes
platform: ej2-asp-core-mvc
publishingplatform: ##Platform_Name##
documentation: ug
---

# Syncfusion AspNetCore AI Coding Assistants Release Notes

This document provides information about the changes and new features included in each version of the Syncfusion AspNetCore AI Coding Assistants, including the [Syncfusion.AspNetCore.MCP](https://www.nuget.org/packages/Syncfusion.AspNetCore.MCP) MCP Server and Skills.

## MCP Server

**(v2.0.0) - September 7, 2026**

**Breaking Changes**

- Updated the MCP server to support the latest 2026-07-28 Model Context Protocol (MCP) specification, ensuring compatibility with the newest protocol standards and capabilities.

- Migrated the MCP Server implementation from the [@modelcontextprotocol/sdk](https://www.npmjs.com/package/@modelcontextprotocol/sdk) package to latest [@modelcontextprotocol/server](https://www.npmjs.com/package/@modelcontextprotocol/server).

**(v1.0.0) - August 3, 2026**

**Breaking Changes**

- The [@syncfusion/aspnetcore-assistant](https://www.npmjs.com/package/@syncfusion/aspnetcore-assistant) npm package has been migrated to the [Syncfusion.AspNetCore.MCP](https://www.nuget.org/packages/Syncfusion.AspNetCore.MCP) .NET package. As part of this transition, [@syncfusion/aspnetcore-assistant](https://www.npmjs.com/package/@syncfusion/aspnetcore-assistant) package has been deprecated and will no longer receive updates.

- The coding assistant tool identifier has been changed from **`#SyncfusionAspNetCoreAssistant`** to **`search_docs`** for a better naming convention.
