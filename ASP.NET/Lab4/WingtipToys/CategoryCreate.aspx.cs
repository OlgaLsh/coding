﻿using System;
using System.Web.UI.WebControls;
using System.Linq;
using WingtipToys.Business;
using WingtipToys.Data;
using System.Collections.Generic;

namespace WingtipToys
{
    public partial class CategoryCreate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private static readonly IStoreService _service = new StoreService(new SqlProductRepository(),
         new SqlCategoriesRepository());
  
        protected void CreateCategoryButton_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                var category = new Category
                {
                    CategoryName = Name.Text,
                    Description = Description.Value
                };
                var created = _service.CreateCategory(category);
                MesageCategoryName.Text = created.CategoryName;
            }
        }
        protected void ValidateUnique(object source, ServerValidateEventArgs args)
        {
            args.IsValid = !_service.CategoryExists(args.Value);
        }
        protected override void OnPreRender(EventArgs e)
        {
            if (IsPostBack && IsValid)
            {
                CreateCategoryForm.Visible = false;
                SuccessBlock.Visible = true;
            }
        }
    }
}