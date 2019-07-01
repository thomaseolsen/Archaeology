using NotebookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NotebookLibrary.Controllers
{
  public class LstArchitecturalConstructionStyleController
  {
    public List<LstArchitecturalConstructionStyle> readArchitecturalConstructionStyles() {
      var retVal = new List<LstArchitecturalConstructionStyle>();
      try {
        using (var context = new ArchaeologyContext()) {
          retVal = context.LstArchitecturalConstructionStyle
                          .OrderBy(l => l.Description)
                          .ToList();
        }
      }
      catch (Exception ex) {
        throw new Exception(ex.Message, ex.InnerException);
      }
      return retVal;
    }

    public LstArchitecturalConstructionStyle readArchitecturalConstructionStyle(int id) {
      var retList = new List<LstArchitecturalConstructionStyle>();
      var retVal = new LstArchitecturalConstructionStyle();
      try {
        using (var context = new ArchaeologyContext()) {
          retList = context.LstArchitecturalConstructionStyle
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
