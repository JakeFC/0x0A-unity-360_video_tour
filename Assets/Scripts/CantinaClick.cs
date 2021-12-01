using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CantinaClick : MonoBehaviour
{
    public GameObject cantina;
    public GameObject player;
    // Moves the camera to the chosen video area after a transition and
    // enables the relevant game object, while disabling the current one
    public void Transport()
    {
        cantina.SetActive(true);
        player.transform.position = new Vector3(0f, 0f, 10f);
        transform.parent.gameObject.SetActive(false);
        gameObject.GetComponent<ButtonHover>().UnHover();
    }
}
