using UnityEngine;

public class PlatformButton : MonoBehaviour
{
    public string doorId;
    private SpriteRenderer sr;
    private bool activated = false;
    
    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!activated && other.CompareTag("Player"))
        {
            activated = true;
            
            sr.color = Color.green;
            EventChannel.PressedButton(doorId);
        }
    }
}
