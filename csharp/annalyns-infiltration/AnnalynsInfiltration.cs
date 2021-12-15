using System;

static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        return !knightIsAwake;
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        return ((knightIsAwake || archerIsAwake) && !prisonerIsAwake) ||
               ((!knightIsAwake || !archerIsAwake) && prisonerIsAwake) ||
               (knightIsAwake && archerIsAwake && prisonerIsAwake);
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        return prisonerIsAwake && (!archerIsAwake || !prisonerIsAwake);
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        var canFreePrisoner = false;

        if (knightIsAwake && !prisonerIsAwake && !archerIsAwake && petDogIsPresent)
             canFreePrisoner = true;

        if (!knightIsAwake && prisonerIsAwake && !archerIsAwake && (petDogIsPresent || !petDogIsPresent))
            canFreePrisoner = true;

        if (knightIsAwake && prisonerIsAwake && !archerIsAwake && petDogIsPresent)
             canFreePrisoner = true;
        
        if (!knightIsAwake && !prisonerIsAwake && !archerIsAwake && petDogIsPresent)
            canFreePrisoner = true;

        return canFreePrisoner;
    }
}
