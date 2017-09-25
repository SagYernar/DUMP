using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem
{
    //задача или запрос автоматически распределяющаяся
    public class TaskStandart : TaskBase
    {
        //задача или запрос
        public bool IsReady { get; set; }

        public TaskStandart()
        {
            IsReady = false;
        }
    }
}
