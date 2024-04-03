using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    PlayerManager playerManager;
    public bool hitattack = false;

    [SerializeField] GameObject weaponLink;
    [SerializeField] GameObject unarmedLink;

    private void Awake()
    {
        playerManager = GetComponent<PlayerManager>();
        weaponLink.SetActive(false);
    }
    private void Update()
    {
        if (playerManager.characterDead == false)
        {
            attack();
        }
    }
    void attack()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            playerManager.playerAnimation.animatorLink.SetTrigger("attack");
            hitattack = true;
        }
        if (Input.GetButtonUp("Fire1"))
        {
            playerManager.playerAnimation.animatorLink.ResetTrigger("attack");
            hitattack = false;
        }
        if (Input.GetKeyDown("1"))
        {
            playerManager.playerAnimation.animatorLink.SetInteger("weapon", 1);
            weaponLink.SetActive(false);
            unarmedLink.SetActive(true);
        }
        if (Input.GetKeyDown("2"))
        {
            playerManager.playerAnimation.animatorLink.SetInteger("weapon", 2);
            weaponLink.SetActive(true);
            unarmedLink.SetActive(false);
        }
    }
}

