using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WeaponData : MonoBehaviour
{
    public enum STATE { IDLE, ACTION }
    public STATE state = STATE.IDLE;
    public ActorData ad;
    public WeaponDataController wdc;
    [Header("== Current data ==")]
    public float ATK;
    public float DFT;

    public void OnTriggerEnter(Collider col)
    {
        if (state == STATE.ACTION)
        {
            BossInteractionM boss = col.GetComponent<BossInteractionM>();
            if (boss != null)
            {
                float totalDamage = ad.ATK + ATK;
                boss.Dodamage(totalDamage,wdc.ATKID);
                Debug.Log("ÕÊº“Œ‰∆˜√¸÷–Boss£¨…À∫¶£∫" + totalDamage + "£¨ATKID£∫" + wdc.ATKID);
            }
        }
    }


}
