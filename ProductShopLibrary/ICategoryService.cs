using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ProductShopLibrary
{
    [ServiceContract]
    public interface ICategoryService
    {
        [OperationContract]
        List<WCFCategory> GetCategories();
    }
}
