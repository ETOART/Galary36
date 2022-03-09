using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintingData 
{
    public Texture texture;
    public float width;
    public float height;

   public PaintingData(Texture texture, float width, float height)
    {
        this.texture = texture;
        this.width = width;
        this.height = height;
    }
}
