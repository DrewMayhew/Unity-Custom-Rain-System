using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HashIDs : MonoBehaviour
{

    public int walkState;
    public int speedFloat;
    public int sneakingBool;
    public int posingBool;

    void Awake()
    {

        walkState = Animator.StringToHash("Walk");
        speedFloat = Animator.StringToHash("Speed");
        sneakingBool = Animator.StringToHash("Sneaking");
        posingBool = Animator.StringToHash("Posing");

    }
}