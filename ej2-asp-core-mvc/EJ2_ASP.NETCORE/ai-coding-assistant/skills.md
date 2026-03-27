---
layout: post
title: Syncfusion ASP.NET Core Agent Skills for AI Assistants | Syncfusion
description: Learn how to install and use Syncfusion Agent Skills to enhance AI assistants with accurate Syncfusion ASP.NET Core component guidance.
platform: ej2-asp-core-mvc
control: Skills
documentation: ug
domainurl: ##DomainURL##
---

# Syncfusion® ASP.NET Core Agent Skills for AI Assistants

This guide introduces **Syncfusion ASP.NET Core Skills**, a knowledge package that enables AI assistants (VS Code, Cursor, CodeStudio, etc.) to understand and generate accurate Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core code using official APIs, patterns, and theming guidelines.

Syncfusion<sup style="font-size:70%">&reg;</sup> Skills eliminate common issues with generic AI suggestions by grounding the assistant in accurate Syncfusion<sup style="font-size:70%">&reg;</sup> component usage patterns, API structures, supported features, and project‑specific configuration.

## Prerequisites

Before installing Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Agent Skills, ensure the following:

- Required [Node.js](https://nodejs.org/en/) version >= 16
- ASP.NET Core application (existing or new); see [Getting Started](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages)
- A supported AI agent or IDE that integrates with the Skills CLI (VS Code, Syncfusion<sup style="font-size:70%">&reg;</sup> Code Studio, Cursor, etc.)

## Installation

Install [Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core components skills](https://github.com/syncfusion/aspnetcore-ui-components-skills.git) using the Skills CLI. Users can also explore available skills from the [marketplace](https://skills.sh/syncfusion/).

### Install all skills

Use the following command to install all component skills at once in the `.agents/skills` directory:

{% tabs %}
{% highlight bash tabtitle="NPM" %}

npx skills add syncfusion/aspnetcore-ui-components-skills -y

{% endhighlight %}
{% endtabs %}

### Install selected skills

Use the following command to install skills interactively:

{% tabs %}
{% highlight bash tabtitle="NPM" %}

npx skills add syncfusion/aspnetcore-ui-components-skills

{% endhighlight %}
{% endtabs %}

The terminal will display a list of available skills. Use the arrow keys to navigate, the space bar to select the desired skills, and the Enter key to confirm.
{% tabs %}
{% highlight bash tabtitle="CMD" %}

 Select skills to install (space to toggle)
│  ◻ syncfusion-aspnetcore-ai-assistview
│  ◻ syncfusion-aspnetcore-grid
│  ◻ syncfusion-aspnetcore-diagram
│  ◻ syncfusion-aspnetcore-common
│  ◻ syncfusion-aspnetcore-gantt-chart
│  ◻ syncfusion-aspnetcore-pivot-table
│  ◻ syncfusion-aspnetcore-rich-text-editor
|  .....

{% endhighlight %}
{% endtabs %}

Next, select which AI agent you're using and where to store the skills.
{% tabs %}
{% highlight bash tabtitle="CMD" %}

│  ── Additional agents ──
│  Search:  
│  ↑↓ move, space select, enter confirm
│
│ ❯ ○ Augment (.augment/skills)
│   ○ Claude Code (.claude/skills)
│   ○ OpenClaw (skills)
│   ○ CodeBuddy (.codebuddy/skills)
│   ○ Command Code (.commandcode/skills)
│   ○ Continue (.continue/skills)
│   ○ Cortex Code (.cortex/skills)
│   ○ Crush (.crush/skills)
|   ....

{% endhighlight %}
{% endtabs %}

Choose your installation scope (project-level or global), then confirm to complete the installation.

{% tabs %}
{% highlight bash tabtitle="CMD" %}

◆  Installation scope
│  ● Project (Install in current directory (committed with your project))
│  ○ Global

◆  Proceed with installation?
│  ● Yes / ○ No

{% endhighlight %}
{% endtabs %}

This registers the Syncfusion<sup style="font-size:70%">&reg;</sup> skill pack so your AI assistant can automatically load it in supported IDEs such as [Code Studio](https://help.syncfusion.com/code-studio/reference/configure-properties/skills), [Visual Studio Code](https://code.visualstudio.com/docs/copilot/customization/agent-skills), and [Cursor](https://cursor.com/docs/skills).

To learn more about the Skills CLI, refer [here](https://skills.sh/docs).

## What’s included

1. **Component Usage & API Knowledge** - Curated, Skill‑based guidance that captures how to add, configure, and compose Syncfusion® ASP.NET Core components, including key parameters, events, services to register (where applicable), and common integration patterns.
2. **Patterns & Best Practices** - Practical recommendations for component configuration, data binding approaches, and feature‑implementation workflows (for example, paging, sorting, filtering, editing, and validation for data components). All guidance is authored directly within the Skill file rather than being fetched from documentation.
3. **Design‑System Guidance** - Includes information related to themes, styling customization, and Syncfusion® ASP.NET Core component best practices across different application types.

## How Syncfusion<sup style="font-size:70%">&reg;</sup> Agent Skills Work

1. **Reads relevant Skill files based on queries**, retrieving component usage patterns, APIs, and best‑practice guidance from the installed Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Skills. The assistant initially loads only skill names and descriptions, then dynamically loads the required skill and reference files as needed to provide accurate Syncfusion guidance.
2. **Enforces Syncfusion<sup style="font-size:70%">&reg;</sup> best practices**, including:
   - Registering applicable component dependencies in `Program.cs`.
   - Adding the correct theme and script imports.
   - Implementing proper data binding patterns for Grid.
3. **Generates component‑accurate code**, avoiding invalid parameters or unsupported patterns.

### Using the AI Assistant

Once skills are installed, the assistant can be used to generate and update Syncfusion® ASP.NET Core code for tasks such as:

- "Add a Grid with paging, sorting, and filtering."
- "Implement file upload with chunk upload and validation."
- "Build a rich text editor with custom toolbar tools."
- "Apply a theme and enable dark mode."

## Skills CLI Commands

After installation, manage Syncfusion<sup style="font-size:70%">&reg;</sup> Agent Skills using the following commands:

### List Skills

View all installed skills in your current project or global environment:

{% tabs %}
{% highlight bash tabtitle="NPM" %}

npx skills list

{% endhighlight %}
{% endtabs %}

### Remove a Skill

Uninstall a specific skill from your environment:

{% tabs %}
{% highlight bash tabtitle="NPM" %}

npx skills remove <skill-name>

{% endhighlight %}
{% endtabs %}

Replace `<skill-name>` with the name of the skill you want to remove (for example, `syncfusion-aspnetcore-grid`).

### Check for Updates

Check if updates are available for your installed skills:

{% tabs %}
{% highlight bash tabtitle="NPM" %}

npx skills check

{% endhighlight %}
{% endtabs %}

### Update All Skills

Update all installed skills to their latest versions:

{% tabs %}
{% highlight bash tabtitle="NPM" %}

npx skills update

{% endhighlight %}
{% endtabs %}

## FAQ

**Which agents and IDEs are supported?**

Any Skills compatible agent or IDE that loads local skill files (Visual Studio Code, Cursor, CodeStudio, etc.).

**Are skills loaded automatically?**

Yes. Once installed, supported agents automatically detect and load relevant skills for Syncfusion‑related queries without requiring additional configuration.

**Skills are not being loaded**

Verify that skills are installed in the correct agent directory, restart the IDE, and confirm that the agent supports external skill files.

## See also

- [Agent Skills Standards](https://agentskills.io/home)
- [Skills CLI](https://skills.sh/docs)
