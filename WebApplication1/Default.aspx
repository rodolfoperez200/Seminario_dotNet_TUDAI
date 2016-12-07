<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Ejemplo Aplicación Web From</h1>
    </div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </p>


        <asp:Button ID="ButtonError" runat="server" OnClick="ButtonError_Click" Text="Generar Error" />


<br>
        <br />
        <br />
        <a href="Log/SiteLog.txt" target="serminario_net_logs">Click aquí para ver los logs</a>
        <br>
        <asp:Button ID="ButtonCleanLogs" runat="server" OnClick="ButtonCleanLogs_Click" Text="Borrar Logs" />
        <br />
        <br />
        <br>
        <br><br>
    <hr>
        <h2>Notas:</h2> 
        <ul>
        <li>Esta applicacion fue creada con la siguiente configuración: <br>
        Tipo de proyecto: <b>"Web-> ASP.NET Web Application"</b><br>
        Template: <b>"Empty"</b><br>
        Seleccionando para que agregue referencias de Web Forms, y quitando la opción cloud</li><br>
        <li>La implementación de la clase <strong>Logger</strong> ejemplifica un uso sencillo de manipulación de archivos y directorios.</li><br>
        <li>Web la configuracion <b>customErrors</b> en Web.config</li><br>
        </ul>
    <hr>

    </form>
</body>
</html>
