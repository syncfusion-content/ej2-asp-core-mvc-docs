function loadTemplate(data) {
  var containerClass =
    data.positionClass === 'right' ? 'justify-content: flex-end' : '';
  return (
    '<div style="display: flex; ' +
    containerClass +
    ';" class="e-list-wrapper e-list-multi-line">' +
    '<span style="display: block; white-space: normal;max-width: 80%; padding: 10px;background-color: #e0e0e0;border-radius: 10px;word-wrap: break-word;" class="e-list-item-header">' +
    data.text +
    '</span>' +
    '</div>'
  );
}