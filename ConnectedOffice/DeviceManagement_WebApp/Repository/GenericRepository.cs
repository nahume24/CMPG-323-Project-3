﻿using DeviceManagement_WebApp.Data;
using System;
using DeviceManagement_WebApp.Models;
using DeviceManagement_WebApp.Repository;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DeviceManagement_WebApp.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly ConnectedOfficeContext _context;

        public GenericRepository(ConnectedOfficeContext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }
        public void AddRange(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange(entities);
        }
        public IEnumerable<T> Find(Expression<Func<T,bool>> expression)
        {
            return _context.Set<T>().Where(expression);
        }
        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }
        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }
        public T GetById(Guid? id)
        {
            return _context.Set<T>().Find(id);
        }
        public void Remove (T entity)
        {
            _context.Set<T>().Remove(entity);
        }
        public void RemoveRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }
        
        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
