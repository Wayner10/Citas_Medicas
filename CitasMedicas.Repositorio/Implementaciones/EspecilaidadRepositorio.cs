using CitasMedicas.DataAccess.Models;
using CitasMedicas.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CitasMedicas.Repositorio.Implementaciones
{
    public class EspecilaidadRepositorio
    {
        private readonly CitasMedicasContext _bd;

        public EspecilaidadRepositorio(CitasMedicasContext bd)
        {
            _bd = bd;
        }

        public async Task<List<Especialidad>> Listar()
        {
            return await _bd.Especialidads.ToListAsync();
        }
    }
}
