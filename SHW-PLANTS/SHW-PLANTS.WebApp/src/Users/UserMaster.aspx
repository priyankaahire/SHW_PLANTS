<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserMaster.aspx.cs" Inherits="SHW_PLANTS.WebApp.src.Users.UserMaster" %>
<asp:Content ID="HeadContent" runat="server" ContentPlaceHolderID="HeadContent">
    
    <script type="text/javascript" src="user.js"></script>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="page-wrapper">
        <div class="row">
            <div class="col-lg-12">
                <h1 class="page-header">User Details</h1>
            </div>
        </div>
        <div class="container" style="width: 100%">

            <div class="row">

                <div class="col-lg-12 margin-tb">

                    <div class="pull-left">

                       

                    </div>

                    <div class="pull-right">

                        <button type="button" class="btn btn-success" data-toggle="modal" data-target="#create-item">
                            Create User
                    
                                   
                        </button>

                    </div>

                </div>

            </div>


            <table id="table" class="table table-bordered">

                <thead>
                    <tr>
                        <th>No</th>
                        <th>User Name</th>
                        <th>Email Id</th>
                        <th>Contact No</th>
                        <th width="200px">Action</th>
                    </tr>
                </thead>
                <tbody id="tbody">
                </tbody>
            </table>

            <div id="pagination" class="pagination-sm"></div>



            <!-- Create Item Modal -->

            <div class="modal fade" id="create-item" tabindex="-1" role="dialog" aria-labelledby="userModelLabel">

                <div class="modal-dialog" role="document" style="margin-left: -315px;">

                    <div class="modal-content">

                        <div class="modal-header">

                            <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">×</span></button>

                            <h4 class="modal-title" id="userModelLabel">Create User</h4>

                        </div>


                        <div class="modal-body">

                            <form data-toggle="validator" method="POST">


                                <div class="form-group">

                                    <label class="control-label" for="username">Username:</label>

                                    <input type="text" id="username" name="username" class="form-control" data-error="Please enter username." required />

                                    <div class="help-block with-errors"></div>

                                </div>


                               <!-- <div class="form-group">

                                    <label class="control-label" for="title">Description:</label>

                                    <textarea name="description" class="form-control" data-error="Please enter description." required></textarea>

                                    <div class="help-block with-errors"></div>

                                </div>-->
                                <div class="form-group">

                                    <label class="control-label" for="emailid">Email Id:</label>

                                    <input type="text" id="emailid" name="emailid" class="form-control" data-error="Please enter emailid." required />

                                    <div class="help-block with-errors"></div>

                                </div>
                                <div class="form-group">

                                    <label class="control-label" for="contactno">Contactno:</label>

                                    <input type="text" id="contactno" name="contactno" class="form-control" data-error="Please enter contactno." required />

                                    <div class="help-block with-errors"></div>

                                </div>

                                <div class="form-group">
                                    <input value="Submit" id="usercreateBtn" type="button" class="btn crud-submit btn-success" />
                                </div>


                            </form>


                        </div>

                    </div>


                </div>

            </div>


            <!-- Edit Item Modal -->

            <div class="modal fade" id="edit-user" tabindex="-1" role="dialog" aria-labelledby="userModelLabel">

                <div class="modal-dialog" role="document" style="margin-left: -315px;">

                    <div class="modal-content">

                        <div class="modal-header">

                            <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">×</span></button>

                            <h4 class="modal-title" id="userModelLabel">User</h4>

                        </div>


                        <div class="modal-body">

                            <form data-toggle="validator" action="api/update.php" method="put">

                                <input type="hidden" id="edit-id" name="id" class="edit-id">


                                <div class="form-group">

                                    <label class="control-label" for="username">User Name:</label>

                                    <input type="text" id="edit_username" name="username" class="form-control" data-error="Please enter username." required />

                                    <div class="help-block with-errors"></div>

                                </div>
                                 <div class="form-group">

                                    <label class="control-label" for="emailid">Email Id:</label>

                                    <input type="text" id="edit_emailid" name="emailid" class="form-control" data-error="Please enter emaild." required />

                                    <div class="help-block with-errors"></div>

                                </div>
                                 <div class="form-group">

                                    <label class="control-label" for="contactno">Contact No:</label>

                                    <input type="text" id="edit_contactno" name="contactno" class="form-control" data-error="Please enter contact." required />

                                    <div class="help-block with-errors"></div>

                                </div>

                                <div class="form-group">
                                    <input type="button" value="Update" class="btn btn-success crud-submit-edit" />
                                </div>


                            </form>


                        </div>

                    </div>

                </div>

            </div>


        </div>
    </div>
</asp:Content>
