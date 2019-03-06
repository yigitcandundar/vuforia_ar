using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ARObjectManager : MonoBehaviour {

    public GameObject arObject;

    public GameObject cube;
    public GameObject sphere;

    private int scoreCounter = 0;
    private int scoreAmount = 5;

    public Text scoreText;

    public void HideObject()
    {
        arObject.SetActive(false);
        GivePoints();
    }

    public void ShowObject()
    {
        arObject.SetActive(true);
        //Greet user
    }
    private void GivePoints()
    {
        scoreCounter += scoreAmount;
        scoreText.text = "Score: " + scoreCounter;
    }
    public void ChangeAppearance()
    {
        if (cube.activeInHierarchy)
        {
            cube.SetActive(false);
            sphere.SetActive(true);
        }
        else
        {
            cube.SetActive(true);
            sphere.SetActive(false);
        }
    }
}
