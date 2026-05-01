using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    public bool gameStarted;

    public static PlayerController instance {  get; private set; }

    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private float gravity = 10f;

    [SerializeField] private bool gameOver = false;
    [SerializeField] public TextMeshProUGUI endGameTxt;


    private void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
    }
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        //Disable player gravity 'till start
        rb.simulated = false;
    }
    private void Update()
    {
        if (rb.linearVelocity.y < -jumpForce)
        {
            rb.linearVelocity = Vector2.down * jumpForce;
        }
    }

    private void OnJump(InputValue value)
    {
        if (value.isPressed)
        {
            if (!gameStarted)
            {
                gameStarted = true;
                rb.simulated = true; //Activate physics 
            }
            rb.linearVelocity = Vector2.up * jumpForce;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Barrier"))
        {
            Debug.Log("Collison!");
            gameOver = true;
        }
    }
}
