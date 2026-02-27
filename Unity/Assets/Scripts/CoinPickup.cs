using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Coin Collected");
    }
}
