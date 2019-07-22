using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BsvService.Core.Models;

namespace BsvService.DAL.Repositories
{
    public interface IRepoBase<T> where T :BaseModel
    {
        T Get(int id);
        IEnumerable<T> GetList(Expression<Func<T, bool>> filter = null);
        void Insert(IEnumerable<T> userProfileList);
        void Insert(T userProfile);
        void Update(T userProfile);

    }
}
