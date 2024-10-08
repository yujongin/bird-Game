using UnityEngine;

public class Background : MonoBehaviour
{
    public float Width;
    public float Speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Speed * Time.deltaTime);

        if (transform.position.x < -Width)
        {
            transform.Translate(new Vector2(Width * 2, 0));
        }
    }
}
