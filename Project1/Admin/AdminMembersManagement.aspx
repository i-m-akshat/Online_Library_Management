<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin2.Master" AutoEventWireup="true" CodeBehind="AdminMembersManagement.aspx.cs" Inherits="Project1.Admin.AdminMembersManagement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        $(document).ready(function() {
            var table = $('[id*=Grd_Member]').prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="">
        <div class="container-fluid mt-5 mb-5" style="height: auto">
            <%--The first card for main Options --%>
            <div class="row">
                <div class="card col-md-6 col-sm-1 mt-5 mb-5" style="border-radius: 1rem 1rem 1rem 1rem; background: linear-gradient(to right bottom, #b867fa, #cb3ff9, #a108f3)">
                    <div class="card-body text-white justify-content-sm-center align-content-sm-center w-100">
                        <div class="col-md-12 col-sm-1">
                            <div class="row">
                                <center>
                                    <img src="../Styling/assets/image/New team members-amico members.png" height="250" width="250" />
                                    <h3 class="text-center mt-1" style="font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif">Member Management</h3>
                                </center>
                            </div>
                        </div>
                        <div class="col-md-12 mt-3">
                            <div class="row justify-content-evenly">
                                <div class="col-md-3 col-sm-1">
                                    <label for="txt_MemberId" class="form-label" runat="server">Id</label>
                                    <div class="form-group">
                                        <div class="input-group">
                                            <asp:TextBox class="form-control form-control-sm" Id="txt_MemberId" runat="server" placeholder="Id" aria-label="MemberId"></asp:TextBox>
                                            <asp:LinkButton OnClick="btn_SearchId_Click" CssClass="btn btn-sm btn-success" runat="server"  Id="btn_SearchId"><i class="fa fa-search"></i></asp:LinkButton>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-4 col-sm-1">
                                    <label for="txt_FullName" runat="server" class="form-label">Full Name</label>
                                    <asp:TextBox ID="txt_FullName" CssClass="form-control form-control-sm" runat="server" ReadOnly="true" placeholder="MemberName"></asp:TextBox>
                                    
                                </div>
                                <div class="col-md-5 col-sm-1">
                                    <label for="txt_AccountStatus" runat="server" class="form-label">Status</label>
                                    <div class="form-group">
                                        <div class="input-group">
                                            <asp:TextBox ID="txt_AccountStatus" CssClass="form-control form-control-sm" ReadOnly="true" runat="server" placeholder="Status" aria-label="Account Status" />
                                            <asp:LinkButton class="btn btn-sm btn-success  mx-1" data-bs-toggle="tooltip" title="Activate" runat="server" ID="btn_Active" OnClick="btn_Active_Click"><i class="fas fa-user-check"></i></asp:LinkButton>
                                            <asp:LinkButton class="btn btn-sm btn-warning mx-1 " runat="server" data-bs-toggle="tooltip" title="Disable" ID="btn_Pending" OnClick="btn_Pending_Click"><i class="fas fa-user-clock"></i></asp:LinkButton>
                                            <asp:LinkButton class="btn btn-sm btn-danger mx-1 " runat="server" data-bs-toggle="tooltip" title="Deactivate" ID="btn_deactivate" OnClick="btn_deactivate_Click"><i class="fas fa-user-times"></i></asp:LinkButton>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-12 mt-3">
                            <div class="row justify-content-evenly">
                                <div class="col-md-3 col-sm-1">
                                    <label for="txt_DOB" class="form-label" runat="server">DOB</label>
                                    <asp:TextBox ID="txt_DOB" runat="server" CssClass="form-control form-control-sm" ReadOnly="true"></asp:TextBox>
                                </div>
                                <div class="col-md-4 col-sm-1">
                                    <label for="txt_ContactNo" runat="server" class="form-label">Contact</label>
                                    <asp:TextBox ID="txt_ContactNo" CssClass="form-control form-control-sm" runat="server" ReadOnly="true"></asp:TextBox>
                                </div>
                                <div class="col-md-5 col-sm-1">
                                    <label for="txt_EMail" runat="server" class="form-label">EMail</label>
                                    <asp:TextBox ID="txt_EMail" CssClass="form-control form-control-sm" ReadOnly="true" runat="server" placeholder="E Mail" aria-label="E Mail" />
                                </div>
                            </div>
                        </div>
                        <div class="col-md-12 mt-3">
                            <div class="row justify-content-evenly">
                                <div class="col-md-4 col-sm-1">
                                    <label for="txt_State" class="form-label" runat="server">State</label>
                                    <asp:TextBox ID="txt_State" runat="server" CssClass="form-control form-control-sm" ReadOnly="true"></asp:TextBox>
                                </div>
                                <div class="col-md-4 col-sm-1">
                                    <label for="txt_City" runat="server" class="form-label">City</label>
                                    <asp:TextBox ID="txt_City" CssClass="form-control form-control-sm" runat="server" ReadOnly="true"></asp:TextBox>
                                </div>
                                <div class="col-md-4 col-sm-1">
                                    <label for="txt_Pincode" runat="server" class="form-label">Pincode</label>
                                    <asp:TextBox ID="txt_Pincode" CssClass="form-control form-control-sm" ReadOnly="true" runat="server" placeholder="Pincode" aria-label="Pincode" />
                                </div>
                            </div>
                        </div>
                        <div class="col-md-12 mt-3">
                            <label for="txt_FullAddress" runat="server" class="form-label">Full Address</label>
                            <asp:TextBox ID="txt_FullAddress" runat="server" ReadOnly="true" CssClass="form-control form-control-sm" TextMode="MultiLine"></asp:TextBox>
                        </div>
                        <div class="col-md-12 mt-3">
                            <center>
                                <asp:LinkButton Id="btn_DeleteMember" OnClick="btn_DeleteMember_Click" runat="server" class="btn btn-danger" title="Delete the member permanently"><i class="fas fa-trash"></i></asp:LinkButton>
                            </center>
                        </div>
                    </div>
                </div>
                <%--The Second card for Issued Books Gridview--%>
                <div class="col-md-6 mb-sm-5 mt-5 mb-5">
                    <div class="card text-white d-flex h-100" style="border-radius: 1rem 1rem 1rem 1rem; background: linear-gradient(to right bottom, #b867fa, #cb3ff9, #a108f3);">
                        <div class="card-body mb-5 mt-2">
                            <div class="col-12">
                                <div class="row">
                                    <center>
                                        <h3 style="font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif">Member List</h3>
                                    </center>
                                </div>
                            </div>

                            <div class="col-md-12 mt-1">
                                <asp:GridView ID="Grd_Member" runat="server" AllowPaging="true" AllowSorting="true"  Class="table table-hover table-active table-responsive dataTable" AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal">
                                    <AlternatingRowStyle BackColor="#F7F7F7" />
                                    <Columns>
                                        <asp:TemplateField HeaderText="UserId">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("UserId") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("UserId") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="MemberID">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("MemberID") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label2" runat="server" Text='<%# Bind("MemberID") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Full Name">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("FullName") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label3" runat="server" Text='<%# Bind("FullName") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Account Status">
                                            <EditItemTemplate>
                                                <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("AccountStatus") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="Label4" runat="server" Text='<%# Bind("AccountStatus") %>'></asp:Label>
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
            <a href="../HomePage.aspx" class="link-danger item-hover" style="text-decoration: none"><i class="fa fa-arrow-left">Back</i></a>
        </div>

    </section>
</asp:Content>
