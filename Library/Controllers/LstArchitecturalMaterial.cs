using NotebookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NotebookLibrary.Controllers
{
  public class LstArchitecturalMaterialController
  {
    public List<LstArchitecturalMaterial> readArchitecturalMaterials() {
      var retVal = new List<LstArchitecturalMaterial>();
      try {
        using (var context = new ArchaeologyContext()) {
          retVal = context.LstArchitecturalMaterial
                          .OrderBy(l => l.Description)
                          .ToList();
        }
      }
      catch (Exception ex) {
        throw new Exception(ex.Message, ex.InnerException);
      }
      return retVal;
    }

    public LstArchitecturalMaterial readArchitecturalMaterial(int id) {
      var retList = new List<LstArchitecturalMaterial>();
      var retVal = new LstArchitecturalMaterial();
      try {
        using (var context = new ArchaeologyContext()) {
          retList = context.LstArchitecturalMaterial
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
