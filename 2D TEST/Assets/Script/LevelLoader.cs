using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class LevelLoader : MonoBehaviour
{
	public UnityEvent OnEndEvent;
	public int lvlToLoad;
    // Start is called before the first frame update

	public void OnTriggerEnter2D(Collider2D collision)
	{
        GameObject collisonGameObject = collision.gameObject;

        if(collisonGameObject.name == "Player")
		{
			OnEndEvent.Invoke();
            LoadScene();
			
		}
	}

    void LoadScene()
	{
        SceneManager.LoadScene(lvlToLoad);
	}
}
