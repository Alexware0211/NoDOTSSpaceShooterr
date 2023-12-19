using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Vector2 Direction { get; set; }
    
    [SerializeField] private float speed;
    const float ScreenWidth = 9.1f;
    const float ScreenHeight = 5.25f;
    void Update()
    {
        transform.Translate(Direction * (speed * Time.deltaTime));
        
        var position = transform.position;
            
        if (position.y < -ScreenHeight ||
            position.y > ScreenHeight ||
            position.x < -ScreenWidth ||
            position.x > ScreenWidth)
        {
            Destroy(this);
        }
        
        List<Asteroid> asteroids = new List<Asteroid>(FindObjectsOfType<Asteroid>());
        foreach (Asteroid asteroid in asteroids)
        {
            if (Vector2.Distance(transform.position, asteroid.transform.position) < 0.5f)
            {
                Destroy(asteroid.gameObject);
            }
        }
    }
}
