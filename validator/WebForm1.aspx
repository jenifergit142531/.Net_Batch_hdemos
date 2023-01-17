<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="validator.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 520px;
        }
        .auto-style2 {
            margin-left: 240px;
        }
        .auto-style3 {
            margin-left: 640px;
        }
        .auto-style4 {
            margin-left: 280px;
        }
        </style>
  <script type="text/javascript">
      function validateLength(sender, args) {
          debugger;
           //string inputData = args.Value;
          if (args.Value.Length < 5) {
              args.IsValid = false;
          }

          else {
              args.IsValid = true;
          }

      }
  </script>
</head>
<body>
    
   
        <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:Label ID="Label1" runat="server" Text="User Registration Page"></asp:Label>
            <br />
            <br />
            <br />
            
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
        <div class="auto-style4">
            <asp:Label ID="Label2" runat="server" Text="First Name"></asp:Label>
        
        
        <asp:TextBox ID="firstname" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="First Name is required" ForeColor="Red" ControlToValidate="firstname"></asp:RequiredFieldValidator>
            </div>
        <br />
        <br />
        <div class="auto-style2">
            <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="password" runat="server"></asp:TextBox>
        </div>
        <br />
        <br />
        <div class="auto-style2">
            <asp:Label ID="Label4" runat="server" Text="Confirm Password"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="cpassword" runat="server"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Password is not matching" ForeColor="Red" ControlToCompare="password" ControlToValidate="cpassword"></asp:CompareValidator>
            <br />
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Age"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="age" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Age should be between 21 and 35" ControlToValidate="age" ForeColor="Red" MinimumValue="21" MaximumValue="35"></asp:RangeValidator>
        </div>
        <br />
        <br />
        <div class="auto-style2">
            <asp:Label ID="Label6" runat="server" Text="Email Id"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="email" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Email not valid" ForeColor="Red" ValidationExpression="^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$" ControlToValidate="email"></asp:RegularExpressionValidator>
        </div>
        <br />
        <br />
        <div class="auto-style2">
            <asp:Label ID="Label7" runat="server" Text="Set your User Name"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="username" runat="server"></asp:TextBox>

    <asp:CustomValidator ID="CustomValidator1" runat="server" ClientValidationFunction="validateLength" ForeColor="Red" ErrorMessage="Invalid user name" ControlToValidate="username"  ></asp:CustomValidator>

            
        </div>
        <br />
        <br />
        <br />
        <div class="auto-style3">
            <asp:Button ID="Button1" runat="server" Text="Register" CausesValidation="true"/>
        </div>
        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
        <p>
            &nbsp;</p>
    </form>

     
    
</body>
</html>
