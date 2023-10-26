using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        // SceneManager.LoadScene(0); 
    }

    public void InicioGame()
    {
        SceneManager.LoadScene(2);
    }
    public void SelectDifficulty()
    {
        SceneManager.LoadScene(1);
    }

    




    //  ________________________________________________________________

    //  Class preguntas  Hard:
    // 1 ¿ a quien refiere el termino ¨Pipero¨ ?
    // 2 ¿ de que habla la cancion de Ramstein ¨Links¨ ?
    // 3 ¿ cual es la mejor forma de eliminar a los Undead en final Fantasy?
    // 4 ¿ cual fue la consola portatil de Bandai?
    // 5  ¿ que significa 0010100 1010111  ?
    // 6 ¿ cual seria la equivalencia 3D a los pixels?
    // 7 ¿ a que se debe el famoso efecto de neblina en Silent hill ?
    // 8 ¿ que significa el termino ¨DirectX¨ ?
    // 9 ¿  a quien hace referencia el slogan ¨ Power yours Dreams ¨?
    // 10 ¿ quien mato a Sega ?

    //  _________________________________________________________________

    // Class respestas Hard
    // 1 conductor de pipas, quien come pipas, groupies de PS(*) , un idiota
    // 2 una aventura de link, un sitio web, hormigas, una marcha(*)
    // 3 phoenix down(*) , cure , run , fire  
    // 4 gameboy  , wonderswan(*) , PSP, ncage
    // 5 101011 , numeros , codigo , S117(*)
    // 6 poligonos, voxels(*) , shadders, renders
    // 7 decision artistica, crush, limitaciones tecnicas(*) , raytracing
    // 8 API(*) , nopor , charles xavier, una pieza de hardware
    // 9 dreamcast , colchones , pildoras para dormir, xbox series(*)
    // 10 Roger rabbit, Dreamcast, malas deciciones(*) , pirateria

}
