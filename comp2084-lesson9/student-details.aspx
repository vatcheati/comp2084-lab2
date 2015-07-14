<%@ Page Title="" Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="student-details.aspx.cs" Inherits="comp2084_lesson9.student_details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <h5>All fields are required</h5>
    <div class="form-group">
        <label for="txtLast" class="col-sm-2">Last Name: *</label>
        <asp:TextBox ID="txtLast" runat="server" required />
    </div>
    <div class="form-group">
        <label for="txtFirst" class="col-sm-2">First Name: *</label>
        <asp:TextBox ID="txtFirst" runat="server" required />
       
    </div>
        <div class="form-group">
        <label for="txtEnroll" class="col-sm-2">Enrollment: *</label>
        <asp:TextBox ID="txtEnroll" runat="server" required />
       
    </div>
    <div class="col-sm-offset-2">
        <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btn btn-primary"
             onclick="btnSave_Click" />
    </div>

</asp:Content>
