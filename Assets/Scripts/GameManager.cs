using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager> {

    protected override void Init()
    {
    }

    public string temp_PlaneName;
    public GameObject temp_PlaneSpawnPos;
    public GameObject temp_PlaneMoveTo;


    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void LateUpdate () {
        
    }
}
