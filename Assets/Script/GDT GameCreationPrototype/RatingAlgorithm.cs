using UnityEngine;

public class RatingAlgorithm : MonoBehaviour
{
    public GenreData genreData;
    public AgeRating selectedRating;

    private int AgeRatingPoint;
    private int GenreMaxPoint;
    private int BonusMrkTrdPoint;

    //Converts button data to a selected age rating
    public void SelectRating(string ratingStr)
    {
        switch (ratingStr)
        {
            case "e":
                selectedRating = AgeRating.Everyone;
                break;
            case "t":
                selectedRating = AgeRating.Teen;
                break;
            case "m":
                selectedRating = AgeRating.Mature;
                break;
        }
    }

    public int ScoreAlgorithm(GenreData genre)
    {
        //Decides what rating to yoink points from
        switch (selectedRating)
        {
            case AgeRating.Everyone:
                AgeRatingPoint = genre.ERatePoint;
                break;
            case AgeRating.Teen:
                AgeRatingPoint = genre.TRatePoint;
                break;
            case AgeRating.Mature:
                AgeRatingPoint = genre.MRatePoint;
                break;
        }
        // Yoinks max points from the genre
        GenreMaxPoint = genre.MaxPoint;
        //Gets market Trend
        //Insert market trend code im too lazy rn

        //Don't forget to finish market trend code!!!

        //Algorithm Calculation (so far)
        int totalPoints = AgeRatingPoint + BonusMrkTrdPoint;
        int CalculatedRating = totalPoints / GenreMaxPoint;

        //Converts point into a rating out of 10
        int RatingOutOf10 = 0;
        if (CalculatedRating >= 0 && CalculatedRating < 0.09f) { RatingOutOf10 = 0; }
        else if (CalculatedRating >= 0.1f && CalculatedRating < 0.19f) { RatingOutOf10 = 1; }
        else if (CalculatedRating >= 0.2f && CalculatedRating < 0.29f) { RatingOutOf10 = 2; }
        else if (CalculatedRating >= 0.3f && CalculatedRating < 0.39f) { RatingOutOf10 = 3; }
        else if (CalculatedRating >= 0.4f && CalculatedRating < 0.49f) { RatingOutOf10 = 4; }
        else if (CalculatedRating >= 0.5f && CalculatedRating < 0.59f) { RatingOutOf10 = 5; }
        else if (CalculatedRating >= 0.6f && CalculatedRating < 0.69f) { RatingOutOf10 = 6; }
        else if (CalculatedRating >= 0.7f && CalculatedRating < 0.79f) { RatingOutOf10 = 7; }
        else if (CalculatedRating >= 0.8f && CalculatedRating < 0.89f) { RatingOutOf10 = 8; }
        else if (CalculatedRating >= 0.9f && CalculatedRating < 0.99f) { RatingOutOf10 = 9; }
        else if (CalculatedRating >= 1f) { RatingOutOf10 = 10; }

        return RatingOutOf10;
    }
}
