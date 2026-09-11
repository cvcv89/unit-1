using Unity.VisualScripting;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float speed = 15f;
    private Rigidbody Rd;
    public float Turnspeed = 10f; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rd = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {

            Rd.AddForce(Vector3.forward * Time.deltaTime * speed);
            
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * Time.deltaTime * Turnspeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * Turnspeed);
        }
            

    }
}
