using UnityEngine;
using static UnityEngine.ParticleSystem;

public class OpenMenu : MonoBehaviour
{
    public GameObject gameUI;
    public GameObject GameCreatePanel;

    public void Awake()
    {
        gameUI.SetActive(false);
    }

    public void Update()
    {
        CheckForInput();
    }

    private void CheckForInput()
    {
        //Mouse click
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

            if (hit.collider != null)
            {
                if(hit.collider.CompareTag("Player"))
                {
                    Debug.Log("Clicked on: " + hit.collider.name);
                    gameUI.SetActive(!gameUI.activeSelf);
                }
            }
        }
    }

    public void OpenCreateGameUI() => GameCreatePanel.SetActive(true);
}
