using System;

class BirdCount
{
    private int[] birdsPerDay;
    
    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => new int[] {0, 2, 5, 3, 7, 8, 4};

    public int Today() => birdsPerDay[birdsPerDay.Length-1];

    public void IncrementTodaysCount() => birdsPerDay[birdsPerDay.Length-1]++;

    public bool HasDayWithoutBirds()
    {
        foreach(int d in birdsPerDay) {
          if (d == 0)
            return true;
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays) {
      int total = 0;
      for (int i = 0; i < numberOfDays; i++) {
        total += birdsPerDay[i];
      }
      return total;
    }

    public int BusyDays() {
      int total = 0;
        foreach(int d in birdsPerDay){
            if(d >= 5)
                total++;
        }
    return total;
    }
}
