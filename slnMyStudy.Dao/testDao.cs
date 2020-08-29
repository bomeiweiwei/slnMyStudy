using slnMyStudy.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnMyStudy.Dao
{
    public class TestDao
    {
        public int UpdateData(test data, testEntities entity)
        {
            int success = 0;
            //entity需一樣，所以移除
            //testEntities entity = (testEntities)base.GetCurrentContext();
            var entry = entity.Entry(data);

            if (entry.State == EntityState.Detached)
            {
                var set = entity.Set<test>();
                test attachedEntity = set.Find(data.id);

                if (attachedEntity != null)
                {
                    var attachedEntry = entity.Entry(attachedEntity);
                    attachedEntry.CurrentValues.SetValues(data);
                }
                else
                {
                    entry.State = EntityState.Modified;
                }
            }

            success = entity.SaveChanges();
            return success;
        }
    }
}
