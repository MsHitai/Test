using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Distance : MonoBehaviour
{
    public InputField distanceInput;
    
    private float distance;

    // Start is called before the first frame update
    void Start()
    {
        distance = float.Parse(distanceInput.text);
        transform.position = new Vector3(0.0f, 0.0f, distance);
    }

    // Update is called once per frame
    void Update()
    {
        distance = float.Parse(distanceInput.text);
        transform.position = new Vector3(0.0f, 0.0f, distance);
    }
}
