using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossWeaponDataController : MonoBehaviour
{
    public BossWeaponData bwdt;
    public int ATKID = 1;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {

    }

    public float ATK()
    {
        return bwdt.ATK;

    }
    public float DFT()
    {
        return bwdt.DFT;
    }
    public void EQenable()
    {
       bwdt.state = BossWeaponData.STATE.ACTION;
    }
    public void EQdisable()
    {
        bwdt.state = BossWeaponData.STATE.IDLE;
        ATKID++;
    }
}
