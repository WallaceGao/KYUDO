using UnityEngine;

public class StaticBatchOnStart : MonoBehaviour
{
    // Force Static Batching in case experience app gameobjects were inactive when call to StaticBatch (OnAwake) is called
    private void OnEnable()
    {
        StaticBatchingUtility.Combine(gameObject);

    }

}
