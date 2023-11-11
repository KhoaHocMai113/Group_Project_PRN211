using BusinessObject;
using DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class TaskRepository : ITaskRepository
    {
        public List<TaskFb> GetTasks() => TaskDAO.Instance.GetTasks();
        public List<TaskFb> GetTaskByStaffId(int staffId) => TaskDAO.Instance.GetTaskByStaffId(staffId);
        public void SaveTask(TaskFb task) => TaskDAO.Instance.SaveTask(task);
        public void UpdateTask(TaskFb task) => TaskDAO.Instance.UpdateTask(task);
        public void RemoveTask(TaskFb task) => TaskDAO.Instance.RemoveTask(task);
    }
}
