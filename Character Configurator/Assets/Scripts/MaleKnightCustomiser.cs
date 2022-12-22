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

    }

}
