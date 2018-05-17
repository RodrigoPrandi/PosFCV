<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaFuncionario.aspx.cs" Inherits="Apresentacao.PaginaFuncionario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GrvFuncionario" runat="server" OnRowCommand="GrvFuncionario_RowCommand" >
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkExcluir" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "id") %>' runat="server" CommandName="Excluir">Excluir</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="lknEditar" CommandArgument='<%# Container.DataItemIndex %>' runat="server" CommandName="Editar">Editar</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
 <br />
 <br />
       <label>Cadastro de Funcionario</label>
        <br /><br />
        <asp:Label ID="Label3" runat="server"  Text="Codigo"></asp:Label>
        <asp:TextBox ID="txtId" Enabled="false" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Nome"></asp:Label>
        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
        <br />
         <asp:Label ID="Label2" runat="server" Text="Salario"></asp:Label>
        <asp:TextBox ID="txtSalario" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
    </div>
    </form>
</body>
</html>
