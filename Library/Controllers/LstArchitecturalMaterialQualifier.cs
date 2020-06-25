using Library.Models;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Library.Controllers
{
  public class LstArchitecturalMaterialQualifierController
  {
    public List<LstArchitecturalMaterialQualifier> readArchitecturalMaterialQualifier() {
      var retVal = new List<LstArchitecturalMaterialQualifier>();
      try {
        using (var context = new ArchaeologyContext()) {
          retVal = context.LstArchitecturalMaterialQualifier
                          .OrderBy(l => l.Description)
                          .ToList();
        }
      }
      catch (Exception ex) {
        throw new Exception(ex.Message, ex.InnerException);
      }
      return retVal;
    }

    public LstArchitecturalMaterialQualifier readArchitecturalMaterialQualifier(int id) {
      var retList = new List<LstArchitecturalMaterialQualifier>();
      var retVal = new LstArchitecturalMaterialQualifier();
      try {
        using (var context = new ArchaeologyContext()) {
          retList = context.LstArchitecturalMaterialQualifier
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
