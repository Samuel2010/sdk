using System;
using System.Text;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace GAME
{
    public enum ID_SPACE
    {
        ID_SPACE_ESSENCE = 0,
        ID_SPACE_ADDON = 1,
        ID_SPACE_TALK = 2,
        ID_SPACE_RECIPE = 3,
        ID_SPACE_CONFIG = 4,
    };
    public enum DATA_TYPE
    {
        DT_INVALID = 0,
        DT_EQUIPMENT_ADDON,
        DT_EQUIPMENT_MAJOR_TYPE,
        DT_EQUIPMENT_SUB_TYPE,
        DT_EQUIPMENT_ESSENCE,
        DT_REFINE_TICKET_ESSENCE,
        DT_MEDICINE_MAJOR_TYPE,
        DT_MEDICINE_SUB_TYPE,
        DT_MEDICINE_ESSENCE,
        DT_MATERIAL_MAJOR_TYPE,
        DT_MATERIAL_SUB_TYPE,
        DT_MATERIAL_ESSENCE,
        DT_SKILLTOME_SUB_TYPE,
        DT_SKILLTOME_ESSENCE,
        DT_TRANSMITROLL_ESSENCE,
        DT_LUCKYROLL_ESSENCE,
        DT_TOWNSCROLL_ESSENCE,
        DT_REVIVESCROLL_ESSENCE,
        DT_TASKMATTER_ESSENCE,
        DT_DROPTABLE_TYPE,
        DT_DROPTABLE_ESSENCE,
        DT_MONSTER_TYPE,
        DT_MONSTER_ESSENCE,
        DT_NPC_TALK_SERVICE,
        DT_NPC_SELL_SERVICE,
        DT_NPC_BUY_SERVICE,
        DT_NPC_TASK_IN_SERVICE,
        DT_NPC_TASK_OUT_SERVICE,
        DT_NPC_TASK_MATTER_SERVICE,
        DT_NPC_HEAL_SERVICE,
        DT_NPC_TRANSMIT_SERVICE,
        DT_NPC_PROXY_SERVICE,
        DT_NPC_STORAGE_SERVICE,
        DT_NPC_TYPE,
        DT_NPC_ESSENCE,
        DT_TALK_PROC,
        DT_RECIPE_MAJOR_TYPE,
        DT_RECIPE_SUB_TYPE,
        DT_RECIPE_ESSENCE,
        DT_ENEMY_FACTION_CONFIG,
        DT_CHARACTER_CLASS_CONFIG,
        DT_PARAM_ADJUST_CONFIG,
        DT_PIE_LOVE_CONFIG,
        DT_TASKDICE_ESSENCE,
        DT_TASKNORMALMATTER_ESSENCE,
        DT_PLAYER_LEVELEXP_CONFIG,
        DT_MINE_TYPE,
        DT_MINE_ESSENCE,
        DT_GM_GENERATOR_TYPE,
        DT_GM_GENERATOR_ESSENCE,
        DT_FIREWORKS_ESSENCE,
        DT_NPC_WAR_TOWERBUILD_SERVICE,
        DT_PLAYER_SECONDLEVEL_CONFIG,
        DT_NPC_RESETPROP_SERVICE,
        DT_ESTONE_ESSENCE,
        DT_PSTONE_ESSENCE,
        DT_SSTONE_ESSENCE,
        DT_RECIPEROLL_MAJOR_TYPE,
        DT_RECIPEROLL_SUB_TYPE,
        DT_RECIPEROLL_ESSENCE,
        DT_SUITE_ESSENCE,
        DT_DOUBLE_EXP_ESSENCE,
        DT_DESTROYING_ESSENCE,
        DT_NPC_EQUIPBIND_SERVICE,
        DT_NPC_EQUIPDESTROY_SERVICE,
        DT_NPC_EQUIPUNDESTROY_SERVICE,
        DT_SKILLMATTER_ESSENCE,
        DT_VEHICLE_ESSENCE,
        DT_COUPLE_JUMPTO_ESSENCE,
        DT_LOTTERY_ESSENCE,
        DT_CAMRECORDER_ESSENCE,
        DT_TITLE_PROP_CONFIG,
        DT_SPECIAL_ID_CONFIG,
        DT_TEXT_FIREWORKS_ESSENCE,
        DT_TALISMAN_MAINPART_ESSENCE,
        DT_TALISMAN_EXPFOOD_ESSENCE,
        DT_TALISMAN_MERGEKATALYST_ESSENCE,
        DT_TALISMAN_ENERGYFOOD_ESSENCE,
        DT_SPEAKER_ESSENCE,
        DT_PLAYER_TALENT_CONFIG,
        DT_POTENTIAL_TOME_ESSENCE,
        DT_WAR_ROLE_CONFIG,
        DT_NPC_WAR_BUY_ARCHER_SERVICE,
        DT_SIEGE_ARTILLERY_SCROLL_ESSENCE,
        DT_PET_BEDGE_ESSENCE,
        DT_PET_FOOD_ESSENCE,
        DT_PET_SKILL_ESSENCE,
        DT_PET_ARMOR_ESSENCE,
        DT_PET_AUTO_FOOD_ESSENCE,
        DT_PET_REFINE_ESSENCE,
        DT_PET_ASSIST_REFINE_ESSENCE,
        DT_RENASCENCE_SKILL_CONFIG,
        DT_RENASCENCE_PROP_CONFIG,
        DT_AIRCRAFT_ESSENCE,
        DT_FLY_ENERGYFOOD_ESSENCE,
        DT_ITEM_TRADE_CONFIG,
        DT_BOOK_ESSENCE,
        DT_PLAYER_SKILL_POINT_CONFIG,
        DT_OFFLINE_TRUSTEE_ESSENCE,
        DT_EQUIP_SOUL_ESSENCE,
        DT_EQUIP_SOUL_MELD_SERVICE,
        DT_SPECIAL_NAME_ITEM_ESSENCE,
        DT_RECYCLE_ITEM_CONFIG,
        DT_SCORE_TO_RANK_CONFIG,
        DT_BATTLE_DROP_CONFIG,
        DT_BATTLE_DEPRIVE_CONFIG,
        DT_BATTLE_SCORE_CONFIG,
        DT_GIFT_BAG_ESSENCE,
        DT_VIP_CARD_ESSENCE,
        DT_INSTANCING_BATTLE_CONFIG,
        DT_CHANGE_SHAPE_CARD_ESSENCE,
        DT_CHANGE_SHAPE_STONE_ESSENCE,
        DT_CHANGE_SHAPE_PROP_CONFIG,
        DT_ORIGINAL_SHAPE_CONFIG,
        DT_LIFE_SKILL_CONFIG,
        DT_ARENA_DROPTABLE_CONFIG,
        DT_MERCENARY_CREDENTIAL_ESSENCE,
        DT_TELEPORTATION_ESSENCE,
        DT_TELEPORTATION_STONE_ESSENCE,
        DT_COMBINE_SKILL_EDIT_CONFIG,
        DT_UPGRADE_EQUIP_CONFIG,
        DT_UPGRADE_EQUIP_CONFIG_1,
        DT_UPGRADE_EQUIP_STONE_ESSENCE,
        DT_NPC_CONSIGN_SERVICE,
        DT_DEITY_CHARACTER_CONFIG,
        DT_LOTTERY2_ESSENCE,
    }
    public enum FIELD_TYPE : int
    {
        FIELD_MONSTER_DMG_REDUCE = 1,    //怪物致命伤害减免
        FIELD_MONSTER_IGN_DMG_REDUCE = 2,    //怪物攻击致命伤害忽略
        FIELD_MONSTER_HP = 3,    //怪物血量
        FIELD_DROPTABLE_DROPS_START = 100,
        FIELD_DROPTABLE_DROPS_END = 163,
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct GIFT_INFO
    {
        public Int32 id_object;
        public float probability;
        public Int32 num_min;
        public Int32 num_max;
        public Int32 is_bind;
        public Int32 effect_time;
    };
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct GIFT_BAG_ESSENCE
    {
        public uint id;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string name;
        public Int32 file_matter;
        public Int32 file_icon;
        public Int32 level_everLimit;
        public Int32 level_required;
        public Int32 level_upperLimit;
        public UInt32 require_gender;
        public Int32 renascence_count;
        public UInt64 character_combo_id;
        public UInt64 character_combo_id2;
        public UInt64 character_combo_id3;
        public UInt32 god_devil_mask;
        public UInt32 open_time;
        public float probability;
        public UInt32 success_disappear;
        public UInt32 faliure_disappear;
        public UInt32 id1_object_need;
        public UInt32 id1_object_num;
        public UInt32 id2_object_need;
        public UInt32 id2_object_num;
        public Int32 money_need;
        public UInt32 num_object;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public GIFT_INFO[] gifts;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public UInt32[] normalize_group;
        public Int32 price;
        public Int32 shop_price;
        public Int32 pile_num_max;
        public UInt32 proc_type;
    };
    [StructLayout(LayoutKind.Sequential)]
    public struct DROPTABEL_NUM
    {
        public float probability;
    };
    [StructLayout(LayoutKind.Sequential)]
    public struct DROPTABEL_OBJECT
    {
		public uint id_obj;
        public float probability;
    };
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct DROPTABLE_ESSENCE
    {
        public uint id;
        public uint id_type;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string name;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
        public DROPTABEL_NUM[] num_to_drop;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public DROPTABEL_OBJECT[] drops;
    };
}
