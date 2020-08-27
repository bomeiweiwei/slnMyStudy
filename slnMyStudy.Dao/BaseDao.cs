using LinqKit;
using slnMyStudy.Common;
using slnMyStudy.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Linq.Expressions;

namespace slnMyStudy.Dao
{
    public class BaseDao<T> where T : class, new()
    {
        public BaseDao(DBEntity entity)
        {
            this.GetData = new BaseDataOperation(entity);
        }
        public BaseDao(string EntitiesName)
        {
            this.GetData = new BaseDataOperation(EntitiesName);
        }

        public IDataOperation<T> GetData { get; } = null;

        public class BaseDataOperation : IDataOperation<T>
        {
            private readonly DbContext db;
            /// <summary>
            /// 設定DB
            /// </summary>
            /// <param name="entity">列舉值</param>
            public BaseDataOperation(DBEntity entity)
            {
                if (entity == DBEntity.NorthWind)
                {
                    db = new NorthwindEntities();
                }
                else if (entity == DBEntity.test)
                {
                    db = new testEntities();
                }
                else if (entity == DBEntity.tMember)
                {
                    db = new tMemberEntities();
                }
                else if (entity == DBEntity.ApiRecord)
                {
                    db = new ApiRecordEntities();
                }
            }
            /// <summary>
            /// 設定DB
            /// </summary>
            /// <param name="EntitiesName">字串</param>
            public BaseDataOperation(string EntitiesName)
            {
                if (EntitiesName == "NorthWindEntities")
                {
                    db = new NorthwindEntities();
                }
                else if (EntitiesName == "testEntities")
                {
                    db = new testEntities();
                }
                else if(EntitiesName == "tMemberEntities")
                {
                    db = new tMemberEntities();
                }
                else if (EntitiesName == "ApiRecordEntities")
                {
                    db = new ApiRecordEntities();
                }
            }
            /// <summary>
            /// 取得資料
            /// </summary>
            /// <param name="whereLambda"></param>
            /// <returns></returns>
            public IQueryable<T> Get(Expression<Func<T, bool>> whereLambda)
            {
                return db.Set<T>().AsExpandable().Where(whereLambda);
            }
            /// <summary>
            /// 取得單一資料
            /// </summary>
            /// <param name="whereLambda"></param>
            /// <returns></returns>
            public T FindOne(Expression<Func<T, bool>> whereLambda)
            {
                return db.Set<T>().AsExpandable().Where(whereLambda).FirstOrDefault();
            }
            /// <summary>
            /// 取得所有資料
            /// </summary>
            /// <returns></returns>
            public IQueryable<T> GetAll()
            {
                return db.Set<T>();
            }
            /// <summary>
            /// 新增資料
            /// </summary>
            /// <param name="Item"></param>
            /// <returns></returns>
            public int Create(T Item)
            {
                try
                {
                    db.Set<T>().Add(Item);
                    return db.SaveChanges();
                }
                catch (DbEntityValidationException)
                {
                    throw;
                }
                catch (DbUpdateException)
                {
                    throw;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            /// <summary>
            /// 更新資料
            /// </summary>
            /// <param name="Item"></param>
            /// <returns></returns>
            public int Update(T Item)
            {
                try
                {
                    db.Entry(Item).State = EntityState.Modified;
                    return db.SaveChanges();
                }
                catch (DbEntityValidationException)
                {
                    throw;
                }
                catch (DbUpdateException)
                {
                    throw;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            /// <summary>
            /// 刪除資料
            /// </summary>
            /// <param name="Item"></param>
            /// <returns></returns>
            public int Delete(T Item)
            {
                try
                {
                    db.Set<T>().Remove(Item);
                    return db.SaveChanges();
                }
                catch (DbEntityValidationException)
                {
                    throw;
                }
                catch (DbUpdateException)
                {
                    throw;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            /// <summary>
            /// 
            /// </summary>
            public void Dispose()
            {
                if (db != null)
                {
                    db.Dispose();
                }
            }           
        }
    }
}
