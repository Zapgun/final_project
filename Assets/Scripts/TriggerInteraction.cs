using UnityEngine;

public class TriggerInteraction : MonoBehaviour
{

    AudioSource myAudioSource;

    void Start() {
        myAudioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other) {
        Debug.Log("Passing through!");
        myAudioSource.Play();
    }
}
