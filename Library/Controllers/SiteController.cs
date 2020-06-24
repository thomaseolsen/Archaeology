using NotebookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NotebookLibrary.Controllers
{
    public class SiteController
    {
      public List<Site> readSites() {
        var retVal = new List<Site>();
        try {
          using (var context = new ArchaeologyContext()) {
            retVal = context.Site
                            .ToList();
          }
        }
        catch (Exception ex) {
          throw new Exception(ex.Message, ex.InnerException);
        }
        return retVal;
      }

      public Site readSite(Guid id) {
        var retList = new List<Site>();
        var retVal = new Site();
        try {
          using (var context = new ArchaeologyContext()) {
            retList = context.Site
                             .Where(s => s.Id == id)
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

      public bool createSite(Site site) {
        try {
          using (var context = new ArchaeologyContext()) {
            context.Site.Add(site);
            context.SaveChanges();
          }
        }
        catch (Exception ex) {
          throw new Exception(ex.Message, ex.InnerException);
        }
        return true;
      }

      public bool updateSite(Site site) {
        try {
          using (var context = new ArchaeologyContext()) {
            context.Site.Update(site);
            context.SaveChanges();
          }
        }
        catch (Exception ex) {
          throw new Exception(ex.Message, ex.InnerException);
        }
        return true;
      }

      public bool deleteSite(Site site) {
        try {
          using (var context = new ArchaeologyContext()) {
            context.Remove(site);
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
