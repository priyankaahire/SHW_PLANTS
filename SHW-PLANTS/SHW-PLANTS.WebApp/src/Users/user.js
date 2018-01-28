
$(document).ready(function () {
    var page = 1;
    var current_page = 5;
    var total_page = 0;
    var is_ajax_fire = 0;
    manageData();

    /* Manage User list */
    function manageData() {

        $.ajax({
            type: "POST",

            //async: false,
            url: 'UserMaster.aspx/GetAllUsers',
            //dataType: 'json',
            contentType: "application/json; charset=utf-8",
            //data: '{ }',
            success: function (data) {
                // var total_page = Math.ceil(data.length / 3);

                //var total_page = Math.ceil(5);
                //var current_page = page;

                //$('#pagination').twbsPagination({
                //    totalPages: total_page,
                //    visiblePages: current_page,
                //    itemOnPage: 3,
                //    onPageClick: function (event, page) {
                //        page = page;
                //        if (is_ajax_fire != 0) {
                //             getPageData(data);
                //            current_page++;
                //        }
                //    }
                //});
                manageRow(data.d);
                is_ajax_fire = 1;
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                alert("Status: " + textStatus); alert("Error: " + errorThrown);
            }
        });
    }


    /* Get Page Data*/
    function getPageData(data) {
        manageRow(data);
        //$.ajax({
        //    url: 'usrs.json',
        //    dataType: 'json',
        //    success: function (data) {
        //        var data1 = JSON.stringify(data);
        //        manageRow(data1, current_page);
        //    },
        //    error: function (XMLHttpRequest, textStatus, errorThrown) {
        //        alert("Status: " + textStatus); alert("Error: " + errorThrown);
        //    }
        //});
    }


    /* Add new Item table row */

    function manageRow(data) {
        var rows = '';
        $.each(data, function (key, value) {
            rows = rows + '<tr>';
            rows = rows + '<td id="UserId' + value.UserId + '" value="' + value.UserId + '">' + value.UserId + '</td>';
            rows = rows + '<td id="UserName' + value.UserId + '" value="' + value.UserName + '">' + value.UserName + '</td>';
            rows = rows + '<td id="UserEmailId' + value.UserId + '">' + value.UserEmailId + '</td>';
            rows = rows + '<td id="ContactNumber' + value.UserId + '">' + value.ContactNumber + '</td>';
            rows = rows + '<td data-id="' + value.UserId + '">';
            rows = rows + '<button data-toggle="modal" data-target="#edit-user" class="btn btn-primary edit-user">Edit</button> ';
            rows = rows + '<button class="btn btn-danger remove-user">Delete</button>';
            rows = rows + '</td>';
            rows = rows + '</tr>';
        });
        $("#tbody").append(rows);
    }
    /* Create New User*/
    $(document).ready(function (e) {
        $('#usersubmitBtn').click(function (e) {
            createUser();
        });
    });
    function createUser() {
        var uname = $('#username').val();
        var email = $('#emailid').val();
        var contact = $('#contactno').val();

        $.ajax({
            type: "POST",
            url: 'UserMaster.aspx/AddUser',
            contentType: "application/json; charset=utf-8",
            data: "{ 'UserId': '0', 'UserName': '" + uname + "', 'UserEmailId': '" + email + "', 'ContactNumber': '" + contact + "'}",
            success: function (data) {
                $(".modal").modal('hide');
                //  toastr.success('User Created Successfully.', 'Success Alert', { timeOut: 5000 });
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                alert("Status: " + textStatus); alert("Error: " + errorThrown);
            }
        });
    };
    /* Remove User */

    $("body").on("click", ".remove-user", function () {
        var id = $(this).parent("td").data('id');
        var c_obj = $(this).parents("tr");
        $.ajax({
            type: 'POST',
            url: 'UserMaster.aspx/DeleteUser',
            contentType: "application/json; charset=utf-8",
            data: "{ 'id': '" + id + "' }",
            success: function (data) {
                // c_obj.remove();
                getPageData();
                // toastr.success('User Update Successfully.', 'Success Alert', { timeOut: 5000 });
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                alert("Status: " + textStatus); alert("Error: " + errorThrown);
            }

            });
    });


    /* Edit User */

    $("body").on("click", ".edit-user", function () {

        var id = $(this).parent("td").data('id');
        var username = $('#UserName' + id)[0]["outerText"];
        var emailid = $('#UserEmailId' + id)[0]["outerText"];
        var contactno = $('#ContactNumber' + id)[0]["outerText"];

        $("#edit-user").find("input[name='username']").val(username);
        $("#edit-user").find("input[name='emailid']").val(emailid);
        $("#edit-user").find("input[name='contactno']").val(contactno);

        $("#edit-user").find(".edit-id").val(id);


    });


    /* Updated new User */

    $(".crud-submit-edit").click(function (e) {
        var userid = $('#edit-id').val();
        var uname = $('#edit_username').val();
        var email = $('#edit_emailid').val();
        var contact = $('#edit_contactno').val();
        $.ajax({
            type: "POST",
            url: 'UserMaster.aspx/EditUser',
            contentType: "application/json; charset=utf-8",
            data: "{ 'UserId': '" + userid + "', 'UserName': '" + uname + "', 'UserEmailId': '" + email + "', 'ContactNumber': '" + contact + "'}",
            success: function (data) {
                $(".modal").modal('hide');
                getPageData();
                // toastr.success('User Update Successfully.', 'Success Alert', { timeOut: 5000 });
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                alert("Status: " + textStatus); alert("Error: " + errorThrown);
            }
        });
    });

});