using UnityEngine;

public class DestroyAfter : MonoBehaviour
{
    public float lifeDuration;
    void Start()
    {
        Destroy(gameObject, lifeDuration);
    }
}
