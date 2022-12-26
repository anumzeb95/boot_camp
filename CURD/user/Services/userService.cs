using user.Models;

namespace user.Services
{
    public static class userService
    {



        private static List<userModel> _student = new List<userModel>();
        public static List<userModel> GetAll()
        {
            return _student;
        }

        public static void Add(userModel model)
        {
            _student.Add(model);
        }

        public static void Delete(int Id)
        {
            foreach(userModel sid in _student)
            {
                if(sid.Id == Id)
                {
                    _student.Remove(sid);
                    break;
                }
            }
        }

        public static void Update(userModel tempmodel)
        {
            foreach (userModel sid in _student)
          {
                if (sid.Id == tempmodel.Id)
               {
                    sid.Name = tempmodel.Name;
                    sid.Age = tempmodel.Age;
               }
           }
       }

    }
}
