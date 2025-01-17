<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="QLMonHoc.aspx.cs" Inherits="WebQLDaoTao.QLMonHoc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
     <h3>Thiết kế nội dung trang quản lý môn học</h3>
    <div>
        <asp:GridView ID="gvMonHoc" runat="server" DataKeyNames="MaMH" 
            AutoGenerateColumns="False" CssClass="table table-bordered table-hover" OnRowEditing="gvMonHoc_RowEditing" OnRowCancelingEdit="gvMonHoc_RowCancelingEdit" OnRowUpdating="gvMonHoc_RowUpdating">
            <Columns>
                <asp:BoundField HeaderText="Mã môn học" DataField="MaMH" ReadOnly="true" />
                <asp:BoundField HeaderText="Tên môn học" DataField="TenMH" />
                <asp:BoundField HeaderText="Số tiết" DataField="SoTiet" />
                <asp:CommandField HeaderText="Chọn tác vụ" ShowEditButton="true" ShowDeleteButton="true" ButtonType="Button" EditText="Sửa" DeleteText="Xoá" />
            </Columns>
            <HeaderStyle BackColor="#0066cc" ForeColor="#ffffff"/>
        </asp:GridView>
    </div>
</asp:Content>
