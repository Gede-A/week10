<%--<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataReport.aspx.cs" Inherits="week10.DataReport" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>--%>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataReport.aspx.cs" Inherits="week10.DataReport" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Data Report Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Transport Emissions</h2>
            <asp:GridView ID="gvTransportEmissions" runat="server">
                <!-- Define columns as per requirements -->
            </asp:GridView>

            <h2>Electricity Consumption</h2>
            <asp:GridView ID="gvElectricityConsumption" runat="server">
                <!-- Define columns as per requirements -->
            </asp:GridView>
        </div>
    </form>
</body>
</html>

