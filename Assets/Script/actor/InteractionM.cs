using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionM : MonoBehaviour
{
    public ActorDataController adc;
    public ActorController ac;
    public ActorData ad;
    public WeaponDataController wdc;

    private int LastTAKID = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Dodamage(float attackerATK,int attackerATKID)
    {
        //this.adc.HP = this.adc.HP -
        // this.adc.data.AddHP(Mathf.Min((-1 * (attacker.adc.TAK() + attacker.wdc.TAK() - this.adc.DEF())), 0));

        //this.ad.AddHP(Mathf.Min((-1* (attacker.ad.ATK - this.ad.DFT)  ),0) );
        if (LastTAKID != attackerATKID)
        {
            float damage = Mathf.Min(-1 * (attackerATK - this.ad.DFT), 0);
            this.ad.AddHP(damage);
            CheckHP();
            Debug.Log($"ÕÊº“ ‹µΩ…À∫¶£∫{damage}£¨ £”‡HP£∫{ad.HP}");
            LastTAKID= attackerATKID;
        }


     }



    public void CheckHP()
    {
        if ( this.adc.HP() <= 0)
        {
            this.ac.anim.SetTrigger("Death");
        }
      
    }


}
