using CreditService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditService.Domain.Interfaces
{
    public interface ICreditRepository<TEntity> where TEntity : BaseEntity
    {
        void Insert(TEntity obj);

        void Update(TEntity obj);

        void Delete(int id);

        IList<TEntity> Select();

        TEntity Select(int id);
    }
}
