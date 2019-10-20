using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnLuna : MonoBehaviour
{
    public GameObject Luna;
    public float Distancia;
    public float masa;
    public float distancial;

    /*private void OnEnable()
    {
        //Call LunaSP Onclick
        BotonLs.onClick.AddListener(() => LunaSp(Luna, float.Parse(GameObject.Find("MasaLuna").GetComponent<InputField>().text), float.Parse(GameObject.Find("DistanciaLuna").GetComponent<InputField>().text)));
    }*/

    public void LunaSp()//GameObject LunaS, float Masa, float DistanciaL)
    {
        //Set And instantiate a Moon/satellite
        GameObject LunaG = Instantiate(Luna);
        LunaG.AddComponent<rotacionLu>();
        //Set the planet 
        GameObject Plan = GameObject.Find(GameObject.FindGameObjectWithTag("SpawnPlaneta").GetComponent<SpawnPlanet>().Nombre);
        //Make the planet a parent of the Satellite
        LunaG.transform.SetParent(Plan.transform);
        //Change Color
        GameObject.Find("Icosphere").GetComponent<Renderer>().material.color = new Color(Random.Range(230, 255), Random.Range(230, 255), Random.Range(230, 255));
        //Change the Satellite size
        masa = GameObject.Find("moonMass").GetComponent<Slider>().value;
        distancial = GameObject.Find("planetDistance").GetComponent<Slider>().value;
        LunaG.transform.localScale = new Vector3(masa * 1e-4f, masa * 1e-4f, masa * 1e-4f);
        //Change the satellite position
        //LunaG.transform.position = new Vector3(Plan.transform.position.x+1e+2f, Plan.transform.position.x + 1e+2f, Plan.transform.position.x + 1e+2f);
        //Set satellite name
        LunaG.name = GameObject.Find("nameLuna").GetComponent<InputField>().text;
        //Set distance Planet - Satellite
        Distancia = distancial;
        //rotacionLu rot = GetComponent<rotacionLu>();
        //rot.radio = float.Parse(GameObject.Find("moonMass").GetComponent<InputField>().text);
        //rot.masa = Plan.GetComponent<PlanetaScript>().masaP;
        //rot.cent = Plan;
    }
}
