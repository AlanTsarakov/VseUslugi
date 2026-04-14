using VseUslugi.Models;

namespace VseUslugi.Data
{
    public interface IAppealRepository
    {
        List<Appeal> GetAll();
        Appeal? TryGetById(Guid id);

        public void Add(string Name, string Decription);
    }
}