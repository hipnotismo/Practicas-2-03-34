using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playertest : MonoBehaviour
{
    [SerializeField] DebugManager debugManager;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        debugManager.Log("this works", this.gameObject);
    }
}
