
$(document).ready(function () {
    var page = 1;
    var current_page = 5;
    var total_page = 0;
    var is_ajax_fire = 0;
    getProjectData();
    function getProjectData() {

        $.ajax({
            url: 'projects.json',
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
                displayProjectList(data);
                is_ajax_fire = 1;
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                alert("Status: " + textStatus); alert("Error: " + errorThrown);
            }
        });
    }


    /* Get Page Data*/
    function getPageData(data) {
        displayProjectList(data);
    }


    /* Add new Item table row */

    function displayProjectList(data) {

        var rows = '';

        $.each(data, function (key, value) {
            rows = rows + '<tr>';
            rows = rows + '<td>' + value.ProjectId + '</td>';
            rows = rows + '<td>' + value.ProjectName + '</td>';
            rows = rows + '<td>' + value.CusterName + '</td>';
            rows = rows + '<td>' + value.PONumber + '</td>';
            rows = rows + '<td>' + value.PODate + '</td>';
            rows = rows + '<td>' + value.ProjectStatus + '</td>';
            rows = rows + '<td data-id="' + value.ProjectId + '">';
            rows = rows + '<button data-toggle="modal" data-target="#edit-project" class="btn btn-primary edit-item">Edit</button> ';
            rows = rows + '<button class="btn btn-danger remove-item">Delete</button>';
            rows = rows + '</td>';
            rows = rows + '</tr>';

        });
        $("#tbody").append(rows);
    }

    /* Create New Project*/
    $(document).ready(function (e) {
        $('#usercreateBtn').click(function (e) {
            createProject();
        });
    });
    function createProject() {
        var uname = $('#username').val();
        var email = $('#emailid').val();
        var contact = $('#contactno').val();
        $.ajax({
            url: 'usrs.json',
            dataType: 'json',
            type: 'POST',
            data: { username: uname, emailid: email, contactno: contact },
            success: function (data) {
                $(".modal").modal('hide');
                toastr.success('User Created Successfully.', 'Success Alert', { timeOut: 5000 });
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                alert("Status: " + textStatus); alert("Error: " + errorThrown);
            }
        });
    };

    /* Edit Item */

    $("body").on("click", ".edit-item", function () {
        var id = $(this).parent("td").data('id');
        var title = $(this).parent("td").prev("td").prev("td").text();
        var description = $(this).parent("td").prev("td").text();

        $("#edit-item").find("input[name='title']").val(title);
        $("#edit-item").find("textarea[name='description']").val(description);
        $("#edit-item").find(".edit-id").val(id);
    });
});