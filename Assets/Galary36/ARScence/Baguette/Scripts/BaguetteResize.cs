using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaguetteResize : MonoBehaviour
{
    private Transform paint;
    private List<Transform> baguetteObjects; 
    private List<Vector3> baguetteScales;
    private List<Vector3> baguettePosition;
    
    private  void Start()
    {
        Initialize();
        ReSizeBaguette(paint.localScale);
    }
    private void ReSizeBaguette(Vector3 paintScale){
        float xScale = paintScale.x;
        float yScale = paintScale.y;
        if(xScale != 1){
            baguetteObjects[2].localScale = new Vector3((baguetteScales[2].x+(xScale-1)),(baguetteScales[2].y),baguetteScales[2].z );
            baguetteObjects[3].localScale = new Vector3((baguetteScales[3].x+(xScale-1)),(baguetteScales[3].y),baguetteScales[3].z );

            baguetteObjects[2].localPosition = new Vector3((baguettePosition[2].x),(baguettePosition[2].y+(xScale-1)/11),baguettePosition[2].z );
            baguetteObjects[3].localPosition = new Vector3((baguettePosition[3].x),(baguettePosition[3].y-(xScale-1)/11),baguettePosition[3].z );
        }
     
        
    }
    private void Initialize(){
        paint = transform.parent.gameObject.GetComponent<Transform>();

        baguetteObjects = new List<Transform>();
        baguetteScales = new List<Vector3>();
        baguettePosition = new List<Vector3>();
        for (int i= 0; i< transform.childCount; i++){
            baguetteObjects.Add(transform.GetChild(i).gameObject.transform);
            baguetteScales.Add(transform.GetChild(i).gameObject.transform.localScale);
            baguettePosition.Add(transform.GetChild(i).gameObject.transform.localPosition);
        }
    }
}
