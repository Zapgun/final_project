using UnityEngine;

public class CylinderScript : MonoBehaviour
{

    Animator myAnimator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myAnimator = GetComponent<Animator>();
    }

    void OnMouseDown() {
        myAnimator.SetBool("isOpen", true);
        myAnimator.SetFloat("speed", 10.5f);
        myAnimator.SetTrigger("isTrigger");

        // prints the variable
        Debug.Log(myAnimator.GetBool("isOpen"));
    }
}
