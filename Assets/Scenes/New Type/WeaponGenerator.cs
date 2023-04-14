using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

public class WeaponGenerator : MonoBehaviour
{
    public List<GameObject> meleeWeaponPrefabs;
    public List<GameObject> rangedWeaponPrefabs;
    public List<Tag> tagPool;

    private System.Random random;

    private void Start()
    {
        random = new System.Random();
        tagPool = new List<Tag>();
        tagPool.Add(new AttackModuleTag());
        tagPool.Add(new AttackModuleTag());
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
        List<Tag> randomTags = GetRandomTag(tagCount);

        for (int i = 0; i < tagCount; i++)
        {
            // Generate tags for the weapon
            weapon.AddTag(randomTags[i]);
        }

        return weaponInstance;
    }

    public List<Tag> GetRandomTag(int cnt)
    {
        List<Tag> ret = new List<Tag>();
        for (int i = 0; i < cnt; i++)
        {
            Tag re = (Tag)DeepCopy(tagPool[UnityEngine.Random.Range(0, tagPool.Count)]);
            ret.Add(re);
        }
        return null;
    }

    public static object DeepCopy(object _object)
    {
        Type T = _object.GetType();
        object o = Activator.CreateInstance(T);
        PropertyInfo[] PI = T.GetProperties();
        for (int i = 0; i < PI.Length; i++)
        {
            PropertyInfo P = PI[i];
            P.SetValue(o, P.GetValue(_object));
        }
        return o;
    }
}
