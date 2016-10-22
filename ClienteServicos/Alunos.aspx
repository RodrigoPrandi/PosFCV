<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Alunos.aspx.cs" Inherits="ClienteServicos.Alunos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="BotaoCarregar" runat="server" Text="Button" />
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>
