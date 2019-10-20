using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlanetaScript : MonoBehaviour
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
    public float masaEstrella;
    public float masaP;
    public float velocidadP;
    public Vector3 centro;
    public GameObject foco1;
    public GameObject sol;
    public bool seguro;

    void Start()
    {
        //Set Planet Name
        nombre = GameObject.Find("PlanetaSpawn").GetComponent<SpawnPlanet>().Nombre;
        //Set foco (Star)
        foco1 = GameObject.FindGameObjectWithTag("sol");
        //Set Starspawn
        sol = GameObject.FindGameObjectWithTag("solSp");
        //Set PlanetVelocity
        velocidadP = (GameObject.Find("PlanetaSpawn").GetComponent<SpawnPlanet>().velocidad);
        //Set a temporal SpawnPlanet Script
        SpawnPlanet SpP = GameObject.FindGameObjectWithTag("SpawnPlaneta").GetComponent<SpawnPlanet>();
    //Set MStar and MPlanet 
        masaEstrella = (float)sol.GetComponent<SpawnSol >().masa; 
        masaP = SpP.Masa;
        //Set major semiaxi
        beta = ((G* (masaEstrella* 1.989e+30f) * SpP.SeM* 1.496e+11f) / (2 * G* (masaEstrella* 1.989e+30f) - (Mathf.Pow((velocidadP* 1e+3f), 2) * SpP.SeM* 1.496e+11f)));
        //Set Minor SemiAxi
        Debug.Log((2 * G* (masaEstrella* 1.989e+30f) - (Mathf.Pow(velocidadP* 1e+3f, 2) * SpP.SeM* 1.496e+11f)));
        alfa = Mathf.Sqrt((2 * SpP.SeM* beta * 1.496e+11f) - (Mathf.Pow((SpP.SeM* 1.496e+11f), 2)));
        //Change planet scale
        transform.localScale = new Vector3(SpP.Masa , SpP.Masa, SpP.Masa);
        //Set H (Ramanujan approximation ellipse circumference)
        h = Mathf.Pow(((beta - alfa) / (beta + alfa)), 2);
        //Set Radius SafeZone
        float zonase = (float)GameObject.Find("SolSpawn").GetComponent<SpawnSol>().zonas;
        //Verify if the planet is in SafeZone
        seguro= ((SpP.SeM>zonase-zonase*0.05)&&(SpP.SeM<zonase+zonase*0.35));
        //Set planet type and trail renderer
        if (seguro) {
            int rand = Random.Range(1, 4);
            GameObject planeta = Instantiate(Resources.Load("agua" + rand) as GameObject);
            planeta.AddComponent<TrailRenderer>();
            planeta.GetComponent<TrailRenderer>().time = 200f;
            planeta.transform.SetParent(transform);
            //Fix Model Position/Rotation/Scale
            if (rand == 1)
            {
                GameObject.Find("node_id19").transform.position = new Vector3(0, 0, 0);
                GameObject.Find("node_id19").transform.rotation = Quaternion.Euler(0, 0, 0);
                GameObject.Find("node_id19").transform.localScale = new Vector3(1, 1, 1);
                GameObject.Find("node_id4").transform.position = new Vector3(0, 0, 0);
                GameObject.Find("node_id4").transform.rotation = Quaternion.Euler(0, 0, 0);
                GameObject.Find("node_id4").transform.localScale = new Vector3(1, 1, 1);
                GameObject.Find("node_id5").transform.position = new Vector3(0, 0, 0);
                GameObject.Find("node_id5").transform.rotation = Quaternion.Euler(0, 0, 0);
                GameObject.Find("node_id5").transform.localScale = new Vector3(1, 1, 1);
                GameObject.Find("node_id7").transform.position = new Vector3(0, 0, 0);
                GameObject.Find("node_id7").transform.rotation = Quaternion.Euler(0, 0, 0);
                GameObject.Find("node_id7").transform.localScale = new Vector3(1, 1, 1);
                GameObject.Find("node_id9").transform.position = new Vector3(0, 0, 0);
                GameObject.Find("node_id9").transform.rotation = Quaternion.Euler(0, 0, 0);
                GameObject.Find("node_id9").transform.localScale = new Vector3(1, 1, 1);
                GameObject.Find("node_id11").transform.position = new Vector3(0, 0, 0);
                GameObject.Find("node_id11").transform.rotation = Quaternion.Euler(0, 0, 0);
                GameObject.Find("node_id11").transform.localScale = new Vector3(1, 1, 1);
                GameObject.Find("node_id13").transform.position = new Vector3(0, 0, 0);
                GameObject.Find("node_id13").transform.rotation = Quaternion.Euler(0, 0, 0);
                GameObject.Find("node_id13").transform.localScale = new Vector3(1, 1, 1);
                GameObject.Find("node_id15").transform.position = new Vector3(0, 0, 0);
                GameObject.Find("node_id15").transform.rotation = Quaternion.Euler(0, 0, 0);
                GameObject.Find("node_id15").transform.localScale = new Vector3(1, 1, 1);
                GameObject.Find("node_id17").transform.position = new Vector3(0, 0, 0);
                GameObject.Find("node_id17").transform.rotation = Quaternion.Euler(0, 0, 0);
                GameObject.Find("node_id17").transform.localScale = new Vector3(1, 1, 1);


            }
            else if (rand == 2)
            {
                GameObject.Find("node_id4").transform.position = new Vector3(0, 0, 0);
                GameObject.Find("node_id4").transform.rotation = Quaternion.Euler(0, 0, 0);
                GameObject.Find("node_id4").transform.localScale = new Vector3(1, 1, 1);
                GameObject.Find("node_id16").transform.position = new Vector3(0, 0, 0);
                GameObject.Find("node_id16").transform.rotation = Quaternion.Euler(0, 0, 0);
                GameObject.Find("node_id16").transform.localScale = new Vector3(1, 1, 1);
                GameObject.Find("node_id5").transform.position = new Vector3(0, 0, 0);
                GameObject.Find("node_id5").transform.rotation = Quaternion.Euler(0, 0, 0);
                GameObject.Find("node_id5").transform.localScale = new Vector3(1, 1, 1);
                GameObject.Find("node_id8").transform.position = new Vector3(0, 0, 0);
                GameObject.Find("node_id8").transform.rotation = Quaternion.Euler(0, 0, 0);
                GameObject.Find("node_id8").transform.localScale = new Vector3(1, 1, 1);
                GameObject.Find("node_id10").transform.position = new Vector3(0, 0, 0);
                GameObject.Find("node_id10").transform.rotation = Quaternion.Euler(0, 0, 0);
                GameObject.Find("node_id10").transform.localScale = new Vector3(1, 1, 1);
                GameObject.Find("node_id12").transform.position = new Vector3(0, 0, 0);
                GameObject.Find("node_id12").transform.rotation = Quaternion.Euler(0, 0, 0);
                GameObject.Find("node_id12").transform.localScale = new Vector3(1, 1, 1);
                GameObject.Find("node_id14").transform.position = new Vector3(0, 0, 0);
                GameObject.Find("node_id14").transform.rotation = Quaternion.Euler(0, 0, 0);
                GameObject.Find("node_id14").transform.localScale = new Vector3(1, 1, 1);


            }
            else
            {
                GameObject.Find("node_id11").transform.position = new Vector3(0, 0, 0);
                GameObject.Find("node_id11").transform.rotation = Quaternion.Euler(0, 0, 0);
                GameObject.Find("node_id11").transform.localScale = new Vector3(1, 1, 1);
                GameObject.Find("node_id5").transform.position = new Vector3(0, 0, 0);
                GameObject.Find("node_id5").transform.rotation = Quaternion.Euler(0, 0, 0);
                GameObject.Find("node_id5").transform.localScale = new Vector3(1, 1, 1);
                GameObject.Find("node_id7").transform.position = new Vector3(0, 0, 0);
                GameObject.Find("node_id7").transform.rotation = Quaternion.Euler(0, 0, 0);
                GameObject.Find("node_id7").transform.localScale = new Vector3(1, 1, 1);
                GameObject.Find("node_id9").transform.position = new Vector3(0, 0, 0);
                GameObject.Find("node_id9").transform.rotation = Quaternion.Euler(0, 0, 0);
                GameObject.Find("node_id9").transform.localScale = new Vector3(1, 1, 1);
                GameObject.Find("node_id4").transform.position = new Vector3(0, 0, 0);
                GameObject.Find("node_id4").transform.rotation = Quaternion.Euler(0, 0, 0);
                GameObject.Find("node_id4").transform.localScale = new Vector3(1, 1, 1);


            }

        }
        else if (beta > zonase + zonase * 0.35) {   
            if (Random.Range(1, 3) < 2)
            {
                GameObject planeta = Instantiate(Resources.Load("generico") as GameObject);
                planeta.AddComponent<TrailRenderer>();
                planeta.GetComponent<TrailRenderer>().time = 200f;
                planeta.transform.SetParent(transform);
            }
            else { 
                GameObject planeta = Instantiate(Resources.Load("saturno") as GameObject);
                planeta.AddComponent<TrailRenderer>();
                planeta.GetComponent<TrailRenderer>().time = 200f;
                planeta.transform.SetParent(transform);
            }
            GameObject.Find("Icosphere").GetComponent<Renderer>().material.color = new Color(Random.Range(230,255), Random.Range(230, 255), Random.Range(230, 255));
            
            GameObject.Find("Icosphere").name = "Malla" + nombre;
        }
        else
        {
            GameObject planeta = Instantiate(Resources.Load("generico") as GameObject);
            planeta.AddComponent<TrailRenderer>();
            planeta.GetComponent<TrailRenderer>().time = 200f;
            planeta.transform.SetParent(transform);
            GameObject.Find("Icosphere").GetComponent<Renderer>().material.color = new Color(255, Random.Range(0, 100), Random.Range(0, 100));
            GameObject.Find("Icosphere").name = "Malla" + nombre;
        }
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
        transform.localScale = new Vector3(masaP * distancia * 1e+1f, masaP * distancia * 1e+1f, masaP * distancia * 1e+1f);
        //Set Ramanujan approximation
        ram = Mathf.PI * (alfa + beta) * (1 + (3 * h) / (10 + Mathf.Sqrt(4 - 3 * h)));
        //Set Velocity
        velocidad = (Mathf.Sqrt(2 * G * (masaEstrella * 1.989e+30f) * ((1 / distancia * (1.50e+11f)) - (1 / ((2) * beta)))) * (360 * Time.deltaTime) / (ram));
        //Change Theta
        theta += velocidad * 1e-6f;




    }

    }


}
