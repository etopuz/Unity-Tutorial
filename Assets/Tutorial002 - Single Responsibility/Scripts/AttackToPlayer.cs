using System;
using UnityEngine;

public class AttackToPlayer : MonoBehaviour
{
    [SerializeField] private int damageAmount = 10;
    [SerializeField] private BadGeneralPlayerClass badGeneralPlayerClass;
    [SerializeField] private BasePlayer basePlayer;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Attack();
        }
    }

    private void Attack()
    {
        badGeneralPlayerClass.TakeDamage(damageAmount);
        basePlayer.TakeDamage(damageAmount);
    }
}
