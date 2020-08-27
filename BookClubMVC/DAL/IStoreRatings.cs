using System;
using System.Collections.Generic;

using BookClubMVC.Models;


namespace BookClubMVC.DAL
{


    public interface IStoreRatings
    {

        void CreateRating(Ratings ratingToCreate);

        void UpdateRating(Ratings ratingToUpdate);

        void DeleteRating(Guid Id);

    }


}