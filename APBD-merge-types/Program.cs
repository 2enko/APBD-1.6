using System;

class Program {
    static void Main() {
        int[] numbs = {5, 4, 7, 9};
        Console.WriteLine(CalculateAvg(numbs));
        Console.WriteLine(CalculateMax(numbs));
    }

    static double CalculateAvg(int[] numbs) {
        double sum = 0;
        foreach (int numb in numbs) {
            sum += numb;
        }
        return sum / numbs.Length; 
    }
        static double CalculateMax(int[] numbs) {
        double max = 0;
        foreach (int numb in numbs) {
            if(numb > max) {
                max = numb; 
            }
        }
        return max;
    }
}
