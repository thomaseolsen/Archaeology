using Microsoft.EntityFrameworkCore;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Library.Controllers
{
    public class ObjectController
    {
      public List<Models.Object> readObjects() {
        var retVal = new List<Models.Object>();
        try {
          using (var context = new ArchaeologyContext()) {
            retVal = context.Object
                            .Include(obj => obj.GeospatialData)
                            .Include(obj => obj.Locus)
                              .ThenInclude(locus => locus.Square)
                                .ThenInclude(square => square.Supervisor)
                            .ToList();
          }
        }
        catch (Exception ex) {
          throw new Exception(ex.Message, ex.InnerException);
        }
        return retVal;
      }

      public Models.Object readObject(Guid id) {
        var retList = new List<Models.Object>();
        var retVal = new Models.Object();
        try {
          using (var context = new ArchaeologyContext()) {
            retList = context.Object
                             .Include(obj => obj.GeospatialData)
                             .Include(obj => obj.Locus)
                              .ThenInclude(locus => locus.Square)
                                .ThenInclude(square => square.Supervisor)
                             .Where(obj => obj.Id == id)
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

      public bool createObject(Models.Object obj) {
        try {
          using (var context = new ArchaeologyContext()) {
            context.Object.Add(obj);
            context.SaveChanges();
          }
        }
        catch (Exception ex) {
          throw new Exception(ex.Message, ex.InnerException);
        }
        return true;
      }

      public bool updateObject(Models.Object obj) {
        try {
          using (var context = new ArchaeologyContext()) {
            context.Object.Update(obj);
            context.SaveChanges();
          }
        }
        catch (Exception ex) {
          throw new Exception(ex.Message, ex.InnerException);
        }
        return true;
      }

      public bool deleteObject(Models.Object obj) {
        try {
          using (var context = new ArchaeologyContext()) {
            context.Remove(obj);
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
