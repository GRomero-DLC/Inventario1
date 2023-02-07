using Inventario.COMMON.Entidades;
using Inventario.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.DAL
{
    public class RepositorioDeTrabajadores : IRepositorio<Trabajador>
    {
        //Base de datos NoSQL: Orientada a Documentos -> LiteDB
        public List<Trabajador> Read => throw new NotImplementedException();

        public bool Create(Trabajador entidad)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Trabajador entidad)
        {
            throw new NotImplementedException();
        }

        public bool Update(Trabajador entidadOriginal, Trabajador entidadModificada)
        {
            throw new NotImplementedException();
        }
    }
}
