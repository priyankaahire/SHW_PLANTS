// JavaScript source code

$(document).ready(function () {
    var page = 1;
    var current_page = 5;
    var total_page = 0;
    var is_ajax_fire = 0;
    getLDDetails();
    function getLDDetails() {

        $.ajax({
            url: 'dashboard.json',
            dataType: 'json',
            data: { page: page },
            success: function (data) {
                alert("in sucess");
                // var total_page = Math.ceil(data.length / 3);

                var total_page = Math.ceil(5);
                var current_page = page;

                $('#pagination').twbsPagination({
                    totalPages: total_page,
                    visiblePages: current_page,
                    itemOnPage: 3,
                    onPageClick: function (event, page) {
                        page = page;
                        if (is_ajax_fire != 0) {
                            getPageData(data);
                            current_page++;
                        }
                    }
                });
                displayLDDetails(data);
                is_ajax_fire = 1;
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                alert("Status: " + textStatus); alert("Error: " + errorThrown);
            }
        });
    }


    /* Get Page Data*/
    function getPageData(data) {
        displayLDDetails(data);
    }


    /* Add new Item table row */

    function displayLDDetails(data) {
        var rows = '';
        $.each(data, function (key, value) {
            rows = rows + '<tr>';
            rows = rows + '<td>' + value.LDId + '</td>';
            rows = rows + '<td>' + value.ProjectName + '</td>';
            rows = rows + '<td>' + value.LDDueDate + '</td>';
            rows = rows + '<td>' + value.LDCompleteddate + '</td>';
            rows = rows + '<td>' + value.Username + '</td>';
            rows = rows + '<td data-id="' + value.LDId + '">';
            rows = rows + '<input type="checkbox"  data-toggle="toggle">';
            rows = rows + '</td>';
            rows = rows + '<td data-id="' + value.LDId + '">';
            rows = rows + '<input type="checkbox"  data-toggle="toggle">';
            rows = rows + '</td>';
            rows = rows + '</tr>';
        });
        $("#tbody").append(rows);
    }
    
});