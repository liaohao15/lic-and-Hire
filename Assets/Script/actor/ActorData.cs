using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActorData : MonoBehaviour
{
    [Range(0, 200f)]
    public float MaxHP = 200.0f;

    public Image Bloom;

    [Header("人物基本信息")]
    public float ATK;
    public float DFT;
    public float HP;
    

  

    private void Update()
    {
        HaemalStrand();
    }

    private void HaemalStrand()
    {
        Bloom.fillAmount = HP / MaxHP;
    }


    //public void AddHP(float value)//接收交互系统，传来的value值
    //{
    //    HP = HPChange(HP + value, 0, MaxHP);//应用HPChange方法
    //    Bloodupdate();
    //}
    //private float HPChange(float value, float min, float max)//传进来，这三个值
    //{
    //    return Mathf.Clamp(value, min, max);//将 （HP+value）限制在min 和 max之间
    //}

    public void AddHP(float value)
    { 
        HP = Mathf.Clamp(HP + value, 0, MaxHP);
        HaemalStrand();
        Debug.Log($"人物当前血量：{HP}/{MaxHP}", this);
    }
}
