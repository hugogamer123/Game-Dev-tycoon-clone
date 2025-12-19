using NUnit.Framework;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "New Genre", menuName = "Genre/New Genre")]
public class GenreData : ScriptableObject
{
    [System.Serializable]
    public class Genre
    {
        public string Name;
    }
    [System.Serializable]
    public class AgeRatingStuff
    {
        public AgeRating agerating;
        public int score;
    }
    [Header("Genre Name")]
    public Genre genre;
    [Header("Ratings and their scores")]
    public List<AgeRatingStuff> ratingList = new List<AgeRatingStuff>();
}

public enum AgeRating
{
    Everyone,
    Teen,
    Mature
}
