using UnityEngine;
using UnityEngine.UI;

public class PlayerInteraction : MonoBehaviour
{
    public GameObject WeaponPanel; 
    public bool Box_Open = false;

    void Update()
    {
        

        if (Input.GetKey(KeyCode.E))
        {
            if (Box_Open)
            {
                WeaponPanel.SetActive(false);

            }
            else
            {
                WeaponPanel.SetActive(true);

            }
        }
    }
}
