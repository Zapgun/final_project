using UnityEngine;

public class SphereEvents : MonoBehaviour
{

    Animation myAnim;
    public GameObject otherObject;
    MouseInteractions mouseI;

    void Start() {
        myAnim = GetComponent<Animation>();
        mouseI = otherObject.GetComponent<MouseInteractions>();
    }

    public void SphereTrigger() {
        Debug.Log("Function works!");
    }

    void OnMouseDown() {
        myAnim.Play();
        mouseI.TestFunction();
    }
}
