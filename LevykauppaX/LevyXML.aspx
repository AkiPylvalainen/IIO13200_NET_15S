<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LevyXML.aspx.cs" Inherits="LevyXML" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:XmlDataSource ID="srcLevyt"
            DataFile="~/App_Data/LevykauppaX.xml"
            XPath="Records/genre/record"
            runat="server">
        </asp:XmlDataSource>
        <h1>LevykauppaX</h1>
        <asp:Repeater ID="LevyRepeater" DataSourceID="srcLevyt" runat="server">
            <HeaderTemplate>
            </HeaderTemplate>
            <ItemTemplate>
                <img alt="Kansikuva" src='<%#"Images/" + Eval("ISBN") + ".jpg" %>'/> <br />
                <h3> <b> <%# Eval("Artist") %> : <%# Eval("Title") %> </b> </h3>
                <b> ISBN: </b> 
                <asp:hyperlink href="Levytiedot.aspx" runat="server"><%# Eval("ISBN") %></asp:hyperlink> <br />
                <b> Hinta: </b>
                <%# Eval("Price") %> <br />
            </ItemTemplate>
        </asp:Repeater>
    </div>
    </form>
</body>
</html>
