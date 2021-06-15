using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SmartMarket.Interfaces
{
    public interface IDao<T> where T : class
    {
        void Crear(T t);
        int Actualizar(T t);
        bool Eliminar(T t);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<bool>> where);

    }
}
