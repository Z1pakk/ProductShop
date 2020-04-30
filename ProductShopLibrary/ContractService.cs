using BankomatLibrary.EFContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductShopLibrary
{

    public class ContractService : ICategoryService
    {
        public List<WCFCategory> GetCategories()
        {
            using (EFContext context = new EFContext())
            {
                List<string> prods = new List<string>();
                List<WCFCategory> categories = new List<WCFCategory>();
                foreach (var item in context.Categories)
                {
                    foreach(var it in item.ProductsOf)
                    {
                        prods.Add(it.Name);
                    }

                    categories.Add(new WCFCategory() { Id = item.Id, Name = item.Name,Products=prods });
                }
                return categories;
            }
        }
    }
}
