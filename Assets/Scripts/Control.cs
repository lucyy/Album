using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
 

    List<GameObject> gosFotos;
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("16").transform.position.x<=0)
        {
            foreach (GameObject goMover in GameObject.FindGameObjectsWithTag("Primero"))
            {
                goMover.transform.position = goMover.transform.position + new Vector3(410, 0, 0);
            }
        }
        if (GameObject.Find("16").transform.position.x >= 415)
        {
            foreach (GameObject goMover in GameObject.FindGameObjectsWithTag("Primero"))
            {
                goMover.transform.position = goMover.transform.position + new Vector3(-410, 0, 0);
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (GameObject goMover in GameObject.FindGameObjectsWithTag("Primero"))
            {
                goMover.transform.position = goMover.transform.position + new Vector3(-5, 0, 0);
            }
            Debug.Log("Lu");
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            foreach (GameObject goMover in GameObject.FindGameObjectsWithTag("Primero"))
            {
                goMover.transform.position = goMover.transform.position + new Vector3(5, 0, 0);
            }
     
        }

        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase==TouchPhase.Began)
            {
                foreach (GameObject goMover in GameObject.FindGameObjectsWithTag("Primero"))
                {
                    goMover.transform.position = goMover.transform.position + new Vector3(-5, 0, 0);
                }
            }
           

        }

        if (Input.touchCount == 2)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Ended)
            {

                foreach (GameObject goMover in GameObject.FindGameObjectsWithTag("Primero"))
                {
                    goMover.transform.position = goMover.transform.position + new Vector3(5, 0, 0);
                }
            }

        }
        if (Input.touchCount == 3)
        {
            Application.Quit();
        }

        }

    public void Salir() {
        Application.Quit();
    
    }
}
