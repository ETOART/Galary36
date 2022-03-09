using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Painting : MonoBehaviour
{
    [SerializeField] private Texture _texture;
    [SerializeField] private GameObject _renderPlane;

    private void Awake()
    {
        changePlaneTexture(_texture);
    }
    private void Update()
    {
        changePlaneTexture(_texture);
    }

    private void changePlaneTexture(Texture texture)
    {
        ChangePlaneScale(texture.width,texture.height);
        _renderPlane.GetComponent<Renderer>().material.mainTexture = texture;
    }

    private void ChangePlaneScale(float width, float height)
    {
        _renderPlane.gameObject.transform.localScale = new Vector3(width / height, 1, 1);
    }
}
