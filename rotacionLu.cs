using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rotacionLu : MonoBehaviour
{
    const float G=6.674e-11f;
    public float radio;
    public float velocidad;
    public float theta;
    public Vector3 centro;
    public GameObject cent;
    public float masa;
    // Start is called before the first frame update
    void Start()
    {
        //Set m from TxtBox
        masa=(GameObject.Find("moonMass").GetComponent<Slider>().value);
        //Set Distance from TxtBox
        radio= (GameObject.Find("planetDistance").GetComponent<Slider>().value);
        //Set Planet
        cent = GameObject.Find(GameObject.FindGameObjectWithTag("SpawnPlaneta").GetComponent<SpawnPlanet>().Nombre);
        //Set Velocity
        velocidad = ((Mathf.Sqrt((G * masa) / radio) * (180 * Time.deltaTime))/(Mathf.PI*radio));
    
    }

    // Update is called once per frame
    void Update()
    {
        //Set center
        centro = new Vector3(cent.transform.position.x + radio * Mathf.Cos(theta), cent.transform.position.y, cent.transform.position.z + radio * Mathf.Sin(theta));
        //Change Position
        transform.position = new Vector3(centro.x + radio * Mathf.Cos(theta)*1e+1f, centro.y, centro.z + radio * Mathf.Sin(theta) * 1e+1f);
        //change theta    
        theta += velocidad*1e+4f;
    }
}
