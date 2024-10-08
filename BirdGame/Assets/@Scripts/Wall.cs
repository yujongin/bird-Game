using UnityEngine;

public class Wall : MonoBehaviour
{
    public float Speed = 2;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * Speed);  

        if(transform.position.x < -10){
            Destroy(gameObject);
        }
    }
}
