using BusinessObject;
using DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class FeedbackRepository : IFeedbackRepository
    {
        public List<Feedback> GetFeedbacks() => FeedbackDAO.Instance.GetFeedbacks();
        public Feedback GetFeedbackById(int Id) => FeedbackDAO.Instance.GetFeedbackById(Id);
        public List<Feedback> GetFeedbackByStatus(int status) => FeedbackDAO.Instance.GetFeedbackByStatus(status);
        public List<Feedback> GetFeedbackByDay(DateTime day) => FeedbackDAO.Instance.GetFeedbackByDay(day);
        public List<Feedback> GetFeedbackBySender(int id) => FeedbackDAO.Instance.GetFeedbackBySender(id);
        public void SaveFeedback(Feedback fb) => FeedbackDAO.Instance.SaveFeedback(fb);
        public void UpdateFeedback(Feedback fb) => FeedbackDAO.Instance.UpdateFeedback(fb);
        public void RemoveFeedback(Feedback fb) => FeedbackDAO.Instance.RemoveFeedback(fb);
    }
}
