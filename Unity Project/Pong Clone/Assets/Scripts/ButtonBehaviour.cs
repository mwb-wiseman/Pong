using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonBehaviour : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public void OnPointerEnter(PointerEventData eventData)
    {
        this.gameObject.GetComponentInChildren<Outline>().effectColor = Color.white;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        this.gameObject.GetComponentInChildren<Outline>().effectColor = Color.black;
    }

    // To be used when transitioning between the Main Menu and Controls scenes
    public void ChangeSceneWithMusic(int sceneId)
    {
        SceneManager.LoadScene(sceneId);
    }

    // To be used when transitioning between scenes that are not the Main Menu and Controls scenes
    public void ChangeSceneWithoutMusic(int sceneId)
    {
        SceneManager.LoadScene(sceneId);
        // End of AudioManager script, following on from AudioManager.Awake() script
        Destroy(GameObject.Find("AudioManager"));
    }

    public void QuitToDesktop()
    {
        print("QuitToDesktop called");
        Application.Quit();
    }
}
