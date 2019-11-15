<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="TaiKhoan.aspx.cs" Inherits="TH_Buoi2.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-group">
        <label for="text1" class="control-label col-lg-4">Tên Tài Khoản</label>
        <div class="col-lg-12">
            <asp:TextBox ID="txtTenTaiKhoan" runat="server" CssClass="form-control"> </asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtTenTaiKhoan" ErrorMessage="Tài khoản không được bỏ trống!!!" Display="Dynamic" CssClass="text-danger"></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="form-group">
        <label for="pass1" class="control-label col-lg-4">Mật Khẩu</label>
        <div class="col-lg-12">
            <asp:TextBox ID="txtMatKhau" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtMatKhau" ErrorMessage="Mật khảu không được bỏ trống!!!" Display="Dynamic" CssClass="text-danger"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtMatKhau" ValidationExpression="\w{6,15}" ErrorMessage="Mật khẩu phải từ 6 đến 15 kí tự" CssClass="text-danger"></asp:RegularExpressionValidator>
        </div>
    </div>
    <div class="form-group">
        <label for="text2" class="control-label col-lg-4">Email</label>
        <div class="col-lg-12">
            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" TextMode="Email"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email không được bỏ trống!!!" Display="Dynamic" CssClass="text-danger"></asp:RequiredFieldValidator>

        </div>
    </div>

    <div class="form-group">
        <label for="text3" class="control-label col-lg-4">Số Điện Thoại</label>
        <div class="col-lg-12">
            <asp:TextBox ID="txtSDT" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtSDT" ErrorMessage="Số điện thoại không được bỏ trống!!!" Display="Dynamic" CssClass="text-danger"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtSDT" ErrorMessage="Số điện thoại không hợp lệ!!!" ValidationExpression="0\d{9}" CssClass="text-danger"></asp:RegularExpressionValidator>
        </div>
    </div>

    <div class="form-group">
        <label for="text4" class="control-label col-lg-4">Địa Chỉ</label>

        <div class="col-lg-12">
            <asp:TextBox ID="txtDiaChi" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtDiaChi" ErrorMessage="Địa chỉ không được bỏ trống!!!" CssClass="text-danger"></asp:RequiredFieldValidator>
        </div>
    </div>

    <div class="form-group">
        <label for="text5" class="control-label col-lg-4">Họ Tên</label>

        <div class="col-lg-12">
            <asp:TextBox ID="txtHoTen" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtHoTen" ErrorMessage="Họ tên không được bỏ trống!!!" CssClass="text-danger"></asp:RequiredFieldValidator>
        </div>
    </div>

    <div class="form-group">
        <label for="text6" class="control-label col-lg-4">LaAdmin</label>
        <div class="col-lg-8">
            <asp:CheckBox ID="chkLaAdmin" runat="server" />
        </div>
    </div>

    <div class="form-group">
        <label for="text7" class="control-label col-lg-4">Ảnh đại diện</label>
        <div class="col-lg-12">
            <asp:TextBox ID="txtAnhDaiDien" runat="server"></asp:TextBox>
        </div>
    </div>

    <div class="form-group">
        <label for="text8" class="control-label col-lg-4">Trạng thái</label>

        <div class="col-lg-8">
            <asp:CheckBox ID="chkTrangThai" runat="server" Checked="True" />
        </div>
    </div>
    <div class="col-lg-6">
        <asp:Button ID="btnThem" runat="server" Text="Thêm" CssClass="col-lg-2 btn-lg btn-success" OnClick="btnThem_Click" />
        <asp:Button ID="btnSua" runat="server" Text="Sửa" CssClass="col-lg-2 btn-lg btn-warning" OnClick="btnSua_Click" Visible="True" />
        <asp:Button ID="btnHuyBo" runat="server" Text="Hủy bỏ" CssClass="col-lg-2 btn-lg btn-default" OnClick="btnHuyBo_Click" />
    </div>

    <div class="col-lg-12">
        <asp:GridView ID="grvAccount" runat="server" AutoGenerateColumns="False" CssClass="table text-info nowrap text-center table-centered" OnRowCommand="grvAccount_RowCommand">
            <Columns>
                <asp:BoundField DataField="TENTK1" HeaderText="Tên tài khoản" />
                <asp:BoundField DataField="MATKHAU1" HeaderText="Mật khẩu" />
                <asp:BoundField DataField="EMAIL1" HeaderText="Email" />
                <asp:BoundField DataField="SDT1" HeaderText="Số điện thoại" />
                <asp:BoundField DataField="DIACHI1" HeaderText="Địa Chỉ" />
                <asp:BoundField DataField="HOTEN1" HeaderText="Họ tên" />
                <asp:CheckBoxField DataField="LAADMIN1" HeaderText="Là Admin" />
                <asp:BoundField DataField="ANHDAIDIEN1" HeaderText="Ảnh đại diện" />
                <asp:CheckBoxField DataField="TRANGTHAI1" HeaderText="Trạng thái" />
                <asp:TemplateField HeaderText="Chọn" ShowHeader="False">
                    <ItemTemplate>
                        <asp:Button ID="btnChon" runat="server" CausesValidation="False" CommandName="ChonTK" CommandArgument='<%# Eval("TENTK1") %>' Text="Chọn" CssClass="btn btn-primary" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Xóa" ShowHeader="False">
                    <ItemTemplate>
                        <asp:Button ID="btnXoa" runat="server" CausesValidation="False" CommandName="XoaTK" Text="Xóa" CommandArgument='<%# Eval("TENTK1") %>' CssClass="btn btn-danger" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
