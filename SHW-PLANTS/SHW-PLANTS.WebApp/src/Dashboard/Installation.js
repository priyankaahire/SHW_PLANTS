// JavaScript source code

$(document).ready(function () {
    var page = 1;
    var current_page = 5;
    var total_page = 0;
    var is_ajax_fire = 0;
    getInstallationDetails();
    function getInstallationDetails() {

        $.ajax({
            type: "POST",
            url: 'InstallationWebApp.aspx/GetInstallationDetail',
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                displayInstallation(data.d);
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                alert("Status: " + textStatus); alert("Error: " + errorThrown);
            }
        });
    }


    /* Get Page Data*/
    function getPageData(data) {
        displayInstallation(data);
    }


    /* Add new Item table row */

    function displayInstallation(data) {
        var rows = '';
        $.each(data, function (key, value) {
            rows = rows + '<tr>';
            rows = rows + '<td>' + value.Installation_ID + '</td>';
            rows = rows + '<td>' + value.ProjectName + '</td>';
            rows = rows + '<td>' + value.CustomerName + '</td>';
            rows = rows + '<td>' + value.Duedate + '</td>';
            rows = rows + '<td>' + value.UserName + '</td>';
            rows = rows + '<td data-id="' + value.Read + '">';
            rows = rows + '<input type="checkbox"  data-toggle="toggle">';
            rows = rows + '</td>';
            rows = rows + '<td data-id="' + value.Complited + '">';
            rows = rows + '<input type="checkbox"  data-toggle="toggle">';
            rows = rows + '</td>';
            rows = rows + '</tr>';
        });
        $("#tbody").append(rows);
    }

});