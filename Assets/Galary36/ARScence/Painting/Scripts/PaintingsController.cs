using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaintingsController : MonoBehaviour
{
    [SerializeField] private GameObject _paintingPrefab;
    [SerializeField] private List<Texture> _images;
    // Start is called before the first frame update
    void Start()
    {
        PaintingData paintingData = new PaintingData(_images[0], (float)_images[0].width / _images[0].height, (float)_images[0].height / _images[0].height);
        GameObject paintingGameObj = Instantiate(_paintingPrefab, gameObject.transform.position, Quaternion.identity);
        //paintingGameObj.transform.parent = gameObject.transform;
        Painting painting = paintingGameObj.GetComponent<Painting>();
        painting.Initialize(paintingData);
        GameObject prevPainting = paintingGameObj;
        PaintingData prevPaintingData = paintingData;
        for (int i = 1; i < _images.Capacity; i++)
        {
            paintingData = new PaintingData(_images[i], (float)_images[i].width / _images[i].height, (float)_images[i].height / _images[i].height);
            paintingGameObj = Instantiate(_paintingPrefab, prevPainting.transform.position + new Vector3(paintingData.width / 2f * 10 + prevPaintingData.width / 2f * 10 + 0.25f, 0, 0), Quaternion.identity);
            //paintingGameObj.transform.parent = gameObject.transform;
            painting = paintingGameObj.GetComponent<Painting>();
            painting.Initialize(paintingData);
            prevPainting = paintingGameObj;
            prevPaintingData = paintingData;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
