using RunGroupWebApp.Models;

namespace RunGroupWebApp.Interface
{
    public interface IDashboardRepository
    {
        Task<List<Race>> GetAllUsersRaces();
        Task<List<Club>> GetAllUsersClubs();
    }
}
