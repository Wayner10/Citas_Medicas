using CitasMedicas.DataAccess.Models;
using CitasMedicas.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CitasMedicas.Repositorio.Implementaciones
{
    public class DoctorRepositorio
    {
        private readonly CitasMedicasContext _bd;

        public DoctorRepositorio(CitasMedicasContext bd) 
        {
            _bd = bd;
        }

        public async Task<List<Doctor>> Listar() 
        {
            return await _bd.Doctors.ToListAsync();
        }
  
    }
}
