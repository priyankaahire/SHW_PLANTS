
$( document ).ready(function() {
    
    
    var page = 1;
    
    var current_page = 5;
    
    var total_page = 0;
    
    var is_ajax_fire = 0;
    
    
    manageData();
    
    
    /* manage data list */
    
    function manageData() {
    
        $.ajax({
            url: 'projects.json',
            dataType: 'json',
            data: {page:page},
            success: function (data) {
               
                   var total_page = Math.ceil(data.length/3);

                //var total_page = Math.ceil(5);
                   var current_page = page;
                  
                   $('#pagination').twbsPagination({
                        totalPages: total_page,
                        visiblePages: current_page,
                        itemOnPage: 3,
                        onPageClick: function (event, page) {
                            page = page;
                            if(is_ajax_fire != 0){
                                getPageData();
                                current_page++;
                            }
                        }
                    });
                    manageRow(data, current_page);
                    is_ajax_fire = 1;
            },
            error: function(XMLHttpRequest, textStatus, errorThrown) { 
                alert("Status: " + textStatus); alert("Error: " + errorThrown); 
            }
    }); 
        // $.ajax({
        //     dataType: 'json',
        //     url: url,
        //     data: {page:page}
        // }).done(function(data){
        //     total_page = Math.ceil(data.total/10);
        //     current_page = page;
        //     $('#pagination').twbsPagination({
        //         totalPages: total_page,
        //         visiblePages: current_page,
        //         onPageClick: function (event, pageL) {
        //             page = pageL;
        //             if(is_ajax_fire != 0){
        //               getPageData();
        //             }
        //         }
        //     });
        //     manageRow(data);
        //     is_ajax_fire = 1;
        // });
    }
    
    
    /* Get Page Data*/
    function getPageData() {
        $.ajax({
            url: 'projects.json',
            dataType: 'json',
            success: function(data) {
                var data1 = JSON.stringify(data); 
                manageRow(data1, current_page);
            },
            error: function(XMLHttpRequest, textStatus, errorThrown) { 
                alert("Status: " + textStatus); alert("Error: " + errorThrown); 
            }
        }); 
        // $.ajax({
    
        //     dataType: 'json',
    
        //     url: 'projects.json',
    
        //     data: {page:page}
    
        // }).sucess(function(data){
    
        //     manageRow(data);
    
        // });
    
    }
    
    
    /* Add new Item table row */
    
    function manageRow(data, i) {
    
        var	rows = '';
    
        $.each(data, function (key, value) {
            if (value.id <= i * 5) {
                rows = rows + '<tr>';
                rows = rows + '<td>' + value.id + '</td>';
                rows = rows + '<td>' + value.address + '</td>';
                rows = rows + '<td>' + value.projectname + '</td>';
                rows = rows + '<td>' + value.assignename + '</td>';
                rows = rows + '<td data-id="' + value.id + '">';
                rows = rows + '<button data-toggle="modal" data-target="#edit-item" class="btn btn-primary edit-item">Edit</button> ';
                rows = rows + '<button class="btn btn-danger remove-item">Delete</button>';
                rows = rows + '</td>';
                rows = rows + '</tr>';
            }
           
        });
        $("#tbody").append(rows);
    }
    /* Create new Item */
    $(".crud-submit").click(function(e){
    
        e.preventDefault();
    
        var form_action = $("#create-item").find("form").attr("action");
    
        var title = $("#create-item").find("input[name='title']").val();
    
        var description = $("#create-item").find("textarea[name='description']").val();
    
    
        if(title != '' && description != ''){
    
            $.ajax({
    
                dataType: 'json',
    
                type:'POST',
    
                url: url + form_action,
    
                data:{title:title, description:description}
    
            }).done(function(data){
    
                $("#create-item").find("input[name='title']").val('');
    
                $("#create-item").find("textarea[name='description']").val('');
    
                getPageData();
    
                $(".modal").modal('hide');
    
                toastr.success('Item Created Successfully.', 'Success Alert', {timeOut: 5000});
    
            });
    
        }else{
    
            alert('You are missing title or description.')
    
        }
    
    
    });
    
    
    /* Remove Item */
    
    $("body").on("click",".remove-item",function(){
    
        var id = $(this).parent("td").data('id');
    
        var c_obj = $(this).parents("tr");
    
    
        $.ajax({
    
            dataType: 'json',
    
            type:'POST',
    
            url: url + 'api/delete.php',
    
            data:{id:id}
    
        }).done(function(data){
    
            c_obj.remove();
    
            toastr.success('Item Deleted Successfully.', 'Success Alert', {timeOut: 5000});
    
            getPageData();
    
        });
    
    
    });
    
    
    /* Edit Item */
    
    $("body").on("click",".edit-item",function(){
    
    
        var id = $(this).parent("td").data('id');
    
        var title = $(this).parent("td").prev("td").prev("td").text();
    
        var description = $(this).parent("td").prev("td").text();
    
    
        $("#edit-item").find("input[name='title']").val(title);
    
        $("#edit-item").find("textarea[name='description']").val(description);
    
        $("#edit-item").find(".edit-id").val(id);
    
    
    });
    
    
    /* Updated new Item */
    
    $(".crud-submit-edit").click(function(e){
    
    
        e.preventDefault();
    
        var form_action = $("#edit-item").find("form").attr("action");
    
        var title = $("#edit-item").find("input[name='title']").val();
    
    
        var description = $("#edit-item").find("textarea[name='description']").val();
    
        var id = $("#edit-item").find(".edit-id").val();
    
    
        if(title != '' && description != ''){
    
            $.ajax({
    
                dataType: 'json',
    
                type:'POST',
    
                url: url + form_action,
    
                data:{title:title, description:description,id:id}
    
            }).done(function(data){
    
                getPageData();
    
                $(".modal").modal('hide');
    
                toastr.success('Item Updated Successfully.', 'Success Alert', {timeOut: 5000});
    
            });
    
        }else{
    
            alert('You are missing title or description.')
    
        }
    
    
    });
    
    });