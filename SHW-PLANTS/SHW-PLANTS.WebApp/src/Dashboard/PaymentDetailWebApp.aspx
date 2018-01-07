<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PaymentDetailWebApp.aspx.cs" Inherits="SHW_PLANTS.WebApp.src.Dashboard.PaymentDetailWebApp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <script src="payment.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
  <div id="page-wrapper">
        <div class="row">
            <div class="col-lg-12">
                
                <h1 class="page-header">BG Details</h1>
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
                        <th>Customer Name</th>
                        <th>Due Date</th>
                        <th>Username</th>
                        <th>Read</th>
                        <th>Completed</th>
                    </tr>
                </thead>
                <tbody id="tbody">
                </tbody>
            </table>

            <div id="pagination" class="pagination-sm"></div>


        </div>
    </div>
</asp:Content>
