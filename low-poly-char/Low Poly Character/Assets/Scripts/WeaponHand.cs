using UnityEngine;

public class WeaponHand : MonoBehaviour
{
    [SerializeField] GameObject[] weaponPrefabs;

    private int _currentIndex;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            SwapWeapon();
        }
    }

    void SwapWeapon()
    {
        _currentIndex++;
        if (_currentIndex >= weaponPrefabs.Length)
        {
            _currentIndex = 0;
        }

        Transform heldWeapon = transform.Find("Weapon");
        if (heldWeapon)
        {
            Destroy(heldWeapon.gameObject);
        }

        GameObject goSwap =
            Instantiate(weaponPrefabs[_currentIndex], transform.position, Quaternion.identity, transform) as GameObject;
        goSwap.name = "Weapon";
        goSwap.transform.position = transform.position;
        goSwap.transform.rotation = transform.rotation;
    }
}