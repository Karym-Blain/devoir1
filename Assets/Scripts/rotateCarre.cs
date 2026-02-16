using UnityEngine;

public class rotateCarre : MonoBehaviour
{
     public float vitesseRotation =0.02f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         transform.Rotate(0f,0f, vitesseRotation);
    }
}
