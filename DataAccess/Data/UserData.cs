using DataAccess.DbAccess;

namespace DataAccess.Data
{
    public class UserData : IUserData
    {


        private readonly ISqlDataAccess _db;

        public UserData(ISqlDataAccess db)
        {
            _db = db;
        }

        //dynamic- we can pass any type of parameters with values, but in our case there are no one
        // new { } - these are our parameters, we don’t have any parameters, but we must pass something, because dynamic is registered and we are passing an empty anonymous object
        public Task<IEnumerable<UserModel>> GetUsers() =>
          _db.LoadData<UserModel, dynamic>("dbo.spUser_GetAll", new { });


        public async Task<UserModel?> GetUser(int id)
        {

            var results = await _db.LoadData<UserModel, dynamic>(
               "dbo.spUser_Get",
                new { Id = id });
            return results.FirstOrDefault();
        }

        public Task InsertUser(UserModel user) =>
            _db.SaveData("dbo.spUser_Insert", new { user.FirstName, user.LastName });

        public Task UpdateUser(UserModel user) =>
             _db.SaveData("dbo.spUser_Update", user);

        public Task DeleteUser(int id) =>
            _db.SaveData("dbo.spUser_Delete", new { Id = id });


    }
}
