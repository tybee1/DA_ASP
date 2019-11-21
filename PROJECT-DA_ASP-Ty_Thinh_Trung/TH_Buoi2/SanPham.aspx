<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="SanPham.aspx.cs" Inherits="TH_Buoi2.SanPham1" %>
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
        <label for="pass1" class="control-label col-lg-4">Tên sản phẩm</label>
        <div class="col-lg-12">
            <asp:TextBox ID="txtTenSanPham" runat="server" CssClass="form-control" ></asp:TextBox>
        </div>
    </div>
    <div class="form-group">
        <label for="text2" class="control-label col-lg-4">Mô tả</label>
        <div class="col-lg-12">
            <asp:TextBox ID="txtMoTa" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
    </div>
     <div class="form-group">
        <label for="text2" class="control-label col-lg-4">Loại</label>
        <div class="col-lg-3">
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" CssClass="form-control"></asp:DropDownList>
        </div>
    </div>

     <div class="form-group">
        <label for="text8" class="control-label col-lg-4">Trạng thái</label>
        <div class="col-lg-8">
            <asp:CheckBox ID="chkTrangThai" runat="server" Checked="True"  />
        </div>
    </div>
     <div class="col-lg-6">
         <asp:Button ID="btnThemSanPham" runat="server" Text="Thêm" OnClick="btnThemSanPham_Click1"  CssClass="col-lg-2 btn-lg btn-success" />
         <asp:Button ID="btnCapNhat" runat="server" Text="Cập nhật"  CssClass="col-lg-2 btn-lg btn-warning" OnClick="btnCapNhat_Click" />
         <asp:Button ID="btnHuyBo" runat="server" Text="Hủy bỏ" CssClass="col-lg-2 btn-lg btn-danger" OnClick="btnHuyBo_Click" />
         </div>

     <div class="col-lg-12">
    <asp:GridView ID="grvSanPham" runat="server" AutoGenerateColumns="False" CssClass="table text-info text-center table-centered" OnRowCommand="grvSanPham_RowCommand" >
        <Columns>
            <asp:BoundField DataField="MASP1" HeaderText="Mã sản phẩm" />
            <asp:BoundField DataField="TENSP1" HeaderText="Tên sản phẩm" />
            <asp:BoundField DataField="MOTA1" HeaderText="Mô tả" />
            <asp:BoundField DataField="LOAI1" HeaderText="Loại" />
            <asp:CheckBoxField DataField="TRANGTHAI1" HeaderText="Trạng thái" />
            <asp:TemplateField HeaderText="Chọn" ShowHeader="False">
                <ItemTemplate>
                    <asp:Button ID="btnChon" runat="server" CausesValidation="False" CommandName="ChonSP"  CommandArgument='<%# Eval("MASP1") %>' Text="Chọn" CssClass="btn btn-primary" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Xóa" ShowHeader="False">
                <ItemTemplate>
                    <asp:Button ID="btnXoa" runat="server" CausesValidation="False" CommandName="XoaSP" CommandArgument='<%# Eval("MASP1") %>' Text="Xóa" CssClass="btn btn-danger" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
         
         </div>
     
</asp:Content>
