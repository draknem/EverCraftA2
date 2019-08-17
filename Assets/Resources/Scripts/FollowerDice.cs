using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerDice : MonoBehaviour
{
    public Transform hero;
    public Transform dice;
    public float voffset = 0.35f;
    public Camera maincam;

    void FixedUpdate()
    {
        Vector3 offset = new Vector3 (0f, maincam.orthographicSize/2 + voffset, 0f);
        // /2 +0.35f, 0f);
        dice.SetPositionAndRotation(hero.position+offset, dice.rotation);
    }
}
