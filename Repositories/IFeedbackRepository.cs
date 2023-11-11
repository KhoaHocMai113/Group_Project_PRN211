using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IFeedbackRepository
    {
        List<Feedback> GetFeedbacks();
        Feedback GetFeedbackById(int Id);
        List<Feedback> GetFeedbackByStatus(int status);
        List<Feedback> GetFeedbackByDay(DateTime day);
        List<Feedback> GetFeedbackBySender(int id);
        void SaveFeedback(Feedback fb);
        void UpdateFeedback(Feedback fb);
        void RemoveFeedback(Feedback fb);

    }
}
