using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Services
{
    public interface IUserService
    {
        // Implementation for Purchases
        Task<bool> PurchaseMovie(PurchaseRequestModel purchaseRequest, int userId);
        Task<bool> IsMoviePurchased(PurchaseRequestModel purchaseRequest, int userId);
        Task<List <PurchasesForUserModel>> GetAllPurchasesForUser(int id);
        Task<IEnumerable <PurchasesDetailsModel>> GetPurchasesDetails(int userId, int movieId);

        // Implementation for Favorites
        Task<bool> AddFavorite(FavoriteRequestModel favoriteRequest);
        Task<bool> RemoveFavorite(FavoriteRequestModel favoriteRequest);
        Task<bool> FavoriteExists(int id, int movieId);
        Task<List <GetAllFavoritesModel>> GetAllFavoritesForUser(int id);

        // Implementation for Reviews
        Task<bool> AddMovieReview(ReviewRequestModel reviewRequest);
        Task<bool> UpdateMovieReview(ReviewRequestModel reviewRequest);
        Task<bool> DeleteMovieReview(int userId, int movieId);
        Task<IEnumerable <GetAllReviewsModel>> GetAllReviewsByUser(int id);
    }
}
