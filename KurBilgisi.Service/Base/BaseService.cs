using KurBilgisi.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurBilgisi.Service.Base
{
    public abstract class BaseService<T, TId> : IBaseService<T, TId>
    {
        public T Create(T entity)
        {
            throw new NotImplementedException();
        }

        public ICollection<T> Find()
        {
            throw new NotImplementedException();
        }

        public T FindById(TId id)
        {
            throw new NotImplementedException();
        }
    }
}
