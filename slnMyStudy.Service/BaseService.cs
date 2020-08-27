using slnMyStudy.Common;
using slnMyStudy.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace slnMyStudy.Service
{
    public class BaseService<T> where T : class, new()
    {       
        private BaseDao<T> serviceModel;
        public BaseService(DBEntity entity)
        {
            this.serviceModel = new BaseDao<T>(entity);
        }
        public BaseService(string EntitiesName)
        {
            this.serviceModel = new BaseDao<T>(EntitiesName);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="whereLambda"></param>
        /// <returns></returns>
        public IQueryable<T> Get(Expression<Func<T, bool>> whereLambda)
        {
            return serviceModel.GetData.Get(whereLambda);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="whereLambda"></param>
        /// <returns></returns>
        public T FindOne(Expression<Func<T, bool>> whereLambda)
        {
            return serviceModel.GetData.FindOne(whereLambda);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IQueryable<T> GetAll()
        {
            return serviceModel.GetData.GetAll();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Item"></param>
        /// <returns></returns>
        public int Create(T Item)
        {
            return serviceModel.GetData.Create(Item);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Item"></param>
        /// <returns></returns>
        public int Update(T Item)
        {
            return serviceModel.GetData.Update(Item);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Item"></param>
        /// <returns></returns>
        public int Delete(T Item)
        {
            return serviceModel.GetData.Delete(Item);
        }

        public void Dispose()
        {
            serviceModel.GetData.Dispose();
        }
    }
}
