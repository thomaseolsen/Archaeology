using NotebookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NotebookLibrary.Controllers
{
  public class LstArchitecturalConstructionSupportController
  {
    public List<LstArchitecturalConstructionSupport> readArchitecturalConstructionSupports() {
      var retVal = new List<LstArchitecturalConstructionSupport>();
      try {
        using (var context = new ArchaeologyContext()) {
          retVal = context.LstArchitecturalConstructionSupport
                          .OrderBy(l => l.Description)
                          .ToList();
        }
      }
      catch (Exception ex) {
        throw new Exception(ex.Message, ex.InnerException);
      }
      return retVal;
    }

    public LstArchitecturalConstructionSupport readArchitecturalConstructionSupport(int id) {
      var retList = new List<LstArchitecturalConstructionSupport>();
      var retVal = new LstArchitecturalConstructionSupport();
      try {
        using (var context = new ArchaeologyContext()) {
          retList = context.LstArchitecturalConstructionSupport
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
