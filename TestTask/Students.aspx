<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Students.aspx.cs" Inherits="Students" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:HyperLink NavigateUrl="~/AddStudent" Text="Добавить студента" runat="server" />
    	<br /><br />
    <asp:Label runat="server" Text="Показать:" />
        <asp:DropDownList runat="server" AutoPostBack="true" ID="DisplayYear">
            <asp:ListItem Text="Все" Value="" />
            <asp:ListItem Text="FirstYear" />
            <asp:ListItem Text="SecondYear" />
            <asp:ListItem Text="ThirdYear" />
            <asp:ListItem Text="FourthYear" />
        </asp:DropDownList>
    <asp:ValidationSummary ShowModelStateErrors="true" runat="server" /> 
    <asp:GridView runat="server" ID="studentsGrid"
        ItemType="TestTask.Models.Student" DataKeyNames="StudentID" 
        SelectMethod="studentsGrid_GetData"
        UpdateMethod="studentsGrid_UpdateItem" DeleteMethod="studentsGrid_DeleteItem"
        AllowSorting="true" 
        AutoGenerateEditButton="true" AutoGenerateDeleteButton="true"  
        AutoGenerateColumns="false">
        <Columns>
            <asp:DynamicField DataField="StudentID" />
            <asp:DynamicField DataField="LastName" />
            <asp:DynamicField DataField="FirstName" />
            <asp:DynamicField DataField="Year" />          
            <asp:TemplateField HeaderText="Всего баллов">
                <ItemTemplate>
                    <asp:Label Text="<%# Item.Enrollments.Sum(en => en.Course.Credits) %>"
                        runat="server" />
                </ItemTemplate>
            </asp:TemplateField>   
            <asp:HyperLinkField Text="Courses" DataNavigateUrlFormatString="~/Courses.aspx?StudentID={0}"
                DataNavigateUrlFields="StudentID" />
        </Columns>
    </asp:GridView>
</asp:Content>
