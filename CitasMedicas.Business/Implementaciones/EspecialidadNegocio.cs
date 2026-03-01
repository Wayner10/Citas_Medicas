using CitasMedicas.Business.Interfaces;
using CitasMedicas.DTO.Response.Doctor;
using CitasMedicas.DTO.Response.Especialidad;
using CitasMedicas.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CitasMedicas.Business.Implementaciones
{
    public class EspecialidadNegocio : IEspecialidadNegocio
    {
        IEspecialidadRepositorio _repositorio;
        public EspecialidadNegocio(IEspecialidadRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
        public async Task<List<EspecialidadResponse>> Listar()
        {
            var lista = await _repositorio.Listar();
            return lista.Select(p => new EspecialidadResponse
            {   
                EspecialidadId = p.EspecialidadId,
                Nombre = p.Nombre
            }).ToList();
        }
    }
}
