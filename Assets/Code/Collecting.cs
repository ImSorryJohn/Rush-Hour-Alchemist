using UnityEngine;

public class Collecting : MonoBehaviour
{
    [SerializeField] private int value;
    private bool hasTriggered;
    private ScoreManager coinManager;
    private void Start()
    {
        coinManager = ScoreManager.Instance;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player") && !hasTriggered)
        {
            hasTriggered = true;
            coinManager.ChangeCoins(value);
            Destroy(gameObject);
        }
    }
}
