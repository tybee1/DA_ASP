<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="HoaDon.aspx.cs" Inherits="TH_Buoi2.HoaDon" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-group">
        <label for="text1" class="control-label col-lg-4">Mã hóa đơn</label>
        <div class="col-lg-12">
            <asp:TextBox ID="txtMaHoaDon" runat="server" CssClass="form-control"> </asp:TextBox>
        </div>
    </div>
    <div class="form-group">
        <label for="pass1" class="control-label col-lg-4">Mã khách hàng</label>
        <div class="col-lg-12">
            <asp:TextBox ID="txtMaKhachHang" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
    </div>
    <div class="form-group">
        <label for="text2" class="control-label col-lg-4">Tổng tiền</label>
        <div class="col-lg-2">
            <asp:TextBox ID="txtTongTien" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
    </div>
    <label for="text2" class="control-label col-lg-4">Ngày lập</label>
    <div class="col-lg-10">
        <asp:TextBox ID="txtNgayLap" runat="server" CssClass="col-lg-2"></asp:TextBox>
        <asp:ImageButton ID="ibtNgayLap" runat="server" Height="25px" Width="40px" ImageUrl="~/images/lich.jpg" OnClick="ibtCal_Click" ImageAlign="AbsBottom" />
        <asp:Calendar ID="CalNgayLap"
            Format="dd/MM/yyyy"
            TargetControlID="txtNgayLap"
            PopupButtonID="ibtNgayLap"
            runat="server" WeekendDayStyle-Wrap="True" OnSelectionChanged="CalNgaySinh_SelectionChanged" SelectedDate="11/16/2019 11:03:29"></asp:Calendar>
    </div>
    <label for="text2" class="control-label col-lg-4">Ngày mua</label>
    <div class="col-lg-10">
        <asp:TextBox ID="txtNgayMua" runat="server" CssClass="col-lg-2"></asp:TextBox>
        <asp:ImageButton ID="ibtNgayMua" runat="server" Height="25px" Width="40px" ImageUrl="~/images/lich.jpg" OnClick="ibtNgayMua_Click" ImageAlign="AbsBottom" />
        <asp:Calendar ID="CalNgayMua"
            Format="dd/MM/yyyy"
            TargetControlID="txtNgayMua"
            PopupButtonID="ibtNgayMua"
            runat="server" WeekendDayStyle-Wrap="True" SelectedDate="11/16/2019 11:03:29" OnSelectionChanged="CalNgayMua_SelectionChanged"></asp:Calendar>
    </div>
    <div class="form-group">
        <label for="text2" class="control-label col-lg-4">Địa chỉ giao hàng</label>
        <div class="col-lg-12">
            <asp:TextBox ID="txtDiaChiGiaoHang" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
    </div>
    <div class="form-group">
        <label for="text2" class="control-label col-lg-4">Số điện thoại giao hàng</label>
        <div class="col-lg-12">
            <asp:TextBox ID="txtSDT" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
    </div>
    <div class="form-group">
        <label for="text8" class="control-label col-lg-4">Trạng thái</label>
        <div class="col-lg-8">
            <asp:CheckBox ID="chkTrangThai" runat="server" Checked="True" />
        </div>
    </div>
     <div class="col-lg-6">
         <asp:Button ID="btnThem" runat="server" Text="Thêm" OnClick="btnThem_Click" CssClass="col-lg-2 btn-lg btn-success" />
         <asp:Button ID="btnCapNhat" runat="server" Text="Cập nhật" OnClick="btnCapNhat_Click" CssClass="col-lg-2 btn-lg btn-warning" />
         </div>
    <div class="col-lg-12">
        <asp:GridView ID="grvHoaDon" runat="server" CssClass="table text-info text-center table-centered" AutoGenerateColumns="False" OnRowCommand="grvHoaDon_RowCommand" OnSelectedIndexChanged="grvHoaDon_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="MAHD1" HeaderText="Mã hóa đơn" />
                <asp:BoundField DataField="MAKH1" HeaderText="Mã khách hàng" />
                <asp:BoundField DataField="NGAYLAP1" HeaderText="Ngày lập" />
                <asp:BoundField DataField="TONGTIEN1" HeaderText="Tổng Tiền" />
                <asp:BoundField DataField="NGAYMUA1" HeaderText="Ngày mua" />
                <asp:BoundField DataField="DIACHIGIAOHANG1" HeaderText="Địa chỉ giao hàng" />
                <asp:BoundField DataField="SDTGIAOHANG1" HeaderText="Số điện thoại giao hàng" />
                <asp:CheckBoxField DataField="TRANGTHAI1" HeaderText="Trạng thái" />
                <asp:TemplateField HeaderText="Chọn" ShowHeader="False">
                    <ItemTemplate>
                        <asp:Button ID="Button1" runat="server" CausesValidation="False" CommandName="ChonHD" CommandArgument='<%# Eval("MAHD1") %>' Text="Chọn" CssClass="btn btn-primary" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Xóa" ShowHeader="False">
                    <ItemTemplate>
                        <asp:Button ID="btnXoa" runat="server" CausesValidation="False" CommandName="XoaHD" Text="Xóa" CommandArgument='<%# Eval("MAHD1") %>' CssClass="btn btn-danger"/>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        </div>
</asp:Content>
