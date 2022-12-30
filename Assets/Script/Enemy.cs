using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public Rigidbody2D target;
    bool Live;
    Rigidbody2D rig;
    SpriteRenderer sprren;
    private void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
        sprren = GetComponent<SpriteRenderer>();
    }


    void FixedUpdate()
    {
        Vector2 dirVec = target.position - rig.position;
        Vector2 nextVec = dirVec.normalized * speed * Time.fixedDeltaTime;
        rig.MovePosition(rig.position + nextVec);
        rig.velocity = Vector2.zero;
        
    }
    private void OnEnable()
    {
        target = GameManager.instance.player.GetComponent<Rigidbody2D>();
    }
}
