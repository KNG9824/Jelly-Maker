using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Vector3[] PointList;

    public RuntimeAnimatorController[] LevelAC;

    public void ChangeAC(Animator anim, int level) { 
    anim.runtimeAnimatorController= LevelAC[level-1];
    
    }
}
