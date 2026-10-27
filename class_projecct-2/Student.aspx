<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="WebApplication1.StudentRegistration" %> 
 
<!DOCTYPE html> 
 
<html xmlns="http://www.w3.org/1999/xhtml"> 
<head runat="server"> 
    <title>Student Registration - MultiView Control</title> 
    <style type="text/css">         body {             font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;             background-color: #f4f6f9;             margin: 40px; 
        } 
        .container {             width: 550px;             margin: 0 auto;             background: #ffffff;             padding: 30px 40px;             border-radius: 8px;             box-shadow: 0 4px 15px rgba(0,0,0,0.1); 
        }         h2 {             color: #2c3e50;             text-align: center;             margin-bottom: 20px; 
        } 
        .step-indicator {             text-align: center;             font-weight: bold;             color: #007bff;             margin-bottom: 20px;             font-size: 16px; 
padding: 8px; background-color: #e9f5ff;             border-radius: 4px; 
        } 
        .form-group {             margin-bottom: 15px; 
        } 
        .form-group label {             display: block;             margin-bottom: 5px;             font-weight: bold;             color: #555; 
        } 
        .form-control {             width: 100%;             padding: 8px 10px;             box-sizing: border-box;             border: 1px solid #ccc;             border-radius: 4px;             font-size: 14px; 
        } 
        .btn { 
padding: 9px 20px; background-color: #007bff;             color: white;             border: none;             border-radius: 4px;             cursor: pointer;             font-size: 14px;             font-weight: bold; 
        } 
        .btn-secondary {             background-color: #6c757d;
            height: 40px;
        } 
        .btn:hover {             opacity: 0.9; 
        } 
        .btn-group {             margin-top: 25px;             display: flex;             justify-content: space-between; 
        } 
        .summary-table {             width: 100%; border-collapse: collapse; margin-top: 15px;
        } 
        .summary-table td {             padding: 10px;             border-bottom: 1px solid #eee; 
        } 
        .summary-table td.label-col {             font-weight: bold;             width: 35%;             color: #333; 
        } 
    </style> 
</head> 
<body> 
    <form id="form1" runat="server"> 
        <div class="container"> 
            <h2>Student Details Form</h2> 
 
            <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0"> 
                <%-- View 1: Student Personal Info --%> 
                <asp:View ID="View1" runat="server"> 
                    <div class="step-indicator">View 1: Student Personal Info</div>                     <div class="form-group"> 
                        <asp:Label ID="lbl1" runat="server" Text="Student Name:"></asp:Label> 
                        <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox> 
                        <asp:RequiredFieldValidator ID="rfvName" runat="server" 
ControlToValidate="txtName" ErrorMessage="Name is required" ForeColor="Red" 
ValidationGroup="Group1"></asp:RequiredFieldValidator> 
                    </div> 
 
                    <div class="form-group"> 
                        <asp:Label ID="lbl2" runat="server" Text="Gender:"></asp:Label> 
                        <asp:RadioButtonList ID="rblGender" runat="server" 
RepeatDirection="Horizontal"> 
                            <asp:ListItem Selected="True">Male</asp:ListItem> 
                            <asp:ListItem>Female</asp:ListItem> 
                            <asp:ListItem>Other</asp:ListItem> 
                        </asp:RadioButtonList> 
                    </div> 
 
                    <div class="form-group"> 
                        <asp:Label ID="lbl3" runat="server" Text="Address:"></asp:Label> 
                        <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine" Rows="3" 
CssClass="form-control"></asp:TextBox> 
                        <asp:RequiredFieldValidator ID="rfvAddress" runat="server" 
ControlToValidate="txtAddress" ErrorMessage="Address is required" ForeColor="Red" 
ValidationGroup="Group1"></asp:RequiredFieldValidator> 
                    </div> 
 
                    <div class="form-group"> 
                        <asp:Label ID="lbl4" runat="server" Text="Degree / Course:"></asp:Label> 
                        <asp:DropDownList ID="ddlDegree" runat="server" CssClass="form-control"> 
                            <asp:ListItem>B.Tech</asp:ListItem> 
                            <asp:ListItem>B.Sc</asp:ListItem> 
                            <asp:ListItem>BCA</asp:ListItem> 
                            <asp:ListItem>M.Tech</asp:ListItem> 
                            <asp:ListItem>MCA</asp:ListItem> 
                            <asp:ListItem>M.Sc</asp:ListItem> 
                        </asp:DropDownList> 
                    </div> 
                    <div class="btn-group">
                        <div>
                        </div>
                        <asp:Button ID="btnNext1" runat="server" CssClass="btn" OnClick="btnNext1_Click" Text="Next (Contact Info) &gt;&gt;" ValidationGroup="Group1" />
                    </div>
                </asp:View> 

                <%-- View 2: Student Contact Info --%> 
                <asp:View ID="View2" runat="server"> 
                    <div class="step-indicator">View 2: Student Contact Info</div> 
 
                    <div class="form-group"> 
                        <asp:Label ID="lbl5" runat="server" Text="Email Address:"></asp:Label> 
                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox> 
                        <asp:RequiredFieldValidator ID="rfvEmail" runat="server" 
