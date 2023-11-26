using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlnave : MonoBehaviour
{
    private Transform _comtras;
    public int velocidad=5;
    // Start is called before the first frame update
    void Awake()
    {
        _comtras = GetComponent<Transform>();
    }
      
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float verti = Input.GetAxis("Vertical");
        _comtras.position = new Vector2(_comtras.position.x +horizontal*velocidad*Time.deltaTime,_comtras.position.y+verti*velocidad*Time.deltaTime);
    }
    private void FixedUpdate()
    {
        
    }
}
