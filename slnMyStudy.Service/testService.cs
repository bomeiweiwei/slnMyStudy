using slnMyStudy.Common;
using slnMyStudy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnMyStudy.Service
{
    public class testService : BaseService<test>
    {
        public testService() : base(DBEntity.test)
        {
        }
    }
}
