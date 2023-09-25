<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin2.Master" AutoEventWireup="true" CodeBehind="AdminAuthorManagement.aspx.cs" Inherits="Project1.Admin.AdminAuthorManagement1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <script type="text/javascript">
        $(document).ready(function () {
            $('#Grd_Author').dataTable();
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section>
        <div class="container-fluid mt-5 mb-5" style="height: auto">
            <%--The first card for User profile --%>
            <div class="row d-flex g-2">
                <div class="col-md-5 mb-sm-5 mt-5 mb-5 pt-5">
                    <div class="card text-white d-flex h-100" style="border-radius: 1rem 1rem 1rem 1rem; background: linear-gradient(to right bottom, #b867fa, #cb3ff9, #a108f3);">
                        <div class="card-body mb-5 mt-2">
                            <div class="col-12">
                                <div class="row">
                                    <center>
                                        <img src="../Styling/assets/image/Writer's block-pana author.png" class="d-flex" style="height: 180px; width: 190px" />
                                        <h3 style="font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif">Author Details</h3>
                                    </center>
                                </div>
                            </div>
                            <div class="col-12 mt-2">
                                <div class="row">
                                    <div class="col-md-6 col-sm-5">
                                        <asp:TextBox ID="txt_AuthorID" runat="server" class="form-control form-control-sm" aria-expanded="false" aria-label="Go" placeholder="Author id" />
                                        <asp:LinkButton class="btn btn-success btn-sm text-light" ID="btn_2_Go" runat="server" Text="Go" OnClick="btn_2_Go_Click"><i class="fas fa-search"></i></asp:LinkButton>
                                    </div>
                                    <div class="col-md-6 col-sm-5">
                                        <asp:TextBox ID="txt_AuthorName" runat="server" CssClass="form-control form-control-sm" Placeholder="Author Name"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="rqr_AuthorName" runat="server" ControlToValidate="txt_AuthorName" ErrorMessage="Please Enter Author Name" ForeColor="Red" ValidationGroup="AuthorName"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-12 mt-2">
                                <div class="row">
                                    <div class="col-md-4 mt-2">
                                        <asp:LinkButton ID="btn_Add" CssClass="form-control btn-success"  runat="server"  OnClick="btn_Add_Click"><center><i class=" fas fa-plus-circle"></i></center></asp:LinkButton>
                                    </div>
                                    <div class="col-md-4 mt-2">
                                        <asp:LinkButton ID="btn_Update" CssClass="form-control btn-primary"  runat="server"  OnClick="btn_Update_Click"><center><i class="fas fa-pen-fancy"></i></center></asp:LinkButton>
                                    </div>
                                    <div class="col-md-4 mt-2">
                                        <asp:LinkButton ID="btn_Delete" CssClass="form-control btn-danger"  runat="server"  OnClick="btn_Delete_Click"><center><i class="fas fa-trash"></i></center></asp:LinkButton>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <%--The Second card for Issued Book status--%>
                <div class="col-md-7 mb-sm-5 mt-5 mb-5 pt-5">
                    <div class="card text-white d-flex h-100" style="border-radius: 1rem 1rem 1rem 1rem; background: linear-gradient(to right bottom, #b867fa, #cb3ff9, #a108f3);">
                        <div class="card-body mb-5 mt-2">
                            <div class="col-12">
                                <div class="row">
                                    <center>
                                        <h3 style="font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif">Author Details</h3>
                                    </center>
                                </div>
                            </div>
                            <div class="col-md-12 mt-1">
                                <asp:GridView ID="Grd_Author" ClientIDMode="Static" DataKeyNames="AuthorID" AllowPaging="true" AllowSorting="true" runat="server" Class="table table-hover table-active table-responsive" AutoGenerateColumns="False" CellPadding="3" GridLines="Horizontal" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px">
                                    <AlternatingRowStyle BackColor="#F7F7F7" />
                                    <Columns>
                                        <asp:TemplateField HeaderText="AuthorID">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("AuthorID") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("AuthorID") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="AuthorName">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("AuthorName") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label2" runat="server" Text='<%# Bind("AuthorName") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                    <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                                    <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                                    <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                                    <SortedAscendingCellStyle BackColor="#F4F4FD" />
                                    <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                                    <SortedDescendingCellStyle BackColor="#D8D8F0" />
                                    <SortedDescendingHeaderStyle BackColor="#3E3277" />
                                </asp:GridView>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
            <a href="AdminDashboard.aspx" class="link-danger item-hover" style="text-decoration: none"><i class="fa fa-arrow-left">Back</i></a>
        </div>
    </section>
</asp:Content>
