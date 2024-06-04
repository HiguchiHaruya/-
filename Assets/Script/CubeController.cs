using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    BlockManager bm = new BlockManager();
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (BlockManager.instance != null) { BlockManager.instance.AddScore(1); }
            else if (BlockManager.instance != null) { Debug.Log("‚Ê‚é‚Å‚·"); }
            Destroy(gameObject);
        }
    }
}
