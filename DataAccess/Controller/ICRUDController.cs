using System.Collections.Generic;

namespace DataAccess.Controller
{
    interface ICRUDController <T>
    {
        T Load(int id);
        bool Save(T t);

        bool Update(T t);

        bool Delete(int id);
        bool Delete(List<int> idList);

        List<T> LoadAll(int start, int count, bool asc);
    }
}
