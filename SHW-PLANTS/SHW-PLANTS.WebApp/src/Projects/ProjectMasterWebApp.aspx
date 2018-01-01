<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProjectMasterWebApp.aspx.cs" Inherits="SHW_PLANTS.WebApp.src.Projects.ProjectMasterWebApp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <script src="project.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="page-wrapper">
        <div class="row">
            <div class="col-lg-12">
                <h1 class="page-header">Project Details</h1>
            </div>
        </div>
        <div class="container" style="width: 100%">
            <div class="row">
                <div class="col-lg-12 margin-tb">
                    <div class="pull-left">
                    </div>
                    <div class="pull-right">
                        <button type="button" class="btn btn-success" data-toggle="modal" data-target="#create-project">
                           Create Project
                        </button>
                    </div>
                </div>
            </div>
            <table id="table" class="table table-bordered">
                <thead>
                    <tr>
                        <th>No</th>
                        <th>Project Name</th>
                        <th>Customer Name</th>
                        <th>PONumber</th>
                        <th>PODate</th>
                        <th>ProjectStatus</th>
                        <th width="200px">Action</th>
                    </tr>
                </thead>
                <tbody id="tbody">
                </tbody>
            </table>
            <div id="pagination" class="pagination-sm"></div>
            <!-- Create Project Modal -->

            <div class="modal fade" id="create-project" tabindex="-1" role="dialog" aria-labelledby="projectModalLabel">
                <div class="modal-dialog" role="document" style="margin-left: -315px;">
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">×</span></button>
                            <h4 class="modal-title" id="projectModalLabel">Create Project</h4>
                        </div>
                        <div class="modal-body">
                            <form data-toggle="validator" method="POST">
                                <div class="form-group">
                                    <label class="control-label" for="username">Username:</label>
                                    <input type="text" id="username" name="username" class="form-control" data-error="Please enter username." required />
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

            <!-- Edit Project Modal -->

            <div class="modal fade" id="edit-project" tabindex="-1" role="dialog" aria-labelledby="projectModalLabel">
                <div class="modal-dialog" role="document" style="margin-left: -315px;">
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">×</span></button>
                            <h4 class="modal-title" id="projectModalLabel">Edit Item</h4>
                        </div>
                        <div class="modal-body">
                            <form data-toggle="validator" action="api/update.php" method="put">
                                <input type="hidden" name="id" class="edit-id">
                                <div class="form-group">
                                    <label class="control-label" for="title">Title:</label>
                                    <input type="text" name="title" class="form-control" data-error="Please enter title." required />
                                    <div class="help-block with-errors"></div>
                                </div>
                                <div class="form-group">
                                    <button type="submit" class="btn btn-success crud-submit-edit">Submit</button>
                                </div>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
