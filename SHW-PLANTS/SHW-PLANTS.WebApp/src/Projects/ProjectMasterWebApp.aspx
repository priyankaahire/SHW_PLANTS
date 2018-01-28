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
                        <%--<input value="Create Project" id="projectcreateBtn" type="button" class="btn btn-success"  />--%>
                        <a href="ProjectCreateWebApp.aspx" id="projectcreateBtn" class="btn btn-success">Create Project</a>
                       <%-- <button type="button" class="btn btn-success" data-toggle="modal" data-target="#create-project">
                           Create Project
                        </button>--%>
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



        </div>
    </div>
</asp:Content>
