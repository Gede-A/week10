<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="week10._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Data Entry Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Transport Emissions</h2>
            <asp:Label ID="lblVehicleType" runat="server" Text="Vehicle Type:"></asp:Label>
            <asp:DropDownList ID="ddlVehicleType" runat="server">
                <asp:ListItem Text="Car" Value="Car"></asp:ListItem>
                <asp:ListItem Text="Truck" Value="Truck"></asp:ListItem>
                <asp:ListItem Text="Bus" Value="Bus"></asp:ListItem>
            </asp:DropDownList><br />
            <!-- Similar controls for other fields in transport emissions -->

            <h2>Electricity Consumption</h2>
            <!-- Controls for electricity consumption -->

            <asp:Button ID="btnSubmitTransport" runat="server" Text="Submit" OnClick="btnSubmitTransport_Click" />
            <asp:Button ID="btnSubmitElectricity" runat="server" Text="Submit" OnClick="btnSubmitElectricity_Click" />
        </div>
    </form>
</body>
</html>
