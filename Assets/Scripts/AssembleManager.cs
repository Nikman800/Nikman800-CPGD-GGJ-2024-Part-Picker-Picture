using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AssembleManager : MonoBehaviour
{
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
    // Start is called before the first frame update
    void Awake()
    {
        headImage = Resources.Load("drawing", typeof(Texture)) as Texture;
        torsoImage = Resources.Load("drawing", typeof(Texture)) as Texture;
        rightArmImage = Resources.Load("drawing", typeof(Texture)) as Texture;
        rightHandImage = Resources.Load("drawing", typeof(Texture)) as Texture;
        leftArmImage = Resources.Load("drawing", typeof(Texture)) as Texture;
        leftHandImage = Resources.Load("drawing", typeof(Texture)) as Texture;
        rightLegImage = Resources.Load("drawing", typeof(Texture)) as Texture;
        rightFootImage = Resources.Load("drawing", typeof(Texture)) as Texture;
        leftLegImage = Resources.Load("drawing", typeof(Texture)) as Texture;
        leftFootImage = Resources.Load("drawing", typeof(Texture)) as Texture;
    }

    // Update is called once per frame
    void FixedUpdate()
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
                leftFoot.texture = leftLegImage;
                displayed = true;
            }
            delay -= Time.deltaTime;
        }
    }
}
