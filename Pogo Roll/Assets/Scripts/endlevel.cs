using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endlevel : MonoBehaviour
{

    [SerializeField] private GameObject player;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
		AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
        }
   }
	
 void Update ()
    {
	RestartLevel();
	MenuOpenFromLevel();

	if (player.transform.position.y <= -60) 
	    {
		AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 0);
	    }    
    }

    void RestartLevel()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
		AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 0);
        }
    }

    void MenuOpenFromLevel()
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
		AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(0);
        }
    }

}
