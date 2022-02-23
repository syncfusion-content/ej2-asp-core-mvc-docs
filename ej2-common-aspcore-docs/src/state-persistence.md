# State Persistence

Essential JS 2 has support for persisting component’s state across page refreshes or navigation. To
enable this feature, set `enablePersistence` property as true to the required component. This will store
the component’s state in browser’s `localStorage` object on page `unload` event. For example, we have
enabled persistence to grid component in the following code.

{% aspTab template="common/persistence" %}

{% endaspTab %}