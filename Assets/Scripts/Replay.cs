using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(0);
        Debug.Log(" Don´t You have Enough  eehh Pal ? ");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
