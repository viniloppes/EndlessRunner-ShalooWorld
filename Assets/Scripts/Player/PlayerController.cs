using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    private Vector2 movement;
    private Rigidbody rigidBody;
    public float xClamp = 4f;
    public float zClamp = 2f;


    [SerializeField] private float[] lanes = { -2.5f, 0f, 2.5f };
    private int indexPosAtual = 0;

    void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        //HandleMovement();
    }

    private void HandleMovement()
    {
        Vector3 currentPosition = rigidBody.position;
        Vector3 moveDirection = new Vector3(movement.x, 0f, movement.y);
        Vector3 newPosition = currentPosition + moveDirection * (Time.fixedDeltaTime * moveSpeed);
        // Debug.Log($@"
        // {currentPosition}
        // {moveDirection}
        // {newPosition}
        // ");
        newPosition.x = Mathf.Clamp(newPosition.x, -xClamp, xClamp);
        newPosition.z = Mathf.Clamp(newPosition.z, -zClamp, zClamp);
        rigidBody.MovePosition(newPosition);
    }

    public void MovePlayer(string direction)
    {
        switch (direction)
        {
            case "Left":
                if (indexPosAtual > 0)
                {
                    indexPosAtual--;
                    Vector3 moveDirection = new Vector3(lanes[indexPosAtual], 0f, 0f);
                    rigidBody.MovePosition(moveDirection);
                }

              

                break;
            case "Right":
                if (indexPosAtual < lanes.Length - 1)
                {
                    indexPosAtual++;
                    Vector3 moveDirection = new Vector3(lanes[indexPosAtual], 0f, 0f);
                    rigidBody.MovePosition(moveDirection);
                }
                break;
            case "Up":
                break;
            case "Down":
                break;
        }
    }

    public void Move(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();
    }
}