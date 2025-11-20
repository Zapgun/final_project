using UnityEngine;

public class MouseInteractions : MonoBehaviour
{
    Rigidbody myRigidBody;
    Renderer myRenderer;
    AudioSource myAudioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
        myRenderer = GetComponent<Renderer>();
        myAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // This triggers every time the mouse right button is clicked 
        // (even if you're not clicking on the object)
        if (Input.GetMouseButtonDown(1)) {
            //Debug.Log("Mouse is down");
            myRigidBody.useGravity = true;
        }

        if (Input.GetKey(KeyCode.R)) {
            myRenderer.material.color = Color.red;
        } else if (Input.GetKey(KeyCode.G)) {
            myRenderer.material.color = Color.green;
        } else if (Input.GetKey(KeyCode.B)) {
            myRenderer.material.color = Color.blue;
        } 
    }

    // This will only trigger when you click the mouse ON the object
    void OnMouseDown() {
        Debug.Log("This should work!");
        myRenderer.material.color = new Color(0.5f,0.25f,.9f,1f);
    }

    private void OnCollisionEnter(Collision other) {
        myAudioSource.Play();
        Debug.Log("We collided with " + other.gameObject.name);

    }

    public void TestFunction() {
        Debug.Log("Hi there");
    }
}
