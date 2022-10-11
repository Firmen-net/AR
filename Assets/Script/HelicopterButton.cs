using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicopterButton : MonoBehaviour
{
    private Ray ray;
    private RaycastHit hit;
    public GameObject infoPanel;
    private bool panelisactive = false;
    private Touch thetouch;

    private void Start()
    {
        infoPanel.SetActive(false);
    }

    private void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null)
                {
                    if (!infoPanel.activeInHierarchy)
                    {
                        Debug.Log("PanelAktif");
                        infoPanel.SetActive(true);
                        panelisactive = true;
                    }
                    else if (infoPanel.activeInHierarchy)
                    {
                        print(hit.collider.name);
                        infoPanel.SetActive(false);
                        panelisactive = false;
                    }
                }
            }
        }
        /*ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            if (Input.GetMouseButtonDown(0) && hit.collider.name == "Helicopter" && !infoPanel.activeInHierarchy)
            {
                Debug.Log("PanelAktif");
                infoPanel.SetActive(true);
                panelisactive = true;
            }
            else if (Input.GetMouseButtonDown(0) && hit.collider.name == "Helicopter" && infoPanel.activeInHierarchy)
            {
                print(hit.collider.name);
                infoPanel.SetActive(false);
                panelisactive = false;
            }
        }*/
    }
}