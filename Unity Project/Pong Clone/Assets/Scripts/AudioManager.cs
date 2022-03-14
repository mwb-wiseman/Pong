using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance = null;
    public static AudioManager Instance
    {
        get { return instance; }
    }

    void Awake()
    {
        // If on Main Menu or Control scenes
        if (SceneManager.GetActiveScene().buildIndex == 0 || SceneManager.GetActiveScene().buildIndex == 3)
        {
            // If another instance of this script is already open destroy the new one 
            if (instance != null && instance != this)
            {
                Destroy(this.gameObject);
                return;
            }
            else
            {
                // If there is no other instance in existence, set this as the instance
                instance = this;
            }
            // Don't destroy the instance when loading a new scene
            DontDestroyOnLoad(this.gameObject);

            // See ButtonBehaviour.ChangeSceneWithoutMusic() for end of instance code
        }
    }

    public void PlayObjectSound(GameObject gameObject)
    {
        gameObject.GetComponent<AudioSource>().Play();
    }
}
