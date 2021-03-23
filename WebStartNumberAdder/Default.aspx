<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="WebStartNumberAdder._Default"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>RCC Student Calculator</title>
    <link href="StyleSheet1.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>RCC Student Calculator</h1>
        <table class="center">
          <tr>
            <td class="leftColumn">
                <asp:Label ID="Label1" runat="server" Text="Number 1:" CssClass="label"></asp:Label>
            </td>
            <td class="centerColumn">
                <asp:TextBox ID="input_number1" AutoPostBack="True" runat="server"></asp:TextBox>
            </td>
            <td class="rightColumn">
                <asp:Label ID="output_number1" runat="server" Text="" ForeColor="Red" CssClass="label"></asp:Label>
            </td>
          </tr>
          <tr>
            <td class="leftColumn">
                <asp:Label ID="Label2" runat="server" Text="Number 2: " CssClass="label"></asp:Label>
            </td>
            <td class="centerColumn">
                <asp:TextBox ID="input_number2" AutoPostBack="True" runat="server"></asp:TextBox>
            </td>
            <td class="rightColumn">
                <asp:Label ID="output_number2" runat="server" Text="" ForeColor="Red" CssClass="label"></asp:Label>
            </td>
          </tr>
          <tr>
            <td class="leftColumn">
                <asp:Label ID="Label3" runat="server" Text="Operation: " CssClass="label"></asp:Label>
            </td>
            <td class="centerColumn">
                <asp:TextBox ID="input_operation"  runat="server"></asp:TextBox>
            </td>
            <td class="rightColumn">
            </td>
          </tr>
          <tr>
            <td class="leftColumn">
               <asp:Label ID="Label4" runat="server" Text="Expected Result: " CssClass="label"></asp:Label>
            </td>
            <td class="centerColumn">
                <asp:TextBox ID="input_expected_result" AutoPostBack="True" runat="server"></asp:TextBox>
            </td>
            <td class="rightColumn">
               <asp:Label ID="output_expected_result" runat="server" Text="" ForeColor="Red" CssClass="label"></asp:Label>
            </td>
          </tr>
          <tr>
            <td class="leftColumn">
            </td>
            <td class="centerColumn">
                <asp:Button ID="Button_Calculate" runat="server" Text="Calculate" />
            </td>
            <td class="rightColumn">
            </td>
          </tr>
          <tr>
            <td class="leftColumn">
                <asp:Label ID="Label5" runat="server" Text="Result:" CssClass="label"></asp:Label>
            </td>
            <td class="centerColumn">
                <asp:Label ID="output_result" runat="server" Text="" CssClass="label"></asp:Label>
            </td>
            <td class="rightColumn">
            </td>
          </tr>
          <tr>
            <td class="leftColumn">
                <asp:Label ID="output_new_calculation" runat="server" Text="" ForeColor="Blue" CssClass="label"></asp:Label>
            </td>
            <td class="centerColumn">
                <asp:Button ID="Button_New_Calculation" runat="server" Text="Yes" />
            </td>
            <td class="rightColumn">
            </td>
          </tr>
        </table>
    </div>
    </form>
</body>
</html>
