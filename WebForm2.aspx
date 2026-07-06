<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="class_project.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" Width="220px" OnSelectionChanged="Calendar1_SelectionChanged">
                <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                <OtherMonthDayStyle ForeColor="#CC9966" />
                <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                <SelectorStyle BackColor="#FFCC66" />
                <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />

            </asp:Calendar>
                            <asp:Label runat="server" Text="Label" ID="label3"></asp:Label>

                <br />

                <asp:Label ID="Label1" runat="server" Text="gender :"></asp:Label>
            <asp:RadioButton runat="server" OnCheckedChanged="Unnamed1_CheckedChanged" Text="female" ID="female" GroupName="gender"></asp:RadioButton>
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:RadioButton runat="server" OnCheckedChanged="Unnamed2_CheckedChanged" Text="male" ID="male" GroupName="gender"></asp:RadioButton>
    <br />
    <br />
<asp:Button runat="server" Text="Submit" ID="Button1" OnClick="Unnamed3_Click" />
                </body>
        <br />
        <br />
<asp:CheckBox runat="server" Text="c language" ID="checkbox1" OnCheckedChanged="Unnamed1_CheckedChanged1"></asp:CheckBox>
        <br />
<asp:CheckBox runat="server" Text="c-sharp" ID="checkbox2"></asp:CheckBox>
        <br />
<asp:CheckBox runat="server" Text="java" ID="checkbox3"></asp:CheckBox>
            <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="total fees" />
<asp:Label runat="server" Text="your fee" ID="label2"></asp:Label>


        </div>
    </form>

</html>

