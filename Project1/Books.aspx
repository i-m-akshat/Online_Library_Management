<%@ Page Title="" Language="C#" MasterPageFile="~/Project1.Master" AutoEventWireup="true" CodeBehind="Books.aspx.cs" Inherits="Project1.Books" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid mt-5 pt-5 mb-5">
        <div class="col-12 mt-3 pt-3">
            <center>
                <h1 class="hvr-pulse-grow text-center" style="font-family: 'Bauhaus 93'">Book Inventory List</h1>
            </center>
        </div>
        <div class="row justify-content-center align-content-center">
            <div class="col-md-9 mt-3 pt-3 mb-3" style="border-radius:2px 2px 2px 2px">
                <asp:GridView ID="Grd_Books" runat="server" Class="table table-hover table-active table-responsive" PageSize="3" AllowPaging="true" OnPageIndexChanging="Grd_Books_PageIndexChanging" AlternatingRowStyle-BackColor="#ffffff" HeaderStyle-BackColor="#ffffff" BackColor="#ffffff" GridLines="Both" BorderColor="#999999" AlternatingRowStyle-BorderColor="#999999" AutoGenerateColumns="False" PagerSettings-FirstPageText="First" PagerSettings-LastPageText="Last" PagerSettings-Mode="NextPreviousFirstLast">
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
                                                            <span style="font-size: small">Author-</span><asp:Label ID="lbl_Author" runat="server" Font-Bold="true" Font-Size="Small" Font-Italic="true" Text='<%#Bind("AuthorName")%>'></asp:Label>
                                                        </div>
                                                        <div class="col-md-4">
                                                            <span style="font-size: small">Genre-</span><asp:Label ID="lbl_Genre" runat="server" Font-Bold="true" Font-Size="Small" Font-Italic="true" Text='<%#Bind("Genre")%>'></asp:Label>

                                                        </div>
                                                        <div class="col-md-4">
                                                            <span style="font-size: small">Language-</span><asp:Label ID="lbl_Language" runat="server" Font-Size="Small" Font-Bold="true" Font-Italic="true" Text='<%#Bind("Language")%>'></asp:Label>
                                                        </div>

                                                    </div>
                                                </div>
                                                <div class="col-md-12 mt-1">
                                                    <div class="row" style="row-gap: 0px; column-gap: 0px">
                                                        <div class="col">
                                                            <span style="font-size: small">Publisher- </span>
                                                            <asp:Label ID="lbl_Publisher" Font-Size="Small" runat="server" Font-Bold="true" Text='<%#Bind("PublisherName")%>'></asp:Label>
                                                        </div>
                                                        <div class="col">
                                                            <span style="font-size: small">PublishDate-</span><asp:Label ID="Lbl_PublishDate" CssClass="d-flex d-inline" Font-Size="Small" runat="server" Font-Bold="true" Text='<%#Bind("PublishDate","{0:MM/dd/yyyy}")%>'></asp:Label>

                                                        </div>
                                                        <div class="col">
                                                            <span style="font-size: small">Page- </span>
                                                            <asp:Label ID="lbl_Page" runat="server" Font-Size="Small" Font-Bold="true" Text='<%#Bind("Pages")%>'></asp:Label>
                                                        </div>
                                                        <div class="col">
                                                            <span style="font-size: small">Edition- </span>
                                                            <asp:Label ID="lbl_Edition" Font-Size="Small" runat="server" Font-Bold="true" Text='<%#Bind("Edition") %>'></asp:Label>
                                                        </div>

                                                    </div>
                                                </div>
                                                <div class="col-md-12 mt-1">
                                                    <div class="row" style="row-gap: 0px; column-gap: 0px">
                                                        <div class="col-md-4">
                                                            <span style="font-size: small">Cost-</span><asp:Label ID="Label1" Font-Size="Small" runat="server" Font-Bold="true" Text='<%#Bind("BookCost")%>'></asp:Label>
                                                        </div>
                                                        <div class="col-md-4">
                                                            <span style="font-size: small">Actual Stock-</span><asp:Label ID="Label2" Font-Size="Small" runat="server" Font-Bold="true" Text='<%#Bind("ActualStock")%>'></asp:Label>

                                                        </div>
                                                        <div class="col-md-4">
                                                            <span style="font-size: small">Current Stock-</span><asp:Label ID="Label3" runat="server" Font-Size="Small" Font-Bold="true" Text='<%#Bind("CurrentStock")%>'></asp:Label>
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class="col-md-12 mt-2">
                                                    <span style="font-size: small">Description-</span><asp:Label ID="Label4" Font-Size="Small" runat="server" Font-Bold="true" Text='<%#Bind("BookDescription")%>'></asp:Label>
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

</asp:Content>
