using Aplicacao_PsicoScarlet.Shared;

namespace Aplicacao_PsicoScarlet.Data.Service.Interfaces
{
    public interface IPacienteService
    {

        Task<List<Paciente>> GetallPacientes();
        Task<bool> InsertTurnoAsync(Paciente paciente);
        Task<Paciente> GetPacienteIdAsync(string Id);
        Task<bool> UpdateRegistroAsync(Paciente paciente);
        Task<bool> VerificaSeExistePaciente(Guid id);
        Task<bool> DeleteTurnoAsync(Paciente paciente);
        
    }
}
