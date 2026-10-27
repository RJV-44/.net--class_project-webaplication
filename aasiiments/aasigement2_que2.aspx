<%@ Page Language="C#" AutoEventWireup="true"
    CodeFile="aasigement2_que2.aspx.cs"
    Inherits="aasiiments.aasigement2_que2" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2> Name : vekariya abhay</h2>             
            CALENDAR CONTROL DEMO<br />             
            <br />             
            Today is: 
            <asp:Label ID="lblToday" runat="server"></asp:Label>             
            <br /><br />              
            <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>             
            <br />              
            Selected Date: <asp:Label ID="lblSelected" runat="server"></asp:Label> 
        </div>
    </form>
</body>
</html>
