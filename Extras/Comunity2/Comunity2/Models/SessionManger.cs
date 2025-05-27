namespace jobs.Models
{
    public class SessionManger
    {

        private readonly ISession? session;
        public SessionManger(IHttpContextAccessor httpContextAccessor)
        { 
            session = httpContextAccessor.HttpContext.Session;
        }

        public SessionManger()
        {
        }

        public  void SetUserInfo(int userid, string usertype, string username)
        {
            session.SetInt32("UserId", userid);
            session.SetString("UserType", usertype);
            session.SetString("UserName", username);
        }
        public  int GetUserId()
        {
            return session.GetInt32("UserId") ?? 0;
        }
        public string GetUserName() {
            return session.GetString("UserName") ?? "Bossuser";
        }
        public string UserType() {
            return session.GetString("UserType")??"Boss";
        }
        public string setusername( string n)
        {
            session.SetString("uname", n);
            return session.GetString("uname");
        }
    }
}
