using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeClick : MonoBehaviour
{
    public GameObject cube;
    public GameObject player;
    // Moves the camera to the chosen video area after a transition and
    // enables the relevant game object, while disabling the current one
    public void Transport()
    {
        cube.SetActive(true);
        player.transform.position = new Vector3(10f, 0f, 0f);
        transform.parent.gameObject.SetActive(false);
        gameObject.GetComponent<ButtonHover>().UnHover();
    }
}
