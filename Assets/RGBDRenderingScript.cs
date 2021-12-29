using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RGBDRenderingScript : MonoBehaviour
{
    [SerializeField]
    Material material;
    [SerializeField]
    Camera cam;
    
    // Start is called before the first frame update
    void Start()
    {
       cam.depthTextureMode = cam.depthTextureMode | DepthTextureMode.Depth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, this.material);
    }
}
