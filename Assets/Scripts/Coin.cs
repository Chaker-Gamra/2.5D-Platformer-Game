using UnityEngine;

public class Coin : MonoBehaviour
{
    public float rotationSpeed = 50;

    void Update()
    {
        //Rotate The Coin
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            PlayerManager.numberOfCoins++;//Increment the number of coins
            Destroy(gameObject);//destroy the coin
        }
    }
}
