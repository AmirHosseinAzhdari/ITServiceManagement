using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ITServiceManagement.DataLayer.Repositories
{
    public class CommonGenericRepository<TEntity> where TEntity : class
    {
        private ITServiceManagement_DBEntities _db;
        private DbSet<TEntity> _dbSet;
        public CommonGenericRepository(ITServiceManagement_DBEntities context)
        {
            _db = context;
            _dbSet = context.Set<TEntity>();
        }

        /// <summary>
        /// For get all records of a table with condition , order and includes
        /// </summary>
        /// <param name="where"></param>
        /// <param name="orderBy"></param>
        /// <param name="includes"> names of relations (split with '-') </param>
        /// <returns></returns>
        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> where = null
            , Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includes = "")
        {
            IQueryable<TEntity> query = _dbSet;

            if (where != null)
            {
                query = query.Where(where);
            }

            if (orderBy != null)
            {
                query = orderBy(query);
            }

            if (includes != "")
            {
                foreach (var include in includes.Split('-'))
                {
                    query = query.Include(include);
                }
            }

            return query.ToList();
        }

        /// <summary>
        /// get a record from any table
        /// </summary>
        /// <param name="id"> unique identifier </param>
        /// <returns></returns>
        public virtual TEntity Get(object id)
        {
            return _dbSet.Find(id);
        }

        /// <summary>
        /// Insert any record of entities to database
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual bool Insert(TEntity entity)
        {
            try
            {
                _dbSet.Add(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Update any record of entities exist in database
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual bool Update(TEntity entity)
        {
            try
            {
                _dbSet.Attach(entity);
                _db.Entry(entity).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Delete any record of entities exist in database
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual bool Delete(TEntity entity)
        {
            try
            {
                if (_db.Entry(entity).State == EntityState.Detached)
                {
                    _dbSet.Attach(entity);
                }
                _dbSet.Remove(entity);

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Delete any record of entities exist in database
        /// </summary>
        /// <param name="entity"> unigue identifier </param>
        /// <returns></returns>
        public virtual bool Delete(object id)
        {
            try
            {
                var entity = Get(id);
                Delete(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public virtual void Save()
        {
            _db.SaveChanges();
        }
    }
}
