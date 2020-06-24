using NotebookLibrary.Models;
using NotebookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NotebookLibrary.Controllers
{
  public class LstArchitecturalMasonryStonesController
  {
    public List<LstArchitecturalMasonryStones> readArchitecturalMasonryStones() {
      var retVal = new List<LstArchitecturalMasonryStones>();
      try {
        using (var context = new ArchaeologyContext()) {
          retVal = context.LstArchitecturalMasonryStones
                          .OrderBy(l => l.Description)
                          .ToList();
        }
      }
      catch (Exception ex) {
        throw new Exception(ex.Message, ex.InnerException);
      }
      return retVal;
    }

    public LstArchitecturalMasonryStones readArchitecturalMasonryStones(int id) {
      var retList = new List<LstArchitecturalMasonryStones>();
      var retVal = new LstArchitecturalMasonryStones();
      try {
        using (var context = new ArchaeologyContext()) {
          retList = context.LstArchitecturalMasonryStones
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
