using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExcelAsset]
public class Enemy : ScriptableObject
{
	public List<EnemyTest> EnemyStats; // Replace 'EntityType' to an actual type that is serializable.
}
