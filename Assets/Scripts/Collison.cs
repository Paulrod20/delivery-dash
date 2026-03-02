using UnityEngine;

public class Collison : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collison Detected");
    }
}
