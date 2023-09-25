<%@ Page Title="" Language="C#" MasterPageFile="~/Project1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Project1.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="vh-100">
        <div class="container pt-5 mt-5 mb-0">
            <div class="row d-flex justify-content-center align-items-center h-100">
                <div class="col col-md-10 col-xl-10">
                    <div class="card mt-5 mb-5" style="border-radius:1rem;border-style:none">
                        <div class="row g-0">
                            <div class="col-md-6 col-lg-5 d-none d-md-block">
                                <img src="Styling/assets/image/man-with-ladder-searching-for-a-book-on-bookshelf-vector-12902515.jpg" alt="login form" class="img-fluid" style="border-radius:1rem 0 0 1rem"; />
                            </div>
                            <div class="col-md-6 col-lg-7 d-flex align-items-center">
                                <div class="card-body p-4 p-lg-5 pb-5">
                                    <h4 class="fa fa-sign-in-alt mb-3 pb-3 text-black-50"> Sign in To Your Account</h4>
                                    <div class="mb-4">
                                        <label class="form-label text-black-50" runat="server" for="txt_UserId">User Id</label>
                                        <asp:TextBox ID="txt_UserId" CssClass="form-control" runat="server"></asp:TextBox>
                                       
                                    </div>
                                    <div class="mb-4">
                                        <label class="form-label text-black-50" runat="server" for="txt_Password">Password</label>
                                        <asp:TextBox ID="txt_Password" CssClass="form-control" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="form-check mb-4">
                                        <label class="form-check-label" for="chk_remember" runat="server">
                                            <asp:CheckBox ID="chk_remember" runat="server" CssClass="form-check-input" />Remember Me
                                        </label>
                                    </div>
                                    <div class="mb-4">
                                        <asp:Button ID="btn_2_Login" CssClass="btn btn-dark btn-sm float-start" OnClick="btn_2_Login_Click" BackColor="#cc66ff" BorderStyle="Double" runat="server" Text="Login"/>
                                        <asp:Button ID="btn_2_signup" CssClass="btn btn-dark btn-sm float-end" BackColor="#cc66ff" BorderStyle="Double" runat="server" Text="SignUp" OnClick="btn_2_signup_Click"/>
                                    </div>
                                </div>
                               
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <a href="HomePage.aspx" class="link-danger item-hover" style="text-decoration:none"><i class="fa fa-arrow-left">Back</i></a>
        </div> 
    </section>
</asp:Content>
