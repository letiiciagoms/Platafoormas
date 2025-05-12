using UnityEngine;

public class Porta : MonoBehaviour
{
    public string doorId;
    
    private SpriteRenderer sr;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }
    
    private void OnEnable()
    {
        EventChannel.OnButtonPressed += CheckDoor;
    }

    private void OnDisable()
    {
        EventChannel.OnButtonPressed -= CheckDoor;
    }

    private void CheckDoor(string triggeredId)
    {
        if (triggeredId == doorId)
        {
            OpenDoor();
        }
    }

    private void OpenDoor()
    {
        
        GetComponent<Collider2D>().enabled = false;
        if (sr != null)
            sr.color = Color.cyan;
    }
}
