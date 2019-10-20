using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnSol : MonoBehaviour
{

    public GameObject sol;
    public double masa;
    public double radio;
    public double zonas;
    public double luminosidad;
    public string nombre;
    public Button solBot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    /*void OnEnable()
    {
        //Call function SpawnS OnClick
        solBot.onClick.AddListener(() => SpawnS(GameObject.Find("StarName").GetComponent<InputField>(), GameObject.Find("Mass").GetComponent<Slider>(), GameObject.Find("Radius").GetComponent<Slider>(), GameObject.Find("Brightness").GetComponent<Slider>()));
    }*/

    public void SpawnS()//InputField inputField, Slider masaSo, Slider radioSo, Slider luminosidadSo)
    {
        //Set and instantiate a star
        GameObject Soler = Instantiate(sol);
        //change Generic Material color
        GameObject.Find("Icosphere").GetComponent<Renderer>().material.color = Color.yellow;
        //set star position
        Soler.transform.position = new Vector3(0, 0, 0);
        //Change object name
        Soler.name = GameObject.Find("StarName").GetComponent<InputField>().text;
        nombre = Soler.name;
        //Change object tag
        Soler.tag = ("sol");
        GameObject.Find("Icosphere").name = "mallaSol";
        //Add halo effect
        //GameObject halo = Instantiate(Resources.Load("halo") as GameObject);
        //halo.transform.SetParent(Soler.transform);
        //halo.transform.position = new Vector3(0, 0, 0);
        //Set name
        nombre = Soler.name;
        //Set m
        masa = GameObject.Find("Mass").GetComponent<Slider>().value;//masaSo.value;
        //Set Radius
        radio = GameObject.Find("Radius").GetComponent<Slider>().value;  //radioSo.value;
        //Set luminosity
        luminosidad = GameObject.Find("Brightness").GetComponent<Slider>().value; ;
        //Set SafeZone Constant
        zonas = Mathf.Sqrt((float)luminosidad);
        //Change halo size
        //halo.GetComponent<Light>().range = (float)luminosidad * 4e1f * (float)radio;
        //halo.GetComponent<Light>().intensity = (float)luminosidad * 1e2f;
        //Change Star Size
        Soler.transform.localScale = new Vector3((float)radio * 1e2f, (float)radio * 1e2f, (float)(radio * 1e2f));
        GameObject Cmra = Instantiate(Resources.Load("Camara") as GameObject);
        Cmra.transform.position = new Vector3(0, 0, (float)radio*2e+2f);
        Cmra.transform.SetParent(Soler.transform);
        Cmra.GetComponent<CameraFollow>().player = (Soler.transform);
        Cmra.GetComponent<CameraFollow>().turnSpeed = (7);

    }

}
