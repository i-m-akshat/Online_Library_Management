<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin2.Master" AutoEventWireup="true" CodeBehind="AdminBookInventory.aspx.cs" Inherits="Project1.Admin.AdminBookInventory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        function readURL(input) {
            if (input.files && input.files[0]) {
                var reader = new FileReader();
                reader.onload = function (e) {
                    $('#imgview').attr('src', e.target.result);
                };
                reader.readAsDataURL(input.files[0]);
            }
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="">
        <div class="container-fluid mt-5 mb-5 pt-5" style="height: auto">
            <%--The first card for User profile --%>
            <div class="row d-flex g-2">
                <div class="col-md-5 mb-sm-5 mt-5 mb-5">
                    <div class="card text-white d-flex h-100" style="border-radius: 1rem 1rem 1rem 1rem; background: linear-gradient(to right bottom, #b867fa, #cb3ff9, #a108f3);">
                        <div class="card-body mb-5 mt-2">
                            <div class="col-md-12">
                                <div class="row">
                                    <center>
                                        <h3 style="font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif">Book Details</h3>
                                        <img id="imgview" src="../Styling/assets/image/Nerd-amico.png" class="d-flex" style="height: 250px; width: 250px;" />
                                    </center>
                                </div>
                            </div>
                            <div class="col-md-12">
                                <asp:FileUpload ID="FileUpload1" onchange="readURL(this);" runat="server" CssClass="form-control form-control-sm" Placeholder="Upload File" />
                            </div>
                            <div class="col-md-12 mt-1">
                                <div class="row justify-content-evenly">
                                    <div class="col-md-4 col-sm-1 mt-2">
                                        <div class="form-group">
                                            <div class="input-group">
                                                <asp:TextBox CssClass="form-control form-control-sm" ID="txt_BookID" runat="server" placeholder="Book Id" aria-label="Book Id"></asp:TextBox>
                                                <asp:LinkButton CssClass="btn btn-sm btn-success" runat="server" ID="btn_SearchId" OnClick="btn_SearchId_Click"><i class="fas fa-search"></i></asp:LinkButton>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-md-8 col-sm-1 mt-2">
                                        <asp:TextBox ID="txt_BookName" CssClass="form-control form-control-sm" runat="server" placeholder="Book Name"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-12 mt-2">
                                <div class="row">
                                    <div class="col-md-4 col-sm-1 mt-1">
                                        <div class="col-md-12 col-sm-1">
                                            <label>Publisher Name</label>
                                            <asp:DropDownList ID="ddl_PublisherName" runat="server" CssClass="form-control form-control-sm" placeholder="Publisher Name">
                                                <asp:ListItem Value="0">Please Select Any Publisher</asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                        <div class="col-md-12 col-sm-1">
                                            <label>Language</label>
                                            <asp:DropDownList ID="ddl_Language" runat="server" CssClass="form-control form-control-sm" Placeholder="Language">
                                                <asp:ListItem Text="Please Select Any language" Value="0"></asp:ListItem>
                                                <asp:ListItem Text="English" Value="English" />
                                                <asp:ListItem Text="Hindi" Value="Hindi" />
                                                <asp:ListItem Text="Marathi" Value="Marathi" />
                                                <asp:ListItem Text="French" Value="French" />
                                                <asp:ListItem Text="German" Value="German" />
                                                <asp:ListItem Text="Urdu" Value="Urdu" />
                                            </asp:DropDownList>
                                        </div>

                                    </div>
                                    <div class="col-md-4 col-sm-1 mt-1">
                                        <div class="col-md-12 col-sm-1">
                                            <label>Author Name</label>
                                            <asp:DropDownList ID="ddl_AuthorName" runat="server" CssClass="form-control form-control-sm" Placeholder="AuthorName">
                                                <asp:ListItem Value="0">Please Select Any Author</asp:ListItem>

                                            </asp:DropDownList>
                                        </div>
                                        <div class="col-md-12 col-sm-1">
                                            <label>Publish Date</label>
                                            <asp:TextBox ID="txt_PublishDate" runat="server" CssClass="form-control form-control-sm" Placeholder="Publish Date" TextMode="Date"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="col-md-4 col-sm-1 mt-1">
                                        <label>Genre</label>
                                        <asp:ListBox ID="List_Genre" runat="server" SelectionMode="Multiple" CssClass="form-control form-control-sm"></asp:ListBox>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-12 mt-3">
                                <div class="row justify-content-evenly">
                                    <div class="col-md-4 col-sm-1">
                                        <label for="txt_Edition" class="form-label" runat="server">Edition</label>
                                        <asp:TextBox ID="txt_Edition" runat="server" CssClass="form-control form-control-sm" placeholder="Edition"></asp:TextBox>
                                    </div>
                                    <div class="col-md-4 col-sm-1">
                                        <label for="txt_BookCost" runat="server" class="form-label">Book Cost(Per Unit)</label>
                                        <asp:TextBox ID="txt_BookCost" CssClass="form-control form-control-sm" runat="server" Placeholder="Book cost"></asp:TextBox>
                                    </div>
                                    <div class="col-md-4 col-sm-1">
                                        <label for="txt_Pages" runat="server" class="form-label">Pages</label>
                                        <asp:TextBox ID="txt_Pages" CssClass="form-control form-control-sm" runat="server" placeholder="Pages" />
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-12 mt-3">
                                <div class="row justify-content-evenly">
                                    <div class="col-md-4 col-sm-1">
                                        <label for="txt_ActualStock" class="form-label" runat="server">Actual Stock</label>
                                        <asp:TextBox ID="txt_ActualStock" runat="server" Placeholder="Actual Stock" CssClass="form-control form-control-sm"></asp:TextBox>
                                    </div>
                                    <div class="col-md-4 col-sm-1">
                                        <label for="txt_CurrentStock" runat="server" class="form-label">Current Stock</label>
                                        <asp:TextBox ID="txt_CurrentStock" CssClass="form-control form-control-sm" runat="server" ReadOnly="true" Placeholder="Current Stock"></asp:TextBox>
                                    </div>
                                    <div class="col-md-4 col-sm-1">
                                        <label for="txt_BookIssued" runat="server" class="form-label">Book Issued</label>
                                        <asp:TextBox ID="txt_BookIssued" CssClass="form-control form-control-sm" ReadOnly="true" runat="server" placeholder="Pages" />
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-12 mt-3">
                                <label>Book Description</label>
                                <asp:TextBox ID="txt_BookDescription" runat="server" CssClass="form-control form-control-sm" TextMode="MultiLine"></asp:TextBox>
                            </div>
                            <div class="col-12 mt-2 pt-2">
                                <div class="row ">
                                    <div class="col-4">
                                        <asp:LinkButton ID="btn_Add" runat="server" OnClick="btn_Add_Click" CssClass="btn form-control btn-success btn-sm"><i class="fas fa-book-medical"></i></asp:LinkButton>
                                    </div>
                                    <div class="col-4">
                                        <asp:LinkButton ID="btn_Update" runat="server" OnClick="btn_Update_Click" CssClass="btn form-control btn-sm btn-warning text-white"><i class="fas fa-edit"></i></asp:LinkButton>
                                    </div>
                                    <div class="col-4">
                                        <asp:LinkButton ID="btn_Delete" runat="server" OnClick="btn_Delete_Click" CssClass="btn form-control btn-sm btn-danger"><i class="fas fa-book-dead"></i></asp:LinkButton>
                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>
                </div>
                <%--The Second card for Issued Book status--%>
                <div class="col-md-7 mb-sm-5 mt-5 mb-5">
                    <div class="card text-white d-flex h-100" style="border-radius: 1rem 1rem 1rem 1rem; background: linear-gradient(to right bottom, #b867fa, #cb3ff9, #a108f3);">
                        <div class="card-body mb-5 mt-2">
                            <div class="col-12">
                                <div class="row d-flex g-2">
                                    <center>
                                        <h3 style="font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif">Book Inventory List</h3>

                                    </center>
                                </div>
                            </div>
                            <div class="col-md-12 mt-1">
                                <asp:GridView ID="Grd_Books" runat="server" Class="table table-hover table-active table-responsive"  PageSize="3" AllowPaging="true" OnPageIndexChanging="Grd_Books_PageIndexChanging"  AlternatingRowStyle-BackColor="#ffffff" HeaderStyle-BackColor="#ffffff" BackColor="#ffffff" GridLines="Both" BorderColor="#999999" AlternatingRowStyle-BorderColor="#999999" AutoGenerateColumns="False" PagerSettings-FirstPageText="First" PagerSettings-LastPageText="Last" PagerSettings-Mode="NextPreviousFirstLast">
                                    <Columns>
                                        <asp:BoundField DataField="BookId" HeaderText="BookId" />
                                        <asp:TemplateField>
                                            <ItemTemplate>
                                                <div class="container-fluid">
                                                    <div class="row">
                                                        <div class="col-md-10">
                                                            <div class="row">
                                                                <div class="col-md-12">
                                                                    <asp:Label ID="lbl_BookName" runat="server" Font-Bold="true" Font-Size="X-Large" Text='<%#Bind("BookName")%>'></asp:Label>
                                                                </div>
                                                                <div class="col-md-12 mt-3">
                                                                    <div class="row">
                                                                        <div class="col-md-4">
                                                                            <span style="font-size:small">Author-</span><asp:Label ID="lbl_Author" runat="server" Font-Bold="true" Font-Size="Small" Font-Italic="true" Text='<%#Bind("AuthorName")%>'></asp:Label>
                                                                        </div>
                                                                        <div class="col-md-4">
                                                                           <span style="font-size:small">Genre-</span><asp:Label ID="lbl_Genre" runat="server" Font-Bold="true" Font-Size="Small" Font-Italic="true"  Text='<%#Bind("Genre")%>'></asp:Label>

                                                                        </div>
                                                                        <div class="col-md-4">
                                                                           <span style="font-size:small">Language-</span><asp:Label ID="lbl_Language" runat="server" Font-Size="Small" Font-Bold="true" Font-Italic="true" Text='<%#Bind("Language")%>'></asp:Label>
                                                                        </div>

                                                                    </div>
                                                                </div>
                                                                <div class="col-md-12 mt-1">
                                                                    <div class="row" style="row-gap:0px;column-gap:0px">
                                                                        <div class="col">
                                                                           <span style="font-size:small">Publisher- </span><asp:Label ID="lbl_Publisher" Font-Size="Small" runat="server" Font-Bold="true"  Text='<%#Bind("PublisherName")%>'></asp:Label>
                                                                        </div>
                                                                        <div class="col">
                                                                          <span style="font-size:small">PublishDate-</span><asp:Label ID="Lbl_PublishDate" CssClass="d-flex d-inline" Font-Size="Small" runat="server" Font-Bold="true" Text='<%#Bind("PublishDate","{0:MM/dd/yyyy}")%>'></asp:Label>

                                                                        </div>
                                                                        <div class="col">
                                                                          <span style="font-size:small">Page- </span><asp:Label ID="lbl_Page" runat="server" Font-Size="Small" Font-Bold="true"  Text='<%#Bind("Pages")%>'></asp:Label>
                                                                        </div>
                                                                        <div class="col">
                                                                           <span style="font-size:small">Edition- </span><asp:Label ID="lbl_Edition" Font-Size="Small" runat="server" Font-Bold="true" Text='<%#Bind("Edition") %>'></asp:Label>
                                                                        </div>

                                                                    </div>
                                                                </div>
                                                                <div class="col-md-12 mt-1">
                                                                    <div class="row" style="row-gap:0px;column-gap:0px">
                                                                        <div class="col-md-4">
                                                                           <span style="font-size:small">Cost-</span><asp:Label ID="Label1" Font-Size="Small" runat="server" Font-Bold="true"  Text='<%#Bind("BookCost")%>'></asp:Label>
                                                                        </div>
                                                                        <div class="col-md-4">
                                                                          <span style="font-size:small">Actual Stock-</span><asp:Label ID="Label2" Font-Size="Small" runat="server" Font-Bold="true" Text='<%#Bind("ActualStock")%>'></asp:Label>

                                                                        </div>
                                                                        <div class="col-md-4">
                                                                          <span style="font-size:small">Current Stock-</span><asp:Label ID="Label3" runat="server" Font-Size="Small" Font-Bold="true"  Text='<%#Bind("CurrentStock")%>'></asp:Label>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                                <div class="col-md-12 mt-2">
                                                                    <span style="font-size:small">Description-</span><asp:Label ID="Label4" Font-Size="Small" runat="server" Font-Bold="true"  Text='<%#Bind("BookDescription")%>'></asp:Label>
                                                                </div>
                                                            </div>
                                                        </div>
                                                        <div class="col-md-2">
                                                            <asp:Image CssClass="img-fluid p-2" ID="Img_Book" runat="server" ImageUrl='<%#Bind("BookURL")%>' />
                                                        </div>
                                                    </div>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
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
