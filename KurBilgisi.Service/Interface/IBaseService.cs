using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurBilgisi.Service.Interface
{
    public interface IBaseService<T,TIdType>
    {
        ICollection<T> Find();
        T FindById(TIdType id);
        T Create(T entity);
    }
}
