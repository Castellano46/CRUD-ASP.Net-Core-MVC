using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoCrud.Models;

namespace ProyectoCrud.BLL.Service
{
    public interface IContactoService
    {
        Task<bool> Insertar(Contacto modelo);

        Task<bool> Actualizar(Contacto modelo);

        Task<bool> Eliminar(int id);

        Task<Contacto> Obtener(int id);

        Task<IQueryable<Contacto>> ObtenerTodos();


        Task<Contacto> ObtenerPorNombre(string nombreContacto);

    }
}
