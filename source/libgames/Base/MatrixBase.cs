using System;
using System.Text;
using System.Runtime.CompilerServices;

namespace GAME
{
    /// <summary>
    /// 游戏管理器接口类
    /// </summary>
    public class GMatrixBase
    {
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static GMatrix GetInstance();
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int RandInt(int lower, int upper);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static float RandFloat(float lower, float upper);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static void Log(GLOG_TYPE type, string s);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static string GetConfig(string name);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static GDataManItem GetDataMan(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetServerIndex(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static string GetServerName(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static string GetRoleName(IntPtr p, int id);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void BroadcastMsg(IntPtr p, string s, TCHAT_CHANNEL channel);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void Test(IntPtr p, int n, string s);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetWorldDomainId(IntPtr p, int worldtag, float x, float z, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void TriggerSpawn(int ctrl_id, bool active, int world_tag);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetMapPlayerCount(int worldtag);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetMapNpcCount(int worldtag);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetMapMatterCount(int worldtag);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddDeathMonId(IntPtr p, int n);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddDropItemId(IntPtr p, int n);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddObtainItemId(IntPtr p, int n);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddPickupItemId(IntPtr p, int n);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddUseItemId(IntPtr p, int n);
        private IntPtr nativePtr = new IntPtr();
        /// <summary>
        /// 取得游戏管理器全局对象
        /// </summary>
        /// <returns>管理器对象</returns>
        public static GMatrix GetMatrix()
        {
            return GetInstance();
        }
        /// <summary>
        /// 输出日志
        /// </summary>
        /// <param name="type">日志类型</param>
        /// <param name="s">日志内容</param>
        public static void log(GLOG_TYPE type, string s)
        {
            Log(type, s);
        }
        /// <summary>
        /// 随机函数
        /// </summary>
        /// <param name="lower">最小值</param>
        /// <param name="upper">最大值</param>
        /// <returns>随机数</returns>
        public static int Rand(int lower, int upper)
        {
            return RandInt(lower, upper);
        }
        /// <summary>
        /// 随机函数
        /// </summary>
        /// <param name="lower">最小值</param>
        /// <param name="upper">最大值</param>
        /// <returns>随机数</returns>
        public static float Rand(float lower, float upper)
        {
            return RandFloat(lower, upper);
        }
        /// <summary>
        /// 取得游戏数据管理器
        /// </summary>
        /// <returns>游戏数据管理器对象</returns>
        public GDataManItem GetDataMan()
        {
            return GetDataMan(nativePtr);
        }
        /// <summary>
        /// 取得游戏服务器线路号码
        /// </summary>
        /// <returns>线路号码</returns>
        public int GetServerIndex()
        {
            return GetServerIndex(nativePtr);
        }
        /// <summary>
        /// 取得游戏服务器线路名称
        /// </summary>
        /// <returns>线路名称</returns>
        public string GetServerName()
        {
            return GetServerName(nativePtr);
        }
        /// <summary>
        /// 取得角色名称
        /// </summary>
        /// <param name="id">角色标识</param>
        /// <returns>角色名称</returns>
        public string GetRoleName(int id)
        {
            return GetRoleName(nativePtr, id);
        }
        /// <summary>
        /// 发送广播信息
        /// </summary>
        /// <param name="s">信息内容</param>
        /// <param name="channel">频道类型（0普通，1世界，2组队，3帮派，4密语，9广播）</param>
        public void BroadcastMsg(string s, TCHAT_CHANNEL channel)
        {
            BroadcastMsg(nativePtr, s, channel);
        }
        public void Test(int n,string s)
        {
            Test(nativePtr,n,s);
        }
        public bool SetWorldDomainId(int worldtag, float x, float z, int v)
        {
            return SetWorldDomainId(nativePtr, worldtag, x, z, v);
        }
        /// <summary>
        /// 开启控制器
        /// </summary>
        /// <param name="worldtag">地图标识(-1，则开启所有地图控制器)</param>
        public static void BeginSpawn(int ctrl_id, int world_tag)
        {
            TriggerSpawn(ctrl_id, true, world_tag);
        }
        /// <summary>
        /// 关闭控制器
        /// </summary>
        /// <param name="worldtag">地图标识(-1，则关闭所有地图控制器)</param>
        public static void EndSpawn(int ctrl_id, int world_tag)
        {
            TriggerSpawn(ctrl_id, false, world_tag);
        }
        /// <summary>
        /// 取得指定地图中的角色数量
        /// </summary>
        /// <param name="worldtag">地图标识</param>
        /// <returns>角色数量</returns>
        public static int GetPlayerCount(int worldtag)
        {
            return GetMapPlayerCount(worldtag);
        }
        /// <summary>
        /// 取得指定地图中的NPC数量(怪物及NPC)
        /// </summary>
        /// <param name="worldtag">地图标识</param>
        /// <returns>NPC数量</returns>
        public static int GetNpcCount(int worldtag)
        {
            return GetMapNpcCount(worldtag);
        }
        /// <summary>
        /// 取得指定地图中的物品数量
        /// </summary>
        /// <param name="worldtag">地图标识</param>
        /// <returns>物品数量</returns>
        public static int GetMatterCount(int worldtag)
        {
            return GetMapMatterCount(worldtag);
        }
        public void AddDeathMonId(int n)
        {
            AddDeathMonId(nativePtr, n);
        }
        public void AddDropItemId(int n)
        {
            AddDropItemId(nativePtr, n);
        }
        public void AddObtainItemId(int n)
        {
            AddObtainItemId(nativePtr, n);
        }
        public void AddPickupItemId(int n)
        {
            AddPickupItemId(nativePtr, n);
        }
        public void AddUseItemId(int n)
        {
            AddUseItemId(nativePtr, n);
        }
    }
}
