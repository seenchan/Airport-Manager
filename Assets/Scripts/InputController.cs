using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputController : MonoBehaviour
{

    public Button btn_Plane1;
    public Button btn_Plane2;
    public GameObject planeObj;

    private GameObject spawnedPlane;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MouseControl();
    }

    void MouseControl()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction * 100, Color.yellow);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, 100);
            if (hit.collider != null)
            {
                if (hit.transform.tag == "RunwayShort" || hit.transform.tag == "RunwayLong")
                {
                    GameManager.Instance.temp_PlaneMoveTo = hit.collider.transform.GetChild(0).gameObject;
                    GameManager.Instance.temp_PlaneSpawnPos = hit.collider.transform.GetChild(0).GetChild(0).gameObject;
                    ChosenPlane();
                    SpawnPlane();
                }
            }
        }
    }

    public void ChosenPlane()
    {
        GameManager.Instance.temp_PlaneName = btn_Plane1.name;
    } 

    void SpawnPlane()
    {
        spawnedPlane = Instantiate(planeObj);
    }
}
