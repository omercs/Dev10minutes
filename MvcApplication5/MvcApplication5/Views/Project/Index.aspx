<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MvcApplication5.Models.Project>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Index</h2>

    <table>
        <tr>
            <th></th>
            <th>
                ProjectId
            </th>
            <th>
                Name
            </th>
            <th>
                StartDate
            </th>
            <th>
                EndDate
            </th>
            <th>
                Description
            </th>
            <th>
                AssignedTo
            </th>
            <th>
                CreatedOn
            </th>
            <th>
                CreatedBy
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Edit", "Edit", new { id=item.ProjectId }) %> |
                <%: Html.ActionLink("Details", "Details", new { id=item.ProjectId })%> |
                <%: Html.ActionLink("Delete", "Delete", new { id=item.ProjectId })%>
            </td>
            <td>
                <%: item.ProjectId %>
            </td>
            <td>
                <%: item.Name %>
            </td>
            <td>
                <%: String.Format("{0:g}", item.StartDate) %>
            </td>
            <td>
                <%: String.Format("{0:g}", item.EndDate) %>
            </td>
            <td>
                <%: item.Description %>
            </td>
            <td>
                <%: item.AssignedTo %>
            </td>
            <td>
                <%: String.Format("{0:g}", item.CreatedOn) %>
            </td>
            <td>
                <%: item.CreatedByName%>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Create New", "Create") %>
    </p>

</asp:Content>

