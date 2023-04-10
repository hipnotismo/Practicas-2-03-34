using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DebugManager : MonoBehaviour
{
    [SerializeField] string[] tags;
    [SerializeField] bool log;
    [SerializeField] bool logError;
    [SerializeField] bool logWarning;
    [SerializeField] bool drawLine;
    [SerializeField] bool drawRay;

    public static DebugManager inst;

    private void Awake()
    {
        if (DebugManager.inst == null)
        {
            DebugManager.inst = this;
            DontDestroyOnLoad(gameObject);
            
        }
        else
        {
            Destroy(gameObject);
        }

    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Log(string temp, GameObject context)
    {
        if (log) {
            for (int i = 0; i < tags.Length; i++)
            {
                if (context.tag == tags[i])
                {
                    Debug.Log(temp);

                }
            }
        }
        
    }

    void LogError(string temp,GameObject context)
    {
        if (logError) {
            for (int i = 0; i < tags.Length; i++)
            {
                if (context.tag == tags[i])
                {
                    Debug.LogError(temp);
                }
            }
        }
       
    }

   void LogWarning(string temp, GameObject context)
   {
        if (logWarning) {         
            for (int i = 0; i < tags.Length; i++)
            {
                if (context.tag == tags[i])
                {
                    Debug.LogWarning(temp);
                }
            }
        }
   }

    void DrawLine()
    {
         if(drawLine)
         {

         }   
    }

    void DrawRay()
    {
        if (drawRay)
        {

        }
    }
}
