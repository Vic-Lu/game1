using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EndGame : MonoBehaviour
{

    public TextMeshProUGUI score;
    // Start is called before the first frame update
    void Start()
    {
        int valorScore = PlayerPrefs.GetInt("puntuacion", 0);
        score.SetText(valorScore.ToString());
    }

    public void finalScreen()
    {
        //
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
