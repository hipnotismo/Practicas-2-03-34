using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private TMP_Text scoreText;

    private void OnEnbla()
    {
        player.OnUpdateScore += HandleUpdateScore;
    }

    private void OnDisable()
    {
        player.OnUpdateScore -= HandleUpdateScore;

    }

    private void HandleUpdateScore(int newScore)
    {
        scoreText.text = $"Score: {newScore}";
    }
}
