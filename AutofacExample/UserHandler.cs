namespace AutofacExample
{
    internal interface IUserHandler
    {
        void PerformSomeAction();
    }

    class UserHandler : IUserHandler
    {
        private static IBackupFactory _backupFactory;
        public UserHandler(IBackupFactory backupFactory)
        {
            _backupFactory = backupFactory;
        }

        public void PerformSomeAction()
        {
            var users = _backupFactory.GetFtpUsers();
        }
    }
}