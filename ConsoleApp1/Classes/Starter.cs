using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_1.Classes
{
    public class Starter
    {
        private Action _action;

        public Starter()
        {
            _action = new Action();
        }

        public void Run()
        {
            int num = 0;
            var rand = new Random();
            for (int i = 0; i < 100; i++)
            {
               num = rand.Next(1, 4);
               switch ((StatusEnum)num)
                {
                    case StatusEnum.Info:
                        _action.StartMethod();
                        break;
                    case StatusEnum.Warning:
                        _action.SkippedLogicInMethod();
                        break;
                    case StatusEnum.Error:
                        _action.BrokenLogic();
                        break;
                    default: break;
                }
            }
        }
    }
}
