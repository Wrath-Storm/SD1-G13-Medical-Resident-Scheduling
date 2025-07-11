using MedicalDemo.Data.Models;

namespace MedicalDemo.Repositories
{
    //connector functions
    public interface IMedicalRepository
    {
        Task<List<Admins>> GetAllAdminsAsync();

        Task<List<Residents>> GetAllResidentsAsync();

        Task<List<Rotations>> GetAllRotationsAsync();

        Task<List<Vacations>> GetAllVacationsAsync();

        Task<List<Residents>> LoadPGYOne();

        Task<List<Residents>> LoadPGYTwo();

        Task<List<Residents>> LoadPGYThree();

        Task<Dictionary<string, List<Rotations>>> GetResidentRolesByMonthAsync();
        Task<List<Dates>> GenerateTrainingDatesAsync();

        Task<List<Dates>> GenerateTrainingScheduleAsync();

    }
}