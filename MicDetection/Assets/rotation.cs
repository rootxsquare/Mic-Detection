using UnityEngine;

public class rotation : MonoBehaviour
{
    public float multiplier, sensitivity;
    public float speed;
   
    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(Vector3.forward * FindFirstObjectByType<MicrophoneInput>().loudness * Time.deltaTime * multiplier);
        if (FindFirstObjectByType<MicrophoneInput>().loudness > sensitivity)
        { transform.Translate(Vector3.up * Time.deltaTime * FindFirstObjectByType<MicrophoneInput>().loudness * multiplier); }

        transform.Translate(Vector3.right * speed * Time.deltaTime * Input.GetAxis("Horizontal"));
        //GetComponent<Rigidbody>().AddForce(Vector3.up * FindFirstObjectByType<MicrophoneInput>().loudness * multiplier);
    }
  
}
