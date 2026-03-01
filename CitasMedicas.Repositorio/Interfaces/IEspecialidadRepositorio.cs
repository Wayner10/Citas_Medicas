using CitasMedicas.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CitasMedicas.Repositorio.Interfaces
{
    public interface IEspecialidadRepositorio
    {
        Task<List<Especialidad>> Listar();
    }
}
