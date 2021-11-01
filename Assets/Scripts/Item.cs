using UnityEngine;

public abstract class Item : MonoBehaviour
{
	internal ItemInfo itemInfo;

	public GameObject itemGameObject;

	[SerializeField]
	private GameObject weaponThis;

	internal bool pricelYes;

	internal bool checkOnGun;

    public void OpenWeapon()
	{
		if (weaponThis != null)
              weaponThis.SetActive(true);

		checkOnGun = true;
		pricelYes = true;
		// add Sound Plus Gun
	}

	public abstract void Use();

	public abstract void InstMines();

	public abstract void UsePricel();
}