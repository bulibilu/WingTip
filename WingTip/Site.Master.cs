using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using WingTip.Models;
using WingTip.Logic;

namespace WingTip
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Category> GetCategories()
        {
            var _db = new WingTip.Models.ProductContext();
            IQueryable<Category> query = _db.Categories;
            return query;
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            using (ShoppingCartActions usersShoppingCart = new ShoppingCartActions())
            {
                string cartStr = string.Format("Cart ({0})", usersShoppingCart.GetCount());
                cartCount.InnerText = cartStr;
            }
        }
    }
}