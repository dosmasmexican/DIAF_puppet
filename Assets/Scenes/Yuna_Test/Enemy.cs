using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public CharacterStats stats;

    void Start()
    {
        Debug.Log($"Enemy: {stats.characterName}");
        Debug.Log($"HP: {stats.HP}");
        Debug.Log($"ATK: {stats.ATK}");
        Debug.Log($"SPD: {stats.SPD}");
        Debug.Log($"SPD: {stats.DEF}");
        Debug.Log($"SPD: {stats.STA}");
        Debug.Log($"SPD: {stats.STM}");
    }

    public void TakeDamage(int damage)
    {
        stats.HP -= damage;
        Debug.Log($"Health after damage: {stats.HP}");
    }
}
