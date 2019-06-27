using Microsoft.EntityFrameworkCore;
using NotebookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NotebookLibrary.Controllers
{
    public class PotteryBucketController
    {
      public List<PotteryBucket> readPotteryBuckets() {
        var retVal = new List<PotteryBucket>();
        try {
          using (var context = new ArchaeologyContext()) {
            retVal = context.PotteryBucket
                            .Include(potteryBucket => potteryBucket.GeospatialData)
                            .Include(potteryBucket => potteryBucket.Locus)
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

      public PotteryBucket readPotteryBucket(Guid id) {
        var retList = new List<PotteryBucket>();
        var retVal = new PotteryBucket();
        try {
          using (var context = new ArchaeologyContext()) {
            retList = context.PotteryBucket
                             .Include(potteryBucket => potteryBucket.GeospatialData)
                             .Include(potteryBucket => potteryBucket.Locus)
                              .ThenInclude(locus => locus.Square)
                                .ThenInclude(square => square.Supervisor)
                             .Where(potteryBucket => potteryBucket.Id == id)
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

      public bool createPotteryBucket(PotteryBucket potteryBucket) {
        try {
          using (var context = new ArchaeologyContext()) {
            context.PotteryBucket.Add(potteryBucket);
            context.SaveChanges();
          }
        }
        catch (Exception ex) {
          throw new Exception(ex.Message, ex.InnerException);
        }
        return true;
      }

      public bool updatePotteryBucket(PotteryBucket potteryBucket) {
        try {
          using (var context = new ArchaeologyContext()) {
            context.PotteryBucket.Update(potteryBucket);
            context.SaveChanges();
          }
        }
        catch (Exception ex) {
          throw new Exception(ex.Message, ex.InnerException);
        }
        return true;
      }

      public bool deletePotteryBucket(PotteryBucket potteryBucket) {
        try {
          using (var context = new ArchaeologyContext()) {
            context.Remove(potteryBucket);
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
