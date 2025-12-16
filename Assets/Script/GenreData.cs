using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "New Genre", menuName = "Game/Genre")]
public class GenreData : ScriptableObject
{
    public string genreName;

    [System.Serializable]
    public class AgeRatingScore
    {
        public AgeRating rating;
        public int score;
    }

    public List<AgeRatingScore> ageRatingScores = new List<AgeRatingScore>();

    public int basePopularity;
    public float marketTrend;

    public int GetScoreForRating(AgeRating rating)
    {
        var entry = ageRatingScores.Find(x => x.rating == rating);
        return entry != null ? entry.score : 0;
    }
}

public enum AgeRating
{
    Everyone,
    Teen,
    Mature,
    AdultsOnly
}