using Microsoft.EntityFrameworkCore;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Library.Controllers
{
    public class TeamController
    {
      public List<Team> readTeams() {
        var retVal = new List<Team>();
        try {
          using (var context = new ArchaeologyContext()) {
            retVal = context.Team
                            .ToList();
          }
        }
        catch (Exception ex) {
          throw new Exception(ex.Message, ex.InnerException);
        }
        return retVal;
      }

      public Team readTeam(Guid id) {
        var retList = new List<Team>();
        var retVal = new Team();
        try {
          using (var context = new ArchaeologyContext()) {
            retList = context.Team
                             .Where(team => team.Id == id)
                             .ToList();
          }
        }
        catch (Exception ex) {
          throw new Exception(ex.Message, ex.InnerException);
        }
        if (retList.Count > 0) {
          retVal = retList[0];
        }
        return retVal;
      }

      public bool createTeam(Team team) {
        try {
          using (var context = new ArchaeologyContext()) {
            context.Team.Add(team);
            context.SaveChanges();
          }
        }
        catch (Exception ex) {
          throw new Exception(ex.Message, ex.InnerException);
        }
        return true;
      }

      public bool updateTeam(Team team) {
        try {
          using (var context = new ArchaeologyContext()) {
            context.Team.Update(team);
            context.SaveChanges();
          }
        }
        catch (Exception ex) {
          throw new Exception(ex.Message, ex.InnerException);
        }
        return true;
      }

      public bool deleteTeam(Team team) {
        try {
          using (var context = new ArchaeologyContext()) {
            context.Remove(team);
            context.SaveChanges();
          }
        }
        catch (Exception ex) {
          throw new Exception(ex.Message, ex.InnerException);
        }
        return true;
      }
    }
}
