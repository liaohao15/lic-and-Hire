using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ActorDataController : MonoBehaviour
{

    public ActorData ad;

    public float ATK()
    {
        return ad.ATK;
    }

    public float DFT()
    {
        return ad.DFT;
    }

    public float HP()
    {
        return ad.HP;
    }
}
