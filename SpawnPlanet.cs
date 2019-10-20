using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnPlanet : MonoBehaviour
{

    public Button BotonSp;
    public string Nombre;
    public float Masa;
    public float SeM;
    public float velocidad;
    public GameObject planeta;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


   /* private void OnEnable()
    {
        BotonSp.onClick.AddListener(() => SpawnPlaneta(Resources.Load("PlanetaVacio") as GameObject, GameObject.Find("NombrePlanet").GetComponent<InputField>().text, float.Parse(GameObject.Find("MasaPlanet").GetComponent<InputField>().text), float.Parse(GameObject.Find("EjeM").GetComponent<InputField>().text)));
    }*/
    public void SpawnPlaneta()//GameObject PlanS, string NombreS, float MasaS, float SeMS)
    {
        //Instantiate a Planet
        
        GameObject Planet = Instantiate(Resources.Load("PlanetaVacio") as GameObject);
        //Change Planet Name
        Planet.name = GameObject.Find("nombreP").GetComponent<InputField>().text ;
        //Set Planet Name 
        Nombre = Planet.name ;
        //Change Planet Tag
        Planet.tag = "Planeta";
        //Set Planet M
        Masa = GameObject.Find("masa").GetComponent<Slider>().value;
        //Set Distance Planet-Star
        SeM = float.Parse(GameObject.Find("distancia").GetComponent<InputField>().text);
        velocidad = float.Parse(GameObject.Find("vo").GetComponent<InputField>().text);
        //Add script rotation
        Planet.AddComponent<PlanetaScript>();
        //Add script TrailRenderer
        //Planet.AddComponent<TrailRenderer>();

    }

}
