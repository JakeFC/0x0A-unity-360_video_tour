using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoClick : MonoBehaviour
{
    private GameObject text;
    public void InfoPop()
    {
        text = this.gameObject.transform.GetChild(1).gameObject;

        if (text.activeSelf)
        {
            text.SetActive(false);
        }
        else
        {
            text.SetActive(true);
        }
    }
}
