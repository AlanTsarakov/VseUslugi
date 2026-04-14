using VseUslugi.Models;

namespace VseUslugi.Data
{
    public class AppealRepositoryInMemory : IAppealRepository
    {
        private static List<Appeal> appeals = new List<Appeal>()
        {
            new Appeal(new Guid(), "Не работает подача заявления на пенсию", "Мошенники! Выплатите мне мою пенсию"),
            new Appeal(new Guid(), "Не работает подача заявления на пенсию", "Мошенники! Выплатите мне мою пенсию"),
            new Appeal(new Guid(), "Не работает подача заявления на пенсию", "Мошенники! Выплатите мне мою пенсию"))
        };

        public List<Appeal> GetAll()
        {
            return appeals;
        }

        public Appeal? TryGetById(Guid id)
        {
            return appeals.FirstOrDefault(product => product.Id == id);
        }
    }
}
