using vinoteca_JairMirad.Models;

namespace vinoteca_JairMirad.Repositories
{
    public interface IInventoryRepository
    {
        IEnumerable<Wine> GetAllWines();
        Wine? GetWineByName(string name);
        void AddWine(Wine wine);
        void UpdateStock(int wineId, int amount);
        void CreateUser(User user);
    }

}
