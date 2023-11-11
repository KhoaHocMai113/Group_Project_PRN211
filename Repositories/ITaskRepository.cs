using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ITaskRepository
    {
        List<TaskFb> GetTasks();
        List<TaskFb> GetTaskByStaffId(int staffId);
        void SaveTask(TaskFb task);
        void UpdateTask(TaskFb task);
        void RemoveTask(TaskFb task);

    }
}
