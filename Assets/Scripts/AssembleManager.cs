//using System.Collections;
//using System.Collections.Generic;
//using Unity.VisualScripting;
//using UnityEditor.SearchService;
//using UnityEngine;
//using UnityEngine.SceneManagement;
//using UnityEngine.UI;

//public class AssembleManager : MonoBehaviour
//{
//    [SerializeField] private Button btn;
//    private Texture headImage;
//    private Texture torsoImage;
//    private Texture rightArmImage;
//    private Texture rightHandImage;
//    private Texture leftArmImage;
//    private Texture leftHandImage;
//    private Texture rightLegImage;
//    private Texture rightFootImage;
//    private Texture leftLegImage;
//    private Texture leftFootImage;
//    [SerializeField] private RawImage head;
//    [SerializeField] private RawImage torso;
//    [SerializeField] private RawImage rightArm;
//    [SerializeField] private RawImage rightHand;
//    [SerializeField] private RawImage leftArm;
//    [SerializeField] private RawImage leftHand;
//    [SerializeField] private RawImage rightLeg;
//    [SerializeField] private RawImage rightFoot;
//    [SerializeField] private RawImage leftLeg;
//    [SerializeField] private RawImage leftFoot;
//    private float delay = 3f;
//    private bool displayed = false;
//    private bool retBtn = true;
//    // Start is called before the first frame update
//    void Awake()
//    {
//        btn.onClick.AddListener(() =>
//        {
//            SceneManager.LoadScene(0);
//        });
//        btn.gameObject.SetActive(false);

//        headImage = Resources.Load("HeadDraw", typeof(Texture)) as Texture;
//        torsoImage = Resources.Load("TorsoDraw", typeof(Texture)) as Texture;
//        rightArmImage = Resources.Load("RightArmDraw", typeof(Texture)) as Texture;
//        rightHandImage = Resources.Load("RightHandDraw", typeof(Texture)) as Texture;
//        leftArmImage = Resources.Load("LeftArmDraw", typeof(Texture)) as Texture;
//        leftHandImage = Resources.Load("LeftHandDraw", typeof(Texture)) as Texture;
//        rightLegImage = Resources.Load("RightLegDraw", typeof(Texture)) as Texture;
//        rightFootImage = Resources.Load("RightFootDraw", typeof(Texture)) as Texture;
//        leftLegImage = Resources.Load("LeftLegDraw", typeof(Texture)) as Texture;
//        leftFootImage = Resources.Load("LeftFootDraw", typeof(Texture)) as Texture;
//    }


//    // Update is called once per frame
//    void FixedUpdate()
//    {
//       if (!displayed)
//        {
//            if (delay < 0)
//            {
//                head.texture = headImage;
//                torso.texture = torsoImage;
//                rightArm.texture = rightArmImage;
//                rightHand.texture = rightHandImage;
//                leftArm.texture = leftArmImage;
//                leftHand.texture = leftHandImage;
//                rightLeg.texture = rightLegImage;
//                rightFoot.texture = rightFootImage;
//                leftLeg.texture = leftLegImage;
//                leftFoot.texture = leftFootImage;
//                displayed = true;
//                delay = 3f;
//            }
//            delay -= Time.deltaTime;
//        }
//        else
//        {
//            if (delay < 0 && retBtn)
//            {
//                btn.gameObject.SetActive(true);
//                retBtn = false;
//            }
//            delay -= Time.deltaTime;
//        }
//    }
//}

using System.Collections;
using System.Diagnostics;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class AssembleManager : MonoBehaviour
{
    [SerializeField] private Button btn;
    private Texture headImage;
    private Texture torsoImage;
    private Texture rightArmImage;
    private Texture rightHandImage;
    private Texture leftArmImage;
    private Texture leftHandImage;
    private Texture rightLegImage;
    private Texture rightFootImage;
    private Texture leftLegImage;
    private Texture leftFootImage;

    [SerializeField] private RawImage head;
    [SerializeField] private RawImage torso;
    [SerializeField] private RawImage rightArm;
    [SerializeField] private RawImage rightHand;
    [SerializeField] private RawImage leftArm;
    [SerializeField] private RawImage leftHand;
    [SerializeField] private RawImage rightLeg;
    [SerializeField] private RawImage rightFoot;
    [SerializeField] private RawImage leftLeg;
    [SerializeField] private RawImage leftFoot;

    private float delay = 3f;
    private bool displayed = false;
    private bool retBtn = true;

    private IEnumerator Start()
    {
        btn.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(0);
        });
        btn.gameObject.SetActive(false);

        // Load images using StreamingAssets
        yield return LoadImageAsync("HeadDraw", texture => headImage = texture);
        yield return LoadImageAsync("TorsoDraw", texture => torsoImage = texture);
        yield return LoadImageAsync("RightArmDraw", texture => rightArmImage = texture);
        yield return LoadImageAsync("RightHandDraw", texture => rightHandImage = texture);
        yield return LoadImageAsync("LeftArmDraw", texture => leftArmImage = texture);
        yield return LoadImageAsync("LeftHandDraw", texture => leftHandImage = texture);
        yield return LoadImageAsync("RightLegDraw", texture => rightLegImage = texture);
        yield return LoadImageAsync("RightFootDraw", texture => rightFootImage = texture);
        yield return LoadImageAsync("LeftLegDraw", texture => leftLegImage = texture);
        yield return LoadImageAsync("LeftFootDraw", texture => leftFootImage = texture);

        // Images are loaded, proceed with your logic
    }

    private IEnumerator LoadImageAsync(string imageName, System.Action<Texture> callback)
    {
        string path = Path.Combine(UnityEngine.Application.streamingAssetsPath, imageName + ".png");

        // Use UnityWebRequestTexture to load the image asynchronously
        using (var request = UnityEngine.Networking.UnityWebRequestTexture.GetTexture("file://" + path))
        {
            yield return request.SendWebRequest();

            if (request.result == UnityEngine.Networking.UnityWebRequest.Result.Success)
            {
                Texture2D texture = ((UnityEngine.Networking.DownloadHandlerTexture)request.downloadHandler).texture;
                callback?.Invoke(texture);
            }
            else
            {
                UnityEngine.Debug.LogError("Failed to load image " + imageName + ": " + request.error);
            }
        }
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (!displayed)
        {
            if (delay < 0)
            {
                head.texture = headImage;
                torso.texture = torsoImage;
                rightArm.texture = rightArmImage;
                rightHand.texture = rightHandImage;
                leftArm.texture = leftArmImage;
                leftHand.texture = leftHandImage;
                rightLeg.texture = rightLegImage;
                rightFoot.texture = rightFootImage;
                leftLeg.texture = leftLegImage;
                leftFoot.texture = leftFootImage;
                displayed = true;
                delay = 3f;
            }
            delay -= Time.deltaTime;
        }
        else
        {
            if (delay < 0 && retBtn)
            {
                btn.gameObject.SetActive(true);
                retBtn = false;
            }
            delay -= Time.deltaTime;
        }
    }
}

