using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public GameObject efectoMuerte;
    public Puntaje puntaje;
    private Rigidbody2D _compRigidbody;
    public float SpeedY;
    // Start is called before the first frame update
    void Awake()
    {
        _compRigidbody = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        _compRigidbody.velocity = new Vector2(0, SpeedY);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            Instantiate(efectoMuerte, transform.position, transform.rotation);
            
            Destroy(this.gameObject);
            puntaje.UpdatePoints(1);
        }
        if(other.gameObject.tag == "HorizontalWall")
        {
            Destroy(this.gameObject);
        }

    }
    public void SetGameManager(Puntaje gm)
    {
        puntaje = gm;
    }
}
