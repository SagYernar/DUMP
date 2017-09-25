using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem
{
    public class StatisticsOfUser:TaskBase
    {
        public List<TaskBase> CurrentTasks { get; set; }
        User user = new User();
        private int countOfTasks = 0;
        public void ShowStatistics()
        {
            for(int i = 0; i < CurrentTasks.Capacity; i++)
            {
                if (IsDone)
                {
                    countOfTasks++;
                }
            }
        }
    }
}
