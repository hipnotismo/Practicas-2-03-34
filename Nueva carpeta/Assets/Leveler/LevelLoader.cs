using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelLoader : MonoBehaviour
{
    [SerializeField]
    private int level1BuilderIndex = 1;

    [ContextMenu(itemName:"Load Level 1")]
    private void LoadLevel1()
    {
        SceneManager.LoadScene(level1BuilderIndex);

    }


    [ContextMenu(itemName: "Load Level 1", isValidateFunction:true)]
    private bool ValidateLoadLevel1()
    {
        return level1BuilderIndex != null;

    }
}
