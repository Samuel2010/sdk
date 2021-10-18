using System;
using System.Text;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace GAME
{
    /// <summary>
    /// 游戏数据管理器接口
    /// </summary>
    public class GDataManBase
    {
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void Log(IntPtr p, GLOG_TYPE type, string s);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static string GetDataName(IntPtr p, int id, ID_SPACE idspace);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetDataType(IntPtr p, int id, ID_SPACE idspace);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static IntPtr GetDataPtr(IntPtr p, int id, ID_SPACE idspace, ref DATA_TYPE dt);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDataField(IntPtr p, uint id, ID_SPACE idspace, DATA_TYPE dt, FIELD_TYPE field, int value);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetDataFieldFloat(IntPtr p, uint id, ID_SPACE idspace, DATA_TYPE dt, FIELD_TYPE field, float value);
        private IntPtr nativePtr = new IntPtr();
        /// <summary>
        /// 输出日志
        /// </summary>
        /// <param name="type">日志类型</param>
        /// <param name="s">日志内容</param>
        public void Log(GLOG_TYPE type, string s)
        {
            Log(nativePtr, type, s);
        }
        /// <summary>
        /// 根据游戏数据标识取得数据的名称
        /// </summary>
        /// <param name="id">游戏数据标识（物品ID、怪物ID等标识）</param>
        /// <returns>数据名称</returns>
        public string GetDataName(int id, ID_SPACE idspace)
        {
            return GetDataName(nativePtr, id, idspace);
        }
        /// <summary>
        /// 根据游戏数据标识取得数据的类型
        /// </summary>
        /// <param name="id">游戏数据标识（物品ID、怪物ID等标识）</param>
        /// <returns>数据类型</returns>
        public int GetDataType(int id, ID_SPACE idspace)
        {
            return GetDataType(nativePtr, id, idspace);
        }
        public IntPtr GetDataPtr(int id, ID_SPACE idspace, ref DATA_TYPE dt)
        {
            return GetDataPtr(nativePtr, id, idspace, ref dt);
        }
        public bool SetDataField(uint id, ID_SPACE idspace, DATA_TYPE dt, FIELD_TYPE field, int value)
        {
            return SetDataField(nativePtr, id, idspace, dt, field, value);
        }
        public bool SetDataFieldFloat(uint id, ID_SPACE idspace, DATA_TYPE dt, FIELD_TYPE field, float value)
        {
            return SetDataFieldFloat(nativePtr, id, idspace, dt, field, value);
        }
    }
}
