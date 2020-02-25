using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

public GameObject shop;
public GameObject rocket;
public GameObject shopBullet;
public GameObject resetDummy;

public GameObject comet1, comet2, comet3, comet4, comet5;

public float bulletSpeed;

private ShopBullet shopBulletScript;

private bool liftOff = false;
private bool bulletFired = false;

    void Start()
    {
        shopBulletScript = shopBullet.GetComponent<ShopBullet>();
    }

    void Update()
    {

        if (!resetDummy.activeSelf) {
            Reset();
        }

        if (!liftOff && resetDummy.activeSelf) {
            CheckLiftOff();
        }

        if (liftOff && shopBulletScript.currentTier >= 1) {
            CheckFire();
        }

        if (liftOff && shopBulletScript.currentTier >= 1 && transform.position.y < 12) {
            CheckCollide();
        }

        if (bulletFired) {
            MoveBullet();
        }

        if (shop.transform.position.y == 24 || shopBulletScript.currentTier == 0) {
            GetComponent<Renderer>().enabled = false;
        }
    }

    private void CheckLiftOff() {
        if (Input.GetKeyDown("space")) {
            liftOff = true;
        }
    }

    private void CheckFire() {
        if (Input.GetKeyDown("space") && !bulletFired) {
            FireBullet();
        }
    }

    private void FireBullet() {
        bulletFired = true;
        transform.position = new Vector2(rocket.transform.position.x, -6.4f);
        GetComponent<Renderer>().enabled = true;
    }

    private void Reset() {
        liftOff = false;
        bulletFired = false;
    }

    private void MoveBullet() {
        if (transform.position.y < 15) {
            transform.position = new Vector2(transform.position.x, transform.position.y + bulletSpeed);
        } else {
            bulletFired = false;
        }
    }

    private void CheckCollide() {
        if (Mathf.Round(transform.position.x) == Mathf.Round(comet1.transform.position.x) && transform.position.y >= comet1.transform.position.y - 1f && transform.position.y < comet1.transform.position.y) {
            BulletHit(comet1);
        }
        if (Mathf.Round(transform.position.x) == Mathf.Round(comet2.transform.position.x) && transform.position.y >= comet2.transform.position.y - 1f && transform.position.y < comet2.transform.position.y) {
            BulletHit(comet2);
        }
        if (Mathf.Round(transform.position.x) == Mathf.Round(comet3.transform.position.x) && transform.position.y >= comet3.transform.position.y - 1f && transform.position.y < comet3.transform.position.y) {
            BulletHit(comet3);
        }
        if (Mathf.Round(transform.position.x) == Mathf.Round(comet4.transform.position.x) && transform.position.y >= comet4.transform.position.y - 1f && transform.position.y < comet4.transform.position.y) {
            BulletHit(comet4);
        }
        if (Mathf.Round(transform.position.x) == Mathf.Round(comet5.transform.position.x) && transform.position.y >= comet5.transform.position.y - 1f && transform.position.y < comet5.transform.position.y) {
            BulletHit(comet5);
        }
    }

    private void BulletHit(GameObject comet) {
        Debug.Log("hit");
        comet.GetComponent<Renderer>().enabled = false;
        GetComponent<Renderer>().enabled = false;
        bulletFired = false;

    }
}
