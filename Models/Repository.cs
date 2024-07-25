namespace MeetingApp.Models
{

    public class Repository
    {
        private static List<UserInfo> _users = new();


        static Repository()
        {
            _users.Add(new UserInfo(){Id = 1,Name="Ali",Email="abc@gmail.com",Phone = "1111",WillAttend=true});
            _users.Add(new UserInfo(){Id = 2,Name="Ahmet",Email="ahmet@gmail.com",Phone = "2222",WillAttend=true});
            _users.Add(new UserInfo(){Id = 3,Name="Yasir",Email="yasir@gmail.com",Phone = "3333",WillAttend=false});

        }
        public static List<UserInfo> Users {
            get{
                return _users;
            }
        }

        public static void CreateUser(UserInfo user){
            user.Id = Users.Count+1;
            _users.Add(user);
        }

        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(users=> users.Id == id);

        }
    }

}