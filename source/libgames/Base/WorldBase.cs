using System;
using System.Text;
using System.Runtime.CompilerServices;

namespace GAME
{
    /// <summary>
    /// 地图接口类
    /// </summary>
    public class GWorldBase
    {
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetTag(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetIndex(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool CreateSpawerCtrl(IntPtr p, int ctrl_idx, int condition_id, bool auto_spawn, int spawn_delay, int active_life, int active_date_duration);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool CreateSpawer(IntPtr p, int ctrl_idx, int sp_idx, TSPAWER_TYPE sp_type, TSPAWER_NPC npc_type, TSPAWER_GROUP group_type, bool revive, TSPAWER_REGION region_type, float x, float y, float z, float dx, float dy, float dz, float ex, float ey, float ez, int dir1, int rad, int life_time, int total_num, int phase_id, int reborn_time);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool CreateSpawerNpc(IntPtr p,int sp_idx,int npc_tid,int aggressive,int deffaction,int faction,int deffachelper,int fachelper,int deffacaccept,int facaccept,int dead_tme,int refresh_time,int num,float offset_trn,int path_id,int loop_type,int speed_flag);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool CreateSpawerMine(IntPtr p, int sp_idx, int mid, int num, int refresh_time, float offset_trn);
        private IntPtr nativePtr = new IntPtr();
        /// <summary>
        /// 取得地图标识
        /// </summary>
        /// <returns>地图标识</returns>
        public int GetTag()
        {
            return GetTag(nativePtr);
        }
        /// <summary>
        /// 取得地图索引
        /// </summary>
        /// <returns></returns>
        public int GetIndex()
        {
            return GetIndex(nativePtr);
        }
        /// <summary>
        /// 创建控制器
        /// </summary>
        /// <param name="ctrl_idx">控制器标识</param>
        /// <param name="ctrl_id">控制器标志(用于控制开关)</param>
        /// <param name="auto_spawn">是否正动开启</param>
        /// <param name="spawn_delay">spawn_delay</param>
        /// <param name="active_life">active_life</param>
        /// <param name="active_date_duration">active_date_duration</param>
        /// <returns>成功/失败</returns>
        public bool CreateSpawerCtrl(int ctrl_idx, int ctrl_id, bool auto_spawn, int spawn_delay, int active_life, int active_date_duration)
        {
            return CreateSpawerCtrl(nativePtr, ctrl_idx, ctrl_id, auto_spawn, spawn_delay, active_life, active_date_duration);
        }
        /// <summary>
        /// 创建生成器
        /// </summary>
        /// <param name="ctrl_idx">控制器标识</param>
        /// <param name="sp_idx">生成器标识</param>
        /// <param name="sp_type">生成器类型</param>
        /// <param name="npc_type">NPC类型</param>
        /// <param name="group_type">群组类型</param>
        /// <param name="revive">是否复活</param>
        /// <param name="region_type">区域类型</param>
        /// <param name="x">坐标x</param>
        /// <param name="y">坐标y</param>
        /// <param name="z">坐标z</param>
        /// <param name="dx">ex</param>
        /// <param name="dy">dy</param>
        /// <param name="dz">sz</param>
        /// <param name="ex">ex</param>
        /// <param name="ey">ey</param>
        /// <param name="ez">ez</param>
        /// <param name="dir1">dir1</param>
        /// <param name="rad">rad</param>
        /// <param name="life_time">life_time</param>
        /// <param name="total_num">total_num</param>
        /// <param name="phase_id">phase_id</param>
        /// <param name="reborn_time">reborn_time</param>
        /// <returns>成功/失败</returns>
        public bool CreateSpawer(int ctrl_idx, int sp_idx, TSPAWER_TYPE sp_type, TSPAWER_NPC npc_type, TSPAWER_GROUP group_type, bool revive, TSPAWER_REGION region_type, float x, float y, float z, float dx, float dy, float dz, float ex, float ey, float ez, int dir1, int rad, int life_time, int total_num, int phase_id, int reborn_time)
        {
            return CreateSpawer(nativePtr, ctrl_idx, sp_idx, sp_type, npc_type, group_type, revive, region_type, x, y, z, dx, dy, dz, ex, ey, ez, dir1, rad, life_time, total_num, phase_id, reborn_time);
        }
        /// <summary>
        /// 创建NPC生成条目
        /// </summary>
        /// <param name="sp_idx">生成器标识</param>
        /// <param name="npc_tid">NPC标识</param>
        /// <param name="num">数量</param>
        /// <param name="dead_tme">死亡消失时间</param>
        /// <param name="refresh_time">刷新时间</param>
        /// <param name="aggressive"></param>
        /// <param name="deffaction"></param>
        /// <param name="faction"></param>
        /// <param name="deffachelper"></param>
        /// <param name="fachelper"></param>
        /// <param name="deffacaccept"></param>
        /// <param name="facaccept"></param>
        /// <param name="offset_trn"></param>
        /// <param name="path_id"></param>
        /// <param name="loop_type"></param>
        /// <param name="speed_flag"></param>
        /// <returns>成功/失败</returns>
        public bool CreateSpawerNpc(int sp_idx, int npc_tid, int num, int dead_tme, int refresh_time, int aggressive, int deffaction, int faction, int deffachelper, int fachelper, int deffacaccept, int facaccept, float offset_trn, int path_id, int loop_type, int speed_flag)
        {
            return CreateSpawerNpc(nativePtr, sp_idx, npc_tid, aggressive, deffaction, faction, deffachelper, fachelper, deffacaccept, facaccept, dead_tme, refresh_time, num, offset_trn, path_id, loop_type, speed_flag);
        }
        /// <summary>
        /// 创建矿物生成条目
        /// </summary>
        /// <param name="sp_idx">生成器标识</param>
        /// <param name="mid">矿物标识</param>
        /// <param name="num">数量</param>
        /// <param name="refresh_time">刷新时间</param>
        /// <param name="offset_trn"></param>
        /// <returns>成功/失败</returns>
        public bool CreateSpawerMine(int sp_idx, int mid, int num, int refresh_time, float offset_trn)
        {
            return CreateSpawerMine(sp_idx, mid, num, refresh_time, offset_trn);
        }
    }
}
