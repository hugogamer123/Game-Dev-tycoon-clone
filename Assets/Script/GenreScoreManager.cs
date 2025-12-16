using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class GenreScoreManager : MonoBehaviour
{
    [SerializeField] private List<GenreData> availableGenres;

    private GenreData selectedGenre;
    private AgeRating selectedRating;
    private int currentScore;

    public void SelectGenre(GenreData genre)
    {
        selectedGenre = genre;
        CalculateScore();
    }

    public void SelectAgeRating(AgeRating rating)
    {
        selectedRating = rating;
        CalculateScore();
    }

    public void CalculateScore()
    {
        if (selectedGenre == null) return;

        currentScore = selectedGenre.GetScoreForRating(selectedRating);
    }

    public int GetCurrentScore() => currentScore;

    public void ScoreGen(int point, int score)
    {

    }
}
