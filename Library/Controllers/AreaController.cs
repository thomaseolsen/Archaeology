using Microsoft.EntityFrameworkCore;
using NotebookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NotebookLibrary.Controllers
{
    public class AreaController
    {
      public List<Area> readAreas() {
        var retVal = new List<Area>();
        try {
          using (var context = new ArchaeologyContext()) {
            retVal = context.Area
                            .Include(area => area.Site)
                            .ToList();
          }
        }
        catch (Exception ex) {
          throw new Exception(ex.Message, ex.InnerException);
        }
        return retVal;
      }

      public Area readArea(Guid id) {
        // TODO: Figure out Linq query to bring in Team information.
        var retList = new List<Area>();
        var retVal = new Area();
        try {
          using (var context = new ArchaeologyContext()) {
            retList = context.Area
                             .Include(area => area.Site)
                             .Where(area => area.Id == id)
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

      public bool createArea(Area area) {
        try {
          using (var context = new ArchaeologyContext()) {
            context.Area.Add(area);
            context.SaveChanges();
          }
        }
        catch (Exception ex) {
          throw new Exception(ex.Message, ex.InnerException);
        }
        return true;
      }

      public bool updateArea(Area area) {
        try {
          using (var context = new ArchaeologyContext()) {
            context.Area.Update(area);
            context.SaveChanges();
          }
        }
        catch (Exception ex) {
          throw new Exception(ex.Message, ex.InnerException);
        }
        return true;
      }

      public bool deleteArea(Area area) {
        try {
          using (var context = new ArchaeologyContext()) {
            context.Remove(area);
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
