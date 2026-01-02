using TMPro;
using UnityEngine;

public class RatingAlgorithm : MonoBehaviour
{
    public GenreData genreData;
    public AgeRating selectedRating;
    public GenreDropdown genredropdown;
    private float score;

    private float AgeRatingPoint;
    private float GenreMaxPoint;
    private float BonusMrkTrdPoint;

    //For Rating UI
    public TextMeshProUGUI ratingText;
    public TextMeshProUGUI AgeRatingText;

    public GameObject ratingDisplay;

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

        //Random Point increase/decrease for more randomness
        float RandomPointChange = Random.Range(-5, 5);

        //Algorithm Calculation (so far)
        float totalPoints = AgeRatingPoint + BonusMrkTrdPoint + RandomPointChange;
        float CalculatedRating = totalPoints / GenreMaxPoint;



        //Converts point into a rating out of 10
        int RatingOutOf10 = 0;
        if (CalculatedRating < 0.09f) { RatingOutOf10 = 0; }
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

        //Bunch of Debug Logs for testing
        Debug.LogWarning($"Genre: {genredropdown.selectedGenre.GenreName}");
        Debug.Log($"Age Rating: {selectedRating}");
        Debug.Log($"Age Rating Points: {AgeRatingPoint}");
        Debug.Log($"Genre Max Points: {GenreMaxPoint}");
        Debug.Log($"Random Point Change: {RandomPointChange}");
        Debug.Log($"Total Points: {totalPoints}");
        Debug.Log($"Calculated Rating (decimal): {CalculatedRating}");
        Debug.Log($"Final Rating (out of 10): {RatingOutOf10}");
        return RatingOutOf10;
    }

    private void Update()
    {
        AgeRatingText.text = $"Rating : {selectedRating}";
    }

    private void RevealRating()
    {
        ratingDisplay.gameObject.SetActive(true);
        ratingText.text = $"Game Rating : {score}/10";
    }

    public void HideRating()
    {
        ratingDisplay.gameObject.SetActive(false);
    }

    public void StartAlgorithm()
    {
        score = ScoreAlgorithm(genredropdown.selectedGenre);
        RevealRating();
    }

    private void Start()
    {
        HideRating();
    }
}
