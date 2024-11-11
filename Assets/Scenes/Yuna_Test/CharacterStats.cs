using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCharacterStats", menuName = "Game/Character Stats")]
public class CharacterStats : ScriptableObject
{
    public string characterName;
    public int HP;
    public int ATK;
    public float SPD;
    public float DEF;
    public float STA;
    public float STM;
}
