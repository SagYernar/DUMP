using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem
{
    //Висящая задача, которую необходимо подобрать
    public class TaskSelectable : TaskBase
    {
        //Взята ли кем то данная задача
        public bool IsSelected { get; set; }

        public TaskSelectable()
        {
            IsSelected = false;
        }
    }
}
