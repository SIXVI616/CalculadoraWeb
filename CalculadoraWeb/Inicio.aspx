<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="CalculadoraWeb.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculadora Web</title>
    <style>
        body {
            background-color: #2F4F4F;
            font-family: Consolas;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>CALCULADORA WEB</h1>
        </div>
        <p>
            <asp:Label ID="Label1" runat="server" Text="NUMERO 1:"></asp:Label>
            <asp:TextBox ID="num1TB" runat="server" BackColor="#934AD5"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="NUMERO 2:"></asp:Label>
            <asp:TextBox ID="num2TB" runat="server" BackColor="#934AD5"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="RESULTADO:"></asp:Label>
            <asp:Label ID="resultadoL" runat="server" Text="0"></asp:Label>
        </p>
        <asp:RadioButton ID="sumaRB" runat="server" GroupName="operacion" Text="SUMA" />
        <asp:RadioButton ID="restaRB" runat="server" GroupName="operacion" Text="RESTA" />
        <asp:RadioButton ID="multiplicacionRB" runat="server" GroupName="operacion" Text="MULTIPLICACION" />
        <asp:RadioButton ID="divisionRB" runat="server" GroupName="operacion" Text="DIVISION" />
        <p>
            <asp:RadioButton ID="cuadradoRB" runat="server" GroupName="operacion" Text="X^2" />
            <asp:RadioButton ID="exponencialRB" runat="server" GroupName="operacion" Text="e^x" />
            <asp:RadioButton ID="diezXRB" runat="server" GroupName="operacion" Text="10x" />
        </p>
        <p>
            <asp:Button ID="igualB" runat="server" BackColor="#934AD5" Height="80px" OnClick="igualB_Click" Text="=" Width="80px" />
        </p>
    </form>
</body>
</html>
