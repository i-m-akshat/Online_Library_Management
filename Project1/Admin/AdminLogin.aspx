<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin2.Master" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="Project1.Admin.AdminLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="vh-100">
        <div class="container pt-5 mt-5 mb-0">
            <div class="row d-flex justify-content-center align-items-center h-100">
                <div class="col col-md-10 col-xl-10">
                    <div class="card mt-5" style="border-radius:1rem;border-style:none">
                        <div class="row g-0">
                            <div class="col-md-6 col-lg-5 d-none d-md-block">
                                <img src="../Styling/assets/image/Reasons-To-Use-Illustrations-On-Your-Website.jpg" alt="login form" class="img-fluid" style="border-radius:1rem 0 0 1rem"; />
                            </div>
                            <div class="col-md-6 col-lg-7 d-flex align-items-center">
                                <div class="card-body p-4 p-lg-5">
                                    <h4 class="fa fa-sign-in-alt mb-3 pb-3 text-black-50"> Admin Login</h4>
                                    <div class="mb-4">
                                        <label class="form-label" runat="server" for="txt_Username"><span class="text-dark">Username</span> </label>
                                        <asp:TextBox runat="server" ID="txt_Username" CssClass="form-control form-control-sm"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="rq_Username" runat="server" ControlToValidate="txt_Username" ErrorMessage="Please Enter Your Username" ForeColor="Red" ValidationGroup="AdminLogin"></asp:RequiredFieldValidator>
                                    </div>
                                    <div class="mb-4">
                                        <label class="form-label" runat="server" for="txt_Password"><span class="text-dark">Password</span> </label>
                                        <asp:TextBox runat="server" TextMode="Password" ID="txt_Password" CssClass="form-control form-control-sm"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="rq_Password" runat="server" ControlToValidate="txt_Password" ErrorMessage="Please Enter Your Password" ForeColor="Red" ValidationGroup="AdminLogin"></asp:RequiredFieldValidator>
                                    </div>
                                    <div class="form-check mb-4">
                                        <label class="form-check-label" for="chk_remember" runat="server">
                                            <asp:CheckBox ID="chk_remember" runat="server" CssClass="form-check-input" />Remember Me
                                        </label>
                                    </div>
                                    <center>
                                    <div class="mb-4 col-12">
                                        <asp:Button ID="btn_2_Login" CssClass="btn btn-dark  justify-content-center" OnClick="btn_2_Login_Click" BackColor="#cc66ff" BorderStyle="Double" runat="server" Text="Login" ValidationGroup="AdminLogin"/>
                                    </div>
                                    </center>
                                </div>
                               
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <a href="../HomePage.aspx" class="link-danger item-hover" style="text-decoration:none"><i class="fa fa-arrow-left">Back</i></a>
        </div> 
    </section>
</asp:Content>
