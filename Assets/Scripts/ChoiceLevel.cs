using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ChoiceLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(" Ready to Go ");
    }

    public void TooEasy()
    {
        SceneManager.LoadScene(2);
        Debug.Log("Go Back to your Bed after this Kiddo");
       
    }

    public void TooHorny()
    {
        SceneManager.LoadScene(3);
        Debug.Log(". . .   do you Really wants more of this Bro ? ");
    }

    public void TooHard()
    {
        SceneManager.LoadScene(4);
        Debug.Log("  ... Don´t said that I haven´t Warned You Hopeless Moron !!");
    }


}
