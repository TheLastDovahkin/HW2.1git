using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_1.Classes
{
    public class Action
    {
        public void StartMethod()
        {
            var logger = Logger.GetLogger();
            logger.Info();
        }

        public void SkippedLogicInMethod()
        {
            var logger = Logger.GetLogger();
            logger.Warning();
        }

        public void BrokenLogic()
        {
            var logger = Logger.GetLogger();
            logger.Error();
        }
    }
}