using UnityEngine;
using System.Collections;

public static class MessageSystem
{
    public delegate void DeathScenarioHandle();
    public static event DeathScenarioHandle onDeathScenario;
   // public static event DeathScenarioHandle onKillzoneSenario;
    public static event DeathScenarioHandle onPlayerSenario;

    public static void BroadcastDeath()
    {
        if (onDeathScenario == null)
            return;

        onDeathScenario();
    }

    public static void PlayerReset()
    {
        if (onPlayerSenario == null)
            return;

        onPlayerSenario();
    }
}
