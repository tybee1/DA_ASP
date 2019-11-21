<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="ChiTietSanPham.aspx.cs" Inherits="TH_Buoi2.ChiTietSanPham1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="form-group">
        <label for="text1" class="control-label col-lg-4">Mã sản phẩm</label>
        <div class="col-lg-12">
            <asp:TextBox ID="txtMaSanPham" runat="server" CssClass="form-control"> </asp:TextBox>
        </div>
    </div>
      <div class="form-group">
        <label for="text1" class="control-label col-lg-4">ID</label>
        <div class="col-lg-12">
            <asp:TextBox ID="txtID" runat="server" CssClass="form-control"> </asp:TextBox>
        </div>
    </div>
      <div class="form-group">
        <label for="text1" class="control-label col-lg-4">Màu sắc</label>
        <div class="col-lg-12">
            <asp:TextBox ID="txtMauSac" runat="server" CssClass="form-control"> </asp:TextBox>
        </div>
    </div>
    
        <label for="text1" class="control-label col-lg-4">Kích thước</label>
        <div class="col-lg-1 ">
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control">
                <asp:ListItem>M</asp:ListItem>
                <asp:ListItem>L</asp:ListItem>
                <asp:ListItem>S</asp:ListItem>
                <asp:ListItem>XL</asp:ListItem>
            </asp:DropDownList>
        </div>
   
      <div class="form-group">
        <label for="text1" class="control-label col-lg-4">Giá tiền</label>
        <div class="col-lg-12">
            <asp:TextBox ID="txtGiaTien" runat="server" CssClass="form-control"> </asp:TextBox>
        </div>
    </div>
      <div class="form-group">
        <label for="text1" class="control-label col-lg-4">Tồn kho</label>
        <div class="col-lg-12">
            <asp:TextBox ID="txtTonKho" runat="server" CssClass="form-control"> </asp:TextBox>
        </div>
    </div>

</asp:Content>
