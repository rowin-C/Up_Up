using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class logicScript : MonoBehaviour
{

    public void restartGame()
    {
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
