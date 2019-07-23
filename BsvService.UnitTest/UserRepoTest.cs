using System;
using System.Collections.Generic;
using System.IdentityModel.Selectors;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BsvService.Core.Models;
using BsvService.DAL.Repositories;

namespace BsvService.UnitTest
{
    public class TestUserRepo : IUserRepo
    {
        private List<UserProfile> _users = new List<UserProfile>()
            {
                new UserProfile()
                {
                    Id = 1,
                    Email = "my Test@myemail.com",
                    FirstName = "Vasya 2",
                    LastName = "Pupkin",
                    Bio = "My name is",
                    PhoneNumber = "+3752734596",
                    Region = "Minsk",
                    Industry = "TractorIT",
                    Educations = new List<Education>()
                    {
                        new Education()
                        {
                            SchoolName = "School",
                            SchoolStartYear = 1997,
                            SchoolEndYear = 2001
                        },
                        new Education()
                        {
                            SchoolName = "Univer",
                            SchoolStartYear = 2002,
                            SchoolEndYear = 2010
                        },
                    },
                    WorkExperiences = new List<WorkExperience>()
                    {
                        new WorkExperience()
                        {
                            JobTitle = "Dev",
                            Company = "Gik",
                            JobStartYear = 2018,
                            JobEndYear = 2019
                        },
                        new WorkExperience()
                        {
                            JobTitle = "DevQa",
                            Company = "Solb",
                            JobStartYear = 2015,
                            JobEndYear = 2020
                        }
                    },
                    Facebook = "My facebook",
                    Twitter = "Twitter",
                    Blog = "blogpost.com"

                },
                new UserProfile()
                {
                    Id = 2,
                    Email = "Test@myemail.com",
                    FirstName = "Petya 2",
                    LastName = "Pupkin",
                    Bio = "My name is",
                    PhoneNumber = "+3752734596",
                    Region = "Minsk",
                    Industry = "IT",
                    Educations = new List<Education>()
                    {
                        new Education()
                        {
                            SchoolName = "School",
                            SchoolStartYear = 1997,
                            SchoolEndYear = 2001
                        },
                        new Education()
                        {
                            SchoolName = "Univer",
                            SchoolStartYear = 2002,
                            SchoolEndYear = 2010
                        },
                    },
                    WorkExperiences = new List<WorkExperience>()
                    {
                        new WorkExperience()
                        {
                            JobTitle = "Dev",
                            Company = "Gik",
                            JobStartYear = 2018,
                            JobEndYear = 2019
                        },
                        new WorkExperience()
                        {
                            JobTitle = "DevQa",
                            Company = "Solb",
                            JobStartYear = 2015,
                            JobEndYear = 2020
                        }
                    },
                    Facebook = "My facebook",
                    Twitter = "Twitter",
                    Blog = "blogpost.com"
                },
                new UserProfile()
                {
                    Id = 3,
                    Email = "TestTest@myemail.com",
                    FirstName = "Petya 2",
                    LastName = "Pupkin",
                    Bio = "My name is",
                    PhoneNumber = "+3752734596",
                    Region = "Gomel",
                    Industry = "IT",
                    Educations = new List<Education>()
                    {
                        new Education()
                        {
                            SchoolName = "School",
                            SchoolStartYear = 1997,
                            SchoolEndYear = 2001
                        },
                        new Education()
                        {
                            SchoolName = "Univer",
                            SchoolStartYear = 2002,
                            SchoolEndYear = 2010
                        },
                    },
                    WorkExperiences = new List<WorkExperience>()
                    {
                        new WorkExperience()
                        {
                            JobTitle = "Dev",
                            Company = "Gik",
                            JobStartYear = 2018,
                            JobEndYear = 2019
                        },
                        new WorkExperience()
                        {
                            JobTitle = "DevQa",
                            Company = "Solb",
                            JobStartYear = 2015,
                            JobEndYear = 2020
                        }
                    },
                    Facebook = "My facebook",
                    Twitter = "Twitter",
                    Blog = "blogpost.com"
                }
            };

        public List<UserProfile> Users => _users;

        void IRepoBase<UserProfile>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        UserProfile IRepoBase<UserProfile>.Get(int id)
        {
            return _users.FirstOrDefault(x => x.Id == id);
        }

        IEnumerable<UserProfile> IRepoBase<UserProfile>.GetList(Expression<Func<UserProfile, bool>> filter)
        {
            return _users.Where(filter.Compile()).ToList();
        }
        void IRepoBase<UserProfile>.Insert(IEnumerable<UserProfile> userProfileList)
        {
            throw new NotImplementedException();
        }

        void IRepoBase<UserProfile>.Insert(UserProfile userProfile)
        {
            if (_users.Exists(x => x.Id == userProfile.Id))
            {
                throw new ArgumentException("DB already has element with such Id");
            }
            _users.Add(userProfile);
        }

        void IRepoBase<UserProfile>.Update(UserProfile userProfile)
        {
            throw new NotImplementedException();
        }
    }

}
