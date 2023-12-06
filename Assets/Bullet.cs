using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed;
    private Transform _compTransform;
    public int direccionY;
    private int direccionX;
 
    // Start is called before the first frame update
    void Awake()
    {
        _compTransform = GetComponent<Transform>();

    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _compTransform.position = new Vector2(_compTransform.position.x + Speed * direccionX * Time.deltaTime, _compTransform.position.y + Speed * direccionY * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag =="Enemy")
        {
            Destroy(this.gameObject);
           
        }
    }
}
