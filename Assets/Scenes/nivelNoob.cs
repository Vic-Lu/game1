using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class nivelNoob : MonoBehaviour
{
    // elemento para class nivNoob

    GameObject[] aregloQuestion = new GameObject[10];
    int playerScore;
    public TextMeshProUGUI Score;
    bool correctAnswer;
    int questionNumber;

    public GameObject Q1;
    public GameObject Q2;
    public GameObject Q3;
    public GameObject Q4;
    public GameObject Q5;
    public GameObject Q6;
    public GameObject Q7;
    public GameObject Q8;
    public GameObject Q9;
    public GameObject Q10;
    void rewriteTextScore(int puntos)
    {
        Score.SetText(puntos.ToString() + " puntos");
    }

    // Start is called before the first frame update
    void Start()
    {
        playerScore = 0;
        rewriteTextScore(playerScore);
        Debug.Log(Q1);

        // Q1.SetActive(true);
    
        aregloQuestion[0] = Q1;
        aregloQuestion[1] = Q2;
        aregloQuestion[2] = Q3;
        aregloQuestion[3] = Q4;
        aregloQuestion[4] = Q5;
        aregloQuestion[5] = Q6;
        aregloQuestion[6] = Q7;
        aregloQuestion[7] = Q8;
        aregloQuestion[8] = Q9;
        aregloQuestion[9] = Q10;

        aregloQuestion[0].SetActive(true); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
