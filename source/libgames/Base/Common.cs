using System;
using System.Text;

namespace GAME
{
    public enum GLOG_TYPE : int
    {
        GLOG_EMERG = 0,
        GLOG_ALERT = 1,
        GLOG_CRIT = 2,
        GLOG_ERR = 3,
        GLOG_WARNING = 4,
        GLOG_NOTICE = 5,
        GLOG_INFO = 6,
        GLOG_DEBUG = 7,
        GLOG_TRACE = 8,
        GLOG_EXCEPT = 9,
    }
    public enum TOCCUPATION
    {
        NONE = 0,
        VIM1 = 1,
        VIM2 = 2,
        VIM3 = 3,
        LUPIN1 = 4,
        LUPIN2 = 5,
        LUPIN3 = 6,
        JADEON1 = 7,
        JADEON2 = 8,
        JADEON3 = 9,
        SKYSONG1 = 10,
        SKYSONG2 = 11,
        SKYSONG3 = 12,
        VIM4 = 13,
        VIM5 = 14,
        LUPIN4 = 16,
        LUPIN5 = 17,
        JADEON4 = 19,
        JADEON5 = 20,
        SKYSONG4 = 22,
        SKYSONG5 = 23,
        MODO1 = 25,
        MODO2 = 26,
        MODO3 = 27,
        MODO4 = 28,
        MODO5 = 29,
        BALO1 = 33,
        BALO2 = 34,
        BALO3 = 35,
        BALO4 = 36,
        BALO5 = 37,
        ARDEN1 = 39,
        ARDEN2 = 40,
        ARDEN3 = 41,
        ARDEN4 = 42,
        ARDEN5 = 43,
        RAYAN1 = 45,
        RAYAN2 = 46,
        RAYAN3 = 47,
        RAYAN4 = 48,
        RAYAN5 = 49,
        CELAN1 = 51,
        CELAN2 = 52,
        CELAN3 = 53,
        CELAN4 = 54,
        CELAN5 = 55,
        VOIDA1 = 56,
        VOIDA2 = 57,
        VOIDA3 = 58,
        VOIDA4 = 59,
        VOIDA5 = 60,
        INCENSE1 = 64,
        INCENSE2 = 65,
        INCENSE3 = 66,
        INCENSE4 = 67,
        INCENSE5 = 68,
        SEIRA1 = 71,
        SEIRA2 = 72,
        SEIRA3 = 73,
        SEIRA4 = 74,
        SEIRA5 = 75,
        GEVRIN1 = 77,
        GEVRIN2 = 78,
        GEVRIN3 = 79,
        GEVRIN4 = 80,
        GEVRIN5 = 81,
        OCC_83 = 83,
        OCC_84 = 84,
        OCC_85 = 85,
        OCC_86 = 86,
        OCC_87 = 87,
        FORTA1 = 96,
        FORTA2 = 97,
        FORTA3 = 98,
        FORTA4 = 99,
        FORTA5 = 100,
        PSYCHEA1 = 102,
        PSYCHEA2 = 103,
        PSYCHEA3 = 104,
        PSYCHEA4 = 105,
        PSYCHEA5 = 106,
        KYTOS1 = 108,
        KYTOS2 = 109,
        KYTOS3 = 110,
        KYTOS4 = 111,
        KYTOS5 = 112,
        HYDRAN1 = 117,
        HYDRAN2 = 118,
        HYDRAN3 = 119,
        HYDRAN4 = 120,
        HYDRAN5 = 121,
        OCC_243 = 243,
        OCC_244,
        OCC_245,
        OCC_246,
        OCC_247,
        OCC_249 = 249,
        OCC_250,
        OCC_251,
        OCC_252,
        OCC_253,
        OCC_254,
    };
    public enum TEQUIP_TYPE : int
    {
	    EQUIP_TYPE_WEAPON = 0, //武器
	    EQUIP_TYPE_HEAD = 1, //头盔
	    EQUIP_TYPE_BODY = 2, //盔甲
	    EQUIP_TYPE_FOOT = 3, //靴子
	    EQUIP_TYPE_NECK = 4, //项链
        EQUIP_TYPE_FINGER1 = 5, //戒子
        EQUIP_TYPE_FINGER2 = 6, //戒子
        EQUIP_TYPE_FASHION_EYE = 7, //面具	
	    EQUIP_TYPE_MAGIC = 8,
	    EQUIP_TYPE_FASHION_LIP = 9,
        EQUIP_TYPE_FASHION_HEAD = 10, //头饰
	    EQUIP_TYPE_FASHION_BODY	= 11, //时装
	    EQUIP_TYPE_FASHION_LEG = 12,
        EQUIP_TYPE_FASHION_FOOT = 13, //靴
	    EQUIP_TYPE_FASHION_BACK	= 14,
	    EQUIP_TYPE_WING = 15,
	    EQUIP_TYPE_TALISMAN1 = 16,
	    EQUIP_TYPE_TALISMAN2 = 17,
	    EQUIP_TYPE_TALISMAN3 = 18,
	    EQUIP_TYPE_BUGLE = 19,
	    EQUIP_TYPE_XITEM1 = 20, //锦囊
	    EQUIP_TYPE_XITEM2 = 21, //玺绶
	    EQUIP_TYPE_XITEM3 = 22, //罡气
	    EQUIP_TYPE_RUNE = 23, //元魂
	    EQUIP_TYPE_XITEM4 = 24,
	    EQUIP_TYPE_XITEM5 = 25,
	    EQUIP_TYPE_FASHION_WEAPON	= 26,
	    EQUIP_TYPE_27	= 27,
	    EQUIP_TYPE_MAX,
    };
    public enum TITEM_INIT_TYPE : int
    {
	    TASK,       //任务初始化
	    SHOP,       //商城初始化
	    NPC,        //NPC处购买
	    LOTTERY,    //彩票
	    NPC_DROP,   //NPC掉落
	    COMBINE,    //合成
	    PRODUCE,    //生产
	    CATCH,      //宠物扑捉
    };
    public enum GM_TYPE : int
    {
        INVALID = -1,
        BROADCAST,
        PLAYER,     //游戏玩家
        NPC,        //怪物
        MATTER,     //物品
    }
    public enum TCHAT_CHANNEL : sbyte
    {
        LOCAL = 0,  //普通
        FARCRY,     //世界
        TEAM,       //组队
        FACTION,    //帮派
        WISPER,     //密语
        DAMAGE,
        FIGHT,
        TRADE,
        SYSTEM,     //系统
        BROADCAST,  //广播
        MISC,
        FAMILY,
        CIRCLE,
        ZONE,
        SPEAKER,    //大喇叭
        RUMOR,		//谣言
    }
    public enum FILTER_MASK : uint
    {
        FILTER_MASK_TRANSLATE_SEND_MSG = 0x00000001,
        FILTER_MASK_TRANSLATE_RECV_MSG = 0x00000002,
        FILTER_MASK_HEARTBEAT = 0x00000004,
        FILTER_MASK_ADJUST_DAMAGE = 0x00000008,
        FILTER_MASK_BEFORE_DAMAGE = 0x00000010,
        FILTER_MASK_ADJUST_EXP = 0x00000020,
        FILTER_MASK_ADJUST_MANA_COST = 0x00000040,
        FILTER_MASK_BEFORE_DEATH = 0x00000080,
        FILTER_MASK_TRANSLATE_ENCHANT = 0x00000100,
        FILTER_MASK_TRANSLATE_SEND_ENCHANT = 0x00000200,
        FILTER_MASK_BE_ATTACKED = 0x00000400,
        FILTER_MASK_BE_REFLECTED = 0x00000800,
        FILTER_MASK_ON_FILTER_ADD = 0x00001000,
        FILTER_MASK_CRITENEMY = 0x00002000,
        FILTER_MASK_DAMAGEENEMY = 0x00004000,
        FILTER_MASK_ADJUST_SKILL = 0x00008000,
        FILTER_MASK_AFTER_DEATH = 0x00010000,
        FILTER_MASK_ON_MOVED = 0x00020000,

