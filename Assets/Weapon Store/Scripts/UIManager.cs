using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GunStoreManager gunStore;

    [SerializeField] private int currentGunID = 0;
    [SerializeField] private TextMeshProUGUI gunNameText, fireRateText, damageText, totalcoinsTxt, purchaseStatusTxt, gunPriceTxt;
    [SerializeField] private Button purchaseBtn, equipBtn, upgradeDamageBtn, upgradeFireRateBtn;


    private void Start()
    {
        totalcoinsTxt.text = gunStore.totalCoins.ToString();
        DisplayGunInfo();

        gunStore.OnTotalCoinsUpdated += UpdateTotalCoinsText;
    }

    private void OnDisable()
    {
        gunStore.OnTotalCoinsUpdated -= UpdateTotalCoinsText;
    }

    private void UpdateTotalCoinsText()
    {
        totalcoinsTxt.text = gunStore.totalCoins.ToString();
    }

    public void DisplayGunInfo()
    {
        gunNameText.text = gunStore.gunData.gunDetails[currentGunID].gunName;
        gunPriceTxt.text = "Purchase Price: " + gunStore.gunData.gunDetails[currentGunID].price.ToString();
        fireRateText.text = Mathf.Round(gunStore.gunData.gunDetails[currentGunID].fireRate).ToString();

        damageText.text = gunStore.gunData.gunDetails[currentGunID].damage.ToString();

        bool purchaseStatus = gunStore.gunData.gunDetails[currentGunID].isPurchased;
        purchaseStatusTxt.text = purchaseStatus ? "Purchased" : "Not Purchased";
        purchaseBtn.gameObject.SetActive(!purchaseStatus);
        equipBtn.gameObject.SetActive(purchaseStatus);

        bool equipStatus = gunStore.gunData.gunDetails[currentGunID].isEquipped;
        equipBtn.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = equipStatus ? "Equipped" : "Equip";
        equipBtn.interactable = !equipStatus;

        bool damageStatus = gunStore.gunData.gunDetails[currentGunID].isMaxDamageLevel;
        upgradeDamageBtn.interactable = !damageStatus;
        upgradeDamageBtn.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = damageStatus ? "Full Upgraded" : "Upgrade";


        bool fireRateStatus = gunStore.gunData.gunDetails[currentGunID].isMaxFireRateLevel;
        upgradeFireRateBtn.interactable = !fireRateStatus;
        upgradeFireRateBtn.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = fireRateStatus ? "Full Upgraded" : "Upgrade";
    }

    public void RightArrow()
    {
        currentGunID++;
        if (currentGunID >= gunStore.gunData.gunDetails.Length)
        {
            currentGunID = 0;
        }
        DisplayGunInfo();
    }

    public void LeftArrow()
    {
        currentGunID--;
        if (currentGunID < 0)
        {
            currentGunID = gunStore.gunData.gunDetails.Length - 1;
        }
        DisplayGunInfo();
    }

    #region UI Buttons

    public void PurchaseGun()
    {
        gunStore.PurchaseGun(currentGunID);
        DisplayGunInfo();
    }

    public void EquipGun()
    {
        gunStore.EquipGun(currentGunID);
        DisplayGunInfo();
    }

    public void UpgradeDamage()
    {
        gunStore.UpgradeGunDamage(currentGunID);
        DisplayGunInfo();
    }

    public void UpgradeFireRate()
    {
        gunStore.UpgradeGunFireRate(currentGunID);
        DisplayGunInfo();
    }

    #endregion
}
