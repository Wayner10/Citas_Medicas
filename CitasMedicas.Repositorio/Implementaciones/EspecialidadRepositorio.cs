using CitasMedicas.DataAccess.Models;
using CitasMedicas.Entities;
using CitasMedicas.Repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CitasMedicas.Repositorio.Implementaciones
{
    public class EspecialidadRepositorio : IEspecialidadRepositorio
    {
        private readonly CitasMedicas.DataAccess.Models.CitasMedicasContext _bd;

        public EspecialidadRepositorio(CitasMedicas.DataAccess.Models.CitasMedicasContext bd)
        {
            _bd = bd;
        }

        public async Task<List<Especialidad>> Listar()
        {
            return await _bd.Especialidad.Where(p => p.Activo).ToListAsync();
        }
    }
}
