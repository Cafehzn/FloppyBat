using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.InputSystem;
using UnityEditor.Rendering.LookDev;

public class PlayerController : MonoBehaviour
{
    private float myY;
    [SerializeField]private float jumpForce = 5f;
    private Rigidbody2D Rb;

    private void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        myY = transform.position.y;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Barrier"))
        {
            Debug.Log("Collison!");
        }
    }
}
