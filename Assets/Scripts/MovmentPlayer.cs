using UnityEngine;
using UnityEngine.InputSystem;

public class MovmentPlayer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] InputAction move = new InputAction(type: InputActionType.Value, expectedControlType: nameof(Vector2));
    [SerializeField] float speed = 5f; // ������ �����
    private Rigidbody2D rb;
    void OnEnable()
    {
        move.Enable();
    }
    void OnDisable()
    {
        move.Disable();
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 inputMovement = move.ReadValue<Vector2>();

        // ����� ����� ���
        Vector2 newPosition = rb.position + inputMovement * speed * Time.deltaTime;

        // ����� ����� �-Rigidbody
        rb.MovePosition(newPosition);
    }
}
