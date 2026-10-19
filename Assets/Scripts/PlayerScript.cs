using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerScript : MonoBehaviour
{

    public InputActionAsset InputActions;

    private Rigidbody2D rb;
    private Animator anim;
    public float speed = 5f;
    InputAction moveAction;

    Vector2 moveAmt;

    private void OnEnable()
    {
        InputActions.FindActionMap("Player").Enable();
    }

    private void OnDisable()
    {
        InputActions.FindActionMap("Player").Disable();
    }

    private void Awake()
    {
        moveAction = InputSystem.actions.FindAction("Move");

        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        moveAmt = moveAction.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        Walking();
    }

    private void Walking()
    {
        Vector2 movement = new Vector2(moveAmt.x, moveAmt.y);

        rb.MovePosition(rb.position + movement * speed * Time.deltaTime);

        anim.SetBool("isWalking", true);

        
    }

}
