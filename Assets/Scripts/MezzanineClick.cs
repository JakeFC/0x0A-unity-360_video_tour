using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MezzanineClick : MonoBehaviour
{
    public GameObject mezzanine;
    public GameObject player;
    public SpriteRenderer blackScreen;

    public void Transition()
    {
        mezzanine.SetActive(true);
        StartCoroutine("Fade");
    }
    // Moves the camera to the chosen video area after a transition and
    // enables the relevant game object, while disabling the current one
    private void Transport()
    {
        player.transform.position = new Vector3(10f, 0f, 10f);
    }

    public IEnumerator Fade()
    {
        Color imageColor = blackScreen.color;
        float fadeAmount;

        while (imageColor.a < 1)
        {
            fadeAmount = imageColor.a + (Time.deltaTime);

            imageColor = new Color(imageColor.r, imageColor.g, imageColor.b, fadeAmount);
            blackScreen.color = imageColor;
            yield return null;
        }

        Transport();

        while (imageColor.a > 0)
        {
            fadeAmount = imageColor.a - (Time.deltaTime);

            imageColor = new Color(imageColor.r, imageColor.g, imageColor.b, fadeAmount);
            blackScreen.color = imageColor;
            yield return null;
        }

        transform.parent.gameObject.SetActive(false);
    }
}
