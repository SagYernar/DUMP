using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem
{
    //Автоматическая задача. Всегда отправляется как запрос директору
    public class TaskAutomatic : TaskBase
    {
        //Начало отчета периодности создания задачи
        public int ReCreationTime { get; set; }
    }
}
