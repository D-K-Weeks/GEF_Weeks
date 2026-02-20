using UnityEngine;

public class S_PressurePlate : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("New Player Stepped on the Pressure Plate");
        }
    }
}
//private void Start()
//{
//    Hello(3);
//}
//void Hello(int NumberOfHellos)
//{
//    for (int i = 0; i < NumberOfHellos; i++)
//    {
//        Debug.Log("Hello");
//    }
//}