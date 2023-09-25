<%@ Page Title="" Language="C#" MasterPageFile="~/Project1.Master" AutoEventWireup="true" CodeBehind="UserProfilePage.aspx.cs" Inherits="Project1.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="">
        <div class="container-fluid mt-5 mb-5" style="height: auto">
            <%--The first card for User profile --%>
            <div class="row d-flex g-2">
                <div class="col-md-5 mb-sm-5 mt-5 mb-5">
                    <div class="card text-white d-flex h-100" style="border-radius: 1rem 1rem 1rem 1rem; background: linear-gradient(to right bottom, #b867fa, #cb3ff9, #a108f3);">
                        <div class="card-body mb-5 mt-2">
                            <div class="col-12">
                                <div class="row">
                                    <center>
                                        <img src="Styling/assets/image/Personal data-bro.png" class="d-flex" style="height: 200px; width: 210px" />
                                        <h3 style="font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif">Your Profile</h3>
                                        <span class="mt-3">Accout Status</span>
                                        <asp:Label ID="lblAccount" runat="server" Class="badge rounded-pill bg-info" Text="Your Status"></asp:Label>
                                    </center>
                                </div>
                            </div>
                            <div class="col-12 mt-1">
                                <div class="row">
                                    <div class="mb-2 col-6">
                                        <label class="form-label" runat="server" for="txt_FullName">Full Name</label>
                                        <asp:TextBox ID="txt_FullName" runat="server" CssClass="form-control form-control-sm"></asp:TextBox>

                                    </div>
                                    <div class="mb-2 col-6">
                                        <label class="form-label" runat="server" for="txt_DOB">Date Of Birth</label>
                                        <asp:TextBox ID="txt_DOB" runat="server" TextMode="Date" CssClass="form-control form-control-sm"></asp:TextBox>

                                    </div>
                                </div>
                            </div>
                            <div class="col-12">
                                <label class="form-label" runat="server" for="txt_email">E Mail</label>
                                <asp:TextBox ID="txt_EMail" TextMode="Email" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>


                            </div>
                            <div class="col-12">
                                <label class="form-label" runat="server" for="txt_FullAddress">Full Address</label>
                                <asp:TextBox ID="txt_FullAddress" runat="server" CssClass="form-control"></asp:TextBox>


                            </div>
                            <div class="col-12 mt-2">
                                <div class="row">
                                    <div class="col-6">
                                        <label for="ddl_State" runat="server" class="form-label">State</label>
                                        <asp:TextBox ID="txt_State" runat="server" CssClass="form-control" ReadOnly="true">
                                        </asp:TextBox>

                                    </div>
                                    <div class="col-6">
                                        <label for="ddl_City" runat="server" class="form-label">City</label>
                                        <asp:TextBox ID="txt_City" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>

                                    </div>
                                </div>
                            </div>
                            <div class="col-12">
                                <div class="row">
                                    <h5 class="text-center rounded-pill mt-3"><span class="badge" style="background-color: #f53919; border-radius: 2rem 2rem 2rem 2rem">Login credentials</span></h5>
                                    <div class="col-4">
                                        <label for="txt_UserId" runat="server" class="form-label">UserId</label>
                                        <asp:TextBox ID="txt_UserId" runat="server" CssClass="form-control " ReadOnly="true"></asp:TextBox>

                                    </div>
                                    <div class="col-4">
                                        <label for="txt_OldPassword" runat="server" class="form-label">Old Password</label>
                                        <asp:TextBox ID="txt_OldPassword" runat="server" CssClass="form-control " ReadOnly="true"></asp:TextBox>

                                    </div>
                                    <div class="col-4">
                                        <label for="txt_NewPassword" runat="server" class="form-label">New Password</label>
                                        <asp:TextBox ID="txt_NewPassword" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <center>
                                <div class="col-12 mt-3">
                                    <div class="row">
                                        <asp:Button ID="btn_Update" runat="server" OnClick="btn_Update_Click" CssClass="btn text-white item-hover form-control" Text="Update" BackColor="#9966ff" />
                                    </div>
                                </div>
                            </center>
                        </div>
                    </div>
                </div>
                <%--The Second card for Issued Book status--%>
                <div class="col-md-7 mb-sm-5 mt-5 mb-5">
                    <div class="card text-white d-flex h-100" style="border-radius: 1rem 1rem 1rem 1rem; background: linear-gradient(to right bottom, #b867fa, #cb3ff9, #a108f3);">
                        <div class="card-body mb-5 mt-2">
                            <div class="col-12">
                                <div class="row">
                                    <center>
                                        <img src="Styling/assets/image/flat-bookshelves-shelf-book-in-room-library-vector-25516029.jpg" class="d-flex" style="height: 150px; width: 150px" />
                                        <h3 style="font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif">Your Issued Books</h3>
                                        <span class="mt-3">Issued Book Status</span>
                                        <asp:Label ID="lbl_BookStatus" runat="server" Class="badge rounded-pill bg-info" Text="Your Book status"></asp:Label>
                                    </center>
                                </div>
                            </div>
                            <div class="col-md-12 mt-3">
                                <asp:GridView ID="Grid_User" runat="server" Class="table table-hover table-active table-responsive" AutoGenerateColumns="False" PageSize="4" BackColor="White" ForeColor="Black" AlternatingRowStyle-Wrap="true" AllowPaging="True" OnPageIndexChanging="Grid_User_PageIndexChanging" OnRowDataBound="Grid_User_RowDataBound">

                                    <AlternatingRowStyle Wrap="True"></AlternatingRowStyle>

                                    <Columns>
                                        <asp:TemplateField HeaderText="MemberId">
                                            <%--<EditItemTemplate>
                                                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("MemberId") %>'></asp:TextBox>
                                            </EditItemTemplate>--%>
                                            <ItemTemplate>
                                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("MemberId") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="MemberName">
                                            <%--<EditItemTemplate>
                                                <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("FullName") %>'></asp:TextBox>
                                            </EditItemTemplate>--%>
                                            <ItemTemplate>
                                                <asp:Label ID="Label2" runat="server" Text='<%# Bind("FullName") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="BookId">
                                           <%-- <EditItemTemplate>
                                                <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("BookId") %>'></asp:TextBox>
                                            </EditItemTemplate>--%>
                                            <ItemTemplate>
                                                <asp:Label ID="Label3" runat="server" Text='<%# Bind("BookId") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="BookName">
                                           <%-- <EditItemTemplate>
                                                <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("BookName") %>'></asp:TextBox>
                                            </EditItemTemplate>--%>
                                            <ItemTemplate>
                                                <asp:Label ID="Label4" runat="server" Text='<%# Bind("BookName") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="IssueDate">
                                           <%-- <EditItemTemplate>
                                                <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("IssueDate") %>'></asp:TextBox>
                                            </EditItemTemplate>--%>
                                            <ItemTemplate>
                                                <asp:Label ID="Label5" runat="server" Text='<%# Bind("IssueDate") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="DueDate">
                                           <%-- <EditItemTemplate>
                                                <asp:TextBox ID="TextBox6" runat="server" Text='<%# Bind("DueDate") %>'></asp:TextBox>
                                            </EditItemTemplate>--%>
                                            <ItemTemplate>
                                                <asp:Label ID="lbl_Due" runat="server" Text='<%# Bind("DueDate") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
            <a href="HomePage.aspx" class="link-danger item-hover" style="text-decoration: none"><i class="fa fa-arrow-left">Back</i></a>
        </div>
    </section>
</asp:Content>
