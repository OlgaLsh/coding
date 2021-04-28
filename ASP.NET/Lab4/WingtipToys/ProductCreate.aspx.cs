using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using WingtipToys.Business;
using WingtipToys.Data;
using System.Net.Http;

namespace WingtipToys
{
    public partial class ProductCreate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private static readonly IStoreService _service = new StoreService(new SqlProductRepository(),
      new SqlCategoriesRepository());
        private readonly HttpClient _httpClient = new HttpClient() { Timeout = TimeSpan.FromSeconds(5) };
        public IQueryable<Category> GetCategories()
        {
            return _service.GetAllCategories().AsQueryable();
        }
        protected void ValidationImageExistence (object source, ServerValidateEventArgs args)
        {
            var request = new HttpRequestMessage(HttpMethod.Head, args.Value);
                try
                {
                    using (var response = AsyncHelper.RunSync(() => _httpClient.SendAsync(request)))
                    {
                        args.IsValid = response.IsSuccessStatusCode && response.Content.Headers.ContentType.MediaType.StartsWith("image/");
                    }
                }
                catch (HttpRequestException)
                {
                    args.IsValid = false;
                }
        }
        protected override void OnPreRender(EventArgs e)
        {
            if (IsPostBack && IsValid)
            {
                ProductCreateForm.Visible = false;
                SuccessBlock.Visible = true;
            }
        }

        protected void CreateProductButton_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                var product = new Product
                {
                    ProductName = ProdName.Text,
                    UnitPrice = double.Parse(Price.Text),
                    CategoryID = int.Parse(Category.SelectedValue),
                    Description = ProdDescription.Value,
                    ImagePath = Productimg.Text
                };
                var created = _service.CreateProduct(product);
                MesageProductName.Text = created.ProductName;
                MessageProductID.Text = created.ProductID.ToString();
            }
        }
    }
}