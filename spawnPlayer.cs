using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FishNet.Connection;
using FishNet.Object;

public class spawnPlayer : NetworkBehaviour
{
    [SerializeField] private GameObject playerPrefab;

    public override void OnStartClient()
    {
        base.OnStartClient();

        PlayerSpawn();
    }

    [ServerRpc(RequireOwnership = false)]

    private void PlayerSpawn(NetworkConnection client = null)
    {
        GameObject go = Instantiate(playerPrefab);
        Spawn(go, client);
    }
}
