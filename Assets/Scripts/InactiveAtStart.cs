using UnityEngine;

public class InactiveAtStart : MonoBehaviour
{
    [SerializeField]
    bool isInactiveAtStart = false;
    // Start is called before the first frame update
    void Awake()
    {
        if (isInactiveAtStart)
        {
            gameObject.SetActive(false);
        }
    }

}
