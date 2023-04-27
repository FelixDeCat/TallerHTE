using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="NpcData", menuName ="Entity/Npc")]
public class NpcData : ScriptableObject
{
    public int life;
    public int energy;
    public int damage;
    public type_npc type;
    public Npc refe;
}

public enum type_npc
{
    hostil,
    ally,
    neutral
}