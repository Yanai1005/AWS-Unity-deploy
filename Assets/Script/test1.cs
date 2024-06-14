using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class test1 : MonoBehaviour
{
    // Start is called before the first frame update
    async void Start()
    {
        var prefab = await Addressables.LoadAssetAsync<GameObject>("universal / Runtime / Materials / Lit.mat.universal / Runtime / Materials / Lit.mat").Task;
        Instantiate(prefab, new Vector3(0.0f, 0.0f, -8.0f), Quaternion.Euler(0f, 180f, 0f));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
