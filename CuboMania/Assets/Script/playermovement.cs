using UnityEngine;

public class playermovement : MonoBehaviour
{   public Rigidbody rigidbody;
    public float forwardforce=2000f;
    public float right=500f;
    public float left=500f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidbody.AddForce(0,0,forwardforce*Time.deltaTime);
        if(Input.GetKey("d"))
        {
            rigidbody.AddForce(right*Time.deltaTime,0,0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("a"))
        {
            rigidbody.AddForce(-left*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if (rigidbody.position.y<-1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
