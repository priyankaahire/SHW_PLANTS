<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProjectCreateWebApp.aspx.cs" Inherits="SHW_PLANTS.WebApp.src.Projects.ProjectCreateWebApp" %>
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
           <%-- <div class="row">
                <div class="col-lg-12 margin-tb">
                    <div class="pull-left">
                    </div>
                    <div class="pull-right">
                        <button type="button" class="btn btn-success" data-toggle="modal" data-target="#create-project">
                           Create Project
                        </button>
                    </div>
                </div>
            </div>--%>
           <div class="">
                <form data-toggle="validator" method="POST" >
                                <div class="project_form" id="" >
                                   <div class="project_div" style="width:100%">
                                        <div class="" style="width:45%; float:left">
                                         <div class="form-group">
                                            <label class="control-label" for="username">Customer Name:</label>
                                            <input type="text" id="username" name="username" class="form-control" data-error="Please enter username." required />
                                            <div class="help-block with-errors">
                                            </div>
                                         </div>
                                        </div>
                                        <div class="" style="width:45%; float:right; right:0">
                                            <div class="form-group">
                                            <label class="control-label" for="username">Project Name:</label>
                                            <input type="text" id="username" name="username" class="form-control" data-error="Please enter username." required />
                                            <div class="help-block with-errors">
                                            </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="project_div" style="width:100%">
                                        <div class="" style="width:45%; float:left">
                                         <div class="form-group">
                                            <label class="control-label" for="username">Mobile number:</label>
                                            <input type="text" id="username" name="username" class="form-control" data-error="Please enter username." required />
                                            <div class="help-block with-errors">
                                            </div>
                                         </div>
                                        </div>
                                         <div class="" style="width:45%; float:right; right:0">
                                            <div class="form-group">
                                            <label class="control-label" for="username">Date:</label>
                                            <input type="text" id="username" name="username" class="form-control" data-error="Please enter username." required />
                                            <div class="help-block with-errors">
                                            </div>
                                            </div>
                                        </div>
                                    </div>
                                     <div class="project_div" style="width:100%">
                                        <div class="" style="width:45%; float:left">
                                         <div class="form-group">
                                             <label class="radio-inline"><input type="radio" name="optradio">Option 1</label>
                                             <label class="radio-inline"><input type="radio" name="optradio">Option 2</label>
                                         </div>
                                        </div>
                                         <div class="" style="width:45%; float:right">
                                         <div class="form-group">
                                            <label class="control-label" for="username">LD Date:</label>
                                            <input type="text" id="username" name="username" class="form-control" data-error="Please enter username." required />
                                            <div class="help-block with-errors">
                                            </div>
                                         </div>
                                        </div>
                                    </div>
                                    <div class="project_div" style="width:100%">
                                        <div class="" style="width:45%; float:left">
                                          <div class="form-group">
                                         <label class="radio-inline"><input type="radio" name="optradio">Option 1</label>
                                         <label class="radio-inline"><input type="radio" name="optradio">Option 2</label>
                                        </div>
                                        </div>
                                         <div class="" style="width:45%; float:right">
                                         <div class="form-group">
                                             <div class="form-group">
                                          <label for="sel1">BG User:</label>
                                          <select class="form-control" id="sel1">
                                            <option>User1</option>
                                            <option>User2</option>
                                            <option>User1</option>
                                            <option>User2</option>
                                          </select>
                                        </div>
                                         </div>
                                        </div>
                                    </div>
                                     <div class="project_div" style="width:100%">
                                        <div class="" style="width:45%; float:left">
                                        <div class="form-group">
                                            <label class="control-label" for="username">BG Start Date:</label>
                                            <input type="text" id="username" name="username" class="form-control" data-error="Please enter username." required />
                                            <div class="help-block with-errors">
                                            </div>
                                         </div>
                                        </div>
                                         <div class="" style="width:45%; float:right">
                                         <div class="form-group">
                                            <label class="control-label" for="username">BG End Date:</label>
                                            <input type="text" id="username" name="username" class="form-control" data-error="Please enter username." required />
                                            <div class="help-block with-errors">
                                            </div>
                                         </div>
                                        </div>
                                    </div>
                                    <div class="project_div" style="width:100%">
                                        <div class="" style="width:45%; float:left">
                                        <div class="form-group">
                                            <label class="control-label" for="username">Deliver Date:</label>
                                            <input type="text" id="username" name="username" class="form-control" data-error="Please enter username." required />
                                            <div class="help-block with-errors">
                                            </div>
                                         </div>
                                        </div>
                                         <div class="" style="width:45%; float:right">
                                          <div class="form-group">
                                             <div class="form-group">
                                          <label for="sel1">Delivery User:</label>
                                          <select class="form-control" id="sel1">
                                            <option>User1</option>
                                            <option>User2</option>
                                              <option>User1</option>
                                            <option>User2</option>
                                          </select>
                                        </div>
                                         </div>
                                        </div>
                                    </div>
                                    <div class="project_div" style="width:100%">
                                        <div class="" style="width:45%; float:left">
                                        <div class="form-group">
                                            <label class="control-label" for="username">Installation Date:</label>
                                            <input type="text" id="username" name="username" class="form-control" data-error="Please enter username." required />
                                            <div class="help-block with-errors">
                                            </div>
                                         </div>
                                        </div>
                                         <div class="" style="width:45%; float:right">
                                          <div class="form-group">
                                             <div class="form-group">
                                          <label for="sel1">Installation User:</label>
                                          <select class="form-control" id="sel1">
                                            <option>User1</option>
                                            <option>User2</option>
                                              <option>User1</option>
                                            <option>User2</option>
                                          </select>
                                        </div>
                                         </div>
                                        </div>
                                    </div>
                                </div>
                                 <div class="project_div" style="width:100%">
                                    <div class="form-group">
                                        <input value="Submit" id="projectsubmitBtn" type="button" class="btn crud-submit btn-success" />
                                    </div>
                                 </div>
                            </form>
           </div>
          
        </div>
    </div>
</asp:Content>
