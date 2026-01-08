using UnityEngine;
using TMPro;

namespace HMC.MarketTrend
{
    public class MarketTrend : MonoBehaviour
    {
        public AgeRating ageRating;
        public GenreDropdown genreDropdown;
        [SerializeField] private TextMeshProUGUI marketTrendText;


        /* Currently for beta reasons the trend will update
         when the menu is opened, however normally it should
         change based on in game timer.*/

        public void UpdateMarketTrend()
        {
            //This is to get a market trend on ageratings
            
            int randomTrend = Random.Range(0, 2);
            switch (randomTrend)
            {
                case 0:
                    ageRating = AgeRating.Everyone;
                    Debug.Log("Market Trend Updated: Everyone");
                    break;
                case 1:
                    ageRating = AgeRating.Teen;
                    Debug.Log("Market Trend Updated: Teen");
                    break;
                case 2:
                    ageRating = AgeRating.Mature;
                    Debug.Log("Market Trend Updated: Mature");
                    break;
            }

            marketTrendText.text = $"Market Trend: {ageRating}";
        }
    }
}
