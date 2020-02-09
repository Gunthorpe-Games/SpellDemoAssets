using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IKtest : MonoBehaviour
{
    public Animator anim;
    public GameObject target;
    void OnAnimatorIK()
    {
        anim.SetIKPositionWeight(AvatarIKGoal.RightHand, 1f);
        anim.SetIKPosition(AvatarIKGoal.RightHand, target.transform.position);
        anim.SetIKRotationWeight(AvatarIKGoal.RightHand, 1f);
        anim.SetIKRotation(AvatarIKGoal.RightHand, target.transform.rotation);
    }
}