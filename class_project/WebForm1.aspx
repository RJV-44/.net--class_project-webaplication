<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="class_project.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student Form</title>
</head>
<body>
    <form id="form1" runat="server">

        <div>
            <h2>Rajvi Lunagariya</h2>

            <br />

            <asp:Label ID="Label1" runat="server" Text="First Name: "></asp:Label>
            3<br /><br />

            <asp:Label ID="Label2" runat="server" Text="Middle Name: "></asp:Label>
            5<br />

            <br /><br />

            <asp:Button ID="submit" runat="server"
                Text="Submit"
                BackColor="#FF3399"
                BorderStyle="Double"
                ForeColor="Black"
                OnClick="submit_Click" />

            <br /><br />

            <asp:Label ID="Label3" runat="server"></asp:Label>

        </div>

    </form>
</body>
</html>