using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceenTransitions : MonoBehaviour
{
    public UIManager manager;

    public void ToRoom2()
    {
        SceneManager.LoadScene("Room 2");
    }

    public void ToRoom3()
    {     
        SceneManager.LoadScene("Room 3");
    }

    public void ToRoom4()
    {
        SceneManager.LoadScene("Room 4");
    }




    public void Room2()
    {     
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void Room3()
    {    
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void Room4()
    {     
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
    }

    public void Room5()
    {      
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
    }

    public void Room6()
    {      
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
    }

    public void Room7()
    {      
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 10);
    }
    public void Room8()
    {    
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 8);
    }



    public void TransitionPainting()
    {      
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 8);
    }

    public void TransitionAztek()
    {        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 7);
    }
}
