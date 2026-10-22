using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    private int coins;
    public GameObject Door;
    [SerializeField] private TMP_Text coinsDisplay;

    private void Awake()
    {
        if(!Instance)
        {
            Instance = this;
        }

        if(coins==5)
        {
             OpenDoor();  
        }

    }

    private void OnGUI()
    {
        coinsDisplay.text = coins.ToString();
    }

    public void ChangeCoins(int amount)
    {
        coins += amount;
    }

    public void OpenDoor()
    {
        Destroy(Door);
    }
}
