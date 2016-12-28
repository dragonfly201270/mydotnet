<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2.Default1" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
    <link href="css/materialize.min.css" rel="stylesheet" />
    <%--<link href="css/bootstrap-theme.min.css" rel="stylesheet" />--%>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center" runat="server">
            <h2>Employee Details</h2>
        </div>
        <div runat="server">

            <asp:Label ID="Label5" runat="server" ForeColor="#ff3300"></asp:Label>




            <table runat="server">
                <tr>
                    <td>
                        <table runat="server">
                            <tr>
                                <td>
                                    <asp:Label ID="Label2" runat="server" Text="First Name" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                                </td>

                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label6" runat="server" Text="Last Name" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                                </td>

                                <td>
                                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>

                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label3" runat="server" Text="Address" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>

                                </td>
                            </tr>
                            <tr>
                                <td>

                                    <asp:Label ID="Label4" runat="server" Text="City" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>

                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insert" Width="108px" />
                                </td>
                                <td>
                                    <asp:Button ID="Button2" runat="server" align="right" OnClick="Button2_Click" Text="Search" Style="float: inherit" Width="108px" />
                                </td>
                                <td>
                                    <asp:Button ID="Button3" runat="server" align="right" OnClick="Button3_Click" Text="List Employee" Style="float: inherit" Width="108px" />
                                </td>
                            </tr>
                        </table>
                        </td>
                            <td>
                                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                    <ContentTemplate>
                                        <asp:Chart ID="Chart2" runat="server" DataSourceID="SqlDataSource1">
                                            <Series>
                                                <asp:Series ChartType="Pie" Name="Series1" XValueMember="city" YValueMembers="City_Count">
                                                </asp:Series>
                                            </Series>
                                            <ChartAreas>
                                                <asp:ChartArea Name="ChartArea1">
                                                </asp:ChartArea>
                                            </ChartAreas>
                                        </asp:Chart>
                                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:conn %>" ProviderName="<%$ ConnectionStrings:conn.ProviderName %>" SelectCommand="SELECT COUNT(city) AS City_Count, city FROM record GROUP BY city"></asp:SqlDataSource>
                                        <asp:Timer ID="Timer1" runat="server">
                                        </asp:Timer>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
