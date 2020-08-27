using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnMyStudy.Common
{
    public enum DBEntity
    {
        NorthWind = 0,
        test = 1,
        tMember = 2,
        ApiRecord = 3
    }
    public static class ExtendEnum
    {
        public static int ToInt(this System.Enum e)
        {
            return e.GetHashCode();
        }
    }
}
