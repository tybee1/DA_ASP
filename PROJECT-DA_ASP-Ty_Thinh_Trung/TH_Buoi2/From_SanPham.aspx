<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="From_SanPham.aspx.cs" Inherits="TH_Buoi2.From_SanPham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>
                Mã sản phẩm:<asp:TextBox ID="txtMaSanPham" runat="server"></asp:TextBox>
            </td>
       
        <tr>
            <td>
                Tên sản phẩm:<asp:TextBox ID="txtTenSanPham" runat="server"></asp:TextBox>
            </td>
        </tr>
          <tr>
            <td>
                Mô tả:<asp:TextBox ID="txtMoTa" runat="server"></asp:TextBox>
            </td>
        </tr>
          <tr>
            <td>
                Loại:<asp:TextBox ID="txtLoai" runat="server"></asp:TextBox>
            </td>
        </tr>

              <tr>
            <td>
               Trạng thái:<asp:CheckBox ID="chkTrangThai" runat="server" />
            </td>
        </tr>

              <tr>
            <td>
                <asp:Button ID="btnThemSanPham" runat="server" Text="Thêm" OnClick="btnThemSanPham_Click" />
            </td>
        </tr>
          
    </table>
      <asp:GridView ID="grvSanPham" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="grvSanPham_SelectedIndexChanged">
          <Columns>
              <asp:BoundField DataField="MASP1" HeaderText="Mã sản phẩm" />
              <asp:BoundField DataField="TENSP1" HeaderText="Tên sản phẩm" />
              <asp:BoundField DataField="MOTA1" HeaderText="Mô tả" />
              <asp:BoundField DataField="LOAI1" HeaderText="Loại" />
              <asp:CheckBoxField DataField="TRANGTHAI1" HeaderText="Trạng thái" />
          </Columns>
    </asp:GridView>
        
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

</asp:Content>
