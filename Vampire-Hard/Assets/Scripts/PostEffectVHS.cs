using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostEffectVHS : MonoBehaviour
{
    public Material mat;
    [ExecuteInEditMode]
    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, mat);     
    }
}
