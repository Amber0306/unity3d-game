using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//测试粒子系统碰撞
public class ParticleCollider : UnityEngine.MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //发生粒子碰撞的回调函数
    private void OnParticleCollision(GameObject other)
    {
        Debug.Log(other.name + "######################");
    }

    //粒子触发的回调函数
    private void OnParticleTrigger()
    {
        //从开始就不断调用？？？？
        //Debug.Log("&&&&&&&&&&&&&trigger of the particle");
        //测试粒子触发器
        //ParticleSystem ps = transform.GetComponent<ParticleSystem>();

        //List<ParticleSystem.Particle> enter = new List<ParticleSystem.Particle>();
        //List<ParticleSystem.Particle> exit = new List<ParticleSystem.Particle>();
        ////particleSystemTriggerEventType为枚举类型，Enter,Exit,Inside,Outside,对应粒子系统属性面板上的四个选项
        //int numEnter = ps.GetTriggerParticles(ParticleSystemTriggerEventType.Enter, enter);
        //int numExit = ps.GetTriggerParticles(ParticleSystemTriggerEventType.Exit, exit);
        ////进入触发器，粒子变为红色
        //for (int i = 0; i < numEnter; i++)
        //{
        //    ParticleSystem.Particle p = enter[i];
        //    p.startColor = Color.red;
        //    enter[i] = p;
        //}
        ////退出触发器 粒子变为蓝绿色
        //for (int i = 0; i < numExit; i++)
        //{
        //    ParticleSystem.Particle p = exit[i];
        //    p.startColor = Color.cyan;
        //    exit[i] = p;
        //}

        //ps.SetTriggerParticles(ParticleSystemTriggerEventType.Enter, enter);
        //ps.SetTriggerParticles(ParticleSystemTriggerEventType.Exit, exit);
    }

}
