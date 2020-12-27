using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeLife : MonoBehaviour
{
    public float timeLife;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, timeLife);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
