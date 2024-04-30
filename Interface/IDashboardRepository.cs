using RunGroupWebApp.Models;

namespace RunGroupWebApp.Interface
{
    public interface IDashboardRepository
    {
        Task<List<Race>> GetAllUsersRaces();
        Task<List<Club>> GetAllUsersClubs();
        Task<AppUser> GetUserById(string id);
        Task<AppUser> GetByIdNoTracking(string id);
        bool Update(AppUser user);
        bool Save();
    }
}
