using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class nivelNoob : MonoBehaviour
{
    // elemento para class nivNoob

    int playerScore;
    public TextMeshProUGUI Score;
    bool correctAnswer;

    void rewriteTextScore(int puntos)
    {
        Score.SetText(puntos.ToString() + " puntos");
    }

    // Start is called before the first frame update
    void Start()
    {
        playerScore = 0;
        rewriteTextScore(playerScore);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
