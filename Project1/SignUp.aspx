<%@ Page Title="" Language="C#" MasterPageFile="~/Project1.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="Project1.SignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="">
        <div class="container-fluid mt-5 mb-5">
            <div class="row d-flex justify-content-center align-content-center">
                <div class="col col-md-10 col-xl-10">
                    <div class="card mt-5" style="border-radius:1rem 1rem 1rem 1rem;border-style:none">
                        <div class="row g-0">
                        <div class="col-md-6 col-lg-6 d-none d-md-block">
                            <img src="Styling/assets/image/young-man-using-computer-desk-working-online-illustration_24877-69117.jpg" class="img-fluid d-flex w-100" alt="signup pic" style="border-radius:1rem 0 0 1rem;border-style:none" />
                        </div>
                         <div class="col-md-6 col-lg-6 align-items-center">
                         <div class="card-body p-md-2 p-sm-1 p-lg-4 mb-5">
                            <h2 class="text-center fa fa-sign-in-alt text-black-50 mb-3 pb-3 align-content-center"> Sign Up </h2>
                            <div class="col-12">
                            <div class="row">
                            <div class="mb-2 col-6">
                                <label class="form-label" runat="server" for="txt_FullName">Full Name</label>
                                <asp:TextBox ID="txt_FullName"  runat="server" CssClass="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rqr_FullName" runat="server" ControlToValidate="txt_FullName" ErrorMessage="Please Enter The Full Name" ForeColor="Red" ValidationGroup="UserSignUp"></asp:RequiredFieldValidator>
                            </div>
                            <div class="col-6">
                                <label class="form-label" runat="server" for="txt_Dob">D.O.B.</label>
                                <asp:TextBox ID="txt_Dob" runat="server" TextMode="Date" CssClass="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rqr_Dob" runat="server" ControlToValidate="txt_Dob" ErrorMessage="Please Enter Your Date of birth" ForeColor="Red" ValidationGroup="UserSignUp"></asp:RequiredFieldValidator>
                            </div>
                            </div>
                            </div>
                            <div class="col-12">
                                <div class="row">
                                <div class="col-6">
                                     <label class="form-label" runat="server" for="txt_email">E Mail</label>
                                     <asp:TextBox ID="txt_EMail" TextMode="Email" runat="server" CssClass="form-control"></asp:TextBox>
                                     <asp:RegularExpressionValidator ID="rgr_EMail" runat="server" ControlToValidate="txt_EMail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ErrorMessage="Please Enter the Valid Email" ForeColor="Red" ValidationGroup="UserSignUp"></asp:RegularExpressionValidator>
                                     <asp:RequiredFieldValidator ID="rq_EMail" runat="server" ControlToValidate="txt_EMail" ValidationGroup="UserSignUp" ErrorMessage="Please Enter Your EMail" ForeColor="Red"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-6">
                                    <label class="form-label" runat="server" for="txt_ContactNo">Contact Number</label>
                                    <asp:TextBox ID="txt_ContactNo" runat="server" CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rqr_ContactNo" runat="server" ControlToValidate="txt_ContactNo" ValidationGroup="UserSignUp" ErrorMessage="Please Enter Your Contact Number" ForeColor="Red"></asp:RequiredFieldValidator>
                                </div>
                               </div>
                            </div>
                            <div class="col-12">
                                <div class="row">
                                    <div class="col-4">
                                        <label for="ddl_State" runat="server" class="form-label">State</label>
                                        <asp:DropDownList ID="ddl_State" runat="server" CssClass="form-control dropdown" Placeholder="Please Select Your State" AutoPostBack="true" AppendDataBoundItems="true" OnSelectedIndexChanged="ddl_State_SelectedIndexChanged">
                                            <asp:ListItem Value="0">Select Your state</asp:ListItem>
                                        </asp:DropDownList>
                                        <asp:RequiredFieldValidator ID="rq_ddlState" runat="server" ControlToValidate="ddl_State" ValidationGroup="UserSignUp" ErrorMessage="Please Select Your State" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div> 
                                    <div class="col-4">
                                        <label for="ddl_City" runat="server" class="form-label">City</label>
                                        <asp:DropDownList ID="ddl_City" runat="server" CssClass="form-control dropdown" AutoPostBack="true" AppendDataBoundItems="true">
                                            <asp:ListItem Value="0">Select Your City</asp:ListItem>
                                        </asp:DropDownList>
                                        <asp:RequiredFieldValidator ID="rq_ddl_City" runat="server" ControlToValidate="ddl_City" ValidationGroup="UserSignUp" ErrorMessage="Please Enter Your City" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                    <div class="col-4">
                                        <label for="txt_Pincode" class="form-label" runat="server">Pincode</label>
                                        <asp:TextBox ID="txt_Pincode" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="rqr_Pincode" runat="server" ValidationGroup="UserSignUp" ControlToValidate="txt_Pincode" ErrorMessage="Please enter your pincode" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                            </div>
                             <div class="col-12">
                                 <label for="txt_FullAddress" runat="server" class="form-label">Full Address</label>
                                 <asp:TextBox ID="txt_FullAddress" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
                                 <asp:RequiredFieldValidator ID="rqr_FullAddress" runat="server" ValidationGroup="UserSignUp" ControlToValidate="txt_FullAddress" ErrorMessage="Please enter your full address" ForeColor="Red"></asp:RequiredFieldValidator>
                             </div>
                            <div class="col-12">
                                <div class="row">
                                    <div class="col-6">
                                        <label for="txt_UserId" runat="server" class="form-label">User Id</label>
                                        <asp:TextBox ID="txt_UserId" runat="server" CssClass="form-control"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="rqr_UserId" runat="server" ControlToValidate="txt_UserId" ValidationGroup="UserId" ErrorMessage="Please Enter User Id" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                    <div class="col-6">
                                        <label for="txt_Password" runat="server" class="form-label">Password</label>
                                        <asp:TextBox ID="txt_Password" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="rq_Password" runat="server" ControlToValidate="txt_Password" ValidationGroup="UserSignUp" ErrorMessage="Please Enter Password" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                            </div>
                            <div class="mb-4">
                                        <asp:Button ID="btn_2_Login" CssClass="btn btn-dark btn-sm float-end" BackColor="#cc66ff" BorderStyle="Double" runat="server" Text="Login" OnClick="btn_2_Login_Click"/>
                                        <asp:Button ID="btn_2_signup" CssClass="btn btn-dark btn-sm float-start" BackColor="#cc66ff" BorderStyle="Double" runat="server" Text="SignUp" ValidationGroup="UserSignUp" OnClick="btn_2_signup_Click"/>
                           </div>
                          </div>
                          </div>
                          </div>
                      </div>
                     
                </div>
                <asp:Label ID="lblmsg" runat="server" CssClass="h4 text-center"></asp:Label>
            </div>
            <a href="HomePage.aspx" class="link-danger item-hover" style="text-decoration:none"><i class="fa fa-arrow-left">Back</i></a>
        </div>
    </section>
</asp:Content>
