using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BossActorDataController : MonoBehaviour
{
    public BossActorData bad;
    
    public BossWeaponData bwd;
    public int ATKID = 0;

    public float ATK()
    {
        return bad.ATK;
    }

    public float DFT()
    {
        return bad.DFT;
    }

    public float HP()
    {
        return bad.HP;
    }


   
}
