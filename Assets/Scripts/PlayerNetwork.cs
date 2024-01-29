using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class PlayerNetwork : NetworkBehaviour
{
    [SerializeField] private GameObject spawnedObjectPrefab;
    // Update is called once per frame
    private void Update()
    {
        if (!IsOwner) return;

        if (Input.GetKeyDown(KeyCode.W))
        {
            /*GameObject spawnedObjectTransform = Instantiate(spawnedObjectPrefab);
            spawnedObjectTransform.GetComponent<NetworkObject>().Spawn(true);
            spawnedObjectTransform.SetActive(true);*/
            spawnedObjectPrefab.SetActive(true);
            /*spawnedObjectPrefab.GetComponent<NetworkObject>().Spawn(true);*/
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            TestServerRpc(new ServerRpcParams());
        }

        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(pos.x, pos.y);
    }
    [ServerRpc]
    private void TestServerRpc(ServerRpcParams serverRpcParams)
    {
        Debug.Log("TestServerRpc " + OwnerClientId + "; " + serverRpcParams);
    }
}
