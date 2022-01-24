---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about State Persistence of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: State Persistence
publishingplatform: ##Platform_Name##
documentation: ug
---

{% if page.publishingplatform == "aspnet-core" %}

# State Persistence

Essential JS 2 has support for persisting component’s state across page refreshes or navigation. To
enable this feature, set `enablePersistence` property as true to the required component. This will store
the component’s state in browser’s `localStorage` object on page `unload` event. For example, we have
enabled persistence to grid component in the following code.

{% aspTab template="common/persistence" %}

{% endaspTab %}

{% if page.publishingplatform == "aspnet-mvc" %}

# State Persistence

Essential JS 2 has support for persisting component’s state across page refreshes or navigation. To
enable this feature, set `EnablePersistence` property as true to the required component. This will store
the component’s state in browser’s `localStorage` object on page `unload` event. For example, we have
enabled persistence to grid component in the following code.

{% aspTab template="common/persistence" %}

{% endaspTab %}

{% endif %}