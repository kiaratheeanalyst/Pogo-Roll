using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endGametoSelector : MonoBehaviour
{
    public void ReallyEndGame (string levelSelector)
    {
	SceneManager.LoadScene(levelSelector);
    }
}
