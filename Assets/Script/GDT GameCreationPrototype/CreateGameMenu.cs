using UnityEngine;

public class CreateGameMenu : MonoBehaviour
{
    public GameObject panel;
    
    private void Awake()
    {
        panel.SetActive(false);
    }

    public void CloseGameUI() => panel.SetActive(false);

}