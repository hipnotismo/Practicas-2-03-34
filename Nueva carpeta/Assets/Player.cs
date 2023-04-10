using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public delegate void ScoreEvent(int newScore);
    private int _score;
    public ScoreEvent OnUpdateScore;

    [ContextMenu(itemName:"Test Update Score")]
   private void TestUpdateScore()
    {
        _score++;
        OnUpdateScore(_score);
    }
}
