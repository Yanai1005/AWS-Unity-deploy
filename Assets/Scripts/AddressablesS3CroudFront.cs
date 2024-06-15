using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;
using System.Threading.Tasks;

public class AddressablesS3CroudFront : MonoBehaviour
{
    [SerializeField] private RawImage m_RawImage;

    // Start is called before the first frame update
    async void Start()
    {
        if (m_RawImage == null)
        {
            Debug.LogError("m_RawImage is not assigned in the Inspector");
            return;
        }

        try
        {
            var tex2D = await Addressables.LoadAssetAsync<Texture2D>("Assets/Scenes/AddressablesS3CroudFront/cat.png").Task;
            if (tex2D == null)
            {
                Debug.LogError("Failed to load texture");
            }
            else
            {
                m_RawImage.texture = tex2D;
            }
        }
        catch (System.Exception e)
        {
            Debug.LogError($"Exception encountered: {e.Message}");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
