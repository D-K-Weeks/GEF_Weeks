using UnityEngine;
using UnityEngine.InputSystem;

public class NewInputSystem : MonoBehaviour
{
    public CustomInputActionMap input;
    private bool attackheld = false;

    private void Start()
    {

    }

    private void OnEnable()
    {
        input = new CustomInputActionMap();

        input.Player.Enable();

        input.Player.Attack.performed += AttackPressed;
        input.Player.Attack.started += _ => attackheld = true;
        input.Player.Attack.canceled += AttackReleased;
        
    }

    private void OnDisable()
    {
        input.Player.Disable();
    }

    private void Update()
    {
        if (attackheld) Debug.Log("ATTACK HELD");

        Vector2 move = input.Player.Move.ReadValue<Vector2>();
        if (move != Vector2.zero)
        {
            transform.position += new Vector3(move.x, move.y, 0) * 0.01f;
        }

    }
    private void AttackPressed(InputAction.CallbackContext _) => Debug.Log("ATTACK PRESSED");

    private void AttackReleased(InputAction.CallbackContext _)
    {
        attackheld = false;
        Debug.Log("ATTACK RELEASED");
    }
}
