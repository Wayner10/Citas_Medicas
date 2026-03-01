using CitasMedicas.Business.Interfaces;
using CitasMedicas.DTO.Response.Doctor;
using CitasMedicas.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CitasMedicas.Business.Implementaciones
{
    public class DoctorNegocio : IDoctorNegocio
    {
        private IDoctorRepositorio _repositorio;
        public DoctorNegocio(IDoctorRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
        public async Task< List<DoctorResponse>> Listar()
        {
            var lista = await _repositorio.Listar();
            return lista.Select(p=>new DoctorResponse { 
                DoctorId = p.DoctorId,
                Nombre = p.Nombre
            }).ToList();
        }
    }
}
