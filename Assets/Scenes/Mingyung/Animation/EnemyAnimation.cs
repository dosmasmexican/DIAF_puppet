using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;

public class EnemyAnimation : MonoBehaviour
{
    public Animator enemyAnim;
    void Start()
    {
        enemyAnim.SetInteger("AnimationState", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
