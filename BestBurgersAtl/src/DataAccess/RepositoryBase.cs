using System;
using System.Collections.Generic;

namespace DataAccess
{
    public abstract class LookupRepositoryBase<TReturnType> : ILookupReposiotry<TReturnType>
    {
        private ILookupReposiotry<TReturnType> _thisRepo;

        public LookupRepositoryBase(ILookupReposiotry<TReturnType> lookupRepo)
        {
            _thisRepo = lookupRepo;
        }

        public virtual IEnumerable<TReturnType> GetAll()
        {
           return _thisRepo.GetAll();
        }

        public virtual TReturnType FindById(int id)
        {
            return _thisRepo.FindById(id);
        }
    }

    public interface ILookupReposiotry<TReturnType>
    {
        IEnumerable<TReturnType> GetAll();
        TReturnType FindById(int id);
    }

    public abstract class RepositoryBase<TReturnType> : IRepository<TReturnType>
    {
        public virtual TReturnType Add()
        {
            throw new NotImplementedException();
        }

        public virtual TReturnType Update()
        {
            throw new NotImplementedException();
        }

        public virtual void Delete()
        {
            throw new NotImplementedException();
        }
    }

    public interface IRepository<TReturnType>
    {
        TReturnType Add();
        TReturnType Update();
        void Delete();
    }
}
