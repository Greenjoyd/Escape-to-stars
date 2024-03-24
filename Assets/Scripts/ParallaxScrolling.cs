using UnityEngine;

public class ParallaxScrolling : MonoBehaviour
{
    public float scrollSpeed = 0.1f;
    private Renderer renderer;


    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    void Update()
    {
        float offset = Time.time * scrollSpeed;
        renderer.material.mainTextureOffset = new Vector3(offset, 0,offset);
    }
}

