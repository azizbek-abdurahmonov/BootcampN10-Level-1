using N22_HT2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace N22_HT2.Models
{
    internal class ReviewList<TReview> : IReviewList<TReview> where TReview : IReview
    {
        private List<TReview> _reviews = new();


        public void Add(TReview item)
        {
            _reviews.Add(item);
        }

        public void GetOverallReview()
        {
            if (!_reviews.Any())
            {
                Console.WriteLine("Be the first leave a review for this product");
                return;
            }
            
            if (_reviews.All(review => review.Star == 5))
            {
                Console.WriteLine("Great News! All reviews for this product are 5 star raitings");
                return;
            }

            var review = _reviews.FirstOrDefault(review => review.Star == 1);
            if (review != null)
            {
                Console.WriteLine(review.Message);
            }
        }

        public TReview? GetReview(Guid id)
        {
            return _reviews.Find(review => review.Id == id);
        }

        public TReview? GetReview(string message)
        {
            return _reviews.Find(review => review.Message == message);
        }

        public void Remove(Guid id)
        {
            _reviews.Remove(_reviews.FirstOrDefault(review => review.Id == id));
        }

        public void Remove(TReview item)
        {
            _reviews.Remove(item);
        }

        public void Update(Guid id, int star, string message)
        {
            var review = _reviews.First(review => review.Id == id);
            review.Star = star;
            review.Message = message;
        }
    }
}