using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using BsvService.Core.Models;
using LiteDB;

namespace BsvService.DAL.Repositories
{
    public class UserRepoLiteDb : IUserRepo, ILiteDbRepo
    {
        public string CollectionName { get; set; } = @"userprofile";


        private string _pathToDb;
        public UserRepoLiteDb(string pathToDb)
        {
            _pathToDb = pathToDb;

            // Create Indexes

            // Open database (or create if doesn't exist)
            using (var db = new LiteDatabase(_pathToDb))
            {
                var col = db.GetCollection<UserProfile>(CollectionName);
                col.EnsureIndex(x => x.Industry);
                col.EnsureIndex(x => x.Region);
            }
        }

        public UserProfile Get(int id)
        {
            throw new Exception("test");
            using (var db = new LiteRepository(_pathToDb))
            {
                // query using fluent query
                return db.Query<UserProfile>(CollectionName)
                    .Where(x => x.Id == id).FirstOrDefault();
            }
        }

        public IEnumerable<UserProfile> GetList(Expression<Func<UserProfile, bool>> filter)
        {
            using (var db = new LiteRepository(_pathToDb))
            {
                var query = db.Query<UserProfile>(CollectionName);
                if (filter != null)
                {
                    query = query
                        .Where(filter); // conditional filter
                }
                return query.ToList();
            }
        }

        public void Insert(IEnumerable<UserProfile> userProfileList)
        {
            using (var db = new LiteRepository(_pathToDb))
            {
                db.Insert(userProfileList, CollectionName);
            }
        }

        public void Insert(UserProfile userProfile)
        {
            using (var db = new LiteRepository(_pathToDb))
            {
                db.Insert(userProfile, CollectionName);
            }
        }

        public void Update(UserProfile userProfile)
        {
            using (var db = new LiteRepository(_pathToDb))
            {
                db.Update(userProfile, CollectionName);
            }
        }
    }
}
