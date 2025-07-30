using UnityEngine;
using System;

[CreateAssetMenu(fileName = "GunData", menuName = "GunStore")]

public class GunData : ScriptableObject
{
    public GunDetails[] gunDetails;

    [Serializable]
    public struct GunDetails
    {
        public string gunName;
        public int gunId;
        public int damage;
        public int price;
        public float fireRate;
        public bool isPurchased, isEquipped, isMaxDamageLevel, isMaxFireRateLevel;


        public Upgrades[] damageUpgrades;
        public Upgrades[] fireRateUpgrades;

        public int damageLevel;
        public int fireRateLevel;
    }


    [Serializable]
    public class Upgrades
    {
        public string name;
        public float value;
        public int price;
    }
}
