using System;
using UnityEngine;

public class NPC : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 4f;
    [SerializeField] private float turnSpeed = 90f;
    [SerializeField] private int startingHp = 100;

    internal void TakeDamage(int amount)
    {
        GetComponent<IHealth>().TakeDamage(amount);
    }

    internal void TakeBleedDamage(int amount, int time)
    {
        GetComponent<IHealth>().TakeBleedDamage(amount, time);
    }

    private void Update()
    {
        transform.position += transform.forward * moveSpeed * Time.deltaTime;
        transform.Rotate(0f, turnSpeed * Time.deltaTime, 0f);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(startingHp / 10);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            TakeBleedDamage(startingHp / 10, 10);
        }
    }

}