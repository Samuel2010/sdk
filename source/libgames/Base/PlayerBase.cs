using System;
using System.Text;
using System.Runtime.CompilerServices;
using SKILL;

namespace GAME
{
    /// <summary>
    /// 角色接口类
    /// </summary>
    public class GPlayerBase
    {
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void Log(IntPtr p, GLOG_TYPE type, string s);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetId(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetGuId(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static IntPtr GetVictim(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static string GetName(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static string GetNameById(IntPtr p, int id);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetLevel(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetGender(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetClass(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetOccupation(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetVIPLevel(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetHP(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetMP(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetMaxHP(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetMaxMP(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static float GetSpeed(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static float GetCrit(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetMinDamage(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetMaxDamage(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetAttack(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetDefense(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetArmor(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetResistance(IntPtr p, int index);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static float GetAttackRange(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetAntiCrit(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static float GetAntiCritDamage(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetSkillAttackRate(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetSkillArmorRate(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetSkillBaseLevel(IntPtr p, int skillid);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetSkillTotalLevel(IntPtr p, int skillid);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetMapId(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static float GetPosX(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static float GetPosY(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static float GetPosZ(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetDomainId(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetMapPlayerCount(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetMapNpcCount(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetMapMatterCount(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetPKLevel(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetPKValue(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int IncPKValue(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int DecPKValue(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void ClrPKValue(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool IsTeamLeader(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool IsTeamMember(IntPtr p, int id);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool IsInTeam(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetTeamLeaderId(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetTeamMemberNum(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetTeamId(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetTeamSeq(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int MoveTeamMember(IntPtr p, int mapid, float x, float y, float z);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetNewProfession(IntPtr p, int new_prof);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool CanMetempsychosis(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool Metempsychosis(IntPtr p, int new_prof);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool CanUnMetempsychosis(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool UnMetempsychosis(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetCultivation(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetCircleMemberCnt(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetEquipment(IntPtr p, int index);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetInscription(IntPtr p, TEQUIP_TYPE type);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetInscription(IntPtr p, TEQUIP_TYPE type, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetFactionId(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetEnemyFactionId(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetFamilyId(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetMasterId(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetSectId(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetZoneId(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetMafiaId(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetCircleId(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetRank(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetMafiaRank(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetCurTitle(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetPkLevel(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetTrashBoxCapacity(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetMafiaTrashBoxCapacity(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetTrashBoxMoney(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetRebornCount(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetPlayTime(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetLoginTimeStamp(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetGender(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetOccupation(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetLevel(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetHP(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetMP(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetMaxHP(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetMaxMP(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetSpeed(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetCrit(IntPtr p, int rate, float damage);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetDamage(IntPtr p, int low, int high);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetAttack(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetDefense(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetArmor(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetResistance(IntPtr p, int index, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetAttackRange(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetAntiCrit(IntPtr p, int crit, float damage);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetSkillRate(IntPtr p, int attack, int armor);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetAntiInvisibleRate(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetInventorySize(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetPocketSize(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetStorehouseSize(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetMountInventorySize(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetPetInventorySize(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetCurTitle(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool CheckTitle(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SelectTitle(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool DelTitle(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool AddTitle(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void EnhanceScaleHPGen(IntPtr p, int hpgen);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void ImpairScaleHPGen(IntPtr p, int hpgen);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void EnhanceScaleMPGen(IntPtr p, int mpgen);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void ImpairScaleMPGen(IntPtr p, int mpgen);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void EnhanceMaxHP(IntPtr p, int hp);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void ImpairMaxHP(IntPtr p, int hp);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void EnhanceMaxMP(IntPtr p, int mp);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void ImpairMaxMP(IntPtr p, int mp);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void EnhanceMaxDP(IntPtr p, int dp);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void ImpairMaxDP(IntPtr p, int dp);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void EnhanceScaleMaxHP(IntPtr p, int hp);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void ImpairScaleMaxHP(IntPtr p, int hp);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void EnhanceScaleMaxMP(IntPtr p, int mp);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void ImpairScaleMaxMP(IntPtr p, int mp);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void EnhanceScaleMaxDP(IntPtr p, int dp);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void ImpairScaleMaxDP(IntPtr p, int dp);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void EnhanceDefense(IntPtr p, int def);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void ImpairDefense(IntPtr p, int def);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void EnhanceScaleDefense(IntPtr p, int def);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void ImpairScaleDefense(IntPtr p, int def);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void EnhanceArmor(IntPtr p, int ac);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void ImpairArmor(IntPtr p, int ac);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void EnhanceScaleArmor(IntPtr p, int ac);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void ImpairScaleArmor(IntPtr p, int ac);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void EnhanceResistance(IntPtr p, RESISTANCE cls, int res);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void ImpairResistance(IntPtr p, RESISTANCE cls, int res);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void EnhanceScaleResistance(IntPtr p, RESISTANCE cls, int res);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void ImpairScaleResistance(IntPtr p, RESISTANCE cls, int res);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void EnhanceResistanceTenaciy(IntPtr p, RESISTANCE cls, int res);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void ImpairResistanceTenaciy(IntPtr p, RESISTANCE cls, int res);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void EnhanceScaleResistanceTenaciy(IntPtr p, RESISTANCE cls, int res);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void ImpairScaleResistanceTenaciy(IntPtr p, RESISTANCE cls, int res);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void EnhanceResistanceProficiency(IntPtr p, RESISTANCE cls, int res);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void ImpairResistanceProficiency(IntPtr p, RESISTANCE cls, int res);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void EnhanceScaleResistanceProficiency(IntPtr p, RESISTANCE cls, int res);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void ImpairScaleResistanceProficiency(IntPtr p, RESISTANCE cls, int res);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void EnhanceDamage(IntPtr p, int dmg);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void ImpairDamage(IntPtr p, int dmg);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void EnhanceScaleDamage(IntPtr p, int dmg);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void ImpairScaleDamage(IntPtr p, int dmg);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void EnhanceDmgReduce(IntPtr p, int dmg_reduce);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void ImpairDmgReduce(IntPtr p, int dmg_reduce);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void EnhanceScaleDmgReduce(IntPtr p, int dmg_reduce);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void ImpairScaleDmgReduce(IntPtr p, int dmg_reduce);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void EnhanceSkillAttack(IntPtr p, int skill_attack);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void ImpairSkillAttack(IntPtr p, int skill_attack);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void EnhanceSkillArmor(IntPtr p, int skill_armor);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void ImpairSkillArmor(IntPtr p, int skill_armor);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void EnhanceAntiCritRate(IntPtr p, int crit_rate);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void ImpairAntiCritRate(IntPtr p, int crit_rate);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void EnhanceAntiCritDamage(IntPtr p, float crit_damage);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void ImpairAntiCritDamage(IntPtr p, float crit_damage);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void EnhanceCultDefense(IntPtr p, CULT_DEF_TYPE index, int cult_defense);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void ImpairCultDefense(IntPtr p, CULT_DEF_TYPE index, int cult_defense);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void EnhancePetDamage(IntPtr p, int adjust);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void EnhancePetAttackDefense(IntPtr p, int adjust);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void EnhanceOverrideSpeed(IntPtr p, float speedup);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void ImpairOverrideSpeed(IntPtr p, float speedup);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void EnhanceSpeed(IntPtr p, float speedup);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void ImpairSpeed(IntPtr p, float speedup);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void EnhanceScaleSpeed(IntPtr p, int inc);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void ImpairScaleSpeed(IntPtr p, int inc);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void EnhanceScaleAttack(IntPtr p, int attack);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void ImpairScaleAttack(IntPtr p, int attack);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void EnhanceAttack(IntPtr p, int attack);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void ImpairAttack(IntPtr p, int attack);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void EnhanceCrit(IntPtr p, int val);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void ImpairCrit(IntPtr p, int val);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void EnhanceCritDmg(IntPtr p, float val);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void ImpairCritDmg(IntPtr p, float val);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetOverSpeed(IntPtr p, float sp);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void EnhanceAntiTransform(IntPtr p, int val);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void ImpairAntiTransform(IntPtr p, int val);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void EnhanceScaleAntiTransform(IntPtr p, int val);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void ImpairScaleAntiTransform(IntPtr p, int val);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void EnhanceMountSpeed(IntPtr p, float val);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void ImpairMountSpeed(IntPtr p, float val);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void EnhanceAntiDiet(IntPtr p, int val);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void ImpairAntiDiet(IntPtr p, int val);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void EnhanceProp(IntPtr p, PLAYER_PROP index, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void ImpairProp(IntPtr p, PLAYER_PROP index, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void UpdateAllProp(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddHP(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddMP(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddDefense(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddAttack(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddArmor(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddDamage(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddResistance(IntPtr p, int index, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddCrit(IntPtr p, int rate, float damage);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddSpeed(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddAntiCrit(IntPtr p, int crit, float damage);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddSkillRate(IntPtr p, int attack, float armor);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddAttackRange(IntPtr p, float v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddScaleHP(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddScaleMP(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddScaleDefense(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddScaleAttack(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddScaleArmor(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddScaleDamage(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddScaleSpeed(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddScaleResistance(IntPtr p, int index, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddReputation(IntPtr p, int index, int rep);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddSkillProficiency(IntPtr p, int id, int add);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddTransformSkill(IntPtr p, int id, int level);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetMoney(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void DecMoney(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddMoney(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetMallCash(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetMallCashUsed(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void PayMallCash(IntPtr p, int cash, int aid);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddMallCash(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void DecMallCash(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetBonus(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static int GetBonusUsed(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddBonus(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void DecBonus(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddExp(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddLevel(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddDeityExp(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void AddDeityLevel(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void DecExp(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void DecLevel(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void DecDeityExp(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void DecDeityLevel(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool GiveEquipment(IntPtr p, int pos, int id, int level);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool GiveItem(IntPtr p, int pos, int id, int count);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool TakeItem(IntPtr p, int pos, int id, int count);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool FindItem(IntPtr p, int pos, int id, int count);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void ForceLogout(IntPtr p, LOGOUT_TYPE v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SetFashionMode(IntPtr p, int v);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void LongJump(IntPtr p, int mapid, float x, float y, float z, float r);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void LineJump(IntPtr p, int lineid, int mapid, float x, float y, float z, float r);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void Say(IntPtr p, string s);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SingleCastMsg(IntPtr p, string s, TCHAT_CHANNEL channel);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void BroadcastMsg(IntPtr p, string s, TCHAT_CHANNEL channel);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void MobObject(IntPtr p, int id, int count, int life);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool AddFilter(IntPtr p, FILTER_TYPE id, FILTER_MASK mask, int bufid, int timeout, int var0, int var1, int var2, int var3, int var4, int var5);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool ChkFilter(IntPtr p, FILTER_TYPE id);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool DelFilter(IntPtr p, FILTER_TYPE id);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool SetScriptDescription(IntPtr p, string s);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool AddScriptOption(IntPtr p, string option, string hint, string func);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static bool ClrScriptContent(IntPtr p);
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private extern static void SendPkLevelNotify(IntPtr p, int level);
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
        /// 取得角色标识
        /// </summary>
        /// <returns>等级</returns>
        public int GetGuId()
        {
            return GetGuId(nativePtr);
        }
        /// <summary>
        /// 取得角色标识
        /// </summary>
        /// <returns>等级</returns>
        public int GetId()
        {
            return GetId(nativePtr);
        }
        public GPlayerWrapper GetVictim()
        {
            return new GPlayerWrapper(GetVictim(nativePtr));
        }
        /// <summary>
        /// 取得角色名称
        /// </summary>
        /// <returns>角色名称</returns>
        public string GetName()
        {
            return GetName(nativePtr);
        }
        /// <summary>
        /// 取得角色名称
        /// </summary>
        /// <returns>角色名称</returns>
        public string GetNameById(int id)
        {
            return GetNameById(nativePtr, id);
        }
        /// <summary>
        /// 取得角色等级
        /// </summary>
        /// <returns>等级</returns>
        public int GetLevel()
        {
            return GetLevel(nativePtr);
        }
        /// <summary>
        /// 取得角色性别
        /// </summary>
        /// <returns>性别</returns>
        public int GetGender()
        {
            return GetGender(nativePtr);
        }
        /// <summary>
        /// 取得角色种族
        /// </summary>
        /// <returns>性别</returns>
        public int GetClass()
        {
            return GetClass(nativePtr);
        }
        /// <summary>
        /// 取得角色职业
        /// </summary>
        /// <returns>职业</returns>
        public int GetOccupation()
        {
            return GetOccupation(nativePtr);
        }
        /// <summary>
        /// 取得角色会员等级
        /// </summary>
        /// <returns>会员等级</returns>
        public int GetVIPLevel()
        {
            return GetVIPLevel(nativePtr);
        }
        /// <summary>
        /// 取得角色血量
        /// </summary>
        /// <returns></returns>
        public int GetHP()
        {
            return GetHP(nativePtr);
        }
        public int GetMP()
        {
            return GetMP(nativePtr);
        }
        public int GetMaxHP()
        {
            return GetMaxHP(nativePtr);
        }
        public int GetMaxMP()
        {
            return GetMaxMP(nativePtr);
        }
        public float GetSpeed()
        {
            return GetSpeed(nativePtr);
        }
        public float GetCrit()
        {
            return GetCrit(nativePtr);
        }
        public int GetMinDamage()
        {
            return GetMinDamage(nativePtr);
        }
        public int GetMaxDamage()
        {
            return GetMaxDamage(nativePtr);
        }
        public int GetAttack()
        {
            return GetAttack(nativePtr);
        }
        public int GetDefense()
        {
            return GetDefense(nativePtr);
        }
        public int GetArmor()
        {
            return GetArmor(nativePtr);
        }
        public int GetResistance(int index)
        {
            return GetResistance(nativePtr,index);
        }
        public float GetAttackRange()
        {
            return GetAttackRange(nativePtr);
        }
        public int GetAntiCrit()
        {
            return GetAntiCrit(nativePtr);
        }
        public float GetAntiCritDamage()
        {
            return GetAntiCritDamage(nativePtr);
        }
        public int GetSkillAttackRate()
        {
            return GetSkillAttackRate(nativePtr);
        }
        public int GetSkillArmorRate()
        {
            return GetSkillArmorRate(nativePtr);
        }
        public int GetSkillBaseLevel(int skillid)
        {
            return GetSkillBaseLevel(nativePtr,skillid);
        }
        public int GetSkillTotalLevel(int skillid)
        {
            return GetSkillTotalLevel(nativePtr,skillid);
        }
        /// <summary>
        /// 取得角色当前所在地图标识
        /// </summary>
        /// <returns>标识</returns>
        public int GetMapId()
        {
            return GetMapId(nativePtr);
        }
        /// <summary>
        /// 取得角色当前座标X
        /// </summary>
        /// <returns>座标X</returns>
        public float GetPosX()
        {
            return GetPosX(nativePtr);
        }
        /// <summary>
        /// 取得角色当前座标Y
        /// </summary>
        /// <returns>座标Y</returns>
        public float GetPosY()
        {
            return GetPosY(nativePtr);
        }
        /// <summary>
        /// 取得角色当前座标Z
        /// </summary>
        /// <returns>座标Z</returns>
        public float GetPosZ()
        {
            return GetPosZ(nativePtr);
        }
        /// <summary>
        /// 取得角色当前所在区域标识
        /// </summary>
        /// <returns>区域标识</returns>
        public int GetDomainId()
        {
            return GetDomainId(nativePtr);
        }
        /// <summary>
        /// 取得角色所在地图角色数量
        /// </summary>
        /// <returns>角色数量</returns>
        public int GetMapPlayerCount()
        {
            return GetMapPlayerCount(nativePtr);
        }
        /// <summary>
        /// 取得角色所在地图NPC数量(怪物及NPC)
        /// </summary>
        /// <returns>NPC数量</returns>
        public int GetMapNpcCount()
        {
            return GetMapNpcCount(nativePtr);
        }
        /// <summary>
        /// 取得角色所在地图物品数量
        /// </summary>
        /// <returns>物品数量</returns>
        public int GetMapMatterCount()
        {
            return GetMapMatterCount(nativePtr);
        }
        /// <summary>
        /// 取得当前PK级别
        /// </summary>
        /// <returns>当前PK级别</returns>
        public int GetPKLevel()
        {
            return GetPKLevel(nativePtr);
        }
        /// <summary>
        /// 取得当前PK值
        /// </summary>
        /// <returns>当前PK值</returns>
        public int GetPKValue()
        {
            return GetPKValue(nativePtr);
        }
        /// <summary>
        /// 增加PK值
        /// </summary>
        /// <returns>增加后的PK值</returns>
        public int IncPKValue(int v)
        {
            return IncPKValue(nativePtr, v);
        }
        /// <summary>
        /// 减少PK值
        /// </summary>
        /// <returns>减少后的PK值</returns>
        public int DecPKValue(int v)
        {
            return DecPKValue(nativePtr, v);
        }
        /// <summary>
        /// 清除PK值
        /// </summary>
        public void ClrPKValue()
        {
            ClrPKValue(nativePtr);
        }
        /// <summary>
        /// 取得角色是否为队长
        /// </summary>
        /// <returns>结果</returns>
        public bool IsTeamLeader()
        {
            return IsTeamLeader(nativePtr);
        }
        /// <summary>
        /// 取得角色是否为队员
        /// </summary>
        /// <returns>结果</returns>
        public bool IsTeamMember(int id)
        {
            return IsTeamMember(nativePtr, id);
        }
        /// <summary>
        /// 取得角色是否加入队伍
        /// </summary>
        /// <returns>结果</returns>
        public bool IsInTeam()
        {
            return IsInTeam(nativePtr);
        }
        /// <summary>
        /// 取得队长标识
        /// </summary>
        /// <returns>角色标识</returns>
        public int GetTeamLeaderId()
        {
            return GetTeamLeaderId(nativePtr);
        }
        /// <summary>
        /// 取得队伍成员数量
        /// </summary>
        /// <returns>角色数量</returns>
        public int GetTeamMemberNum()
        {
            return GetTeamMemberNum(nativePtr);
        }
        /// <summary>
        /// 取得队伍标识
        /// </summary>
        /// <returns>队伍标识</returns>
        public int GetTeamId()
        {
            return GetTeamId(nativePtr);
        }
        public int GetTeamSeq()
        {
            return GetTeamSeq(nativePtr);
        }
        /// <summary>
        /// 队伍成员移动
        /// </summary>
        /// <param name="mapid">职业</param>
        /// <param name="x">坐标X</param>
        /// <param name="y">坐标Y</param>
        /// <param name="z">坐标Z</param>
        /// <returns>成员数量</returns>
        public int MoveTeamMember(int mapid, float x, float y, float z)
        {
            return MoveTeamMember(nativePtr,mapid, x, y, z);
        }
        /// <summary>
        /// 设置新职业
        /// </summary>
        /// <param name="new_prof">职业</param>
        /// <returns></returns>
        public void SetNewProfession(int new_prof)
        {
            SetNewProfession(nativePtr, new_prof);
        }
        /// <summary>
        /// 是否可以飞升
        /// </summary>
        /// <returns>结果</returns>
        public bool CanMetempsychosis()
        {
            return CanMetempsychosis(nativePtr);
        }
        /// <summary>
        /// 飞升
        /// </summary>
        /// <param name="new_prof">职业</param>
        /// <returns>结果</returns>
        public bool Metempsychosis(int new_prof)
        {
            return Metempsychosis(nativePtr, new_prof);
        }
        public bool CanUnMetempsychosis()
        {
            return CanUnMetempsychosis(nativePtr);
        }
        private bool UnMetempsychosis()
        {
            return UnMetempsychosis(nativePtr);
        }
        public int GetCultivation()
        {
            return GetCultivation(nativePtr);
        }
        public int GetCircleMemberCnt()
        {
            return GetCircleMemberCnt(nativePtr);
        }
        /// <summary>
        /// 取得身上装备标识
        /// </summary>
        /// <returns>装备标识</returns>
        public int GetEquipment(int index)
        {
            return GetEquipment(nativePtr, index);
        }
        /// <summary>
        /// 取得身上装备铭刻属性
        /// </summary>
        /// <returns>属性标识</returns>
        public int GetInscription(TEQUIP_TYPE type)
        {
            return GetInscription(nativePtr, type);
        }
        /// <summary>
        /// 设置身上装备铭刻属性
        /// </summary>
        /// <param name="v">属性标识</param>
        public bool SetInscription(TEQUIP_TYPE type, int v)
        {
            return SetInscription(nativePtr, type, v);
        }
        public int GetFactionId()
        {
            return GetFactionId(nativePtr);
        }
        public int GetEnemyFactionId()
        {
            return GetEnemyFactionId(nativePtr);
        }
        public int GetFamilyId()
        {
            return GetFamilyId(nativePtr);
        }
        public int GetMasterId()
        {
            return GetMasterId(nativePtr);
        }
        public int GetSectId()
        {
            return GetSectId(nativePtr);
        }
        public int GetZoneId()
        {
            return GetZoneId(nativePtr);
        }
        public int GetMafiaId()
        {
            return GetMafiaId(nativePtr);
        }
        public int GetCircleId()
        {
            return GetCircleId(nativePtr);
        }
        public int GetRank()
        {
            return GetRank(nativePtr);
        }
        public int GetMafiaRank()
        {
            return GetMafiaRank(nativePtr);
        }
        public int GetCurTitle()
        {
            return GetCurTitle(nativePtr);
        }
        public int GetPkLevel()
        {
            return GetPkLevel(nativePtr);
        }
        public int GetTrashBoxCapacity()
        {
            return GetTrashBoxCapacity(nativePtr);
        }
        public int GetMafiaTrashBoxCapacity()
        {
            return GetMafiaTrashBoxCapacity(nativePtr);
        }
        public int GetTrashBoxMoney()
        {
            return GetTrashBoxMoney(nativePtr);
        }
        public int GetRebornCount()
        {
            return GetRebornCount(nativePtr);
        }
        public int GetPlayTime()
        {
            return GetPlayTime(nativePtr);
        }
        public int GetLoginTimeStamp()
        {
            return GetLoginTimeStamp(nativePtr);
        }
        public void SetGender(int v)
        {
            SetGender(nativePtr, v);
        }
        public void SetOccupation(int v)
        {
            SetOccupation(nativePtr, v);
        }
        public void SetLevel(int v)
        {
            SetLevel(nativePtr, v);
        }
        public void SetHP(int v)
        {
            SetHP(nativePtr, v);
        }
        public void SetMP(int v)
        {
            SetMP(nativePtr, v);
        }
        public void SetMaxHP(int v)
        {
            SetMaxHP(nativePtr, v);
        }
        public void SetMaxMP(int v)
        {
            SetMaxMP(nativePtr, v);
        }
        public void SetSpeed(float v)
        {
            SetSpeed(nativePtr, v);
        }
        public void SetCrit(int rate, float damage)
        {
            SetCrit(nativePtr, rate, damage);
        }
        public void SetDamage(int low, int high)
        {
            SetDamage(nativePtr, low, high);
        }
        public void SetAttack(int v)
        {
            SetAttack(nativePtr, v);
        }
        public void SetDefense(int v)
        {
            SetDefense(nativePtr, v);
        }
        public void SetArmor(int v)
        {
            SetArmor(nativePtr, v);
        }
        public void SetResistance(int index, int v)
        {
            SetResistance(nativePtr, index, v);
        }
        public void SetAttackRange(float v)
        {
            SetAttackRange(nativePtr, v);
        }
        public void SetAntiCrit(int crit, float damage)
        {
            SetAntiCrit(nativePtr, crit, damage);
        }
        public void SetSkillRate(int attack, int armor)
        {
            SetSkillRate(nativePtr, attack, armor);
        }
        public void SetAntiInvisibleRate(int v)
        {
            SetAntiInvisibleRate(nativePtr, v);
        }
        public void SetInventorySize(int v)
        {
            SetInventorySize(nativePtr, v);
        }
        public void SetPocketSize(int v)
        {
            SetPocketSize(nativePtr, v);
        }
        public void SetStorehouseSize(int v)
        {
            SetStorehouseSize(nativePtr, v);
        }
        public void SetMountInventorySize(int v)
        {
            SetMountInventorySize(nativePtr, v);
        }
        public void SetPetInventorySize(int v)
        {
            SetPetInventorySize(nativePtr, v);
        }
        /// <summary>
        /// 设置当前称号(客户端立即显示)
        /// </summary>
        /// <param name="v">称号标识</param>
        public bool SetCurTitle(int v)
        {
            return SetCurTitle(nativePtr, v);
        }
        /// <summary>
        /// 检查是否有称号
        /// </summary>
        /// <param name="v">称号标识</param>
        public bool CheckTitle(int v)
        {
            return CheckTitle(nativePtr, v);
        }
        /// <summary>
        /// 选择已有的称号
        /// </summary>
        /// <param name="v">称号标识</param>
        public bool SelectTitle(int v)
        {
            return SelectTitle(nativePtr, v);
        }
        /// <summary>
        /// 删除称号
        /// </summary>
        /// <param name="v">称号标识</param>
        public bool DelTitle(int v)
        {
            return DelTitle(nativePtr, v);
        }
        /// <summary>
        /// 添加称号
        /// </summary>
        /// <param name="v">称号标识</param>
        public bool AddTitle(int v)
        {
            return AddTitle(nativePtr, v);
        }
        /// <summary>
        /// 增加恢复HP速度(按比例)
        /// </summary>
        /// <param name="hpgen">数值</param>
        public void EnhanceScaleHPGen(int hpgen)
        {
	        EnhanceScaleHPGen(nativePtr, hpgen);
        }
        /// <summary>
        /// 减少恢复HP速度(按比例)
        /// </summary>
        /// <param name="hpgen">数值</param>
        public void ImpairScaleHPGen(int hpgen)
        {
	        ImpairScaleHPGen(nativePtr, hpgen);
        }
        /// <summary>
        /// 增加恢复MP速度(按比例)
        /// </summary>
        /// <param name="hpgen">数值</param>
        public void EnhanceScaleMPGen(int mpgen)
        {
	        EnhanceScaleMPGen(nativePtr, mpgen);
        }
        /// <summary>
        /// 减少恢复MP速度(按比例)
        /// </summary>
        /// <param name="hpgen">数值</param>
        public void ImpairScaleMPGen(int mpgen)
        {
	        ImpairScaleMPGen(nativePtr, mpgen);
        }
        /// <summary>
        /// 增加HP上限
        /// </summary>
        /// <param name="hpgen">数值</param>
        public void EnhanceMaxHP(int hp)
        {
	        EnhanceMaxHP(nativePtr, hp);
        }
        /// <summary>
        /// 减少HP上限
        /// </summary>
        /// <param name="hpgen">数值</param>
        public void ImpairMaxHP(int hp)
        {
	        ImpairMaxHP(nativePtr, hp);
        }
        /// <summary>
        /// 增加HP上限(按比例)
        /// </summary>
        /// <param name="hpgen">数值</param>
        public void EnhanceScaleMaxHP(int hp)
        {
            EnhanceScaleMaxHP(nativePtr, hp);
        }
        /// <summary>
        /// 减少HP上限(按比例)
        /// </summary>
        /// <param name="hpgen">数值</param>
        public void ImpairScaleMaxHP(int hp)
        {
            ImpairScaleMaxHP(nativePtr, hp);
        }
        /// <summary>
        /// 增加MP上限
        /// </summary>
        /// <param name="hpgen">数值</param>
        public void EnhanceMaxMP(int mp)
        {
	        EnhanceMaxMP(nativePtr, mp);
        }
        /// <summary>
        /// 减少MP上限
        /// </summary>
        /// <param name="hpgen">数值</param>
        public void ImpairMaxMP(int mp)
        {
	        ImpairMaxMP(nativePtr, mp);
        }
        /// <summary>
        /// 减少MP上限(按比例)
        /// </summary>
        /// <param name="hpgen">数值</param>
        public void EnhanceScaleMaxMP(int mp)
        {
            EnhanceScaleMaxMP(nativePtr, mp);
        }
        /// <summary>
        /// 减少MP上限(按比例)
        /// </summary>
        /// <param name="hpgen">数值</param>
        public void ImpairScaleMaxMP(int mp)
        {
            ImpairScaleMaxMP(nativePtr, mp);
        }
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="dp">数值</param>
        public void EnhanceMaxDP(int dp)
        {
	        EnhanceMaxDP(nativePtr, dp);
        }
        /// <summary>
        /// 减少
        /// </summary>
        /// <param name="dp">数值</param>
        public void ImpairMaxDP(int dp)
        {
	        ImpairMaxDP(nativePtr, dp);
        }
        /// <summary>
        /// 增加(按比例)
        /// </summary>
        /// <param name="dp">数值</param>
        public void EnhanceScaleMaxDP(int dp)
        {
	        EnhanceScaleMaxDP(nativePtr, dp);
        }
        /// <summary>
        /// 减少(按比例)
        /// </summary>
        /// <param name="dp">数值</param>
        public void ImpairScaleMaxDP(int dp)
        {
	        ImpairScaleMaxDP(nativePtr, dp);
        }
        /// <summary>
        /// 增加防御力
        /// </summary>
        /// <param name="def">数值</param>
        public void EnhanceDefense(int def)
        {
	        EnhanceDefense(nativePtr, def);
        }
        /// <summary>
        /// 减少防御力
        /// </summary>
        /// <param name="def">数值</param>
        public void ImpairDefense(int def)
        {
	        ImpairDefense(nativePtr, def);
        }
        /// <summary>
        /// 增加防御力(按比例)
        /// </summary>
        /// <param name="def">数值</param>
        public void EnhanceScaleDefense(int def)
        {
	        EnhanceScaleDefense(nativePtr, def);
        }
        /// <summary>
        /// 减少防御力(按比例)
        /// </summary>
        /// <param name="def">数值</param>
        public void ImpairScaleDefense(int def)
        {
	        ImpairScaleDefense(nativePtr, def);
        }
        /// <summary>
        /// 增加普攻闪躲
        /// </summary>
        /// <param name="ac">数值</param>
        public void EnhanceArmor(int ac)
        {
	        EnhanceArmor(nativePtr, ac);
        }
        /// <summary>
        /// 减少普攻闪躲
        /// </summary>
        /// <param name="ac">数值</param>
        public void ImpairArmor(int ac)
        {
	        ImpairArmor(nativePtr, ac);
        }
        /// <summary>
        /// 增加普攻闪躲(按比例)
        /// </summary>
        /// <param name="ac">数值</param>
        public void EnhanceScaleArmor(int ac)
        {
	        EnhanceScaleArmor(nativePtr, ac);
        }
        /// <summary>
        /// 减少普攻闪躲(按比例)
        /// </summary>
        /// <param name="ac">数值</param>
        public void ImpairScaleArmor(int ac)
        {
	        ImpairScaleArmor(nativePtr, ac);
        }
        /// <summary>
        /// 增加抗性
        /// </summary>
        /// <param name="cls">类型</param>
        /// <param name="res">数值</param>
        public void EnhanceResistance(RESISTANCE cls, int res)
        {
	        EnhanceResistance(nativePtr, cls,res);
        }
        /// <summary>
        /// 减少抗性
        /// </summary>
        /// <param name="cls">类型</param>
        /// <param name="res">数值</param>
        public void ImpairResistance(RESISTANCE cls, int res)
        {
	        ImpairResistance(nativePtr, cls,res);
        }
        /// <summary>
        /// 增加抗性(按比例)
        /// </summary>
        /// <param name="cls">类型</param>
        /// <param name="res">数值</param>
        public void EnhanceScaleResistance(RESISTANCE cls, int res)
        {
            EnhanceScaleResistance(nativePtr, cls, res);
        }
        /// <summary>
        /// 减少抗性(按比例)
        /// </summary>
        /// <param name="cls">类型</param>
        /// <param name="res">数值</param>
        public void ImpairScaleResistance(RESISTANCE cls, int res)
        {
            ImpairScaleResistance(nativePtr, cls, res);
        }
        /// <summary>
        /// 增加韧性抗性
        /// </summary>
        /// <param name="cls">类型</param>
        /// <param name="res">数值</param>
        public void EnhanceResistanceTenaciy(RESISTANCE cls, int res)
        {
	        EnhanceResistanceTenaciy(nativePtr, cls,res);
        }
        /// <summary>
        /// 减少韧性抗性
        /// </summary>
        /// <param name="cls">类型</param>
        /// <param name="res">数值</param>
        public void ImpairResistanceTenaciy(RESISTANCE cls, int res)
        {
	        ImpairResistanceTenaciy(nativePtr, cls,res);
        }
        /// <summary>
        /// 增加韧性抗性(按比例)
        /// </summary>
        /// <param name="cls">类型</param>
        /// <param name="res">数值</param>
        public void EnhanceScaleResistanceTenaciy(RESISTANCE cls, int res)
        {
	        EnhanceScaleResistanceTenaciy(nativePtr, cls,res);
        }
        /// <summary>
        /// 减少韧性抗性(按比例)
        /// </summary>
        /// <param name="cls">类型</param>
        /// <param name="res">数值</param>
        public void ImpairScaleResistanceTenaciy(RESISTANCE cls, int res)
        {
	        ImpairScaleResistanceTenaciy(nativePtr, cls,res);
        }
        /// <summary>
        /// 增加精通抗性
        /// </summary>
        /// <param name="cls">类型</param>
        /// <param name="res">数值</param>
        public void EnhanceResistanceProficiency(RESISTANCE cls, int res)
        {
	        EnhanceResistanceProficiency(nativePtr, cls,res);
        }
        /// <summary>
        /// 减少精通抗性
        /// </summary>
        /// <param name="cls">类型</param>
        /// <param name="res">数值</param>
        public void ImpairResistanceProficiency(RESISTANCE cls, int res)
        {
	        ImpairResistanceProficiency(nativePtr, cls,res);
        }
        /// <summary>
        /// 增加精通抗性(按比例)
        /// </summary>
        /// <param name="cls">类型</param>
        /// <param name="res">数值</param>
        public void EnhanceScaleResistanceProficiency(RESISTANCE cls, int res)
        {
	        EnhanceScaleResistanceProficiency(nativePtr, cls,res);
        }
        /// <summary>
        /// 减少精通抗性(按比例)
        /// </summary>
        /// <param name="cls">类型</param>
        /// <param name="res">数值</param>
        public void ImpairScaleResistanceProficiency(RESISTANCE cls, int res)
        {
	        ImpairScaleResistanceProficiency(nativePtr, cls,res);
        }
        /// <summary>
        /// 增加攻击力
        /// </summary>
        /// <param name="res">dmg</param>
        public void EnhanceDamage(int dmg)
        {
            EnhanceDamage(nativePtr, dmg);
        }
        /// <summary>
        /// 减少攻击力
        /// </summary>
        /// <param name="res">dmg</param>
        public void ImpairDamage(int dmg)
        {
            ImpairDamage(nativePtr, dmg);
        }
        /// <summary>
        /// 增加攻击力(按比例)
        /// </summary>
        /// <param name="res">dmg</param>
        public void EnhanceScaleDamage(int dmg)
        {
	        EnhanceScaleDamage(nativePtr, dmg);
        }
        /// <summary>
        /// 减少攻击力(按比例)
        /// </summary>
        /// <param name="res">dmg</param>
        public void ImpairScaleDamage(int dmg)
        {
	        ImpairScaleDamage(nativePtr, dmg);
        }
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="dmg_reduce">数值</param>
        public void EnhanceDmgReduce(int dmg_reduce)
        {
	        EnhanceDmgReduce(nativePtr, dmg_reduce);
        }
        /// <summary>
        /// 减少
        /// </summary>
        /// <param name="dmg_reduce">数值</param>
        public void ImpairDmgReduce(int dmg_reduce)
        {
	        ImpairDmgReduce(nativePtr, dmg_reduce);
        }
        /// <summary>
        /// 增加(按比例)
        /// </summary>
        /// <param name="dmg_reduce">数值</param>
        public void EnhanceScaleDmgReduce(int dmg_reduce)
        {
	        EnhanceScaleDmgReduce(nativePtr, dmg_reduce);
        }
        /// <summary>
        /// 减少(按比例)
        /// </summary>
        /// <param name="dmg_reduce">数值</param>
        public void ImpairScaleDmgReduce(int dmg_reduce)
        {
	        ImpairScaleDmgReduce(nativePtr, dmg_reduce);
        }
        /// <summary>
        /// 增加技能命中
        /// </summary>
        /// <param name="skill_attack">数值</param>
        public void EnhanceSkillAttack(int skill_attack)
        {
	        EnhanceSkillAttack(nativePtr, skill_attack);
        }
        /// <summary>
        /// 减少技能命中
        /// </summary>
        /// <param name="skill_attack">数值</param>
        public void ImpairSkillAttack(int skill_attack)
        {
	        ImpairSkillAttack(nativePtr, skill_attack);
        }
        /// <summary>
        /// 增加普攻闪躲
        /// </summary>
        /// <param name="skill_armor">数值</param>
        public void EnhanceSkillArmor(int skill_armor)
        {
	        EnhanceSkillArmor(nativePtr, skill_armor);
        }
        /// <summary>
        /// 减少普攻闪躲
        /// </summary>
        /// <param name="skill_armor">数值</param>
        public void ImpairSkillArmor(int skill_armor)
        {
	        ImpairSkillArmor(nativePtr, skill_armor);
        }
        /// <summary>
        /// 增加暴击抵抗
        /// </summary>
        /// <param name="crit_rate">数值</param>
        public void EnhanceAntiCritRate(int crit_rate)
        {
	        EnhanceAntiCritRate(nativePtr, crit_rate);
        }
        /// <summary>
        /// 减少暴击抵抗
        /// </summary>
        /// <param name="crit_rate">数值</param>
        public void ImpairAntiCritRate(int crit_rate)
        {
	        ImpairAntiCritRate(nativePtr, crit_rate);
        }
        /// <summary>
        /// 增加暴击伤害抵抗
        /// </summary>
        /// <param name="crit_damage">数值</param>
        public void EnhanceAntiCritDamage(float crit_damage)
        {
	        EnhanceAntiCritDamage(nativePtr, crit_damage);
        }
        /// <summary>
        /// 减少暴击伤害抵抗
        /// </summary>
        /// <param name="crit_damage">数值</param>
        public void ImpairAntiCritDamage(float crit_damage)
        {
	        ImpairAntiCritDamage(nativePtr, crit_damage);
        }
        /// <summary>
        /// 增加造化防御
        /// </summary>
        /// <param name="index">类型</param>
        /// <param name="cult_defense">数值</param>
        public void EnhanceCultDefense(CULT_DEF_TYPE index, int cult_defense)
        {
            EnhanceCultDefense(nativePtr, index, cult_defense);
        }
        /// <summary>
        /// 减少造化防御
        /// </summary>
        /// <param name="index">类型</param>
        /// <param name="cult_defense">数值</param>
        public void ImpairCultDefense(CULT_DEF_TYPE index, int cult_defense)
        {
            ImpairCultDefense(nativePtr, index, cult_defense);
        }
        public void EnhancePetDamage(int adjust)
        {
	        EnhancePetDamage(nativePtr, adjust);
        }
        public void EnhancePetAttackDefense(int adjust)
        {
	        EnhancePetAttackDefense(nativePtr, adjust);
        }
        public void EnhanceOverrideSpeed(float speedup)
        {
	        EnhanceOverrideSpeed(nativePtr, speedup);
        }
        public void ImpairOverrideSpeed(float speedup)
        {
	        ImpairOverrideSpeed(nativePtr, speedup);
        }
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="val">数值</param>
        public void EnhanceSpeed(float speedup)
        {
	        EnhanceSpeed(nativePtr, speedup);
        }
        /// <summary>
        /// 减少
        /// </summary>
        /// <param name="speedup">数值</param>
        public void ImpairSpeed(float speedup)
        {
	        ImpairSpeed(nativePtr, speedup);
        }
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="val">数值</param>
        public void EnhanceScaleSpeed(int inc)
        {
	        EnhanceScaleSpeed(nativePtr, inc);
        }
        /// <summary>
        /// 减少
        /// </summary>
        /// <param name="inc">数值</param>
        public void ImpairScaleSpeed(int inc)
        {
	        ImpairScaleSpeed(nativePtr, inc);
        }
        /// <summary>
        /// 增加普攻命中
        /// </summary>
        /// <param name="attack">数值</param>
        public void EnhanceAttack(int attack)
        {
            EnhanceAttack(nativePtr, attack);
        }
        /// <summary>
        /// 减少普攻命中
        /// </summary>
        /// <param name="attack">数值</param>
        public void ImpairAttack(int attack)
        {
            ImpairAttack(nativePtr, attack);
        }
        /// <summary>
        /// 增加普攻命中(按比例)
        /// </summary>
        /// <param name="attack">数值</param>
        public void EnhanceScaleAttack(int attack)
        {
	        EnhanceScaleAttack(nativePtr, attack);
        }
        /// <summary>
        /// 减少普攻命中(按比例)
        /// </summary>
        /// <param name="attack">数值</param>
        public void ImpairScaleAttack(int attack)
        {
	        ImpairScaleAttack(nativePtr, attack);
        }
        /// <summary>
        /// 增加致命一击机率
        /// </summary>
        /// <param name="val">数值</param>
        public void EnhanceCrit(int val)
        {
	        EnhanceCrit(nativePtr, val);
        }
        /// <summary>
        /// 减少致命一击机率
        /// </summary>
        /// <param name="val">数值</param>
        public void ImpairCrit(int val)
        {
	        ImpairCrit(nativePtr, val);
        }
        /// <summary>
        /// 增加致命伤害
        /// </summary>
        /// <param name="val">数值</param>
        public void EnhanceCritDmg(float val)
        {
	        EnhanceCritDmg(nativePtr, val);
        }
        /// <summary>
        /// 减少致命伤害
        /// </summary>
        /// <param name="val">数值</param>
        public void ImpairCritDmg(float val)
        {
	        ImpairCritDmg(nativePtr, val);
        }
        public void SetOverSpeed(float sp)
        {
	        SetOverSpeed(nativePtr, sp);
        }
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="val">数值</param>
        public void EnhanceAntiTransform(int val)
        {
	        EnhanceAntiTransform(nativePtr, val);
        }
        /// <summary>
        /// 减少
        /// </summary>
        /// <param name="val">数值</param>
        public void ImpairAntiTransform(int val)
        {
	        ImpairAntiTransform(nativePtr, val);
        }
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="val">数值</param>
        public void EnhanceScaleAntiTransform(int val)
        {
	        EnhanceScaleAntiTransform(nativePtr, val);
        }
        /// <summary>
        /// 减少
        /// </summary>
        /// <param name="val">数值</param>
        public void ImpairScaleAntiTransform(int val)
        {
	        ImpairScaleAntiTransform(nativePtr, val);
        }
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="val">数值</param>
        public void EnhanceMountSpeed(float val)
        {
	        EnhanceMountSpeed(nativePtr, val);
        }
        /// <summary>
        /// 减少
        /// </summary>
        /// <param name="val">数值</param>
        public void ImpairMountSpeed(float val)
        {
	        ImpairMountSpeed(nativePtr, val);
        }
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="val">数值</param>
        public void EnhanceAntiDiet(int val)
        {
	        EnhanceAntiDiet(nativePtr, val);
        }
        /// <summary>
        /// 减少
        /// </summary>
        /// <param name="val">数值</param>
        public void ImpairAntiDiet(int val)
        {
	        ImpairAntiDiet(nativePtr, val);
        }
        public void EnhanceProp(PLAYER_PROP index, int v)
        {
            EnhanceProp(nativePtr, index, v);
        }
        public void ImpairProp(PLAYER_PROP index, int v)
        {
            ImpairProp(nativePtr, index, v);
        }
        public void UpdateAllProp()
        {
            UpdateAllProp(nativePtr);
        }
        public void AddHP(int v)
        {
            AddHP(nativePtr, v);
        }
        public void AddMP(int v)
        {
            AddMP(nativePtr, v);
        }
        public void AddDefense(int v)
        {
            AddDefense(nativePtr, v);
        }
        public void AddAttack(int v)
        {
            AddAttack(nativePtr, v);
        }
        public void AddArmor(int v)
        {
            AddArmor(nativePtr, v);
        }
        public void AddDamage(int v)
        {
            AddDamage(nativePtr, v);
        }
        public void AddResistance(int index, int v)
        {
            AddResistance(nativePtr, index, v);
        }
        public void AddCrit(int rate, float damage)
        {
            AddCrit(nativePtr, rate, damage);
        }
        public void AddSpeed(float v)
        {
            AddSpeed(nativePtr, v);
        }
        public void AddAntiCrit(int crit, float damage)
        {
            AddAntiCrit(nativePtr, crit, damage);
        }
        public void AddSkillRate(int attack, float armor)
        {
            AddSkillRate(nativePtr, attack, armor);
        }
        public void AddAttackRange(float v)
        {
            AddAttackRange(nativePtr, v);
        }
        public void AddScaleHP(int v)
        {
            AddScaleHP(nativePtr, v);
        }
        public void AddScaleMP(int v)
        {
            AddScaleMP(nativePtr, v);
        }
        public void AddScaleDefense(int v)
        {
            AddScaleDefense(nativePtr, v);
        }
        public void AddScaleAttack(int v)
        {
            AddScaleAttack(nativePtr, v);
        }
        public void AddScaleArmor(int v)
        {
            AddScaleArmor(nativePtr, v);
        }
        public void AddScaleDamage(int v)
        {
            AddScaleDamage(nativePtr, v);
        }
        public void AddScaleSpeed(int v)
        {
            AddScaleSpeed(nativePtr, v);
        }
        public void AddScaleResistance(int index, int v)
        {
            AddScaleResistance(nativePtr, index, v);
        }
        public void AddReputation(int index, int rep)
        {
            AddReputation(nativePtr, index, rep);
        }
        public void AddSkillProficiency(int id, int add)
        {
            AddSkillProficiency(nativePtr, id, add);
        }
        public void AddTransformSkill(int id, int level)
        {
            AddTransformSkill(nativePtr, id, level);
        }
        /// <summary>
        /// 取得当前金钱
        /// </summary>
        public int GetMoney()
        {
            return GetMoney(nativePtr);
        }
        /// <summary>
        /// 增加金钱
        /// </summary>
        /// <param name="v">数值</param>
        public void AddMoney(int v)
        {
            AddMoney(nativePtr, v);
        }
        /// <summary>
        /// 减少金钱
        /// </summary>
        /// <param name="v">数值</param>
        public void DecMoney(int v)
        {
            DecMoney(nativePtr, v);
        }
        /// <summary>
        /// 取得当前元宝
        /// </summary>
        public int GetMallCash()
        {
            return GetMallCash(nativePtr);
        }
        /// <summary>
        /// 取得已消费元宝
        /// </summary>
        public int GetMallCashUsed()
        {
            return GetMallCashUsed(nativePtr);
        }
        public void PayMallCash(int cash, int aid)
        {
            PayMallCash(nativePtr, cash, aid);
        }
        /// <summary>
        /// 增加元宝
        /// </summary>
        /// <param name="v">元宝数量</param>
        public void AddMallCash(int v)
        {
            AddMallCash(nativePtr, v);
        }
        /// <summary>
        /// 减少元宝
        /// </summary>
        /// <param name="v">元宝数量</param>
        public void DecMallCash(int v)
        {
            DecMallCash(nativePtr, v);
        }
        /// <summary>
        /// 取得鸿利元宝
        /// </summary>
        public int GetBonus()
        {
            return GetBonus(nativePtr);
        }
        /// <summary>
        /// 取得已使用鸿利元宝
        /// </summary>
        public int GetBonusUsed()
        {
            return GetBonusUsed(nativePtr);
        }
        /// <summary>
        /// 增加鸿利元宝
        /// </summary>
        /// <param name="v">元宝数量</param>
        public void AddBonus(int v)
        {
            AddBonus(nativePtr, v);
        }
        /// <summary>
        /// 减少鸿利元宝
        /// </summary>
        /// <param name="v">元宝数量</param>
        public void DecBonus(int v)
        {
            DecBonus(nativePtr, v);
        }
        /// <summary>
        /// 增加经验
        /// </summary>
        /// <param name="v">经验</param>
        public void AddExp(int v)
        {
            AddExp(nativePtr, v);
        }
        public void AddLevel(int v)
        {
            AddLevel(nativePtr, v);
        }
        public void AddDeityExp(int v)
        {
            AddDeityExp(nativePtr, v);
        }
        /*
        public void AddDeityLevel(int index, int v)
        {
            AddDeityLevel(nativePtr, index, v);
        }
        public void DecExp(int index, int v)
        {
            DecExp(nativePtr, index, v);
        }
        public void DecLevel(int index, int v)
        {
            DecLevel(nativePtr, index, v);
        }
        public void DecDeityExp(int index, int v)
        {
            DecDeityExp(nativePtr, index, v);
        }
        public void DecDeityLevel(int index, int v)
        {
            DecDeityLevel(nativePtr, index, v);
        }
        */
        /// <summary>
        /// 穿装备
        /// </summary>
        /// <param name="pos">装备位置</param>
        /// <param name="id">装备标识</param>
        /// <param name="id">装备级别</param>
        /// <retuns>返回是否成功</retuns>
        public bool GiveEquipment(int pos, int id, int level)
        {
            return GiveEquipment(nativePtr, pos, id, level);
        }
        /// <summary>
        /// 给物品
        /// </summary>
        /// <param name="pos">位置(0 背包)</param>
        /// <param name="id">物品标识</param>
        /// <param name="id">物品数量</param>
        /// <retuns>返回是否成功</retuns>
        public bool GiveItem(int pos, int id, int count)
        {
            return GiveItem(nativePtr, pos, id, count);
        }
        /// <summary>
        /// 拿掉物品
        /// </summary>
        /// <param name="pos">位置(0 背包)</param>
        /// <param name="id">物品标识</param>
        /// <param name="id">物品数量</param>
        /// <retuns>返回是否成功</retuns>
        public bool TakeItem(int pos, int id, int count)
        {
            return TakeItem(nativePtr, pos, id, count);
        }
        /// <summary>
        /// 查找物品
        /// </summary>
        /// <param name="pos">位置(0 背包)</param>
        /// <param name="id">物品标识</param>
        /// <param name="id">物品数量</param>
        /// <retuns>返回是否成功</retuns>
        public bool FindItem(int pos, int id, int count)
        {
            return FindItem(nativePtr, pos, id, count);
        }
        /// <summary>
        /// 强行退出游戏
        /// </summary>
        /// <param name="v">退出方式(0,1)</param>
        public void ForceLogout(LOGOUT_TYPE v)
        {
            ForceLogout(nativePtr, v);
        }
        public void SetFashionMode(int v)
        {
            SetFashionMode(nativePtr, v);
        }
        /// <summary>
        /// 地图跳转
        /// </summary>
        /// <param name="mapid">地图标识</param>
        /// <param name="x">坐标X</param>
        /// <param name="y">坐标Y</param>
        /// <param name="z">坐标Z</param>
        /// <param name="r">坐标随机范围</param>
        public void LongJump(int mapid, float x, float y, float z, float r)
        {
            LongJump(nativePtr, mapid, x, y, z, r);
        }
        /// <summary>
        /// 线路跳转
        /// </summary>
        /// <param name="lineid">线路标识</param>
        /// <param name="mapid">地图标识</param>
        /// <param name="x">坐标X</param>
        /// <param name="y">坐标Y</param>
        /// <param name="z">坐标Z</param>
        /// <param name="r">坐标随机范围</param>
        public void LineJump(int lineid, int mapid, float x, float y, float z, float r)
        {
            LineJump(nativePtr, lineid, mapid, x, y, z, r);
        }
        /// <summary>
        /// 发送聊天文字
        /// </summary>
        /// <param name="s">文字内容</param>
        public void Say(string s)
        {
            Say(nativePtr, s);
        }
        /// <summary>
        /// 发送文本信息
        /// </summary>
        /// <param name="s">信息内容</param>
        /// <param name="channel">频道类型（0普通，1世界，2组队，3帮派，4密语，9广播）</param>
        public void SingleCastMsg(string s, TCHAT_CHANNEL channel)
        {
            SingleCastMsg(nativePtr, s, channel);
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
        public void MobObject(int id, int count, int life)
        {
            MobObject(nativePtr, id, count, life);
        }
        public bool AddFilter(FILTER_TYPE id, FILTER_MASK mask, int bufid, int timeout, int var0, int var1, int var2, int var3, int var4, int var5)
        {
            return AddFilter(nativePtr, id, mask, bufid, timeout, var0, var1, var2, var3, var4, var5);
        }
        public bool ChkFilter(FILTER_TYPE id)
        {
            return ChkFilter(nativePtr, id);
        }
        public bool DelFilter(FILTER_TYPE id)
        {
            return DelFilter(nativePtr, id);
        }
        /// <summary>
        /// 设置NPC对话框文字
        /// </summary>
        /// <param name="desc">文字内容</param>
        public void SetScriptDescription(string desc)
        {
            SetScriptDescription(nativePtr, desc);
        }
        /// <summary>
        /// 设置NPC对话框选项(最多10个)
        /// </summary>
        /// <param name="desc">选项内容</param>
        /// <param name="func">调用函数</param>
        /// <param name="hint">提示内容</param>
        public void AddScriptOption(string option, string func, string hint)
        {
            AddScriptOption(nativePtr, option, func, hint);
        }
        /// <summary>
        /// 清空对话框数据(用于重设前把前面设置的清空)
        /// </summary>
        public void ClrScriptContent()
        {
            ClrScriptContent(nativePtr);
        }
        /// <summary>
        /// 向客户端广播PK级别
        /// </summary>
        public void SendPkLevelNotify(int level)
        {
            SendPkLevelNotify(nativePtr, level);
        }
    }
}
