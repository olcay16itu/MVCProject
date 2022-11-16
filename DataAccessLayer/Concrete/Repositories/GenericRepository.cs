﻿using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        MContext _context = new MContext();
        DbSet<T> _object;
        public GenericRepository()
        {
            _object=_context.Set<T>();
        }
        public void Delete(T _obj)
        {
            _object.Remove(_obj);
            _context.SaveChanges();
        }

        public void Insert(T _obj)
        {
            _object.Add(_obj);
            _context.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T _obj)
        {
            _context.SaveChanges();
        }
    }
}