        FILTER_MASK_REMOVE_ON_DEATH = 0x00200000,
        FILTER_MASK_MERGE = 0x00400000,
        FILTER_MASK_SKILL2 = 0x00800000,
        FILTER_MASK_SKILL3 = 0x01000000,
        FILTER_MASK_SAVE_DB_DATA = 0x02000000,
        FILTER_MASK_NOSAVE = 0x04000000,
        FILTER_MASK_BATTLE_BUFF = 0x08000000,
        FILTER_MASK_DEBUFF = 0x10000000,
        FILTER_MASK_BUFF = 0x20000000,
        FILTER_MASK_UNIQUE = 0x40000000,
        FILTER_MASK_WEAK = 0x80000000,
    };
    public enum FILTER_TYPE
    {
        FILTER_EXPORT_BASE = 4000,
        FILTER_KILL_TITLE,
        FILTER_ENHANCE_PROP,
    }
    enum FILTER_SKILL
    {
        FILTER_DIZZY = 4096,   // 眩晕
        FILTER_SLEEP = 4097,   // 睡眠
        FILTER_SILENT = 4098,   // 沉默
        FILTER_WRAP = 4099,   // 缠绕
        FILTER_CRAZY = 4100,   // 消耗血魔增强攻击
        FILTER_MAGICSHIELD = 4101,   // 魔力盾牌
        FILTER_DECHURT = 4102,   // 保护盾牌
        FILTER_INCCRITRATE = 4103,   // 增加爆机率
        FILTER_DECRESIST = 4105,   // 降低法术防御力，降低比率 是废弃的id吗? ly ask
        FILTER_DECMP = 4106,   // 降低MP上限
        FILTER_BAREHANDED = 4107,   // 空手
        FILTER_DECDAMAGE = 4108,   // 随机减小伤害百分比
        FILTER_BLOODSHIELD = 4109,   // 受攻击随机增加防御
        FILTER_DIET = 4111,   // 禁食
        FILTER_IMMUNEDIZZY = 4112,   // 免疫昏迷
        FILTER_IMMUNESLEEP = 4113,   // 免疫睡眠
        FILTER_IMMUNESILENT = 4114,   // 免疫沉默
        FILTER_IMMUNEWEAK = 4115,   // 免疫虚弱
        FILTER_IMMUNEWRAP = 4116,   // 免疫缠绕
        FILTER_IMMUNESLOW = 4117,   // 免疫减速
        FILTER_INCHURT = 4118,   // 伤害增加百分比
        FILTER_BLESSED = 4119,   // 免疫后续攻击
        FILTER_CURSED = 4120,   // 受攻击附加伤害
        FILTER_POWERUP = 4121,   // 防御增强攻击降低
        FILTER_SHOUYI = 4122,   // 防御增加攻击减少
        FILTER_NINGJIN = 4123,   // 
        FILTER_ICON = 4124,   // 
        FILTER_INCANTI = 4125,   // 
        FILTER_DECANTI = 4126,   // 
        FILTER_ADDANTI = 4127,   // 
        FILTER_SUBANTI = 4128,   //Change to superimposable was deleted
        FILTER_RETORT = 4129,   // 反震
        FILTER_INCSKILLDAMAGE = 4130,   // 
        FILTER_DECSKILLDAMAGE = 4131,   // 
        FILTER_DRUNK = 4132,   // 
        FILTER_SPICY = 4133,   // 
        FILTER_FAMILYINCHP = 4134,   // 家族加气血上限百分比 
        FILTER_FAMILYINCMP = 4135,   // 家族加真气上限百分比  
        FILTER_FAMILYINCATTACK = 4136,   // 家族加攻百分比  
        FILTER_FRENZIED = 4137,   // 受伤害增加攻击 
        FILTER_DODGE = 4140,   // 轻功
        FILTER_EVILAURA = 4141,   // 邪恶光环
        FILTER_HOLYAURA = 4142,   // 神圣光环
        FILTER_ICESHIELD = 4143,   //
        FILTER_FOCUSANTI = 4144,   //
        FILTER_DISPERSEANTI = 4145,   //
        FILTER_ATTACK2HP = 4146,   //
        FILTER_ATTACK2MP = 4147,   //
        FILTER_POWERLESS = 4148,   //
        FILTER_ALOOF = 4149,   //
        FILTER_DIZZYTIMER = 4150,   //
        FILTER_SLEEPTIMER = 4151,   //
        FILTER_WRAPTIMER = 4152,   //
        FILTER_SILENTTIMER = 4153,   //
        FILTER_GHOSTFORM = 4154,   //
        FILTER_INSANITYFORM = 4155,   //
        FILTER_DODGEREGAIN = 4156,   //
        FILTER_HPREGAIN = 4157,   //
        FILTER_DEADLYBLESS = 4158,   //
        FILTER_HURTSCATTER = 4159,   //
        FILTER_DEATHSCATTER = 4160,   //
        FILTER_REJECTDEBUFF = 4161,   //
        FILTER_EXPBOOST = 4162,   //
        FILTER_CREDITBOOST = 4163,   //
        FILTER_ADDANTI2 = 4164,   // 
        FILTER_CATCHPET = 4165,   //
        FILTER_FEAR = 4166,
        FILTER_LONGXIANG = 4167,
        FILTER_HUJU = 4168,
        FILTER_DOUHUN = 4169,
        FILTER_GANGDAN = 4170,
        FILTER_ASWIND = 4171,
        FILTER_ASFOREST = 4172,
        FILTER_ASFIRE = 4173,
        FILTER_ASHILL = 4174,
        FILTER_MAKECRIT = 4175,
        FILTER_FOXSTATE = 4176,
        FILTER_IMMUNETRANSFORM = 4177,   //变身免疫
        //added by comper
        FILTER_SHADOWHIDE = 4178,
        FILTER_SHADOWDANCE = 4179,
        FILTER_POSEXCHANGEWITHCLONE = 4180,
        FILTER_STATEEXCHANGEWITHCLONE = 4181,
        FILTER_DRAWCLONELIFE = 4182,
        FILTER_SHARELIFEWITHCLONE = 4183,
        FILTER_SHARESTATEWITHCLONE = 4184,
        FILTER_BACKSTAB = 4185,
        FILTER_BLINK = 4186,
        FILTER_CRITCURSE = 4187,
        FILTER_SKILLMIRROR = 4188,
        FILTER_CRAZYCUESE = 4189,
        FILTER_FOGSTATE = 4190,
        FILTER_DARKNESS = 4191,
        FILTER_SKILLREFLECT = 4192,
        FILTER_GOBACK = 4193,
        FILTER_SCOPEDAMAGE = 4194,
        FILTER_PULLBACK = 4195,
        FILTER_HUMANBOMB = 4196,
        FILTER_SPIRITDRAG = 4197,
        FILTER_CYCLE = 4198,
        FILTER_ADDWEAK = 4199,
        FILTER_ADDWRAP = 4200,
        FILTER_ADDCHARM = 4201,
        FILTER_ADDSLOW = 4202,
        FILTER_PARALYSIS = 4203,
        FILTER_SWIFT = 4204,
        FILTER_TRIGGERSKILL = 4205,
        FILTER_CRIPPLED = 4207,
        FILTER_GUISHEN1 = 4208,
        FILTER_TUOLING1 = 4209,
        FILTER_PULL = 4210,
        FILTER_ACTIVECRIT = 4211,
        FILTER_ACTIVEBECRIT = 4212,
        FILTER_INCSKILLLEVEL = 4213,
        FILTER_SETSKILLLEVEL = 4214,
        FILTER_GUISHEN2 = 4215,
        FILTER_TUOLING2 = 4216,
        FILTER_LIMITCYCLEAREA = 4217,
        FILTER_PERMITCYCLEAREA = 4218,
        FILTER_JAIL = 4219,
        FILTER_PULLING = 4220,
        FILTER_YUANLING = 4221,
        FILTER_BEFIRED = 4222,
        FILTER_GUISHEN1DEBUFF = 4223,
        FILTER_TUOLING1DEBUFF = 4224,
        FILTER_GUISHEN2DEBUFF = 4225,
        FILTER_TUOLING2DEBUFF = 4226,
        FILTER_CRIPPLEDDEBUFF = 4227,
        FILTER_PZMAXSPEED = 4228,
        FILTER_PZHALFSPEED = 4229,
        FILTER_PZHILL = 4230,
        FILTER_PZNOMOVE = 4231,
        FILTER_PZCHAOS = 4232,
        FILTER_PZVOID = 4233,
        FILTER_JUNIORDARKFORM = 4234,
        FILTER_JUNIORLIGHTFORM = 4235,
        FILTER_SENIORDARKFORM = 4236,
        FILTER_SENIORLIGHTFORM = 4237,
        FILTER_DARKUNIFORM = 4238,
        FILTER_LIGHTUNIFORM = 4239,
        FILTER_DECHURT2 = 4240,
        FILTER_RECORDPOS = 4241,
        FILTER_RETURNPOS = 4242,
        FILTER_FLY = 4243,
        FILTER_ACTIVEBEATTACKED = 4244,
        FILTER_MIRRORIMAGE = 4245,
        FILTER_INSTANTSKILL = 4246,
        FILTER_SUMMONSKILL = 4247,
        FILTER_BLOODTHIRSTY2 = 4248,
        FILTER_TALISMANEFFECTBLESS = 4249,
        FILTER_DARKLASER = 4250,
        FILTER_AUTORESURRECT = 4251,
        FILTER_ADDSPIRIT = 4252,
        FILTER_DIRSTATE = 4253,
        FILTER_TEAMENCHANT = 4254,
        FILTER_SHOWYB = 4255,
        FILTER_RECOVERYHP = 4256,
        FILTER_EQUIPEFFECT = 4257,
        FILTER_PUPPETFORM = 4258,
        FILTER_PUPPETSKILL = 4259,
        FILTER_SUBANTIDIZZY2 = 4260,
        FILTER_SUBANTISLEEP2 = 4261,
        FILTER_SUBANTIWEAK2 = 4262,
        FILTER_SUBANTISILENT2 = 4263,
        FILTER_SUBANTIWRAP2 = 4264,
        FILTER_SUBANTISLOW2 = 4265,
        FILTER_SUBHP2 = 4266,
        FILTER_SUBMP2 = 4267,
        FILTER_SEED = 4268,
        FILTER_QILINFORM = 4269,
        FILTER_RMHUMANFORM = 4270,
        FILTER_CYCLESKILL = 4271,
        FILTER_BUXIU = 4272,
        FILTER_BETAUNTED2 = 4273,
        FILTER_ADDRAGE1 = 4274,
        FILTER_ADDRAGE2 = 4275,
        FILTER_RENMA1 = 4276,
        FILTER_RENMA2 = 4277,
        FILTER_RENMA3 = 4278,
        FILTER_RENMA4 = 4279,
        FILTER_SHARELIFEWITHSUMMON = 4280,
        FILTER_ACCUMDAMAGE = 4281,
        FILTER_BLOODPOOL = 4282,
        FILTER_GUIWANG_ADDMAXHP = 4283,
        FILTER_GUIWANG_ADDDAMAGE = 4284,
        FILTER_GUIWANG_ADDTENACIY = 4285,
        FILTER_GUIWANG_ADDSKILLATTACK = 4286,
        FILTER_GUIWANG_ADDANTICRIT = 4287,
        FILTER_DSLEEP = 4288,
        FILTER_HIDER = 4289,
        FILTER_KILLMONSTER = 4290,
        FILTER_ADDMONSTEREXP = 4291,
        FILTER_HUMANBOMB2 = 4292,
        FILTER_TRAD = 4293,
        FILTER_STRUGGLE = 4294,
        FILTER_PARRY = 4295,
        FILTER_DISGUISE = 4296,
        FILTER_SIGN = 4297,
        FILTER_SKILLTRANSFER = 4298,
        FILTER_GROUPATKCHANGE = 4299,
        FILTER_SINGLEATKCHANGE = 4300,
        FILTER_REALDODGE = 4301,
        FILTER_DARKNESS2 = 4302,
        FILTER_SMOG = 4303,
        FILTER_KILLASSELF = 4304,
        FILTER_IGNOREBLESSED = 4305,
        FILTER_KILLASTARGET = 4306,
        FILTER_IMMUNETAUNE = 4307,
        FILTER_PARRY2 = 4308,
        FILTER_IMMUNELAKEMP = 4309,
        FILTER_SUPERTRIGGER = 4310,
        FILTER_QINGLUO1 = 4311,
        FILTER_QINGLUO2 = 4312,
        FILTER_ICECURSE = 4313,
        FILTER_FLAMECURSE = 4314,
        FILTER_ICEBLESSING = 4315,
        FILTER_FLAMEBLESSING = 4316,
        FILTER_TORPESCENCE = 4317,
        FILTER_DEATHPACT = 4318,
        FILTER_DERIVEATTR = 4319,
        FILTER_FENGGONG = 4320,
        FILTER_SACRIFICE = 4321,
        FILTER_FEAR2 = 4322,
        FILTER_SUSPEND = 4323,
        FILTER_DISARRANGE = 4324,
        FILTER_IMITATE = 4325,
        FILTER_SKILLREPLACE = 4326,
        FILTER_SHAREDAMAGE = 4327,
        FILTER_SOULLINK = 4328,
        FILTER_DECHURT3 = 4329,
        FILTER_PROMOTEDPS = 4330,
        FILTER_ACTIVEBECRIT2 = 4331,
        FILTER_ABOLISHBLOODPOOL = 4332,
        FILTER_IMMUNEMANABURN = 4333,
        FILTER_XINGYUN = 5650,
    };
    public enum LOGOUT_TYPE
    {
        LOGOUT_FULL = 0,  //大退(关闭客户端程序)
        LOGOUT_HALF = 1,  //小退(返回选角色界面)
    };
    public enum RESISTANCE : uint
    {
        RES_0 = 0,
        RES_1 = 1,
        RES_2 = 2,
        RES_3 = 3,
        RES_4 = 4,
        RES_5 = 5,
    };
    public enum CULT_DEF_TYPE : int
    {
        CULT_DEF_0 = 0,
        CULT_DEF_1 = 1,
        CULT_DEF_2 = 2,
        CULT_DEF_3 = 3,
        CULT_DEF_4 = 4,
        CULT_DEF_5 = 5,
    };
    //实际使用的值，除以100得到实际的精度
    public enum PLAYER_PROP : int
    {
        PROP_MAXHP = 1,    //气血
        PROP_MAXMP = 2,    //真气
        PROP_DAMAGE = 3,    //攻击
        PROP_DEFENSE = 4,    //攻击
        PROP_ATTACK = 5,    //命中
        PROP_ARMOR = 6,    //躲闪
        PROP_SKILL_ATTACK = 7,    //技能命中
        PROP_SKILL_ARMOR = 8,    //技能命中
        PROP_MAXDP = 9,    //元力值
        PROP_CRIT = 10,   //致命一击率
        PROP_CRIT_DAMAGE = 11,   //致命一击伤害
        PROP_ANTI_CRITRATE = 12,   //减免致命一击率
        PROP_ANTI_ANTIDAMAGE = 13,   //减免致命一击伤害
        PROP_CULT_DEFENSE_0 = 14,   //御仙
        PROP_CULT_DEFENSE_1 = 15,   //御佛
        PROP_CULT_DEFENSE_2 = 16,   //御魔
        PROP_CULT_ATTACK_0 = 17,   //克仙
        PROP_CULT_ATTACK_1 = 18,   //克佛
        PROP_CULT_ATTACK_2 = 19,   //克魔
        PROP_DMG_REDUCE = 20,   //减免固定伤害
        PROP_SCALEDMG_REDUCE = 21,   //减免伤害百分比
        PROP_RESISTANCE_0 = 22,   //眩晕
        PROP_RESISTANCE_2 = 23,   //定神
        PROP_RESISTANCE_3 = 24,   //魅惑
        PROP_RESISTANCE_1 = 25,   //虚弱
        PROP_RESISTANCE_4 = 26,   //昏睡
        PROP_RESISTANCE_5 = 27,   //减速
        PROP_SCALEIGNDMG_REDUCE = 28,   //无视伤害减免
        PROP_SCALEMAXHP = 29,   //气血增加百分比
        PROP_SCALEMAXMP = 30,   //真气增加百分比
        PROP_SCALEDAMAGE = 31,   //攻击增加百分比
        PROP_SCALEDEFENSE = 32,   //防御增加百分比
        PROP_DEITY_POWER = 33,   //元神威能
    };
    public enum TSPAWER_TYPE
    {
        NONE,
        NPC,
        MINE,
        DYN_OBJECT,
    };
    public enum TSPAWER_NPC
    {
        NONE,
        SERVER,
        MOBACTIVE,
    };
    public enum TSPAWER_GROUP
    {
        NONE,
        GROUP,
        BOSS,
    };
    public enum TSPAWER_REGION
    {
        TERRAIN,
        BOX,
    };
    public class GCommon
    {
        public static string GetClassName(TOCCUPATION type)
        {
            string sResult = "未知";
            switch (type)
            {
                case TOCCUPATION.NONE: sResult = "少侠"; break;
                case TOCCUPATION.JADEON1: sResult = "青云一重"; break;
                case TOCCUPATION.JADEON2: sResult = "青云二重"; break;
                case TOCCUPATION.JADEON3: sResult = "青云三重"; break;
                case TOCCUPATION.JADEON4: sResult = "青云四重"; break;
                case TOCCUPATION.JADEON5: sResult = "青云五重"; break;
                case TOCCUPATION.VIM1: sResult = "鬼王一重"; break;
                case TOCCUPATION.VIM2: sResult = "鬼王二重"; break;
                case TOCCUPATION.VIM3: sResult = "鬼王三重"; break;
                case TOCCUPATION.VIM4: sResult = "鬼王四重"; break;
                case TOCCUPATION.VIM5: sResult = "鬼王五重"; break;
                case TOCCUPATION.LUPIN1: sResult = "合欢一重"; break;
                case TOCCUPATION.LUPIN2: sResult = "合欢二重"; break;
                case TOCCUPATION.LUPIN3: sResult = "合欢三重"; break;
                case TOCCUPATION.LUPIN4: sResult = "合欢四重"; break;
                case TOCCUPATION.LUPIN5: sResult = "合欢五重"; break;
                case TOCCUPATION.SKYSONG1: sResult = "天音一重"; break;
                case TOCCUPATION.SKYSONG2: sResult = "天音二重"; break;
                case TOCCUPATION.SKYSONG3: sResult = "天音三重"; break;
                case TOCCUPATION.SKYSONG4: sResult = "天音四重"; break;
                case TOCCUPATION.SKYSONG5: sResult = "天音五重"; break;
                case TOCCUPATION.MODO1: sResult = "鬼道一重"; break;
                case TOCCUPATION.MODO2: sResult = "鬼道二重"; break;
                case TOCCUPATION.MODO3: sResult = "鬼道三重"; break;
                case TOCCUPATION.MODO4: sResult = "鬼道四重"; break;
                case TOCCUPATION.MODO5: sResult = "鬼道五重"; break;
                case TOCCUPATION.BALO1: sResult = "九黎一重"; break;
                case TOCCUPATION.BALO2: sResult = "九黎二重"; break;
                case TOCCUPATION.BALO3: sResult = "九黎三重"; break;
                case TOCCUPATION.BALO4: sResult = "九黎四重"; break;
                case TOCCUPATION.BALO5: sResult = "九黎五重"; break;
                case TOCCUPATION.ARDEN1: sResult = "烈山一重"; break;
                case TOCCUPATION.ARDEN2: sResult = "烈山二重"; break;
                case TOCCUPATION.ARDEN3: sResult = "烈山三重"; break;
                case TOCCUPATION.ARDEN4: sResult = "烈山四重"; break;
                case TOCCUPATION.ARDEN5: sResult = "烈山五重"; break;
                case TOCCUPATION.RAYAN1: sResult = "怀光一重"; break;
                case TOCCUPATION.RAYAN2: sResult = "怀光二重"; break;
                case TOCCUPATION.RAYAN3: sResult = "怀光三重"; break;
                case TOCCUPATION.RAYAN4: sResult = "怀光四重"; break;
                case TOCCUPATION.RAYAN5: sResult = "怀光五重"; break;
                case TOCCUPATION.CELAN1: sResult = "天华一重"; break;
                case TOCCUPATION.CELAN2: sResult = "天华二重"; break;
                case TOCCUPATION.CELAN3: sResult = "天华三重"; break;
                case TOCCUPATION.CELAN4: sResult = "天华四重"; break;
                case TOCCUPATION.CELAN5: sResult = "天华五重"; break;
                case TOCCUPATION.VOIDA1: sResult = "辰皇一重"; break;
                case TOCCUPATION.VOIDA2: sResult = "辰皇二重"; break;
                case TOCCUPATION.VOIDA3: sResult = "辰皇三重"; break;
                case TOCCUPATION.VOIDA4: sResult = "辰皇四重"; break;
                case TOCCUPATION.VOIDA5: sResult = "辰皇五重"; break;
                case TOCCUPATION.INCENSE1: sResult = "焚香一重"; break;
                case TOCCUPATION.INCENSE2: sResult = "焚香二重"; break;
                case TOCCUPATION.INCENSE3: sResult = "焚香三重"; break;
                case TOCCUPATION.INCENSE4: sResult = "焚香四重"; break;
                case TOCCUPATION.INCENSE5: sResult = "焚香五重"; break;
                case TOCCUPATION.FORTA1: sResult = "太昊一重"; break;
                case TOCCUPATION.FORTA2: sResult = "太昊二重"; break;
                case TOCCUPATION.FORTA3: sResult = "太昊三重"; break;
                case TOCCUPATION.FORTA4: sResult = "太昊四重"; break;
                case TOCCUPATION.FORTA5: sResult = "太昊五重"; break;
                case TOCCUPATION.PSYCHEA1: sResult = "牵机一重"; break;
                case TOCCUPATION.PSYCHEA2: sResult = "牵机二重"; break;
                case TOCCUPATION.PSYCHEA3: sResult = "牵机三重"; break;
                case TOCCUPATION.PSYCHEA4: sResult = "牵机四重"; break;
                case TOCCUPATION.PSYCHEA5: sResult = "牵机五重"; break;
                case TOCCUPATION.KYTOS1: sResult = "英招一重"; break;
                case TOCCUPATION.KYTOS2: sResult = "英招二重"; break;
                case TOCCUPATION.KYTOS3: sResult = "英招三重"; break;
                case TOCCUPATION.KYTOS4: sResult = "英招四重"; break;
                case TOCCUPATION.KYTOS5: sResult = "英招五重"; break;
                case TOCCUPATION.SEIRA1: sResult = "青罗一重"; break;
                case TOCCUPATION.SEIRA2: sResult = "青罗二重"; break;
                case TOCCUPATION.SEIRA3: sResult = "青罗三重"; break;
                case TOCCUPATION.SEIRA4: sResult = "青罗四重"; break;
                case TOCCUPATION.SEIRA5: sResult = "青罗五重"; break;
                case TOCCUPATION.GEVRIN1: sResult = "归云一重"; break;
                case TOCCUPATION.GEVRIN2: sResult = "归云二重"; break;
                case TOCCUPATION.GEVRIN3: sResult = "归云三重"; break;
                case TOCCUPATION.GEVRIN4: sResult = "归云四重"; break;
                case TOCCUPATION.GEVRIN5: sResult = "归云五重"; break;
                case TOCCUPATION.OCC_83: sResult = "画影一重"; break;
                case TOCCUPATION.OCC_84: sResult = "画影二重"; break;
                case TOCCUPATION.OCC_85: sResult = "画影三重"; break;
                case TOCCUPATION.OCC_86: sResult = "画影四重"; break;
                case TOCCUPATION.OCC_87: sResult = "画影五重"; break;
                case TOCCUPATION.HYDRAN1: sResult = "破军一重"; break;
                case TOCCUPATION.HYDRAN2: sResult = "破军二重"; break;
                case TOCCUPATION.HYDRAN3: sResult = "破军三重"; break;
                case TOCCUPATION.HYDRAN4: sResult = "破军四重"; break;
                case TOCCUPATION.HYDRAN5: sResult = "破军五重"; break;
                case TOCCUPATION.OCC_243: sResult = "惊岚一重"; break;
                case TOCCUPATION.OCC_244: sResult = "惊岚二重"; break;
                case TOCCUPATION.OCC_245: sResult = "惊岚三重"; break;
                case TOCCUPATION.OCC_246: sResult = "惊岚四重"; break;
                case TOCCUPATION.OCC_247: sResult = "惊岚五重"; break;
                case TOCCUPATION.OCC_249: sResult = "逐霜"; break;
                case TOCCUPATION.OCC_250: sResult = "逐霜一重"; break;
                case TOCCUPATION.OCC_251: sResult = "逐霜二重"; break;
                case TOCCUPATION.OCC_252: sResult = "逐霜三重"; break;
                case TOCCUPATION.OCC_253: sResult = "逐霜四重"; break;
                case TOCCUPATION.OCC_254: sResult = "逐霜五重"; break;
            }
            return sResult;
        }
        public static string GetEquipType(TEQUIP_TYPE type)
        {
            string sResult = "未知";
            switch (type)
            {

                case TEQUIP_TYPE.EQUIP_TYPE_WEAPON: sResult = "武器"; break;
                case TEQUIP_TYPE.EQUIP_TYPE_HEAD: sResult = "头盔"; break;
                case TEQUIP_TYPE.EQUIP_TYPE_BODY: sResult = "盔甲"; break;
                case TEQUIP_TYPE.EQUIP_TYPE_FOOT: sResult = "靴子"; break;
                case TEQUIP_TYPE.EQUIP_TYPE_NECK: sResult = "项链"; break;
                case TEQUIP_TYPE.EQUIP_TYPE_FINGER1: sResult = "戒子"; break;
                case TEQUIP_TYPE.EQUIP_TYPE_FINGER2: sResult = "戒子"; break;
                case TEQUIP_TYPE.EQUIP_TYPE_FASHION_EYE: sResult = "面具"; break;
                case TEQUIP_TYPE.EQUIP_TYPE_MAGIC: sResult = "MAGIC"; break;
                case TEQUIP_TYPE.EQUIP_TYPE_FASHION_LIP: sResult = "FASHION_LIP"; break;
                case TEQUIP_TYPE.EQUIP_TYPE_FASHION_HEAD: sResult = "头饰"; break;
                case TEQUIP_TYPE.EQUIP_TYPE_FASHION_BODY: sResult = "时装"; break;
                case TEQUIP_TYPE.EQUIP_TYPE_FASHION_LEG: sResult = "FASHION_LEG"; break;
                case TEQUIP_TYPE.EQUIP_TYPE_FASHION_FOOT: sResult = "FASHION_FOOT"; break;
                case TEQUIP_TYPE.EQUIP_TYPE_FASHION_BACK: sResult = "FASHION_BACK"; break;
                case TEQUIP_TYPE.EQUIP_TYPE_WING: sResult = "WING"; break;
                case TEQUIP_TYPE.EQUIP_TYPE_TALISMAN1: sResult = "TALISMAN1"; break;
                case TEQUIP_TYPE.EQUIP_TYPE_TALISMAN2: sResult = "TALISMAN2"; break;
                case TEQUIP_TYPE.EQUIP_TYPE_TALISMAN3: sResult = "TALISMAN3"; break;
                case TEQUIP_TYPE.EQUIP_TYPE_BUGLE: sResult = "BUGLE"; break;
                case TEQUIP_TYPE.EQUIP_TYPE_XITEM1: sResult = "锦囊"; break;
                case TEQUIP_TYPE.EQUIP_TYPE_XITEM2: sResult = "玺绶"; break;
                case TEQUIP_TYPE.EQUIP_TYPE_XITEM3: sResult = "罡气"; break;
                case TEQUIP_TYPE.EQUIP_TYPE_RUNE: sResult = "元魂"; break;
                case TEQUIP_TYPE.EQUIP_TYPE_XITEM4: sResult = "XITEM4"; break;
                case TEQUIP_TYPE.EQUIP_TYPE_XITEM5: sResult = "XITEM5"; break;
                case TEQUIP_TYPE.EQUIP_TYPE_FASHION_WEAPON: sResult = "FASHION_WEAPON"; break;
                case TEQUIP_TYPE.EQUIP_TYPE_27: sResult = "27"; break;
            }
            return sResult;
        }
    }
}