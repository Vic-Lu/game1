using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

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

    int preguntaActual;
    void rewriteTextScore(int puntos)
    {
        Score.SetText(puntos.ToString() + " puntos");
    }

    // Start is called before the first frame update
    void Start()
    {
        
        playerScore = 0;
        preguntaActual = 0;
        rewriteTextScore(playerScore);
        indexarAreglo();
        cerrarTodosPaneles();
        mezclarPreguntas();
        aregloQuestion[preguntaActual].SetActive(true);
    }

    public void revisarRespuesta()
    {
        GameObject boton = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject;
        bool esCorrecto = boton.GetComponent<mejoraboton>().bottonCorrect;

        if (esCorrecto == true)
        {
            // Si es correcto
            playerScore = playerScore + 100;
            rewriteTextScore(playerScore);
            preguntaActual = preguntaActual + 1;
            siguientePregunta();
        }
        else
        {
            // Si no es correcto
        }

    }

    public void siguientePregunta()
    {
        // Cerrar todos los paneles
        cerrarTodosPaneles();

        // regresar valor a 10
        if (preguntaActual >= 10)
        {
            PlayerPrefs.SetInt("puntuacion", playerScore);
            SceneManager.LoadScene(5);
        }
        else
        {
            // Abrir siguiente pregunta
            aregloQuestion[preguntaActual].SetActive(true);
        }

    }

    public void cerrarTodosPaneles()
    {
        aregloQuestion[0].SetActive(false);
        aregloQuestion[1].SetActive(false);
        aregloQuestion[2].SetActive(false);
        aregloQuestion[3].SetActive(false);
        aregloQuestion[4].SetActive(false);
        aregloQuestion[5].SetActive(false);
        aregloQuestion[6].SetActive(false);
        aregloQuestion[7].SetActive(false);
        aregloQuestion[8].SetActive(false);
        aregloQuestion[9].SetActive(false);
    }

    public void mezclarPreguntas()
    {
        GameObject temporal;
        for (int i = 0; i < aregloQuestion.Length; i++)
        {
            int numeroRandom = Random.Range(0, aregloQuestion.Length);
            temporal = aregloQuestion[numeroRandom];
            aregloQuestion[numeroRandom] = aregloQuestion[i];
            aregloQuestion[i] = temporal;
        }
    }

    void indexarAreglo()
    {
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

    }

}
