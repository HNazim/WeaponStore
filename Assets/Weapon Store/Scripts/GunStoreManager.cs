using UnityEngine;
using System;

public class GunStoreManager : MonoBehaviour
{
    [Header("This is scriptable object")]
    public GunData gunData;
    public int totalCoins;
    public event Action OnTotalCoinsUpdated;


    public void PurchaseGun(int gunId)
    {
        if (gunId >= 0 && gunId < gunData.gunDetails.Length && totalCoins > 0)
        {
            gunData.gunDetails[gunId].isPurchased = true;
            totalCoins -= gunData.gunDetails[gunId].price;
            OnTotalCoinsUpdated?.Invoke();
        }
        else
        {
            Debug.LogWarning("Don't have coins");
        }
    }

    public void EquipGun(int gunId)
    {
        if (gunId >= 0 && gunId < gunData.gunDetails.Length)
        {
            for (int i = 0; i < gunData.gunDetails.Length; i++)
            {
                gunData.gunDetails[i].isEquipped = false;
            }

            gunData.gunDetails[gunId].isEquipped = true;
        }
        else
        {
            Debug.LogError("Invalid gunId in EquipGun");
        }
    }

    public void UpgradeGunDamage(int gunId)
    {
        if (gunId >= 0 && gunId < gunData.gunDetails.Length && totalCoins > 0)
        {
            GunData.Upgrades[] damageUpgradesArray = gunData.gunDetails[gunId].damageUpgrades;
            if (damageUpgradesArray.Length > gunData.gunDetails[gunId].damageLevel)
            {
                gunData.gunDetails[gunId].damage += (int) damageUpgradesArray[gunData.gunDetails[gunId].damageLevel].value;
                gunData.gunDetails[gunId].damageLevel++;

                totalCoins -= damageUpgradesArray[gunData.gunDetails[gunId].damageLevel - 1].price;
                OnTotalCoinsUpdated?.Invoke();
            }
            else
            {
                gunData.gunDetails[gunId].isMaxDamageLevel = true;
                Debug.LogWarning("You have reached the maximum damage level for this gun.");
            }
        }
        else
        {
            Debug.LogWarning("You don't have enough coins to upgrade the gun's damage.");
        }


    }

    public void UpgradeGunFireRate(int gunId)
    {
        if (gunId >= 0 && gunId < gunData.gunDetails.Length && totalCoins > 0)
        {
            GunData.Upgrades[] fireRateUpgradesArray = gunData.gunDetails[gunId].fireRateUpgrades;
            if (fireRateUpgradesArray.Length > gunData.gunDetails[gunId].fireRateLevel)
            {
                gunData.gunDetails[gunId].fireRate += (int)fireRateUpgradesArray[gunData.gunDetails[gunId].fireRateLevel].value;
                gunData.gunDetails[gunId].fireRateLevel++;

                totalCoins -= fireRateUpgradesArray[gunData.gunDetails[gunId].fireRateLevel - 1].price;
                OnTotalCoinsUpdated?.Invoke();
            }
            else
            {
                gunData.gunDetails[gunId].isMaxFireRateLevel = true;
                Debug.LogWarning("You have reached the maximum FireRate level for this gun.");
            }
        }
        else
        {
            Debug.LogWarning("You don't have enough coins to upgrade the gun's fire rate.");
        }
    }
}
