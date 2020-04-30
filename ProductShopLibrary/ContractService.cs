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
                List<WCFCategory> categories = new List<WCFCategory>();
                foreach (var item in context.Categories)
                {
                    categories.Add(new WCFCategory() { Id = item.Id, Name = item.Name });
                }
                return categories;
            }
        }
    }
}
