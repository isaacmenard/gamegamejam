using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameManager", menuName = "GameManagerObject", order = 0)]
public class GameManagerSciptableObject : ScriptableObject
{
    [Header("Party")]
    public float scoreMultiplicateur;//fait
    public float coinDivideurByScore;//fait
    public float capsulePvPuissance;//fait
    public float capsulePvCoolDownMin;//fait
    public float capsulePvCoolDownMax;//fait
    public float howMuchPartyTutoShow;//fait

    [Space, Header("Planet")]
    public float MinPVPlanetToUseProtection;//fait
    public float scalePlanetOffset;//fait
    public Vector3 rotationPlanet;//fait
    public float puissanceLerpScale;//fait

    [Space, Header("Player")]
    public float speedPlayer;//fait
    public float puissanceDash;
    public float cooldownDash;
    public float cooldownDashEnd;

    [Space, Header("Protection")]
    public float cooldownMaxProtection;
    public float protectionQuantity;//fait
}
