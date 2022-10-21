using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public Transform player;
    public Transform Bg1;
    public Transform Bg2;
    public Transform Bg3;
    public float limit = 12f;

        void Start()
        {
        
        }

        void Update()
        { 
            if (player.position.x != transform.position.x && player.position.x < limit)
            {
            transform.position = Vector3.Lerp(transform.position, new Vector3(player.position.x, transform.position.y, transform.position.z), 1.0f);
            }
            Bg1.transform.position = new Vector2(transform.position.x * 1.0f, Bg1.transform.position.y);
            Bg2.transform.position = new Vector2(transform.position.x * 0.8f, Bg2.transform.position.y);
            Bg3.transform.position = new Vector2(transform.position.x * 0.6f, Bg3.transform.position.y);
        }
}
