namespace LeetCode.HackerRank.Problem_Solving;

public class TeamInterface
{
    public class Team {
        
        protected string TeamName;
        private int _noOfPlayers;

        protected Team(string teamName, int noOfPlayers) {
            TeamName = teamName;
            _noOfPlayers = noOfPlayers;
        }
        
        public void AddPlayer(int count) {
            _noOfPlayers += count;
        }
        
        public bool RemovePlayer(int count)
        {

            if(_noOfPlayers - count < 0) {
                return false;
            }

            _noOfPlayers -= count;
            return true;
        }
    }

    public class Subteam: Team {
        
        public Subteam(string teamName, int noOfPlayers) : base(teamName, noOfPlayers){}
        
        public void ChangeTeamName(string name) {
            TeamName = name;
        }
    }
}