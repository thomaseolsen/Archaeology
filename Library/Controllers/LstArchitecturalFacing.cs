using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Library.Controllers
{
  public class LstArchitecturalFacingController
  {
    public List<LstArchitecturalFacing> readArchitecturalFacings() {
      var retVal = new List<LstArchitecturalFacing>();
      try {
        using (var context = new ArchaeologyContext()) {
          retVal = context.LstArchitecturalFacing
                          .OrderBy(l => l.Description)
                          .ToList();
        }
      }
      catch (Exception ex) {
        throw new Exception(ex.Message, ex.InnerException);
      }
      return retVal;
    }

    public LstArchitecturalFacing readArchitecturalFacing(int id) {
      var retList = new List<LstArchitecturalFacing>();
      var retVal = new LstArchitecturalFacing();
      try {
        using (var context = new ArchaeologyContext()) {
          retList = context.LstArchitecturalFacing
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
