using UnityEngine;

[System.Serializable]
public class PlayerReferences
{
    [SerializeField]
    private GameObject[] _weaponObjects;
    public GameObject[] WeaponObjects
    {
        get => _weaponObjects;
        set => _weaponObjects = value;
    }

    [SerializeField]
    private Transform _gunBarrel;
    public Transform GunBarrel
    {
        get => _gunBarrel;
        private set => _gunBarrel = value;
    }
    
    [SerializeField]
    private GameObject _projectilePrefab;
    public GameObject ProjectilePrefab
    {
        get => _projectilePrefab;
        private set => _projectilePrefab = value;
    }
}