ControlToValidate="txtEmail" ErrorMessage="Email is required" ForeColor="Red" 
ValidationGroup="Group2"></asp:RequiredFieldValidator> 
                        <asp:RegularExpressionValidator ID="revEmail" runat="server" 
ControlToValidate="txtEmail" ErrorMessage="Invalid Email Format" ForeColor="Red" 
ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="Group2"></asp:RegularExpressionValidator> 
                    </div> 
 
                    <div class="form-group"> 
                        <asp:Label ID="lbl6" runat="server" Text="Contact No:"></asp:Label> 
                        <asp:TextBox ID="txtContact" runat="server" CssClass="form-control"></asp:TextBox> 
                        <asp:RequiredFieldValidator ID="rfvContact" runat="server" 
ControlToValidate="txtContact" ErrorMessage="Contact number is required" ForeColor="Red" 
ValidationGroup="Group2"></asp:RequiredFieldValidator> 
                        <asp:RegularExpressionValidator ID="revContact" runat="server" 
ControlToValidate="txtContact" ErrorMessage="Must be 10 digits" ForeColor="Red" 
ValidationExpression="\d{10}" ValidationGroup="Group2"></asp:RegularExpressionValidator> 
                    </div> 
 
                    <div class="form-group"> 
                        <asp:Label ID="lbl7" runat="server" Text="City:"></asp:Label> 
                        <asp:TextBox ID="txtCity" runat="server" CssClass="form-control"></asp:TextBox> 
                        <asp:RequiredFieldValidator ID="rfvCity" runat="server" 
ControlToValidate="txtCity" ErrorMessage="City is required" ForeColor="Red" 
ValidationGroup="Group2"></asp:RequiredFieldValidator> 
                    </div> 
 
                    <div class="btn-group"> 
                        <asp:Button ID="btnPrev2" runat="server" Text="<< Previous (Personal Info)" CssClass="btn btn-secondary" OnClick="btnPrev2_Click" CausesValidation="false" /> 
                        <asp:Button ID="btnNext2" runat="server" Text="Next (Show Summary) >>" CssClass="btn" ValidationGroup="Group2" OnClick="btnNext2_Click" /> 
                    </div> 
                </asp:View> 
 
                <%-- View 3: Show Summary (View 1 + View 2) --%> 
                <asp:View ID="View3" runat="server"> 
                    <div class="step-indicator">View 3: Student Summary</div> 
 
                    <table class="summary-table"> 
                        <tr> 
                            <td class="label-col">Name:</td> 
                            <td><asp:Label ID="lblSummaryName" runat="server"></asp:Label></td> 
                        </tr> 
                        <tr> 
                            <td class="label-col">Gender:</td> 
                            <td><asp:Label ID="lblSummaryGender" runat="server"></asp:Label></td> 
                        </tr> 
                        <tr> 
                            <td class="label-col">Address:</td> 
                            <td><asp:Label ID="lblSummaryAddress" runat="server"></asp:Label></td> 
                        </tr> 
                        <tr> 
                            <td class="label-col">Degree:</td> 
                            <td><asp:Label ID="lblSummaryDegree" runat="server"></asp:Label></td> 
                        </tr> 
                        <tr> 
                            <td class="label-col">Email:</td> 
                            <td><asp:Label ID="lblSummaryEmail" runat="server"></asp:Label></td> 
                        </tr> 
                        <tr> 
                            <td class="label-col">Contact No:</td> 
                            <td><asp:Label ID="lblSummaryContact" runat="server"></asp:Label></td> 
                        </tr> 
                        <tr> 
                            <td class="label-col">City:</td> 
                            <td><asp:Label ID="lblSummaryCity" runat="server"></asp:Label></td> 
                        </tr> 
                    </table> 
 
                    <asp:Label ID="lblStatusMessage" runat="server" ForeColor="Green" 
Font-Bold="true" style="display:block; margin-top:15px; text-align:center;"></asp:Label> 
 
                    <div class="btn-group"> 
                        <asp:Button ID="btnPrev3" runat="server" Text="<< Edit Contact Info" 
CssClass="btn btn-secondary" OnClick="btnPrev3_Click" CausesValidation="false" /> 
                        <asp:Button ID="btnSubmit" runat="server" Text="Final Submit" CssClass="btn" OnClick="btnSubmit_Click" CausesValidation="false" /> 
                    </div> 
                </asp:View> 
            </asp:MultiView> 
        </div> 
    </form> 
</body> 
</html> 
 
