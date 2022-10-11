using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour

{
    private Image image;
    public GameObject test;

    // Start is called before the first frame update
    private void Start()
    {
        StartFadeIn();
        image = gameObject.GetComponent<Image>();
        var tempColor = image.color;
        tempColor.a = 1f;
        image.color = tempColor;
    }

    // Update is called once per frame
    private void Update()
    {
    }

    public void StartFadeIn()
    {
        LeanTween.alpha(gameObject.GetComponent<RectTransform>(), 0f, 1f).setOnComplete(tweenFinished);
        gameObject.SetActive(true);
    }

    private void tweenFinished()
    {
        gameObject.SetActive(false);
    }
}