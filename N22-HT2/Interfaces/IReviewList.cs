using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N22_HT2.Interfaces
{
    internal interface IReviewList<TReview> where TReview : IReview
    {
        void Add(TReview item);
        void Update(Guid id, int star, string message);
        void Remove(Guid id);
        void Remove(TReview item);
        TReview GetReview(Guid id);
        TReview GetReview(string message);
        void GetOverallReview();
    }
}
