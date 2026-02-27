
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private bool attackheld;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            attackheld = true;
            Debug.Log("ATTACK PRESSED");
        } 

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            attackheld = false;
            Debug.Log("ATTACK RELEASED");
        }

        if (Input.GetKey(KeyCode.Mouse0)) Debug.Log("ATTACK HELD");

        float x = 0f;
        float y = 0f;

        if (Input.GetKey(KeyCode.A)) x -= 1f;
        if (Input.GetKey(KeyCode.D)) x += 1f;
        if (Input.GetKey(KeyCode.S)) y -= 1f;
        if (Input.GetKey(KeyCode.W)) y += 1f;

        Vector3 move = new Vector3(x, y);
        if (move != Vector3.zero)
        {
            Debug.Log($"Move {move}");

            transform.position += move * 0.01f;
        }
    }
}
