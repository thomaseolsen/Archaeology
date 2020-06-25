using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Library.Controllers
{
  public class LstArchitecturalMasonryController
  {
    public List<LstArchitecturalMasonry> readArchitecturalMasonrys() {
      var retVal = new List<LstArchitecturalMasonry>();
      try {
        using (var context = new ArchaeologyContext()) {
          retVal = context.LstArchitecturalMasonry
                          .OrderBy(l => l.Description)
                          .ToList();
        }
      }
      catch (Exception ex) {
        throw new Exception(ex.Message, ex.InnerException);
      }
      return retVal;
    }

    public LstArchitecturalMasonry readArchitecturalMasonry(int id) {
      var retList = new List<LstArchitecturalMasonry>();
      var retVal = new LstArchitecturalMasonry();
      try {
        using (var context = new ArchaeologyContext()) {
          retList = context.LstArchitecturalMasonry
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
  }
}
