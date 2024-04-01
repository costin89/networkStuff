using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FishNet;

public class CSmanager : MonoBehaviour
{
    [SerializeField] private bool isServer;

    private void Awake()
    {
        if (isServer) InstanceFinder.ServerManager.StartConnection();
        else InstanceFinder.ClientManager.StartConnection();
    }
}
