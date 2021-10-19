using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Op2_ver._2.Data
{
    public interface IRepository<T>
    {
        //ONLY CRUD HERE

        Task<List<T>> ViewAllAsync();

        Task<T> AddAsync(T prod);

        Task<T> DeleteAsync(T prod);

        void Update(T prod);
    }
}
