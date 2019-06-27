using Microsoft.EntityFrameworkCore;
using NotebookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NotebookLibrary.Controllers
{
    public class GeospatialDataController
    {
      public List<GeospatialData> readGeospatialData() {
        var retVal = new List<GeospatialData>();
        try {
          using (var context = new ArchaeologyContext()) {
            retVal = context.GeospatialData
                            .ToList();
          }
        }
        catch (Exception ex) {
          throw new Exception(ex.Message, ex.InnerException);
        }
        return retVal;
      }

      public GeospatialData readGeospatialData(Guid id) {
        var retList = new List<GeospatialData>();
        var retVal = new GeospatialData();
        try {
          using (var context = new ArchaeologyContext()) {
            retList = context.GeospatialData
                             .Where(geospatialData => geospatialData.Id == id)
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

      public bool createGeospatialData(GeospatialData geospatialData) {
        try {
          using (var context = new ArchaeologyContext()) {
            context.GeospatialData.Add(geospatialData);
            context.SaveChanges();
          }
        }
        catch (Exception ex) {
          throw new Exception(ex.Message, ex.InnerException);
        }
        return true;
      }

      public bool updateGeospatialData(GeospatialData geospatialData) {
        try {
          using (var context = new ArchaeologyContext()) {
            context.GeospatialData.Update(geospatialData);
            context.SaveChanges();
          }
        }
        catch (Exception ex) {
          throw new Exception(ex.Message, ex.InnerException);
        }
        return true;
      }

      public bool deleteGeospatialData(GeospatialData geospatialData) {
        try {
          using (var context = new ArchaeologyContext()) {
            context.Remove(geospatialData);
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
