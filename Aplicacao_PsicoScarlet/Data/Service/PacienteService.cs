using Aplicacao_PsicoScarlet.Data.Service.Interfaces;
using Aplicacao_PsicoScarlet.Shared;
using Microsoft.EntityFrameworkCore;

namespace Aplicacao_PsicoScarlet.Data.Service
{
    public class PacienteService : IPacienteService
    {
        #region Property
        private readonly ApplicationDbContext _appDBContext;
        public PacienteService pacienteService;

        #endregion

        #region Constructor
        public PacienteService(ApplicationDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        public async Task<List<Paciente>> GetallPacientes()
        {
            return await _appDBContext.Paciente.ToListAsync();
        }



        public async Task<bool> InsertTurnoAsync(Paciente paciente)
        {
            if (await VerificaSeExistePaciente(Guid.Parse(paciente.Id)) == true)
            {
                await UpdateRegistroAsync(paciente);
                return true;
            }
            else
            {
                await _appDBContext.Paciente.AddAsync(paciente);
                await _appDBContext.SaveChangesAsync();
                return true;
            }

        }




        public async Task<Paciente> GetPacienteIdAsync(string Id)
        {
            Paciente paciente = await _appDBContext.Paciente.FirstOrDefaultAsync(c => c.IdPaciente.Equals(Id));
            return paciente;
        }



        public async Task<bool> UpdateRegistroAsync(Paciente paciente)
        {
            _appDBContext.Paciente.Update(paciente);
            await _appDBContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> VerificaSeExistePaciente(Guid id)
        {
            var retorno = await _appDBContext.Paciente.FindAsync(id);

            if (retorno == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public async Task<bool> DeleteTurnoAsync(Paciente paciente)
        {
            _appDBContext.Remove(paciente);
            await _appDBContext.SaveChangesAsync();
            return true;
        }

    }
}
