using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploDeArray : MonoBehaviour
{
    public GameObject[] balls;
    private GameObject actualBall;

    public string myText = "Texto Ejmplo";
    private string gameObjectName;


    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            actualBall = Instantiate(balls[Random.Range(0, balls.Length)]);
            gameObjectName = actualBall.name;

            if (gameObjectName != "RedBall(Clone)")
            {
                Debug.Log("El objeto es: " + actualBall.name);
            }
        }

    }
}
