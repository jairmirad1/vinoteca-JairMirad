using vinoteca_JairMirad.Models;

namespace vinoteca_JairMirad.Repositories
{
    public class InMemoryInventoryRepository : IInventoryRepository
    {
        private readonly List<Wine> _wines = new();
        private readonly List<User> _users = new();
        private int _nextWineId = 1;
        private int _nextUserId = 1;

        public IEnumerable<Wine> GetAllWines() => _wines;

        public Wine? GetWineByName(string name) => _wines.FirstOrDefault(w => w.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

        public void AddWine(Wine wine)
        {
            wine.Id = _nextWineId++;
            _wines.Add(wine);
        }

        public void UpdateStock(int wineId, int amount)
        {
            var wine = _wines.FirstOrDefault(w => w.Id == wineId);
            if (wine != null)
            {
                wine.Stock += amount;
            }
        }

        public void CreateUser(User user)
        {
            user.Id = _nextUserId++;
            _users.Add(user);
        }
    }
}
