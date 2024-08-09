using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

public class MigratingBirds {

    // id's: 1, 2, 3
    //determine the id of the most frequently sighted type
    //if more has been spotted the maximum amount, return the smalles
    public static int migratoryBirds(List<int> arr) {

        var birdStats = CountId(arr);
        
        var mostSightedBird = MostSightings(birdStats);

        return mostSightedBird;
    }

    // Find the Id's within the list, and their count
    private static Dictionary<int, int> CountId(List<int> arr)
    {
        var birdStats = new Dictionary<int, int>();

        // Count occurrences of each bird ID
        foreach (var id in arr) {

            if (birdStats.ContainsKey(id)) {

                birdStats[id]++;

            } else {

                birdStats[id] = 1;

            }
        }

        return birdStats;
    }

    // Determine the ID with the most sightings, favoring the smallest ID in case of ties
    private static int MostSightings(Dictionary<int, int> birdStats) {

        int maxSightings = 0;
        int mostSightedBird = 0;

        foreach (var bird in birdStats) {
            
            var birdID = bird.Key;  
            var sightings = bird.Value;

            if(sightings > maxSightings) {

                maxSightings = sightings;
                mostSightedBird = birdID;

            }
            else if(sightings == maxSightings && mostSightedBird > birdID){

                mostSightedBird = birdID;

            }
        }

        return mostSightedBird;
    }
}