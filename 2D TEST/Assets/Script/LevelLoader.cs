using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelLoader : MonoBehaviour
{
    public int lvlToLoad;
    // Start is called before the first frame update

	private void OnTriggerEnter2D(Collider2D collision)
	{
        GameObject collisonGameObject = collision.gameObject;

        if(collisonGameObject.name == "Player")
		{
            LoadScene();
		}
	}

    void LoadScene()
	{
        SceneManager.LoadScene(lvlToLoad);
	}
}
