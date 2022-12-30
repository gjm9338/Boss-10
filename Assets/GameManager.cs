using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public float gameTime;
    public float MaxGameTime = 2 * 10f;
    public PoolManager pool;
    public Player player;
    private void Awake()
    {
        instance = this;
        void Update()
        {
            gameTime += Time.deltaTime;
            if(gameTime > MaxGameTime)
            {
                gameTime = MaxGameTime;
            }
        }
    }
}
