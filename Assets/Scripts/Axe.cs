using UnityEngine;

public class Axe : MonoBehaviour
{
    private int _damage;
    private bool _canAttack = true;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.TryGetComponent<IDamageable>(out IDamageable iDmg) && _canAttack)
        {
            iDmg.Hurt(_damage);
            _canAttack = false;
            Invoke("CanAttackAgain", 2f);
        }
    }

    public void CanAttackAgain()
    {
        _canAttack = true;
    }
}
