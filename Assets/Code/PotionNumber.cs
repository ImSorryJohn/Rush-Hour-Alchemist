using UnityEngine;

public class PotionNumber:MonoBehaviour
{
    public static PotionNumber Instance;
    public int i=0;
    public GameObject Door;
    public void AddCount(){
        i++;
        Debug.Log(i);
        if(i==5)
        {
          OpenDoor();  
        }
    }
    public void OpenDoor()
    {
        Door.SetActive(false);
    }
}
