using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossWeaponData : MonoBehaviour
{
    public enum STATE {IDLE,ACTION }
    public STATE state = STATE.IDLE;    
    public float ATK;
    public float DFT;
    public BossActorData bad;
    public BossWeaponDataController bwdc;

    public void OnTriggerEnter(Collider cok)
    {
        if (state == STATE.IDLE)
        {
            InteractionM player = cok.GetComponent<InteractionM>();
            if (player != null)
            {
                float totalDamage = bad.ATK + ATK;
                player.Dodamage(totalDamage, bwdc.ATKID);
                Debug.Log("BossÎäÆ÷ÃüÖÐÍæ¼Ò£¬ÉËº¦£º" + totalDamage + "£¬ATKID£º" + bwdc.ATKID);
            }

        }

    }


}
