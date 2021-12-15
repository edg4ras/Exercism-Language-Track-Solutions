class Lasagna
{
    public int ExpectedMinutesInOven() {
        return 40;
    }

    public int RemainingMinutesInOven(int minutes) {
        return ExpectedMinutesInOven() - minutes;
    }

    public int PreparationTimeInMinutes(int minutes) {
        return minutes * 2;
    }

    public int ElapsedTimeInMinutes(int layer1, int layer2) {
        return (layer1 * 2) + layer2;
    }
}
