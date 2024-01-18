
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class DataEnum
    {
        public enum AccessLevelEnum
        {
            FullAccess=1,
            ControlAccess=2,
            ViewAccess=3
        };
        public enum SystemViewEnum
        {
            Home=1,
            SystemView=2,
            SystemUser=3,
        };
        public enum GenderEnum
        {
            Male=1,
            Female=2,
        }
    }
}
