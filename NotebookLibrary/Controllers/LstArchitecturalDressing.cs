using NotebookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NotebookLibrary.Controllers
{
  public class LstArchitecturalDressingController
  {
    public List<LstArchitecturalDressing> readArchitecturalDressings() {
      var retVal = new List<LstArchitecturalDressing>();
      try {
        using (var context = new ArchaeologyContext()) {
          retVal = context.LstArchitecturalDressing
                          .OrderBy(l => l.Description)
                          .ToList();
        }
      }
      catch (Exception ex) {
        throw new Exception(ex.Message, ex.InnerException);
      }
      return retVal;
    }

    public LstArchitecturalDressing readArchitecturalDressing(int id) {
      var retList = new List<LstArchitecturalDressing>();
      var retVal = new LstArchitecturalDressing();
      try {
        using (var context = new ArchaeologyContext()) {
          retList = context.LstArchitecturalDressing
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
