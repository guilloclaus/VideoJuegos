using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canion : MonoBehaviour
{
    public GameObject PuntoDisparo;
    public GameObject Bala;
    public float startDelay = 2;
    public float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Disparo", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        Disparar();
    }

    void Disparar()
    {
        if (Input.GetKeyDown("space"))
        {
            Instantiate(Bala, PuntoDisparo.transform.position, Bala.transform.rotation);

        }
        else if (Input.GetKeyDown("j"))
        {
            Instantiate(Bala, PuntoDisparo.transform.position, Bala.transform.rotation);
            Instantiate(Bala, PuntoDisparo.transform.position, Bala.transform.rotation);
        }
        else if (Input.GetKeyDown("k"))
        {

            Instantiate(Bala, PuntoDisparo.transform.position, Bala.transform.rotation);
            Instantiate(Bala, PuntoDisparo.transform.position, Bala.transform.rotation);
            Instantiate(Bala, PuntoDisparo.transform.position, Bala.transform.rotation);

        }
        else if (Input.GetKeyDown("l"))
        {
            Instantiate(Bala, PuntoDisparo.transform.position, Bala.transform.rotation);
            Instantiate(Bala, PuntoDisparo.transform.position, Bala.transform.rotation);
            Instantiate(Bala, PuntoDisparo.transform.position, Bala.transform.rotation);
            Instantiate(Bala, PuntoDisparo.transform.position, Bala.transform.rotation);
        }

    }


    void Disparo()
    {
        Instantiate(Bala, PuntoDisparo.transform.position, Bala.transform.rotation);
    }

}
