using System.Threading.Tasks;
using Pavel_Denisa_lab11.Models;
namespace Pavel_Denisa_lab11.Data
{
    public interface IRestService
    {
        Task<List<ShopList>> RefreshDataAsync();
        Task SaveShopListAsync(ShopList item, bool isNewItem);
        Task DeleteShopListAsync(int id);
    }

}
