using Microsoft.EntityFrameworkCore;
using NotebookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NotebookLibrary.Controllers
{
    public class LocusController
    {
      public List<Locus> readLocuss() {
        var retVal = new List<Locus>();
        try {
          using (var context = new ArchaeologyContext()) {
            retVal = context.Locus
                            .Include(locus => locus.Square)
                            .Include(locus => locus.SeparationClarity)
                            .ToList();
          }
        }
        catch (Exception ex) {
          throw new Exception(ex.Message, ex.InnerException);
        }
        return retVal;
      }

      public Locus readLocus(Guid id) {
        var retList = new List<Locus>();
        var retVal = new Locus();
        try {
          using (var context = new ArchaeologyContext()) {
            retList = context.Locus
                             .Include(locus => locus.Square)
                             .Include(locus => locus.SeparationClarity)
                             .Where(locus => locus.Id == id)
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

      public bool createLocus(Locus locus) {
        try {
          using (var context = new ArchaeologyContext()) {
            context.Locus.Add(locus);
            context.SaveChanges();
          }
        }
        catch (Exception ex) {
          throw new Exception(ex.Message, ex.InnerException);
        }
        return true;
      }

      public bool updateLocus(Locus locus) {
        try {
          using (var context = new ArchaeologyContext()) {
            context.Locus.Update(locus);
            context.SaveChanges();
          }
        }
        catch (Exception ex) {
          throw new Exception(ex.Message, ex.InnerException);
        }
        return true;
      }

      public bool deleteLocus(Locus locus) {
        try {
          using (var context = new ArchaeologyContext()) {
            context.Remove(locus);
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
