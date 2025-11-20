using UnityEngine;

public class DemoScript : MonoBehaviour
{

    //float firstFloat = 4.5f; // 32 bits of memory space, 9 digits accuracy

    
    int[] intArray = {1,2,3};
    int firstNum = 6;

    
    int secondNum = 5;
    //float pi = 3.14159f;
    //string myName = "Brian";
    //bool isTrue = false;

    //DemoScript myDemoScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // print("Hello World!");
        int result = MultiplyByTwo(firstNum, secondNum);
        print(result);

        Example();
    }

    // Update is called once per frame
    void Update()
    {
        // Polling
        // if (Input.GetMouseButtonDown(0)) {
        //     Debug.Log("Mouse is down");
        // }


        //Debug.Log("Hello World again!");
        //Debug.LogWarning("Warning!");
    }

    // // Event Driven
    // void OnMouseDown() {
    //     Debug.Log("Mouse was pushed down!");
    // }

    int MultiplyByTwo(int a, int b) {
        int newNum = 10;
        newNum++; // newNum = newNum + 1;
        return a * b;
    }

    void Example() {
        if (firstNum != secondNum) {
            print("Numbers are the NOT same");
        } else {
            print("They are the same!");
        }
    }

}