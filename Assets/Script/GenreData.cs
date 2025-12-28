using NUnit.Framework;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "New Genre", menuName = "Genre/New Genre")]
public class GenreData : ScriptableObject
{
    public string GenreName;

    [Header("Age Rating Points")]
    public int ERatePoint;
    public int TRatePoint;
    public int MRatePoint;

    [Header("Max Point")]
    public int MaxPoint;
}

public enum AgeRating
{
    Everyone,
    Teen,
    Mature
}
