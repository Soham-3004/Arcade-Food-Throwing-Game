using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public float rotateSpeed = 10f;
    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;
        
       
    }
    
    void Update()
    {
        transform.Rotate(rotateSpeed * Time.deltaTime, 0.0f, 0.0f);
        Material material = Renderer.material;

        float colx = Random.Range(0f, 1f);
        float coly = Random.Range(0f, 1f);
        float colz = Random.Range(0f, 1f);
        float op = Random.Range(0f, 1f);
        material.color = new Color(colx, coly, colz, op);
    }
}
