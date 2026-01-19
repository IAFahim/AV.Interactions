using UnityEngine;

[HelpURL("https://github.com/IAFahim/AV.Interactions")]
[AddComponentMenu("AV/Interactions/OnTriggerEnterMono")]

namespace AV.Interactions.Runtime
{
    public class OnTriggerEnterMono : MonoBehaviour
    {
        [SerializeField] private GameObject currentEntity;
        [SerializeField] private bool isInstantiate;

        private void OnTriggerEnter(Collider other)
        {
            if (isInstantiate)
                Instantiate(currentEntity);
            else
                currentEntity.SetActive(true);
        }
    }
}