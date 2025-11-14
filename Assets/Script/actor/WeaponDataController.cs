using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponDataController : MonoBehaviour
{
    public WeaponData wdt;
    public int ATKID = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (wdt == null) Debug.LogError("WeaponDataÎª¸ºÖµ", this);
    }

    public float ATK()
    {
        return wdt.ATK;

    }
    public float DFT()
    {
        return wdt.DFT;
    }

    public void EQenable()
    {
        wdt.state = WeaponData.STATE.ACTION;
    }
    public void EQdisable()
    {
        wdt.state = WeaponData.STATE.IDLE;
        ATKID++;
    }


}
