using MathFightWebApi.App.AuthenticationHeaders;
using MathFightWebApi.App.Models;
using MathFightWebApi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.ValueProviders;
using System.Web.Mvc;

namespace MathFightWebApi.App.Controllers
{
    public class ProblemsController : BaseApiController
    {
        static Random rnd = new Random();
        [HttpGet]
        [ActionName("questions")]
        public IQueryable<ProblemModel> GetQuestions(int difficulty,
            [ValueProvider(typeof(HeaderValueProviderFactory<string>))]
            string accessToken)
        {
            return this.ExecuteOperationAndHandleExceptions(() =>
            {
                var context = new MathFightDbContext();
                var user = this.GetUserByAccessToken(accessToken, context);
                List<ProblemModel> Problems = new List<ProblemModel>();
                while (Problems.Count <= 100)
                {
                    ProblemModel newProblem = GetProblem(context);
                    if (difficulty == newProblem.Difficulty)
                    {
                        Problems.Add(newProblem);
                    }
                }
                return Problems.AsQueryable();
            });
        }

        private ProblemModel GetProblem(MathFightDbContext context)
        {
            int maxId = context.Problems.Max(p=>p.Id);
            
            int id = rnd.Next(1,maxId+1);
            var problem = context.Problems.FirstOrDefault(p=>p.Id==id);
            ProblemModel Problem = new ProblemModel()
            {
                Answer = problem.Answer,
                Difficulty = problem.Difficulty,
                Question = problem.Qestion,
                Id = problem.Id
            };

            return Problem;
        }

    }
}
