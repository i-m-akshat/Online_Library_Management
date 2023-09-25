<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin2.Master" AutoEventWireup="true" CodeBehind="AdminBookIssuing.aspx.cs" Inherits="Project1.Admin.AdminBookIssuing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="">
       <div class="container-fluid mt-5 mb-5" style="height:auto">
           <%--The first card for main Options --%>
               <div class="row d-flex g-2">
                    <div class="col-md-5 mb-sm-5 mt-5 mb-5">
                    <div class="card text-white d-flex h-100" style="border-radius:1rem 1rem 1rem 1rem;background:linear-gradient(to right bottom, #b867fa, #cb3ff9, #a108f3);">
                    <div class="card-body mb-5 mt-2">
                       <div class="col-12">
                           <div class="row">
                            <center><img src="../Styling/assets/image/Woman reading-bro.png" class="d-flex" style="height:200px;width:210px" />
                                <h3 style="font-family:'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif">Book Issuing</h3>
                            </center>  
                           </div>
                       </div>
                       <div class="col-12 mt-3">
                           <div class="row">
                           <div class="col-6">
                           <label>Member ID</label>
                           <div class="form-group">
                               <asp:TextBox ID="txt_MemberID" runat="server" CssClass="form-control form-control-sm"></asp:TextBox>
                               <asp:RequiredFieldValidator ID="rqr_MemberId" runat="server" ValidationGroup="btn" ControlToValidate="txt_MemberID" ForeColor="Red" ErrorMessage="Please enter the MemberID"></asp:RequiredFieldValidator>
                              
                           </div>
                           </div>
                           <div class="col-6">
                           <label>Book Id</label>
                           <div class="form-group">
                               <div class="input-group">
                                   <asp:TextBox CssClass="form-control form-control-sm" runat="server" aria-expanded="false" aria-label="Go" ID="txt_BookId"></asp:TextBox>
                                   <asp:LinkButton CssClass="btn btn-sm btn-success text-light" ValidationGroup="btn" runat="server" ID="btn_2_Search" OnClick="btn_2_Search_Click">Go</asp:LinkButton>
                               </div>   
                           </div>
                           </div>
                       </div>
                       </div>
                       <div class="col-12 mt-3">
                           <div class="row">
                           <div class="col-6">
                           <label>Member Name</label>
                           <div class="form-group">
                               <asp:TextBox ID="txt_MemberName" ReadOnly="true" runat="server" CssClass="form-control"></asp:TextBox>
                               
                           </div>
                           </div>
                           <div class="col-6">
                           <div class="form-group">
                               <label>Book Name</label>
                                <asp:TextBox ID="txt_BookName" ReadOnly="true" runat="server" CssClass="form-control"></asp:TextBox>
                           </div>
                           </div>
                       </div>
                       </div>
                       <div class="col-12 mt-3">
                           <div class="row">
                           <div class="col-6">
                           <label>Issue Date</label>
                           <div class="form-group">
                               <asp:TextBox ID="txt_IssueDate" TextMode="Date" runat="server" CssClass="form-control"></asp:TextBox>
                               
                           </div>
                           </div>
                           <div class="col-6">
                           <div class="form-group">
                               <label>Due Date</label>
                                <asp:TextBox ID="txt_DueDate" TextMode="Date" runat="server" CssClass="form-control"></asp:TextBox>
                           </div>
                           </div>
                       </div>
                       </div>
                       <div class="col-12 mt-3">
                           <div class="row">
                               <div class="col-6">
                                   <asp:LinkButton class="btn form-control btn-success" ValidationGroup="btn" runat="server" ID="btn_Issue" OnClick="btn_Issue_Click">Issue</asp:LinkButton> 
                               </div>
                               <div class="col-6">
                                   <asp:LinkButton class="btn form-control btn-danger" ValidationGroup="btn" runat="server" ID="btn_Return" OnClick="btn_Return_Click">Return </asp:LinkButton>
                               </div>
                           </div>
                       </div>
                       
                   </div>
                   </div>
                   </div>
           <%--The Second card for Issued Books Gridview--%>
                    <div class="col-md-7 mb-sm-5 mt-5 mb-5">
                       <div class="card text-white d-flex h-100" style="border-radius:1rem 1rem 1rem 1rem;background:linear-gradient(to right bottom, #b867fa, #cb3ff9, #a108f3);">
                       <div class="card-body mb-5 mt-2">
                       <div class="col-12">
                           <div class="row">
                            <center>
                                <h3 style="font-family:'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif">Issued Book List</h3>
                            </center>  
                           </div>
                       </div>
                       
                       <div class="col-md-12 mt-1">
                               <asp:GridView ID="Grd_Issue" OnRowDataBound="Grd_Issue_RowDataBound" HeaderStyle-BackColor="#999999" PageSize="4" GridLines="Both" AutoGenerateColumns="false" AllowPaging="True" AllowSorting="True" OnPageIndexChanging="Grd_Issue_PageIndexChanging" ForeColor="Black" BackColor="White" runat="server" Class="table table-hover table-active table-responsive" BorderStyle="Solid">
                                   <Columns>
                                       <asp:TemplateField HeaderText="MemberID">
                                           <EditItemTemplate>
                                               <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("MemberId") %>'></asp:TextBox>
                                           </EditItemTemplate>
                                           <ItemTemplate>
                                               <asp:Label ID="Label1" runat="server" Text='<%# Bind("MemberId") %>'></asp:Label>
                                           </ItemTemplate>
                                       </asp:TemplateField>
                                       <asp:TemplateField HeaderText="BookId">
                                           <EditItemTemplate>
                                               <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("BookId") %>'></asp:TextBox>
                                           </EditItemTemplate>
                                           <ItemTemplate>
                                               <asp:Label ID="Label2" runat="server" Text='<%# Bind("BookId") %>'></asp:Label>
                                           </ItemTemplate>
                                       </asp:TemplateField>
                                       <asp:TemplateField HeaderText="MemberName">
                                           <EditItemTemplate>
                                               <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("MemberName") %>'></asp:TextBox>
                                           </EditItemTemplate>
                                           <ItemTemplate>
                                               <asp:Label ID="Label3" runat="server" Text='<%# Bind("MemberName") %>'></asp:Label>
                                           </ItemTemplate>
                                       </asp:TemplateField>
                                       <asp:TemplateField HeaderText="BookName">
                                           <EditItemTemplate>
                                               <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("BookName") %>'></asp:TextBox>
                                           </EditItemTemplate>
                                           <ItemTemplate>
                                               <asp:Label ID="Label4" runat="server" Text='<%# Bind("BookName") %>'></asp:Label>
                                           </ItemTemplate>
                                       </asp:TemplateField>
                                       <asp:TemplateField HeaderText="IssueDate">
                                           <EditItemTemplate>
                                               <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("IssueDate") %>'></asp:TextBox>
                                           </EditItemTemplate>
                                           <ItemTemplate>
                                               <asp:Label ID="Label5" runat="server" Text='<%# Bind("IssueDate") %>'></asp:Label>
                                           </ItemTemplate>
                                       </asp:TemplateField>
                                       <asp:TemplateField HeaderText="DueDate">
                                           <EditItemTemplate>
                                               <asp:TextBox ID="TextBox6" runat="server" Text='<%# Bind("DueDate") %>'></asp:TextBox>
                                           </EditItemTemplate>
                                           <ItemTemplate>
                                               <asp:Label ID="lblDueDate" runat="server" Text='<%# Bind("DueDate") %>'></asp:Label>
                                           </ItemTemplate>
                                       </asp:TemplateField>
                                   </Columns>
                               </asp:GridView>
                       </div>
                      </div>
                      </div>
                   </div>
                     
                  </div>
           <a href="AdminDashboard.aspx" class="link-danger item-hover" style="text-decoration:none"><i class="fa fa-arrow-left">Back</i></a>
      </div>                                   
   </section>
</asp:Content>
