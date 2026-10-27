<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="WebForm1.aspx.cs"
    Inherits="class_projecct_2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Registration Form</title>

    <style>
        body {
            font-family: Arial;
            font-size: large;
            margin: 40px;
        }

        .form-box {
            width: 700px;
        }

        .row {
            margin-bottom: 18px;
        }

        .label {
            display: inline-block;
            width: 180px;
        }

        .textbox {
            width: 250px;
            height: 25px;
        }

        .button {
            padding: 8px 25px;
            font-size: large;
        }
    </style>
</head>

<body>

    <form id="form1" runat="server">

        <div class="form-box">

            <h2>Registration Form</h2>

            <!-- NAME -->

            <div class="row">

                <asp:Label
                    ID="Label1"
                    runat="server"
                    Text="Name:"
                    CssClass="label">
                </asp:Label>

                <asp:TextBox
                    ID="name"
                    runat="server"
                    CssClass="textbox">
                </asp:TextBox>

                <asp:RequiredFieldValidator
                    ID="RequiredFieldValidator1"
                    runat="server"
                    ControlToValidate="name"
                    ErrorMessage=" Enter name"
                    ForeColor="Red">
                </asp:RequiredFieldValidator>

            </div>


            <!-- PASSWORD -->

            <div class="row">

                <asp:Label
                    ID="Label2"
                    runat="server"
                    Text="Password:"
                    CssClass="label">
                </asp:Label>

                <asp:TextBox
                    ID="pass"
                    runat="server"
                    TextMode="Password"
                    CssClass="textbox">
                </asp:TextBox>

                <asp:RequiredFieldValidator
                    ID="RequiredFieldValidator2"
                    runat="server"
                    ControlToValidate="pass"
                    ErrorMessage=" Enter password"
                    ForeColor="Red">
                </asp:RequiredFieldValidator>

            </div>


            <!-- CONFIRM PASSWORD -->

            <div class="row">

                <asp:Label
                    ID="Label6"
                    runat="server"
                    Text="Confirm Password:"
                    CssClass="label">
                </asp:Label>

                <asp:TextBox
                    ID="confrim"
                    runat="server"
                    TextMode="Password"
                    CssClass="textbox">
                </asp:TextBox>

                <asp:CompareValidator
                    ID="CompareValidator1"
                    runat="server"
                    ControlToCompare="pass"
                    ControlToValidate="confrim"
                    ErrorMessage=" Password does not match"
                    ForeColor="Red">
                </asp:CompareValidator>

            </div>


            <!-- AGE -->

            <div class="row">

                <asp:Label
                    ID="Label3"
                    runat="server"
                    Text="Age:"
                    CssClass="label">
                </asp:Label>

                <asp:TextBox
                    ID="age"
                    runat="server"
                    CssClass="textbox">
                </asp:TextBox>

                <asp:RangeValidator
                    ID="RangeValidator1"
                    runat="server"
                    ControlToValidate="age"
                    MinimumValue="18"
                    MaximumValue="100"
                    Type="Integer"
                    ErrorMessage=" Enter age between 18 and 100"
                    ForeColor="Red">
                </asp:RangeValidator>

            </div>


            <!-- EMAIL -->

            <div class="row">

                <asp:Label
                    ID="Label4"
                    runat="server"
                    Text="Email:"
                    CssClass="label">
                </asp:Label>

                <asp:TextBox
                    ID="email"
                    runat="server"
                    CssClass="textbox">
                </asp:TextBox>

                <asp:RequiredFieldValidator
                    ID="RequiredEmailValidator"
                    runat="server"
                    ControlToValidate="email"
                    ErrorMessage=" Enter email"
                    ForeColor="Red">
                </asp:RequiredFieldValidator>

                <asp:RegularExpressionValidator
                    ID="RegularExpressionValidator2"
                    runat="server"
                    ControlToValidate="email"
                    ErrorMessage=" Enter valid email"
                    ForeColor="Red"
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
                </asp:RegularExpressionValidator>

            </div>


            <!-- CONTACT -->

            <div class="row">

                <asp:Label
                    ID="Label5"
                    runat="server"
                    Text="Contact No:"
                    CssClass="label">
                </asp:Label>

                <asp:TextBox
                    ID="contact"
                    runat="server"
                    CssClass="textbox">
                </asp:TextBox>

                <asp:RequiredFieldValidator
                    ID="RequiredContactValidator"
                    runat="server"
                    ControlToValidate="contact"
                    ErrorMessage=" Enter contact number"
                    ForeColor="Red">
                </asp:RequiredFieldValidator>

                <asp:RegularExpressionValidator
                    ID="RegularExpressionValidator1"
                    runat="server"
                    ControlToValidate="contact"
                    ErrorMessage=" Enter 10 digit number"
                    ForeColor="Red"
                    ValidationExpression="^[0-9]{10}$">
                </asp:RegularExpressionValidator>

            </div>


            <!-- REGISTER BUTTON -->

            <div class="row">

                <asp:Button
                    ID="btn_reg"
                    runat="server"
                    Text="Register"
                    CssClass="button"
                    OnClick="btn_reg_Click" />

            </div>

        </div>

    </form>

</body>

</html>