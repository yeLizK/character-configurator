using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaleKnightCustomiser : MonoBehaviour
{
    public MaleKnightSO MaleKnightSO;

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
