using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MaleKnightCustomiser : MonoBehaviour
{
    public MaleKnightSO MaleKnightSO;

    public Material raceMaterial;

    public SkinnedMeshRenderer Skins;
    public SkinnedMeshRenderer HeadArmors;
    public SkinnedMeshRenderer Eyebrows;
    public SkinnedMeshRenderer FacialHairs;
    public SkinnedMeshRenderer Torsos;
    public SkinnedMeshRenderer ArmUpperRights;
    public SkinnedMeshRenderer ArmUpperLefts;
    public SkinnedMeshRenderer ArmLowerRights;
    public SkinnedMeshRenderer ArmLowerLefts;
    public SkinnedMeshRenderer RightHands;
    public SkinnedMeshRenderer LeftHands;
    public SkinnedMeshRenderer Hips;
    public SkinnedMeshRenderer RightLegs;
    public SkinnedMeshRenderer LeftLegs;
    public SkinnedMeshRenderer Hairs;
    public SkinnedMeshRenderer HelmetAttachments;
    public SkinnedMeshRenderer BackAttachments;
    public SkinnedMeshRenderer RightShoulderAttachments;
    public SkinnedMeshRenderer LeftShoulderAttachments;
    public SkinnedMeshRenderer RightElbowAttachments;
    public SkinnedMeshRenderer LeftElbowAttachments;
    public SkinnedMeshRenderer RightKneeAttachments;
    public SkinnedMeshRenderer LeftKneeAttachments;

    public TMP_Text HeadText;
    public TMP_Text EyebrowText;
    public TMP_Text FacialHairText;
    public TMP_Text HeadArmorText;
    public TMP_Text TorsoText;
    public TMP_Text UpperArmText;
    public TMP_Text LowerArmText;
    public TMP_Text HandText;
    public TMP_Text HipText;
    public TMP_Text LegText;
    //public TMP_Text HairText;

    private int headIndex;
    private int eyebrowIndex;
    private int facialHairIndex;
    private int headArmorIndex;
    private int torsoIndex;
    private int upperArmIndex;
    private int lowerArmIndex;
    private int handIndex;
    private int hipIndex;
    private int legIndex;
    private int hairIndex;

    private void Start()
    {
        headIndex = 0;
        eyebrowIndex = 0;
        facialHairIndex = 0;
        headArmorIndex = 0;
        torsoIndex = 0;
        upperArmIndex = 0;
        lowerArmIndex = 0;
        handIndex = 0;
        hipIndex = 0;
        legIndex = 0;
        hairIndex = 0;


        HeadText.text = "Head " + (headIndex + 1);
        EyebrowText.text = "Eyebrows " + (eyebrowIndex + 1);
        FacialHairText.text = "Facial Hair " + (facialHairIndex + 1);
        HeadArmorText.text = "Head Armor " + (headArmorIndex + 1);
        TorsoText.text = "Torso " + (torsoIndex + 1);
        UpperArmText.text = "Upper Arm " + (upperArmIndex + 1);
        LowerArmText.text = "Lower Arm " + (lowerArmIndex + 1);
        HandText.text = "Hand " + (handIndex + 1);
        HipText.text = "Hip " + (hipIndex + 1);
        LegText.text = "Leg " + (legIndex + 1);
        //HairText.text = "Hair " + (hairIndex + 1);
    }

    public void HeadSelectionRight()
    {
        if(headArmorIndex == 0)
        {
            if (headIndex != MaleKnightSO.SkinMesh.Length - 1)
            {
                headIndex++;
            }
            else
            {
                headIndex = 0;
            }
            Skins.sharedMesh = MaleKnightSO.SkinMesh[headIndex];
            Skins.sharedMaterial = raceMaterial;
            HeadText.text = "Head " + (headIndex + 1);
        }
 
    }

    public void HeadSelectionLeft()
    {
        if (headArmorIndex == 0)
        {
            if (headIndex != 0)
            {
                headIndex--;
            }
            else
            {
                headIndex = MaleKnightSO.SkinMesh.Length - 1;
            }

            Skins.sharedMesh = MaleKnightSO.SkinMesh[headIndex];
            Skins.sharedMaterial = raceMaterial;
            HeadText.text = "Head " + (headIndex + 1);
        }
    }

    public void EyebrowSelectionRight()
    {
        if (headArmorIndex == 0)
        {
            if (eyebrowIndex != MaleKnightSO.EyebrowsMesh.Length - 1)
            {
                eyebrowIndex++;
            }
            else
            {
                eyebrowIndex = 0;
            }
            Eyebrows.sharedMesh = MaleKnightSO.EyebrowsMesh[eyebrowIndex];
            Eyebrows.sharedMaterial = raceMaterial;
            EyebrowText.text = "Eyebrows " + (eyebrowIndex + 1);
        }
    }
    public void EyebrowSelectionLeft()
    {
        if (headArmorIndex == 0)
        {
            if (eyebrowIndex != 0)
            {
                eyebrowIndex--;
            }
            else
            {
                eyebrowIndex = MaleKnightSO.EyebrowsMesh.Length - 1;
            }

            Eyebrows.sharedMesh = MaleKnightSO.EyebrowsMesh[eyebrowIndex];
            Eyebrows.sharedMaterial = raceMaterial;
            EyebrowText.text = "Eyebrows " + (eyebrowIndex + 1);
        }
    }

    public void FacialHairSelectionRight() 
    {
        if (headArmorIndex == 0)
        {
            if (facialHairIndex != MaleKnightSO.FacialHairMesh.Length - 1)
            {
                facialHairIndex++;
            }
            else
            {
                facialHairIndex = 0;
            }
            FacialHairs.sharedMesh = MaleKnightSO.FacialHairMesh[facialHairIndex];
            FacialHairs.sharedMaterial = raceMaterial;
            FacialHairText.text = "Facial Hair " + (facialHairIndex + 1);
        }
    }
    public void FacialHairSelectionLeft() 
    {
        if (headArmorIndex == 0)
        {
            if (facialHairIndex != 0)
            {
                facialHairIndex--;
            }
            else
            {
                facialHairIndex = MaleKnightSO.FacialHairMesh.Length - 1;
            }

            FacialHairs.sharedMesh = MaleKnightSO.FacialHairMesh[facialHairIndex];
            FacialHairs.sharedMaterial = raceMaterial;
            FacialHairText.text = "Facial Hair " + (facialHairIndex + 1);
        }
    }


    public void HeadArmorSelectionRight()
    {
        if (headArmorIndex != MaleKnightSO.HeadArmorMesh.Length - 1)
        {
            headArmorIndex++;
        }
        else
        {
            headArmorIndex = 0;
        }
        HeadArmors.sharedMesh = MaleKnightSO.HeadArmorMesh[headArmorIndex];
        HeadArmors.sharedMaterial = raceMaterial;
        HeadArmorText.text = "Head Armor " + (headArmorIndex + 1);

        if (headArmorIndex != 0)
        {
            Skins.sharedMesh = null;
            Eyebrows.sharedMesh = MaleKnightSO.EyebrowsMesh[0];
            FacialHairs.sharedMesh = MaleKnightSO.FacialHairMesh[0];
        }
        else
        {
            Skins.sharedMesh = MaleKnightSO.SkinMesh[headIndex];
            Eyebrows.sharedMesh = MaleKnightSO.EyebrowsMesh[eyebrowIndex];
            FacialHairs.sharedMesh = MaleKnightSO.FacialHairMesh[facialHairIndex];
        }
    }
    public void HeadArmorSelectionLeft()
    {
        if (headArmorIndex != 0)
        {
            headArmorIndex--;
        }
        else
        {
            headArmorIndex = MaleKnightSO.HeadArmorMesh.Length - 1;
        }

        HeadArmors.sharedMesh = MaleKnightSO.HeadArmorMesh[headArmorIndex];
        HeadArmors.sharedMaterial = raceMaterial;
        HeadArmorText.text = "Head Armor " + (headArmorIndex + 1);

        if (headArmorIndex != 0)
        {
            Skins.sharedMesh = null;
            Eyebrows.sharedMesh = MaleKnightSO.EyebrowsMesh[0]; ;
            FacialHairs.sharedMesh = MaleKnightSO.FacialHairMesh[0];
        }
        else
        {
            Skins.sharedMesh = MaleKnightSO.SkinMesh[headIndex];
            Eyebrows.sharedMesh = MaleKnightSO.EyebrowsMesh[eyebrowIndex];
            FacialHairs.sharedMesh = MaleKnightSO.FacialHairMesh[facialHairIndex];
        }
    }
    public void TorsoSelectionRight()
    {
        if (torsoIndex != MaleKnightSO.TorsoMesh.Length - 1)
        {
            torsoIndex++;
        }
        else
        {
            torsoIndex = 0;
        }
        Torsos.sharedMesh = MaleKnightSO.TorsoMesh[torsoIndex];
        Torsos.sharedMaterial = raceMaterial;
        TorsoText.text = "Torso " + (torsoIndex + 1);
    }
    public void TorsoSelectionLeft()
    {
        if (torsoIndex != 0)
        {
            torsoIndex--;
        }
        else
        {
            torsoIndex = MaleKnightSO.TorsoMesh.Length - 1;
        }

        Torsos.sharedMesh = MaleKnightSO.TorsoMesh[torsoIndex];
        Torsos.sharedMaterial = raceMaterial;
        TorsoText.text = "Torso " + (torsoIndex + 1);
    }
    public void UpperArmSelectionRight() 
    {
        if (upperArmIndex != MaleKnightSO.ArmUpperRightMesh.Length - 1)
        {
            upperArmIndex++;
        }
        else
        {
            upperArmIndex = 0;
        }

        ArmUpperRights.sharedMesh = MaleKnightSO.ArmUpperRightMesh[upperArmIndex];
        ArmUpperLefts.sharedMesh = MaleKnightSO.ArmUpperLeftMesh[upperArmIndex];
        ArmUpperRights.sharedMaterial = raceMaterial;
        ArmUpperLefts.sharedMaterial = raceMaterial;
        UpperArmText.text = "Upper Arm " + (upperArmIndex + 1);
    }
    public void UpperArmSelectionLeft() 
    {
        if (upperArmIndex != 0)
        {
            upperArmIndex--;
        }
        else
        {
            upperArmIndex = MaleKnightSO.ArmUpperRightMesh.Length - 1;
        }

        ArmUpperRights.sharedMesh = MaleKnightSO.ArmUpperRightMesh[upperArmIndex];
        ArmUpperLefts.sharedMesh = MaleKnightSO.ArmUpperLeftMesh[upperArmIndex];
        ArmUpperRights.sharedMaterial = raceMaterial;
        ArmUpperLefts.sharedMaterial = raceMaterial;
        UpperArmText.text = "Upper Arm " + (upperArmIndex + 1);
    }
    public void LowerArmSelectionRight() 
    {
        if (lowerArmIndex != MaleKnightSO.ArmLowerRightMesh.Length - 1)
        {
            lowerArmIndex++;
        }
        else
        {
            lowerArmIndex = 0;
        }

        ArmLowerRights.sharedMesh = MaleKnightSO.ArmLowerRightMesh[lowerArmIndex];
        ArmLowerLefts.sharedMesh = MaleKnightSO.ArmLowerLeftMesh[lowerArmIndex];
        ArmLowerRights.sharedMaterial = raceMaterial;
        ArmLowerLefts.sharedMaterial = raceMaterial;
        LowerArmText.text = "Lower Arm " + (lowerArmIndex + 1);
    }
    public void LowerArmSelectionLeft() 
    {
        if (lowerArmIndex != 0)
        {
            lowerArmIndex--;
        }
        else
        {
            lowerArmIndex = MaleKnightSO.ArmLowerRightMesh.Length - 1;
        }

        ArmLowerRights.sharedMesh = MaleKnightSO.ArmLowerRightMesh[lowerArmIndex];
        ArmLowerLefts.sharedMesh = MaleKnightSO.ArmLowerLeftMesh[lowerArmIndex];
        ArmLowerRights.sharedMaterial = raceMaterial;
        ArmLowerLefts.sharedMaterial = raceMaterial;
        LowerArmText.text = "Lower Arm " + (lowerArmIndex + 1);
    }
    public void HandSelectionRight()
    {
        if (handIndex != MaleKnightSO.RightHandMesh.Length - 1)
        {
            handIndex++;
        }
        else
        {
            handIndex = 0;
        }

        RightHands.sharedMesh = MaleKnightSO.RightHandMesh[handIndex];
        LeftHands.sharedMesh = MaleKnightSO.LeftHandMesh[handIndex];
        RightHands.sharedMaterial = raceMaterial;
        LeftHands.sharedMaterial = raceMaterial;
        HandText.text = "Hand " + (handIndex + 1);
    }
    public void HandSelectionLeft()
    {
        if (handIndex != 0)
        {
            handIndex--;
        }
        else
        {
            handIndex = MaleKnightSO.RightHandMesh.Length - 1;
        }

        RightHands.sharedMesh = MaleKnightSO.RightHandMesh[handIndex];
        LeftHands.sharedMesh = MaleKnightSO.LeftHandMesh[handIndex];
        RightHands.sharedMaterial = raceMaterial;
        LeftHands.sharedMaterial = raceMaterial;
        HandText.text = "Hand " + (handIndex + 1);
    }
    public void HipSelectionRight()
    {
        if (hipIndex != MaleKnightSO.HipsMesh.Length - 1)
        {
            hipIndex++;
        }
        else
        {
            hipIndex = 0;
        }

        Hips.sharedMesh = MaleKnightSO.HipsMesh[hipIndex];
        Hips.sharedMaterial = raceMaterial;
        HipText.text = "Hip " + (hipIndex + 1);
    }
    public void HipSelectionLeft() 
    {
        if (hipIndex != 0)
        {
            hipIndex--;
        }
        else
        {
            hipIndex = MaleKnightSO.HipsMesh.Length - 1;
        }
        Hips.sharedMesh = MaleKnightSO.HipsMesh[hipIndex];
        Hips.sharedMaterial = raceMaterial;
        HipText.text = "Hip " + (hipIndex + 1);
    }
    public void LegSelectionRight() 
    {
        if (legIndex != MaleKnightSO.LegRightMesh.Length - 1)
        {
            legIndex++;
        }
        else
        {
            legIndex = 0;
        }

        RightLegs.sharedMesh = MaleKnightSO.LegRightMesh[legIndex];
        LeftLegs.sharedMesh = MaleKnightSO.LegLeftMesh[legIndex];
        RightLegs.sharedMaterial = raceMaterial;
        LeftLegs.sharedMaterial = raceMaterial;
        LegText.text = "Leg " + (legIndex + 1);
    }
    public void LegSelectionLeft() 
    {
        if (legIndex != 0)
        {
            legIndex--;
        }
        else
        {
            legIndex = MaleKnightSO.LegRightMesh.Length - 1;
        }

        RightLegs.sharedMesh = MaleKnightSO.LegRightMesh[legIndex];
        LeftLegs.sharedMesh = MaleKnightSO.LegLeftMesh[legIndex];
        RightLegs.sharedMaterial = raceMaterial;
        LeftLegs.sharedMaterial = raceMaterial;
        LegText.text = "Leg " + (legIndex + 1);
    }
    public void HairSelectionRight() { }
    public void HairSelectionLeft() { }

    public void ChooseKnight()
    {
        raceMaterial = MaleKnightSO.Materials[0];
    }
    public void ChooseHighFolks()
    {
        raceMaterial = MaleKnightSO.Materials[1];
    }
    public void ChooseMage()
    {
        raceMaterial = MaleKnightSO.Materials[2];
    }

    public void UpdateMaterial()
    {
        RightLegs.sharedMaterial = raceMaterial;
        LeftLegs.sharedMaterial = raceMaterial;
        Hips.sharedMaterial = raceMaterial;
        RightHands.sharedMaterial = raceMaterial;
        LeftHands.sharedMaterial = raceMaterial;
        ArmLowerRights.sharedMaterial = raceMaterial;
        ArmLowerLefts.sharedMaterial = raceMaterial;
        ArmUpperRights.sharedMaterial = raceMaterial;
        ArmUpperLefts.sharedMaterial = raceMaterial;
        Torsos.sharedMaterial = raceMaterial;
        HeadArmors.sharedMaterial = raceMaterial;
        FacialHairs.sharedMaterial = raceMaterial;
        Eyebrows.sharedMaterial = raceMaterial;
        Skins.sharedMaterial = raceMaterial;
    }

    public void Randomise()
    {
        Skins.sharedMesh = MaleKnightSO.SkinMesh[Random.Range(0, MaleKnightSO.SkinMesh.Length)];
        HeadArmors.sharedMesh = MaleKnightSO.HeadArmorMesh[Random.Range(0, MaleKnightSO.HeadArmorMesh.Length)];
        Eyebrows.sharedMesh = MaleKnightSO.EyebrowsMesh[Random.Range(0, MaleKnightSO.EyebrowsMesh.Length)];
        FacialHairs.sharedMesh = MaleKnightSO.FacialHairMesh[Random.Range(0, MaleKnightSO.FacialHairMesh.Length)];
        Torsos.sharedMesh = MaleKnightSO.TorsoMesh[Random.Range(0, MaleKnightSO.TorsoMesh.Length)];
        int armUpperRandomIndex = Random.Range(0, MaleKnightSO.ArmUpperRightMesh.Length);
        ArmUpperRights.sharedMesh = MaleKnightSO.ArmUpperRightMesh[armUpperRandomIndex];
        ArmUpperLefts.sharedMesh = MaleKnightSO.ArmUpperLeftMesh[armUpperRandomIndex];
        int armLowerRandomIndex = Random.Range(0, MaleKnightSO.ArmLowerRightMesh.Length);
        ArmLowerRights.sharedMesh = MaleKnightSO.ArmLowerRightMesh[armLowerRandomIndex];
        ArmLowerLefts.sharedMesh = MaleKnightSO.ArmLowerLeftMesh[armLowerRandomIndex];
        int handIndex = Random.Range(0, MaleKnightSO.RightHandMesh.Length);
        RightHands.sharedMesh = MaleKnightSO.RightHandMesh[handIndex];
        LeftHands.sharedMesh = MaleKnightSO.LeftHandMesh[handIndex];
        Hips.sharedMesh = MaleKnightSO.HipsMesh[Random.Range(0, MaleKnightSO.HipsMesh.Length)];
        int legIndex = Random.Range(0, MaleKnightSO.LegRightMesh.Length);
        RightLegs.sharedMesh = MaleKnightSO.LegRightMesh[legIndex];
        LeftLegs.sharedMesh = MaleKnightSO.LegLeftMesh[legIndex];
        Hairs.sharedMesh = MaleKnightSO.HairMesh[Random.Range(0, MaleKnightSO.HairMesh.Length)];
        HelmetAttachments.sharedMesh = MaleKnightSO.HelmetAttachmentMesh[Random.Range(0, MaleKnightSO.HelmetAttachmentMesh.Length)];
        BackAttachments.sharedMesh = MaleKnightSO.BackAttachmentMesh[Random.Range(0, MaleKnightSO.BackAttachmentMesh.Length)];
        int shoulderAttachIndex = Random.Range(0, MaleKnightSO.RightShoulderAttachmentMesh.Length);
        RightShoulderAttachments.sharedMesh = MaleKnightSO.RightShoulderAttachmentMesh[shoulderAttachIndex];
        LeftShoulderAttachments.sharedMesh = MaleKnightSO.LeftShoulderAttachmentMesh[shoulderAttachIndex];
        int elbowAttachIndex = Random.Range(0, MaleKnightSO.RightElbowAttachmentMesh.Length);
        RightElbowAttachments.sharedMesh = MaleKnightSO.RightElbowAttachmentMesh[elbowAttachIndex];
        LeftElbowAttachments.sharedMesh = MaleKnightSO.LeftElbowAttachmentMesh[elbowAttachIndex];
        int kneeAttachIndex = Random.Range(0, MaleKnightSO.RightKneeAttachmentMesh.Length);
        RightKneeAttachments.sharedMesh = MaleKnightSO.RightKneeAttachmentMesh[elbowAttachIndex];
        LeftKneeAttachments.sharedMesh = MaleKnightSO.LeftKneeAttachmentMesh[elbowAttachIndex];

    }

}
