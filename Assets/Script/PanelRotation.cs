using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class PanelRotation : MonoBehaviour
{
    public float speed = 0;
    public GameObject ARCamera;
    public Quaternion position;
    public RectTransform UIElementGameObject;
    private float testing;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        position = ARCamera.transform.rotation;
        transform.eulerAngles = new Vector3(position.x, position.y, position.z);
        //transform.Rotate(position.x, position.y, position.z);
        //LeanTween.rotate(this.gameObject, new Vector3(position.x, position.y, position.z), speed);
    }
}