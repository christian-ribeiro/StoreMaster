namespace StockEase.Arguments
{
    public static class SessionData
    {
        private static LoggedUser? LoggedUser { get; set; }

        public static void SetLoggedUser(LoggedUser loggedUser)
        {
            LoggedUser = loggedUser;
        }

        public static LoggedUser? GetLoggedUser()
        {
            return LoggedUser;
        }
    }
}