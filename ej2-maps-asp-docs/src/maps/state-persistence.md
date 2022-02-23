# State Persistence

## State persistence

For state maintenance, state persistence allows Maps to save the current model value in browser cookies. This action is handled through the `EnablePersistence` property which is set to **false** by default. When this property is set to true, some of the Maps component model values are preserved even after the page is refreshed.

{% aspTab template="maps/markers/persistence", sourceFiles="persistence.cs" %}

{% endaspTab %}