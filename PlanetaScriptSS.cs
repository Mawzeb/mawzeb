using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlanetaScriptSS : MonoBehaviour
{

    //alfa<beta
    const float G = 6.674e-11f;
    public string nombre;
    public float alfa;
    public float beta;
    public float theta;
    public float velocidad;
    public float excen;
    public float ram;
    public float h;
    public float distancia;
    public float distanciap;
    public float masaEstrella;
    public float masaP;
    public float velocidadP;
    public Vector3 centro;
    public GameObject foco1;
    public GameObject sol;
    public bool seguro;

    void Start()
    {


        beta = ((G * (masaEstrella * 1.989e+30f) * distanciap * 1.496e+11f) / (2 * G * (masaEstrella * 1.989e+30f) - (Mathf.Pow((velocidadP * 1e+3f), 2) * distanciap * 1.496e+11f)));

        alfa = Mathf.Sqrt((2 * distanciap * beta * 1.496e+11f) - (Mathf.Pow(distanciap * 1.496e+11f, 2)));
        //Set Planet Name
        //Set foco (Star)
        //Set Starspawn
        //Set PlanetVelocity
        //Set a temporal SpawnPlanet Script

        h = Mathf.Pow(((beta - alfa) / (beta + alfa)), 2);
     
    
    }
    // Update is called once per frame
    void Update()
{

    {
        //Set Eccentricity            
        excen = Mathf.Sqrt(Mathf.Pow(beta, 2) - Mathf.Pow(alfa, 2));
        //Set Center
        centro = new Vector3(foco1.transform.position.x + (beta * Mathf.Cos(theta) + excen), foco1.transform.position.y, foco1.transform.position.z + (alfa * Mathf.Sin(theta)));
        //Set Position
        transform.position = new Vector3((centro.x * 1e-9f + beta * Mathf.Cos(theta) * 1e-9f), centro.y * 1e-9f, (centro.z * 1e-9f + alfa * Mathf.Sin(theta) * 1e-9f));
        //Set Distance
        distancia = Vector3.Distance(foco1.transform.position, transform.position);
        //Set Ramanujan approximation
        ram = Mathf.PI * (alfa + beta) * (1 + (3 * h) / (10 + Mathf.Sqrt(4 - 3 * h)));
        //Set Velocity
        velocidad = (Mathf.Sqrt(2 * G * (masaEstrella * 1.989e+30f) * ((1 / distancia * (1.50e+11f)) - (1 / ((2) * beta)))) * (360 * Time.deltaTime) / (ram));
        //Change Theta
        theta += velocidad * 1e-6f;




    }

    }


}
