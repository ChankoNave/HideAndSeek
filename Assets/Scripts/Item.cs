using UnityEngine;

public abstract class Item : MonoBehaviour
{
	public ItemInfo itemInfo;

	public GameObject itemGameObject;

	[SerializeField]
	private GameObject weaponThis;

	public bool pricelYes;

	public bool checkOnGun;

    public void OpenWeapon()
	{
		if (weaponThis != null)
              weaponThis.SetActive(true);
		checkOnGun = true;
		pricelYes = true;
		// Sound Plus Gun
	}

	public abstract void Use();

	public abstract void InstMines();

	public abstract void UsePricel();
}