using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    
    public static int health;
    public Text healthText;
    
    // Start is called before the first frame update
    void Start()
    {
        health = 5;
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Vidas: " + health;
        //Debug.Log("Puntaje: " + score);
    }
}
