using UnityEngine;

public class Monster : MonoBehaviour
{
    public Rigidbody2D RB;
    public PlayerScript Player;
    public float Speed = 1;

    // Update is called once per frame
    void Update()
    {
        Vector2 vel = new Vector2(0,0);
        if (transform.position.x < Player.transform.position.x)
        {

            vel.x = Speed;
        }
        if (transform.position.x > Player.transform.position.x)
        {

            vel.x = -Speed;
        }
        if (transform.position.y < Player.transform.position.y)
        {

            vel.y = Speed;
        }
        

        RB.linearVelocity = vel;
    }
}
