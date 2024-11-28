using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoCrud.DAL.Repositories;
using ProyectoCrud.Models;

namespace ProyectoCrud.BLL.Service
{
    public class ContactoService : IContactoService
    {
        private readonly IGenericRepository<Contacto> _contactRepo;
        public ContactoService(IGenericRepository<Contacto> contactRepo)
        {
            _contactRepo = contactRepo;          
        }

        public async Task<bool> Actualizar(Contacto modelo)
        {
            return await _contactRepo.Actualizar(modelo);
        }

        public async Task<bool> Eliminar(int id)
        {
            return await _contactRepo.Eliminar(id);
        }

        public async Task<bool> Insertar(Contacto modelo)
        {
            return await _contactRepo.Insertar(modelo);
        }

        public async Task<IQueryable<Contacto>> ObtenerTodos()
        {
            return await _contactRepo.ObtenerTodos();
        }

        public async Task<Contacto> Obtener(int id)
        {
            return await _contactRepo.Obtener(id);
        }

        public async Task<Contacto> ObtenerPorNombre(string nombreContacto)
        {
            IQueryable<Contacto> queryConctactoSQL = await _contactRepo.ObtenerTodos();
            Contacto contacto = queryConctactoSQL.Where(c => c.Nombre == nombreContacto).FirstOrDefault();
            return contacto;
        }
    }
}
