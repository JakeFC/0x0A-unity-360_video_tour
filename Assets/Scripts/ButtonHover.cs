using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class ButtonHover : MonoBehaviour
{
    public void Hover()
    {
        Vector3 temp = transform.localScale;
        temp.x *= 1.5f;
        temp.y *= 1.5f;
        transform.localScale = temp;
    }

    public void UnHover()
    {
        Vector3 temp = transform.localScale;
        temp.x /= 1.5f;
        temp.y /= 1.5f;
        transform.localScale = temp;
    }

    private Transform button;
    public void InfoHover()
    {
        button = this.gameObject.transform.GetChild(0);
        Vector3 temp = button.localScale;
        temp.x *= 1.5f;
        temp.y *= 1.5f;
        button.localScale = temp;
    }

    public void InfoUnHover()
    {
        button = this.gameObject.transform.GetChild(0);
        Vector3 temp = button.localScale;
        temp.x /= 1.5f;
        temp.y /= 1.5f;
        button.localScale = temp;
    }
}
