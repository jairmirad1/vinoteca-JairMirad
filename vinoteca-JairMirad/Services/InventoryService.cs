using vinoteca_JairMirad.Models;
using vinoteca_JairMirad.Repositories;

namespace vinoteca_JairMirad.Services
{
    public class InventoryService
    {
        private readonly IInventoryRepository _repository;

        public InventoryService(IInventoryRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Wine> GetAllWines() => _repository.GetAllWines();

        public Wine? GetWineByName(string name) => _repository.GetWineByName(name);

        public void AddWine(Wine wine) => _repository.AddWine(wine);

        public void UpdateWineStock(int wineId, int amount) => _repository.UpdateStock(wineId, amount);

        public void RegisterUser(User user) => _repository.CreateUser(user);
    }
}
