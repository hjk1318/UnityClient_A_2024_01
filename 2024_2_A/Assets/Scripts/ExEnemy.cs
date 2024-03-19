using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExEnemy : MonoBehaviour
{

    public ExPlayer TargetPlayer;
    private int damage = 20;

    public void AttackPlayer(ExPlayer player)
    {
        player.TakeDamage(damage);
        Debug.Log("�÷��̾� ����");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AttackPlayer(TargetPlayer);
        }
                }
}
