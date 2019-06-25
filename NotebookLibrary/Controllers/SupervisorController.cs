using Microsoft.EntityFrameworkCore;
using NotebookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NotebookLibrary.Controllers
{
    public class SupervisorController
    {
      public List<Supervisor> readSupervisors() {
        var retVal = new List<Supervisor>();
        try {
          using (var context = new ArchaeologyContext()) {
            retVal = context.Supervisor
                            .Include(supervisor => supervisor.Team)
                            .ToList();
          }
        }
        catch (Exception ex) {
          throw new Exception(ex.Message, ex.InnerException);
        }
        return retVal;
      }

      public Supervisor readSupervisor(Guid id) {
        var retList = new List<Supervisor>();
        var retVal = new Supervisor();
        try {
          using (var context = new ArchaeologyContext()) {
            retList = context.Supervisor
                             .Include(supervisor => supervisor.Team)
                             .Where(supervisor => supervisor.Id == id)
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

      public bool createSupervisor(Supervisor supervisor) {
        try {
          using (var context = new ArchaeologyContext()) {
            context.Supervisor.Add(supervisor);
            context.SaveChanges();
          }
        }
        catch (Exception ex) {
          throw new Exception(ex.Message, ex.InnerException);
        }
        return true;
      }

      public bool updateSupervisor(Supervisor supervisor) {
        try {
          using (var context = new ArchaeologyContext()) {
            context.Supervisor.Update(supervisor);
            context.SaveChanges();
          }
        }
        catch (Exception ex) {
          throw new Exception(ex.Message, ex.InnerException);
        }
        return true;
      }

      public bool deleteSupervisor(Supervisor supervisor) {
        try {
          using (var context = new ArchaeologyContext()) {
            context.Remove(supervisor);
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
