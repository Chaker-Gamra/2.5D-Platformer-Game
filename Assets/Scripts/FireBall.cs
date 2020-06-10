using UnityEngine;

public class FireBall : MonoBehaviour
{
    public GameObject damageEffect;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            Instantiate(damageEffect, transform.position, damageEffect.transform.rotation);
            Destroy(gameObject);
        }
    }
}
