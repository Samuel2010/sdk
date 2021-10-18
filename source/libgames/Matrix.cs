using System;
using System.Text;
using System.Collections.Generic;

namespace GAME
{
    /// <summary>
    /// 游戏管理器类
    /// </summary>
    public class GMatrix : GMatrixBase
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public GMatrix()
        {

        }
        /// <summary>
        /// 游戏管理器初始完成回调函数
        /// </summary>
        protected void OnInit()
        {

        } 
        /// <summary>
        /// 游戏管理器心跳回调函数
        /// </summary>
        protected void OnHeartbeat()
        {

        }
        /// <summary>
        /// 怪物死亡时爆出物品回调函数
        /// </summary>
        /// <param name="item_type">物品类型</param>
        /// <param name="item_count">物品数量</param>
        /// <param name="owner_type">所属者类型</param>
        /// <param name="owner_id">所属者标识</param>
        /// <param name="owner_team">所属者队伍</param>
        /// <param name="drop_id">怪物标识</param>
        /// <param name="world_tag">地图标识</param>
        /// <param name="x">坐标X</param>
        /// <param name="y">坐标Y</param>
        /// <param name="z">坐标Z</param>
        protected void OnNpcDropItem(int item_type, int item_count, GM_TYPE owner_type, int owner_id, int owner_team, int drop_id, int world_tag, float x, float y, float z)
        {

        }
        /// <summary>
        /// 怪物AI处理时扔出物品回调函数
        /// </summary>
        /// <param name="item_type">物品类型</param>
        /// <param name="item_count">物品数量</param>
        /// <param name="owner_type">所属者类型</param>
        /// <param name="owner_id">所属者标识</param>
        /// <param name="owner_team">所属者队伍</param>
        /// <param name="drop_id">怪物标识</param>
        /// <param name="world_tag">地图标识</param>
        /// <param name="x">坐标X</param>
        /// <param name="y">坐标Y</param>
        /// <param name="z">坐标Z</param>
        protected void OnMonDropItem(int item_type, int item_count, GM_TYPE owner_type, int owner_id, int owner_team, int drop_id, int world_tag, float x, float y, float z)
        {

        }
    }
}
