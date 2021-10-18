using System;
using System.Text;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using SKILL;

namespace GAME
{
    /// <summary>
    /// 游戏角色类
    /// </summary>
    public class GPlayerImp : GPlayerBase
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public GPlayerImp()
        {

        }
        protected void OnSwap(GPlayerImp rhs)
        {

        }
        /// <summary>
        /// 角色处理心跳回调函数
        /// </summary>
        /// <param name="tick">二次心跳间隔时间（秒）</param>
        protected void OnHeartbeat(uint tick)
        {

        }
        /// <summary>
        /// 角色进入游戏回调函数
        /// </summary>
        protected void OnEnterWorld()
        {

        }
        /// <summary>
        /// 角色离开游戏回调函数
        /// </summary>
        protected void OnLeaveWorld()
        {

        }
        /// <summary>
        /// 角色进入地图回调函数
        /// </summary>
        /// <param name="old_tag">原来地图标识</param>
        /// <param name="old_x">原来地图坐标X</param>
        /// <param name="old_y">原来地图坐标Y</param>
        /// <param name="old_z">原来地图坐标Z</param>
        protected void OnEnterMap(int old_tag, float old_x, float old_y, float old_z)
        {

        }
        /// <summary>
        /// 角色离开地图回调函数
        /// </summary>
        protected void OnLeaveMap()
        {

        }
        /// <summary>
        /// 角色杀死怪物回调函数
        /// </summary>
        /// <param name="id">怪物标识</param>
        /// <param name="tid">怪物EL标识</param>
        /// <param name="exp">爆出经验值</param>
        /// <param name="world_tag">地图标识</param>
        /// <param name="x">坐标X</param>
        /// <param name="y">坐标Y</param>
        /// <param name="z">坐标Z</param>
        protected void OnKillNpc(int id, int tid, Int64 exp, int world_tag, float x, float y, float z)
        {

        }
        /// <summary>
        /// 角色死亡回调函数
        /// </summary>
        /// <param name="type">攻击者类型</param>
        /// <param name="id">攻击者标识</param>
        protected void OnDeath(int type, int id, int tid)
        {

        }
        /// <summary>
        /// 角色等级提升回调函数
        /// </summary>
        /// <param name="level_old">原等级</param>
        /// <param name="level_new">新等级</param>
        /// <param name="level_reborn">飞升次数</param>
        protected void OnLevelUp(int level_old, int level_new, int level_reborn)
        {

        }
        /// <summary>
        /// 角色转重回调函数
        /// </summary>
        /// <param name="old_prof">原职业</param>
        /// <param name="new_prof">新职业</param>
        protected void OnNewProfession(TOCCUPATION old_prof, TOCCUPATION new_prof)
        {

        }
        /// <summary>
        /// 角色飞升回调函数
        /// </summary>
        /// <param name="old_prof">原职业</param>
        /// <param name="new_prof">新职业</param>
        protected void OnMetempsychosis(TOCCUPATION old_prof, TOCCUPATION new_prof)
        {

        }
        /// <summary>
        /// 角色获得物品回调函数
        /// </summary>
        /// <param name="item_where">物品包裹</param>
        /// <param name="item_type">物品类型</param>
        /// <param name="item_count">物品数量</param>
        /// <param name="deliver_type">获得方式</param>
        protected void OnObtainItem(int item_where, int item_type, int item_count, TITEM_INIT_TYPE deliver_type)
        {

        }
        /// <summary>
        /// 角色捡起物品回调函数
        /// </summary>
        /// <param name="item_type">物品类型</param>
        /// <param name="total_count">物品数量</param>
        /// <param name="pickup_count">捡起数量</param>
        /// <param name="drop_id">物品所属标识</param>
        /// <param name="worldtag">地图号</param>
        /// <param name="x">坐标X</param>
        /// <param name="y">坐标Y</param>
        /// <param name="z">坐标Z</param>
        protected void OnPickupItem(int item_type, int total_count, int pickup_count, int drop_id, int worldtag, float x, float y, float z)
        {

        }
        protected int OnChatMessage(int channel, string message)
        {
            return -1;
        }
        /// <summary>
        /// 物品是否可以使用
        /// </summary>
        /// <param name="l">物品位置(0,背包)</param>
        /// <param name="type">物品类型</param>
        /// <returns>-1未处理调用原流程，1可以使用，0不可以使用</returns>
        protected int OnItemCanUse(int l, int type)
        {
            return -1;
        }
        /// <summary>
        /// 使用物品
        /// </summary>
        /// <param name="l">包裹位置(0,背包)</param>
        /// <param name="index">物品包裹中的位置</param>
        /// <param name="type">物品类型</param>
        /// <returns>-1未处理调用原流程，1删除物品，0保留物品</returns>
        protected int OnItemUse(int l, uint index, int type)
        {
            return -1;
        }
        /// <summary>
        /// 装备穿脱回调
        /// </summary>
        /// <param name="type_inv">穿上的装备类型</param>
        /// <param name="type_equip">脱下的装备类型</param>
        protected void OnItemEquip(int type_inv, int type_equip)
        {

        }
        /// <summary>
        /// 添加元宝回调
        /// </summary>
        /// <param name="retcode">结果(0为成功)</param>
        /// <param name="cash">银元宝数量</param>
        /// <param name="aid">添加渠道</param>
        /// <param name="present">是否为赠送</param>
        protected void OnPayCashResult(int retcode, int cash, int aid, bool present)
        {

        }
        /// <summary>
        /// 过滤器添加回调
        /// </summary>
        /// <param name="id">过滤器标识</param>
        /// <param name="var0">自定义变量</param>
        /// <param name="var5">物品类型</param>
        /// var0..5 为自定义变量，在添加过滤器时传入
        protected void OnFilterAttach(FILTER_TYPE id, ref int var0, ref int var1, ref int var2, ref int var3, ref int var4, ref int var5)
        {

        }
        /// <summary>
        /// 过滤器删除回调
        /// </summary>
        /// <param name="id">过滤器标识</param>
        /// <param name="var0">自定义变量</param>
        /// <param name="var5">自定义变量</param>
        /// var0..5 为自定义变量，在添加过滤器时传入
        protected void OnFilterDetach(FILTER_TYPE id, ref int var0, ref int var1, ref int var2, ref int var3, ref int var4, ref int var5)
        {

        }
        /// <summary>
        /// 过滤器心跳回调
        /// </summary>
        /// <param name="tick">秒数</param>
        /// <param name="id">过滤器标识</param>
        /// <param name="var0">自定义变量</param>
        /// <param name="var5">自定义变量</param>
        /// var0..5 为自定义变量，在添加过滤器时传入
        protected void OnFilterHeartbeat(int tick, FILTER_TYPE id, ref int var0, ref int var1, ref int var2, ref int var3, ref int var4, ref int var5)
        {

        }
    }
}
