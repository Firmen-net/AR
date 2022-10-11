using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour
{
    private Image image;

    // Start is called before the first frame update
    private void Start()
    {
        image = gameObject.GetComponent<Image>();
        var tempColor = image.color;
        tempColor.a = 0f;
        image.color = tempColor;
    }

    // Update is called once per frame
    private void Update()
    {
    }

    public void StartFadeOut()
    {
        LeanTween.alpha(gameObject.GetComponent<RectTransform>(), 1f, 1f);
        gameObject.SetActive(true);
    }
}