using UnityEngine;

public class Character : MonoBehaviour, IDamageable
{
    protected int HP;
    public void Hurt(int dmg)
    {
        Debug.Log("AY");
        HP--;
    }
}
