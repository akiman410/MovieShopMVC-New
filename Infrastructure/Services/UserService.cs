using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Enities;
using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IPurchaseRepository _purchaseRepository;
        private readonly IUserRepository _userRepository;
        private readonly IFavoriteRepository _favoriteRepository;
        private readonly IReviewRepository _reviewRepository;



        public UserService(IPurchaseRepository purchaseRepository)
        {
            _purchaseRepository = purchaseRepository;
        }
        public UserService(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }

        public UserService(IFavoriteRepository favoriteRepository)
        {
            _favoriteRepository = favoriteRepository;
        }

        // Purchases 

        public Task<IEnumerable<PurchasesDetailsModel>> GetPurchasesDetails(int userId, int movieId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsMoviePurchased(PurchaseRequestModel purchaseRequest, int userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PurchaseMovie(PurchaseRequestModel purchaseRequestModel, int userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<PurchasesForUserModel>> GetAllPurchasesForUser(int id)
        {
            throw new NotImplementedException();
        }

        //Favorites

        public Task<bool> AddFavorite(FavoriteRequestModel favoriteRequest)
        {
            throw new NotImplementedException();
        }
        public Task<bool> FavoriteExists(int id, int movieId)
        {
            throw new NotImplementedException();
        }
        public Task<List<GetAllFavoritesModel>> GetAllFavoritesForUser(int id)
        {
            throw new NotImplementedException();
        }
        public Task<bool> RemoveFavorite(FavoriteRequestModel favoriteRequest)
        {
            throw new NotImplementedException();
        }

        //Reviews
        public Task<bool> AddMovieReview(ReviewRequestModel reviewRequest)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteMovieReview(int userId, int movieId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<GetAllReviewsModel>> GetAllReviewsByUser(int id)
        {
            throw new NotImplementedException();
        }
        public Task<bool> UpdateMovieReview(ReviewRequestModel reviewRequest)
        {
            throw new NotImplementedException();
        }
    }
}
