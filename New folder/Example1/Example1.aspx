<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Example1.aspx.cs" Inherits="SampleWebApp.Example1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My Words</title>
    <style type="text/css">
        .auto-style1 {
            width: 237px;
        }
        .auto-style2 {
            width: 392px;
        }
        .auto-style3 {
            width: 123px;
        }
        .auto-style4 {
            width: 121px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            English Word : 
            <asp:TextBox runat="server" ID="word" Width="315px" />
            <asp:Button Text="Search" ID="searchbtn" OnClick="search_button" runat="server" Width="104px" />
            <asp:Label runat="server" ID="foundword" />
        </div>
        <hr />
        <div>
            <table style="width: 59%">
                <tr>
                    <th class="auto-style4">Word</th>
                    <th class="auto-style1">Translation</th>
                    <th>Action</th>
                </tr>
                <tr>
                    <td class="auto-style4"><asp:Label runat="server" ID="selectedword" /></td>
                    <td class="auto-style1"><asp:TextBox ID="meaning" runat="server" Width="345px" />
                        <asp:Label runat="server" ID="error" />
                    </td>
                    <td><asp:Button Text="Add to My_Words" ID="addToList" OnClick="AddingList" runat="server" Width="195px" /></td>
                </tr>
            </table>
            <hr />
            <hr />
            <table>
                <tr>
                    <th class="auto-style3">Word</th>
                    <th class="auto-style2">Translation</th>
                </tr>
                <tr>
                    <td><asp:Label runat="server" ID="wordshow" /></span></td>
                    <td><asp:Label runat="server" ID="translation" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
