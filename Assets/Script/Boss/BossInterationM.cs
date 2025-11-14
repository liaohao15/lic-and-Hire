using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossInteractionM : MonoBehaviour
{
    public BossActorDataController badc;
    public BossActorController bac;
    public BossActorData bad;
    private int LastTAKID = -1;

    // Start is called before the first frame update
    void Start()
    {
        
        
            
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    //public void Dodamage(InteractionM attacker)//获得列一个攻击者的交互脚本
    //{
    //    //this.adc.HP = this.adc.HP -
    //    // this.adc.data.AddHP(Mathf.Min((-1 * (attacker.adc.TAK() + attacker.wdc.TAK() - this.adc.DEF())), 0));


    //    //this.badc.bad.AddHP(Mathf.Min((-1 * (attacker.ad.ATK - this.bad.DFT)), 0));
    //    //修改成
    //    float damage = Mathf.Min(-1 * (attacker.ad.ATK - this.bad.DFT), 0);
    //    this.badc.bad.AddHP(damage); 

    //    CheckHP();
    //}

    public void Dodamage(float attackerATK, int attackerTADID)
    {
        //this.adc.HP = this.adc.HP -
        // this.adc.data.AddHP(Mathf.Min((-1 * (attacker.adc.TAK() + attacker.wdc.TAK() - this.adc.DEF())), 0));
        //this.ad.AddHP(Mathf.Min((-1* (attacker.ad.ATK - this.ad.DFT)  ),0) );
        if (LastTAKID != attackerTADID)
        {
            float damage = Mathf.Min(-1 * (attackerATK - badc.bad.DFT), 0);
            this.bad.AddHP(damage);
            CheckHP();
            Debug.Log($"Boss受到伤害：{damage}，剩余HP：{badc.bad.HP}");
            LastTAKID = attackerTADID;
        }
    }


    public void CheckHP()
    {
        if (this.badc.HP() <= 0)
        {
            this.bac.Banim.SetTrigger("Death");
        }

    }


}
