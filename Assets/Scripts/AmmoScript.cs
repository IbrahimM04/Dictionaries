using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoScript : MonoBehaviour
{
    Dictionary<string, int> ammo = new Dictionary<string, int>();
    int ammoAmmount;
    string currentWeapon;

    // Start is called before the first frame update
    void Start() {               
        ammo.Add("Shotgun", 8);
        ammo.Add("AK47", 32);
        ammo.Add("Pistol", 16);
        currentWeapon = EnumScript.Weapons.Shotgun.ToString();
        ammoAmmount = ammo[currentWeapon];
        if (currentWeapon != "Hands"){
            print("Current weapon: " + currentWeapon + " \nAmmount of ammo: " + ammoAmmount);
        }

    }

    // Update is called once per frame
    void Update(){
        if (Input.GetKeyDown("space")) {
            if (ammoAmmount <= 0) {
                print("You have no ammo for this gun!");
                    
            } else {
                ammoAmmount--;
                print("Current weapon: " + currentWeapon + " \nAmmount of ammo: " + ammoAmmount);
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            if (currentWeapon != EnumScript.Weapons.Shotgun.ToString()) {
                currentWeapon = EnumScript.Weapons.Shotgun.ToString();
                ammoAmmount = ammo[currentWeapon];
                print("Switched to " + currentWeapon + " With " + ammoAmmount + " ammo!");                    
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha2)) {
            if (currentWeapon != EnumScript.Weapons.AK47.ToString()) {
                currentWeapon = EnumScript.Weapons.AK47.ToString();
                ammoAmmount = ammo[currentWeapon];
                print("Switched to " + currentWeapon + " With " + ammoAmmount + " ammo!");
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha3)) {
            if (currentWeapon != EnumScript.Weapons.Pistol.ToString()) {
                currentWeapon = EnumScript.Weapons.Pistol.ToString();
                ammoAmmount = ammo[currentWeapon];
                print("Switched to " + currentWeapon + " With " + ammoAmmount + " ammo!");
            }
        }        
    }
}
