using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{

    private GameObject spawnLocation;
    private GameObject landAt;

    // Start is called before the first frame update
    void Start()
    {
        spawnLocation = GameManager.Instance.temp_PlaneSpawnPos;
        landAt = GameManager.Instance.temp_PlaneMoveTo;

        this.transform.position = spawnLocation.transform.position;
        //transform.LookAt(landAt.transform);
    }

    // Update is called once per frame
    void Update()
    {
        Move(landAt.transform.position - spawnLocation.transform.position);
    }

    void Move(Vector2 dir)
    {
        transform.Translate(dir);
    }
    void Rotate()
    {

    }

    void OnTriggerEnter2D(Collider2D target)
    {
        Debug.Log(target.name);
    }
}
