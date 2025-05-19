using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector3 = BEPUutilities.Vector3;
namespace BEPUphysics.Unity
{
    public class BEPUWorld : MonoBehaviour
    {
        public BEPUphysics.Space space;

        public void Awake()
        {

            //关闭物理模拟
            Physics.simulationMode = SimulationMode.Script;
            Physics2D.simulationMode = SimulationMode2D.Script;

            //关闭transform同步(射线)
            Physics.autoSyncTransforms = false;
            Physics2D.autoSyncTransforms = false;

   
            this.space = new BEPUphysics.Space(); // 创建物理世界
            this.space.ForceUpdater.Gravity = new Vector3(0, -9, 0); // 设置重力
        }

        public void Update()
        {
            this.space.Update(); // 模拟迭代物理世界
        }
    }
}