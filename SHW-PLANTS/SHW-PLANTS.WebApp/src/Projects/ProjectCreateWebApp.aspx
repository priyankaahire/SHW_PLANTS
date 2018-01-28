<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProjectCreateWebApp.aspx.cs" Inherits="SHW_PLANTS.WebApp.src.Projects.ProjectCreateWebApp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
     <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css">
  <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
  <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
  <script src="project.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="page-wrapper">
        <div class="row">
            <div class="col-lg-12">
                <h1 class="page-header">Create Project</h1>
            </div>
        </div>
        <div class="container" style="width: 100%">
        <div class="">
<form>
  <div class="form-row">
    <div class="form-group col-md-6">
      <label for="cname">Customer Name</label>
      <input type="text" class="form-control" id="cname" placeholder="Customer Name">
    </div>
    <div class="form-group col-md-6">
      <label for="uname">Username</label>
      <input type="text" class="form-control" id="uname" placeholder="Username">
    </div>
  </div>
  <div class="form-row">
    <div class="form-group col-md-4">
      <label for="emailid">Email Id</label>
      <input type="text" class="form-control" id="emailid">
    </div>
    <div class="form-group col-md-4">
     <label for="mobileid">Mobile</label>
      <input type="text" class="form-control" id="mobileid">
    </div>
    <div class="form-group col-md-4">
      <label for="date">Date</label>
      <input type="text" class="form-control" id="user_date">
    </div>
  </div>
   <div class="form-row">
    <div class="form-group col-md-4">
        <b>Late Duty Applicable</b>
    <br /> <label class="radio-inline"><input id="ld_applicable" type="radio" value="'yes'" name="ld_applicable">Yes</label>
     <label class="radio-inline"><input id="ld_applicable" type="radio" value="'no'" name="ld_applicable">No</label>
    </div>
    <div class="form-group col-md-4">
      <label for="lddate">LD Date</label>
      <input type="text" class="form-control" id="ld_date" placeholder="Date">
    </div>
       <div class="form-group col-md-4">
    <label for="ld_user">User</label>
      <select id="ld_user" class="form-control">
        <option selected>Choose...</option>
        <option>User1</option>
        <option>User2</option>
        <option>User3</option>
        <option>User4</option>
      </select>
    </div>
  </div>
   <div class="form-row">
    <div class="form-group col-md-3">
         <b>BG Applicable</b>
     <br /><label class="radio-inline"><input id="bg_applicable" type="radio" name="bg_applicable">Yes</label>
     <label class="radio-inline"><input id="bg_applicable" type="radio" name="bg_applicable">No</label>
    </div>
    <div class="form-group col-md-3">
      <label for="bg_user">User</label>
      <select id="bg_user" class="form-control">
        <option selected>Choose...</option>
        <option>User1</option>
        <option>User2</option>
        <option>User3</option>
        <option>User4</option>
      </select>
    </div>
       <div class="form-group col-md-3">
      <label for="bgdate">Start Date</label>
      <input type="text" class="form-control" id="bg_start_date" placeholder="Date">
    </div>
       <div class="form-group col-md-3">
      <label for="bgdate">End Date</label>
      <input type="text" class="form-control" id="bg_end_date" placeholder="Date">
    </div>
  </div>
  <div class="form-row">
      <div class="form-group col-md-4">
         <b>Delivery Applicable</b>
     <br /><label class="radio-inline"><input id="da_applicable" type="radio" name="da_applicable">Yes</label>
     <label class="radio-inline"><input id="da_applicable" type="radio" name="da_applicable">No</label>
    </div>
      <div class="form-group col-md-4">
      <label for="">Delivery Date</label>
      <input type="text" class="form-control" id="delivery_date" placeholder="Date">
    </div>
    <div class="form-group col-md-4">
      <label for="da_user">User</label>
      <select id="da_user" class="form-control">
        <option selected>Choose...</option>
        <option>User1</option>
        <option>User2</option>
        <option>User3</option>
        <option>User4</option>
      </select>
    </div>
    
  </div>
     <div class="form-row">
         <div class="form-group col-md-4">
         <b>Installation Applicable</b>
     <br /><label class="radio-inline"><input id="inst_applicable" type="radio" name="inst_applicable">Yes</label>
     <label class="radio-inline"><input  id="inst_applicable" type="radio" name="inst_applicable">No</label>
    </div>
         <div class="form-group col-md-4">
      <label for="inst_date">Installation Date</label>
      <input type="text" class="form-control" id="inst_date" placeholder="Date">
    </div>
    <div class="form-group col-md-4">
    <label for="i">User</label>
      <select id="inst_user" class="form-control">
        <option selected>Choose...</option>
        <option>User1</option>
        <option>User2</option>
        <option>User3</option>
        <option>User4</option>
      </select>
    </div>
    
  </div>
   <div class="form-row">
    <div id="TextBoxesGroup" class="TextBoxesGroup form-group col-md-6">
         <b>payment details</b><br />
    <label>Payment Date1 : </label><input type='text' id='paymentdate1' >
    </div>
    <div class="form-group col-md-6">
    <span class="glyphicon glyphicon-plus" id='addButton' style="cursor:pointer"></span>
    <span class="glyphicon glyphicon-minus" id='removeButton' style="cursor:pointer"></span>
   <%-- <input type='button' value='Add Button' id='addButton'>
    <input type='button' value='Remove Button' id='removeButton'>--%>
    </div>
  </div>
  <div class="form-row">
  <input type="button" value="Submit" id="projectsubmitBtn" class="btn btn-primary"/>
 </div>
</form>
</div>         
</div>
</div>
</asp:Content>
