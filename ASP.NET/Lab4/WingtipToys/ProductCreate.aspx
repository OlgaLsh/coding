<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductCreate.aspx.cs" Inherits="WingtipToys.ProductCreate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Add new product</h1>
    <div runat="server" id="ProductCreateForm">
        <asp:Label ID="LabelName" runat="server" AssociatedControlID="ProdName" Text="Name:"></asp:Label>
        <br />
        <asp:TextBox ID="ProdName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="ProdNameValidator" runat="server" ControlToValidate="ProdName" 
            ErrorMessage="Product name is required" Display="Dynamic"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="LabelPrice" runat="server" AssociatedControlID="Price" Text="Price"></asp:Label>
        <br />
        <asp:TextBox ID="Price" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="PriceRequiredValidator" runat="server" ControlToValidate="Price" 
            ErrorMessage="Price is required" Display="Dynamic"></asp:RequiredFieldValidator>
        <asp:RangeValidator ID="PriceRangeValidator" ControlToValidate="Price" runat="server" 
            ErrorMessage="Price should be grater then zero. Max price is 600$" MaximumValue="600,00"
            MinimumValue="0,10" Display="Dynamic"></asp:RangeValidator>
        <br />
        <asp:Label ID="LabelCategory" runat="server" AssociatedControlID="Category" Text="Category"></asp:Label>
        <asp:DropDownList ID="Category" runat="server" ItemType="WingtipToys.Data.Category" 
            DataTextField="CategoryName" DataValueField="CategoryID" SelectMethod="GetCategories"></asp:DropDownList>
        <asp:RequiredFieldValidator ID="CategoryRequiredValidator" runat="server" ControlToValidate="Category" 
            ErrorMessage="Category is required" Display="Dynamic"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="LabelDescription" runat="server" AssociatedControlID="ProdDescription" Text="Description"></asp:Label>
        <br />
        <textarea id="ProdDescription" name="S1" runat="server"></textarea>
        <asp:RegularExpressionValidator ID="ProdDescriptionLengthValidator" runat="server" ControlToValidate="ProdDescription"
            ErrorMessage="Description should be maximum 500 symbols long" ValidationExpression="^.{0,500}$"></asp:RegularExpressionValidator>
        <br/>
        <asp:Label ID="LabelProductimg" runat="server" AssociatedControlID="Productimg" Text="Product image URL"></asp:Label>
        <br />
        <asp:TextBox ID="Productimg" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="CorrectURLValidator" runat="server" ControlToValidate="Productimg"
            ErrorMessage="The entering URL is not correct" ValidationExpression="^\s*((?:https?://)?(?:[\w-]+\.)+[\w-]+)(/[\w ./?%&=-]*)?\s*$"
            Display="Dynamic"></asp:RegularExpressionValidator>
        <asp:CustomValidator ID="ImageValidator" runat="server" ControlToValidate="Productimg" 
            ErrorMessage="There is no image on this URL" Display="Dynamic"></asp:CustomValidator>
        <br/>
        <asp:Button ID="CreateProductButton" runat="server" Text="Create Product" OnClick="CreateProductButton_Click" />
    </div>
      <div runat="server" ID="SuccessBlock" Visible="False">
        <h2>New product <b><asp:Literal ID="MesageProductName" runat="server"></asp:Literal>&nbsp;</b>
            (number: <b><asp:Literal ID="MessageProductID" runat="server"></asp:Literal></b>) 
            was successfully added to our store. You could <a href="~/ProductList" runat="server">
                check catalog</a></h2>
    </div>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
</asp:Content>
