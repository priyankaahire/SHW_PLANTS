
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
                // var total_page = Math.ceil(data.length / 3);
                displayProjectList(data);
                is_ajax_fire = 1;
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                alert("Status: " + textStatus); alert("Error: " + errorThrown);
            }
        });
    }

    $(document).ready(function () {

        var counter = 2;

        $("#addButton").click(function () {

            if (counter >= 5) {
                alert("Only 5 payments are allow");
                return false;
            }

            var newTextBoxDiv = $(document.createElement('div'))
                .attr("id", 'TextBoxDiv' + counter);

            newTextBoxDiv.after().html('<label>Payment Date' + counter + ' : </label>' +
                '<input type="text" name="paymentdate' + counter +
                '" id="paymentdate' + counter + '" value="" >');

            newTextBoxDiv.appendTo("#TextBoxesGroup");
            counter++;
        });

        $("#removeButton").click(function () {
            if (counter == 1) {
                alert("No more textbox to remove");
                return false;
            }

            counter--;
            $("#TextBoxDiv" + counter).remove();

        });

        $("#getButtonValue").click(function () {
            var msg = '';
            for (i = 1; i < counter; i++) {
                msg += "\n Textbox #" + i + " : " + $('#paymentdate' + i).val();
            }
            alert(msg);
        });
    });


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
        $('#projectcreateBtn').click(function (e) {
           // location.href = "BGDetailsWebApp.aspx/GetBGDetail";
        });
    });
    /* Date Picker*/
    $(function () {
        $("#user_date").datepicker();
    });
    $(function () {
        $("#ld_date").datepicker();
    });
    $(function () {
        $("#bg_start_date").datepicker();
    });
    $(function () {
        $("#bg_end_date").datepicker();
    });
    $(function () {
        $("#delivery_date").datepicker();
    });
    $(function () {
        $("#inst_date").datepicker();
    });
    $(function () {
        $("#paymentdate").datepicker();
    });
    /*  submit user */
    /* Create New User*/
    $(document).ready(function (e) {
        $('#projectsubmitBtn').click(function (e) {
            createProject();
        });
    });
    function createProject() {
        var cname = $('#cname').val();
        var uname = $('#uname').val();
        var emailid = $('#emailid').val();
        var mobile = $('#mobileid').val();
        var ld_date = $('#ld_date').val();
        var ld_radio = $("input[name='ld_applicable']:checked").val();
        var ld_user = $('#ld_user').val();
        var bg_user = $('#bg_user').val();
        var bg_start_date = $('#bg_start_date').val();
        var bg_end_date = $('#bg_end_date').val();
        var bg_radio = $("input[name='bg_applicable']:checked").val();

        var da_radio = $("input[name='da_applicable']:checked").val();
        var da_user = $('#da_user').val();
        var delivery_date = $('#delivery_date').val();
        var inst_radio = $("input[name='inst_applicable']:checked").val();
        var inst_user = $('#inst_user').val();
        var inst_date = $('#inst_date').val();

        $.ajax({
            type: "POST",
            url: 'ProjectCreateWebApp.aspx/AddProject',
            contentType: "application/json; charset=utf-8",
          //  data: "{ 'UserId': '0', 'UserName': '" + uname + "', 'UserEmailId': '" + email + "', 'ContactNumber': '" + contact + "'}",
            success: function (data) {
                $(".modal").modal('hide');
                //  toastr.success('User Created Successfully.', 'Success Alert', { timeOut: 5000 });
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