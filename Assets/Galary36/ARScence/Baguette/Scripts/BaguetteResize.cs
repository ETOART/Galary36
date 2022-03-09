using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaguetteResize : MonoBehaviour
{
    [SerializeField] private GameObject paint;
    private List<GameObject> baguetteObjects; 
    private Vector3 paintScale;
    private  void Start()
    {
        baguetteObjects = new List<GameObject>();
        for (int i= 0; i< transform.childCount; i++){
            baguetteObjects.Add(transform.GetChild(i).gameObject);
        }
        ReSizeBaguette(paint.transform.localScale);
    }
    private void ReSizeBaguette(Vector3 paintScale){
        float xScale = paintScale.x;
        float yScale = paintScale.y;

        if(xScale != 1){
            Vector3 oldScale = baguetteObjects[2].transform.localScale;
            baguetteObjects[2].transform.localScale = new Vector3(oldScale.x, xScale+xScale*0.1f,oldScale.z);
            oldScale = baguetteObjects[3].transform.localScale;
            baguetteObjects[3].transform.localScale = new Vector3(oldScale.x, xScale+xScale*0.1f,oldScale.z);

            Vector3 oldPosition = baguetteObjects[0].transform.localPosition;
            baguetteObjects[0].transform.localPosition = new Vector3(oldPosition.x + xScale, oldPosition.y, oldPosition.z);
            oldPosition = baguetteObjects[1].transform.localPosition;
            baguetteObjects[1].transform.localPosition = new Vector3(oldPosition.x - xScale, oldPosition.y, oldPosition.z);

        }
        if(yScale != 1){
            Vector3 oldScale = baguetteObjects[0].transform.localScale;
            baguetteObjects[0].transform.localScale = new Vector3(oldScale.x, yScale,oldScale.z);
            oldScale = baguetteObjects[1].transform.localScale;
            baguetteObjects[1].transform.localScale = new Vector3(oldScale.x, yScale,oldScale.z);

            Vector3 oldPosition = baguetteObjects[2].transform.localPosition;
            baguetteObjects[2].transform.localPosition = new Vector3(oldPosition.x + yScale, oldPosition.y, oldPosition.z);
            oldPosition = baguetteObjects[3].transform.localPosition;
            baguetteObjects[3].transform.localPosition = new Vector3(oldPosition.x - yScale, oldPosition.y, oldPosition.z);
        }
    }
}
