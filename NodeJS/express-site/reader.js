$(document).ready(function () {
  $('#get-data').click(function () {
    var showData = $('#show-data');

    $.getJSON('users.json', function (data) {
      console.log(data);

      var items = data.items.map(function (item) {
        return item.firstName + ': ' + item.secondName + ':' + item.userName + ':' + item.emailAddress;
      });

      showData.empty();

      if (items.length) {
        var content = '<li>' + items.join('</li><li>') + '</li>';
        var list = $('<ul />').html(content);
        showData.append(list);
      }
    });

    showData.text('Loading the JSON file.');
  });
});

