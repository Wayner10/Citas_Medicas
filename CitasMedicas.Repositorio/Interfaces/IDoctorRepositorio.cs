using CitasMedicas.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CitasMedicas.Repositorio.Interfaces
{
    public interface IDoctorRepositorio
    {
        Task<List<Doctor>> Listar();
    }
}
