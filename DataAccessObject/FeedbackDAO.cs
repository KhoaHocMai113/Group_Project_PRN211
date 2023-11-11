using BusinessObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class FeedbackDAO
    {
        private static FeedbackDAO instance = null;
        public static readonly object Lock = new object();
        private FeedbackDAO() { }
        public static FeedbackDAO Instance
        {
            get
            {
                lock (Lock)
                {
                    if (instance == null)
                    {
                        instance = new FeedbackDAO();
                    }
                    return instance;
                }
            }
        }
        public List<Feedback> GetFeedbacks()
        {
            using var db = new FeedbackFacilitiesDBContext();
            return db.Feedbacks
                .Include(m => m.Device)
                .Include(m => m.SenderNavigation)
                .ToList();
        }
        public Feedback GetFeedbackById(int Id)
        {
            var tmp = GetFeedbacks().SingleOrDefault(m => m.Id == Id);
            return tmp;
        }
        public List<Feedback> GetFeedbackByStatus(int status)
        {
            var tmp = GetFeedbacks().FindAll(m => m.Status == status);
            return tmp;
        }
        public List<Feedback> GetFeedbackByDay(DateTime day)
        {
            var tmp = GetFeedbacks().FindAll(m => m.Day == day);
            return tmp;
        }
        public List<Feedback> GetFeedbackBySender(int id)
        {
            var tmp = GetFeedbacks().FindAll(m => m.Sender == id);
            return tmp;
        }
        public void SaveFeedback(Feedback fb)
        {
            using var db = new FeedbackFacilitiesDBContext();
            db.Feedbacks.Add(fb);
            db.SaveChanges();
        }
        public void UpdateFeedback(Feedback fb)
        {
            using var db = new FeedbackFacilitiesDBContext();
            db.Feedbacks.Update(fb);
            db.SaveChanges();
        }
        public void RemoveFeedback(Feedback fb)
        {
            using var db = new FeedbackFacilitiesDBContext();
            var tmp = db.Feedbacks.SingleOrDefault(m => m.Id == fb.Id);
            db.Feedbacks.Remove(tmp);
            db.SaveChanges();
        }
    }
}
