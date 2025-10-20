using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Chest : MonoBehaviour, IDamageable
{
    public void Hurt(int dmg)
    {
        Open();
    }

    public void Open()
    {
        Debug.Log("Has trobat un tresor");
    }

    void Start()
    {

    }

    void Update()
    {

    }
}
