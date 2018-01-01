﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BGDetailsWebApp.aspx.cs" Inherits="SHW_PLANTS.WebApp.src.Dashboard.BGDetailsWebApp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <script src="dashboard.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
     <div id="page-wrapper">
        <div class="row">
            <div class="col-lg-12">
                
                <h1 class="page-header">LD Details</h1>
            </div>
        </div>
        <div class="container" style="width: 100%">

            <div class="row">

                <div class="col-lg-12 margin-tb">

                    <div class="pull-left">

                       

                    </div>

                    <div class="pull-right">
                    </div>

                </div>

            </div>


            <table id="table" class="table table-bordered">

                <thead>
                    <tr>
                        <th>No</th>
                        <th>Project Name</th>
                        <th>LD Due Date</th>
                        <th>LD Read</th>
                        <th>LD Complicated Date</th>
                        <th>Username</th>
                        <th width="200px">Action</th>
                    </tr>
                </thead>
                <tbody id="tbody">
                </tbody>
            </table>

            <div id="pagination" class="pagination-sm"></div>


        </div>
    </div>

</asp:Content>
