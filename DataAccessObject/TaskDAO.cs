using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class TaskDAO
    {
        private static TaskDAO instance = null;
        public static readonly object Lock = new object();
        private TaskDAO() { }
        public static TaskDAO Instance
        {
            get
            {
                lock (Lock)
                {
                    if (instance == null)
                    {
                        instance = new TaskDAO();
                    }
                    return instance;
                }
            }
        }
        public List<TaskFb> GetTasks()
        {
            using var db = new FeedbackFacilitiesDBContext();
            return db.TaskFbs.ToList();
        }
        public List<TaskFb> GetTaskByStaffId(int staffId)
        {
            var tmp = GetTasks().FindAll(m => m.StaffId.Equals(staffId));
            return tmp;
        }
        public void SaveTask(TaskFb task)
        {
            using var db = new FeedbackFacilitiesDBContext();
            db.TaskFbs.Add(task);
            db.SaveChanges();
        }
        public void UpdateTask(TaskFb task)
        {
            using var db = new FeedbackFacilitiesDBContext();
            db.TaskFbs.Update(task);
            db.SaveChanges();
        }
        public void RemoveTask(TaskFb task)
        {
            using var db = new FeedbackFacilitiesDBContext();
            var tmp = db.TaskFbs.SingleOrDefault(m => m.Id == task.Id);
            db.TaskFbs.Remove(tmp);
            db.SaveChanges();
        }
    }
}
