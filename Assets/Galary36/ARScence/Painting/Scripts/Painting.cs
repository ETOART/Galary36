using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Painting : MonoBehaviour
{
    [SerializeField] private GameObject _renderPlane;

    public PaintingData _paintingData { get; private set; }


    public void Initialize(PaintingData paintingData)
    {
        _paintingData = paintingData;
        changePlaneTexture();
    }

    private void Awake()
    {
        
    }
    private void Update()
    {
        
    }

    private void changePlaneTexture()
    {
        ChangePlaneScale();
        _renderPlane.GetComponent<Renderer>().material.mainTexture = _paintingData.texture;
    }

    private void ChangePlaneScale()
    {
        _renderPlane.gameObject.transform.localScale = new Vector3(_paintingData.width, 1, _paintingData.height);
    }
}
