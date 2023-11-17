using Aplicacao_PsicoScarlet.Shared;

namespace Aplicacao_PsicoScarlet.Data.Service
{
    public interface  IPacienteService 
    {

        Task<List<Paciente>> GetPacientes();
        Task<Paciente> GetPaciente(Guid id);
        Task<bool> DeleteUser(Guid id);
        Task<bool> UpdatePaciente(Guid id, Paciente paciente);
    }
}
