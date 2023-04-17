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

    public UI u;

    private System.Random random;

    private void Start()
    {
        random = new System.Random();
        tagPool = new List<Tag>();
        //tagPool.Add(new AttackModuleTag());
        tagPool.Add(new AttackModuleTag());
        tagPool.Add(new AttributeEnhanceTag());
        tagPool.Add(new PowerOfLightning());
        //tagPool.Add(new UselessTag());
        tagPool.Add(new TwinFang());
        tagPool.Add(new ThreeRing());
        tagPool.Add(new FinalSpark());
        tagPool.Add(new Damnation());
        tagPool.Add(new BloodDrinker());

        GameObject w = GenerateWeapon(transform.position);
        u.updateUI(w.GetComponent<Weapon>());
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
            Tag t = randomTags[i];
            t.Apply(weapon);
            // Generate tags for the weapon
            weapon.AddTag(t);
        }

        return weaponInstance;
    }

    public List<Tag> GetRandomTag(int cnt)
    {
        List<Tag> ret = new List<Tag>();
        List<int> temp = new List<int>();
        for (int i = 0; i < cnt; i++)
        {
            int temp_num = UnityEngine.Random.Range(0, tagPool.Count);
            while (temp.Contains(temp_num))
            {
                temp_num = UnityEngine.Random.Range(0, tagPool.Count);
            }
            temp.Add(temp_num);
            Tag re = (Tag)DeepCopy(tagPool[temp_num]);

            
            ret.Add(re);
        }
        return ret;
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
