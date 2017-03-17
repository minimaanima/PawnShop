namespace PawnShop.Data.Utility
{
    using Exceptions;
    using Models.AuthorizationModels;
    using Models.BusinessModels;

    public class AuthorizationManager
    {
        private readonly PawnShopContext context;

        public AuthorizationManager()
        {
            this.context = new PawnShopContext();
        }

        public void Login(string email, string password)
        {
            var credentials = context.Credentials;

            foreach (var credentialse in credentials)
            {
                if (credentialse.Email == email)
                {
                    if (credentialse.Password == password)
                    {
                        var user = context.Users.Find(credentialse.Id);
                        CurrentUserManager.CurrentUser = user;
                    }
                }
            }

            throw new InvalidEmailOrPasswordException("Email or Password are incorrect !");
        }

        public void Register(string username, string password, string confirmedPassword)
        {
            if (!password.Equals(confirmedPassword))
            {
                throw new PasswordsDontMatchException("The two entered passwords are not equal.");
            }

            var user = new User()
            {
                Credentials = new Credentials()
                {
                    Email = username,
                    Password = password
                }
            };

            this.context.Users.Add(user);
            context.SaveChanges();
            CurrentUserManager.CurrentUser = user;
        }
    }
}
