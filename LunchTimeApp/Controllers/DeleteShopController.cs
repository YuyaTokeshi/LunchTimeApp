using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchTimeApp
{
    class DeleteShopController
    {
        public void DeleteShop(string shop)
        {
            DeleteShopModel deleteShopModel = new DeleteShopModel();
            deleteShopModel.DeleteShop(shop);
        }
    }
}