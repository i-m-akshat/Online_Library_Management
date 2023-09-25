<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin2.Master" AutoEventWireup="true" CodeBehind="AdminPublisherManagement.aspx.cs" Inherits="Project1.Admin.AdminPublisherManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section>
        <div class="container-fluid mt-5 mb-5" style="height:auto">
            <div class="row d-flex g-2 ">
                <div class="col-md-5 col-lg-5 mt-5 pt-5 mb-sm-5">
                <div class="card d-flex text-white" style="border-radius:1rem 1rem 1rem 1rem;border-style:double;background:linear-gradient(to right bottom, #b867fa, #cb3ff9, #a108f3);">
                    <!--Card body-->
                    <div class="card-body mb-5 mt-2">
                        <center> 
                            <img src="../Styling/assets/image/Data report-amico publisher.png" class="img-fluid" height="200" width="200"/>
                            <h2>Publisher Details</h2>
                        </center>
                        <div class="col-12 mt-5">
                            <div class="row m-2">
                                <div class="col-md-6 col-sm-6">
                                   <asp:TextBox ID="txt_PublisherID" runat="server" CssClass="form-control form-control-sm" aria-expanded="false" aria-label="Go" placeholder="Publisher id"></asp:TextBox>
                                   <asp:LinkButton CssClass="btn btn-sm btn-success text-light" runat="server" ID="btn_Search" OnClick="btn_Search_Click"><i class="fas fa-search"></i></asp:LinkButton>
                                </div>
                                <div class="col-md-6 col-sm-6">
                                   <asp:TextBox ID="txt_PublisherName" runat="server" CssClass="form-control form-control-sm" Placeholder="Publisher Name"></asp:TextBox>
                                   <asp:RequiredFieldValidator ID="rqr_PublisherName" runat="server" ControlToValidate="txt_PublisherName" ErrorMessage="Please Enter Publisher Name" ForeColor="Red" ValidationGroup="PublisherName"></asp:RequiredFieldValidator>
                                </div>
                           </div>
                       </div>
                        <div class="col-12 mt-2 pt-2">
                            <div class="row ">
                                <div class="col-4">
                                    <asp:LinkButton ID="btn_Add" runat="server" CssClass="btn form-control btn-success btn-sm" OnClick="btn_Add_Click" ValidationGroup="PublisherName"><center><i class=" fas fa-plus-circle"></i></center></asp:LinkButton>
                                </div>
                                 <div class="col-4">
                                    <asp:LinkButton ID="btn_Update" runat="server" CssClass="btn form-control btn-sm btn-warning text-white" OnClick="btn_Update_Click"><center><i class="fas fa-pen-fancy"></i></center></asp:LinkButton>
                                </div>
                                 <div class="col-4">
                                    <asp:LinkButton ID="btn_Delete" runat="server" CssClass="btn form-control btn-sm btn-danger" OnClick="btn_Delete_Click"><center><i class="fas fa-trash"></i></center></asp:LinkButton>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                </div>
               <!--Second card for gridview-->
                <div class="col-md-7 mb-sm-5 mt-5 mb-5 pt-5">
                       <div class="card text-white d-flex h-100" style="border-radius:1rem 1rem 1rem 1rem;background:linear-gradient(to right bottom, #b867fa, #cb3ff9, #a108f3);">
                       <div class="card-body mb-5 mt-2">
                       <div class="col-12">
                           <div class="row">
                            <center>
                                <h3 style="font-family:'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif">Publisher Details</h3>
                            </center>  
                           </div>
                       </div>
                       <div class="col-md-12 mt-1">
                               <asp:GridView ID="Grd_Publisher" OnPageIndexChanging="Grd_Publisher_PageIndexChanging" PageSize="3" runat="server" AutoGenerateColumns="false" AllowPaging="true" Class="table table-hover table-active table-responsive" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None">
                                   <Columns>
                                       <asp:TemplateField HeaderText="PublisherID">
                                           <EditItemTemplate>
                                               <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("PublisherID") %>'></asp:TextBox>
                                           </EditItemTemplate>
                                           <ItemTemplate>
                                               <asp:Label ID="Label1" runat="server" Text='<%# Bind("PublisherID") %>'></asp:Label>
                                           </ItemTemplate>
                                       </asp:TemplateField>
                                       <asp:TemplateField HeaderText="PublisherName">
                                           <EditItemTemplate>
                                               <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("PublisherName") %>'></asp:TextBox>
                                           </EditItemTemplate>
                                           <ItemTemplate>
                                               <asp:Label ID="Label2" runat="server" Text='<%# Bind("PublisherName") %>'></asp:Label>
                                           </ItemTemplate>
                                       </asp:TemplateField>
                                   </Columns>
                                   <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                                   <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
                                   <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                                   <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
                                   <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                                   <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                   <SortedAscendingHeaderStyle BackColor="#594B9C" />
                                   <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                   <SortedDescendingHeaderStyle BackColor="#33276A" />
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
