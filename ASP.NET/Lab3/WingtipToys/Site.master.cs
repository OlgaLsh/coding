﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WingtipToys.Business;
using WingtipToys.Data.Models;
using System.Web.ModelBinding;
using WingtipToys.Data;

namespace WingtipToys
{
    public partial class Site : System.Web.UI.MasterPage
    {
        private static readonly IStoreService _service = new StoreService(new InMemoryProductRepository(),
        new InMemoryCategoryRepository());
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Category> GetCategories()
        {
            return _service.GetAllCategories().AsQueryable();
        }
    }
}