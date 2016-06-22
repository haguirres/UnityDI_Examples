namespace UnityExample
{
    public class TrivialPursuit : IGame
    {
        private string _status;

        public TrivialPursuit()
        {
            Name = "Trivial Pursuit";
            CurrentPlayers = 0;
            MinPlayers = 2;
            MaxPlayers = 8;
            _status = "No active games";
        }

        public int CurrentPlayers
        {
            get; set;
        }

        public int MaxPlayers
        {
            get; set;
        }

        public int MinPlayers
        {
            get; set;
        }

        public string Name
        {
            get; set;
        }

        public void AddPlayer()
        {
            CurrentPlayers++;
        }

        public void Play()
        {
            if ((CurrentPlayers > MaxPlayers) || (CurrentPlayers < MinPlayers))
                _status = string.Format("{0}: It's not possible to play with {1} players.", Name, CurrentPlayers);
            else
                _status = string.Format("{0}: Playing with {1} players.", Name, CurrentPlayers);
        }

        public void RemovePlayer()
        {
            CurrentPlayers--;
        }

        public string Result()
        {
            return _status;
        }
    }
}