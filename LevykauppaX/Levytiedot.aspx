<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Levytiedot.aspx.cs" Inherits="Levytiedot" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:XmlDataSource ID="srcLevy"
            DataFile="~/App_Data/LevykauppaX.xml"
            XPath="Records/genre/record[@ISBN='Johanna2012']"
            runat="server">
        </asp:XmlDataSource>
        <asp:XmlDataSource ID="srcBiisit"
            DataFile="~/App_Data/LevykauppaX.xml"
            XPath="Records/genre/record[@ISBN='Johanna2012']/song"
            runat="server">
        </asp:XmlDataSource>
        <h1>LevykauppaX</h1>
        <asp:Repeater ID="LevyRepeater" DataSourceID="srcLevy" runat="server">
            <HeaderTemplate>
            </HeaderTemplate>
            <ItemTemplate>
                <img alt="Kansikuva" src='<%#"Images/" + Eval("ISBN") + ".jpg" %>'/> <br />
                <h3> <b> <%# Eval("Artist") %> : <%# Eval("Title") %> </b> </h3>
                <b> ISBN: </b> <%# Eval("ISBN") %> <br />
                <b> Hinta: </b><%# Eval("Price") %> <br />
                <asp:Repeater ID="BiisiRepeater" DataSourceID="srcBiisit" runat="server">
                    <HeaderTemplate>
                        <b> Levyn biisit: </b> <br />
                    </HeaderTemplate>
                    <ItemTemplate>
                        <%# Eval("name") %> <br />
                    </ItemTemplate>
                </asp:Repeater>
            </ItemTemplate>
        </asp:Repeater>
        <br /><asp:HyperLink href="LevyXML.aspx" runat="server">Takaisin</asp:HyperLink>
    </div>
    </form>
</body>
</html>
