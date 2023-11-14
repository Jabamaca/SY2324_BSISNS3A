using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetController : MonoBehaviour {

    [SerializeField]
    private BulletController Bullet;

    private List<BulletController> _PoolableBullets = new List<BulletController> ();
    private List<BulletController> _InactiveBullets = new List<BulletController> ();

    private void Update () {
        if (Input.GetKey ("1")) {
            FireBullet ();
        }
    }

    private void OnDestroy () {
        foreach (BulletController bullet in _PoolableBullets) {
            bullet.OnPool -= PoolBullet;
        }
    }

    private void FireBullet () {
        BulletController bullet = UnpoolBullet ();
        bullet.transform.position = transform.position;
        bullet.gameObject.SetActive (true);
    }

    private BulletController UnpoolBullet () {
        BulletController bullet;

        if (_InactiveBullets.Count > 0) {
            bullet = _InactiveBullets[0];
            _InactiveBullets.RemoveAt (0);
            bullet.ResetObject ();
        } else {
            bullet = Instantiate<BulletController> (Bullet);
            _PoolableBullets.Add (bullet);
            bullet.OnPool += PoolBullet;
        }

        return bullet;
    }

    private void PoolBullet (BulletController bullet) {
        _InactiveBullets.Add (bullet);
        bullet.gameObject.SetActive (false);
    }

}
