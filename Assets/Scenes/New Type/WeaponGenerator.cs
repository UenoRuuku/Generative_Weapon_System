using System.Collections.Generic;
using UnityEngine;

public class WeaponGenerator : MonoBehaviour
{
    public List<GameObject> meleeWeaponPrefabs;
    public List<GameObject> rangedWeaponPrefabs;
    public GameObject tagPool;

    private System.Random random;

    private void Start()
    {
        random = new System.Random();
    }

    public GameObject GenerateWeapon(Vector3 position)
    {
        int weaponType = random.Next(0, 2); // 0 for melee, 1 for ranged
        GameObject weaponPrefab;

        if (weaponType == 0)
        {
            int index = random.Next(meleeWeaponPrefabs.Count);
            weaponPrefab = meleeWeaponPrefabs[index];
        }
        else
        {
            int index = random.Next(rangedWeaponPrefabs.Count);
            weaponPrefab = rangedWeaponPrefabs[index];
        }

        GameObject weaponInstance = Instantiate(weaponPrefab, position, Quaternion.identity);
        Weapon weapon = weaponInstance.GetComponent<Weapon>();

        int weaponRarity = random.Next(0, 4); // 0 for white, 1 for blue, 2 for purple, 3 for red
        weapon.SetRarity(weaponRarity);

        int tagCount = weaponRarity; // number of tags for the weapon
        for (int i = 0; i < tagCount; i++)
        {
            // Generate tags for the weapon
            Tag randomTag = tagPool.GetRandomTag();
            weapon.AddTag(randomTag);
        }

        return weaponInstance;
    }
}
