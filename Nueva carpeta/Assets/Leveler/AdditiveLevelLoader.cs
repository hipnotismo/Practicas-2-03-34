using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class AdditiveLevelLoader : MonoBehaviour
{
    [SerializeField]
    private int level1BuilderIndex = 1;

    [ContextMenu(itemName: "Load Level 1")]
    private void LoadLevel()
    {
        SceneManager.LoadScene(level1BuilderIndex, LoadSceneMode.Additive);

    }

    public void LoadLevel(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex, LoadSceneMode.Additive);

    }

    [ContextMenu(itemName: "Load Level 1", isValidateFunction: true)]
    private bool ValidateLoadLevel1()
    {
        return level1BuilderIndex != null;

    }

    [ContextMenu(itemName: "Unload Load Level ")]
    public void UnloadLevel()
    {
        SceneManager.UnloadSceneAsync(level1BuilderIndex);
    }
}
