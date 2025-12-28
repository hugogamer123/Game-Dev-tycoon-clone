using NUnit.Framework.Interfaces;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class GenreDropdown : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] private TMP_Dropdown genreDropdown;
    
    [Header("Genres")]
    [SerializeField] private List<GenreData> genres;

    [Header("Selected Genre")]
    [SerializeField] private GenreData selectedGenre;

    private void Start()
    {
        PopulateDropdown();
        genreDropdown.onValueChanged.AddListener(OnGenreSelected);
    }

    void PopulateDropdown()
    {
        genreDropdown.ClearOptions();
        genreDropdown.AddOptions(genres.Select(g => g.GenreName).ToList());
    }

    void OnGenreSelected(int index)
    {
        selectedGenre = genres[index];

        Debug.Log("Selected Genre: " + selectedGenre.GenreName);
        Debug.Log("Max Points: " + selectedGenre.MaxPoint);
    }
}
