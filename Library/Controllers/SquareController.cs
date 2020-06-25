using Microsoft.EntityFrameworkCore;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Library.Controllers
{
    public class SquareController
    {
      public List<Square> readSquares() {
        var retVal = new List<Square>();
        try {
          using (var context = new ArchaeologyContext()) {
            retVal = context.Square
                            .Include(square => square.Area)
                            .Include(square => square.Supervisor)
                            .ToList();
          }
        }
        catch (Exception ex) {
          throw new Exception(ex.Message, ex.InnerException);
        }
        return retVal;
      }

      public Square readSquare(Guid id) {
        var retList = new List<Square>();
        var retVal = new Square();
        try {
          using (var context = new ArchaeologyContext()) {
            retList = context.Square
                             .Include(square => square.Area)
                             .Include(square => square.Supervisor)
                             .Where(square => square.Id == id)
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

      public bool createSquare(Square square) {
        try {
          using (var context = new ArchaeologyContext()) {
            context.Square.Add(square);
            context.SaveChanges();
          }
        }
        catch (Exception ex) {
          throw new Exception(ex.Message, ex.InnerException);
        }
        return true;
      }

      public bool updateSquare(Square square) {
        try {
          using (var context = new ArchaeologyContext()) {
            context.Square.Update(square);
            context.SaveChanges();
          }
        }
        catch (Exception ex) {
          throw new Exception(ex.Message, ex.InnerException);
        }
        return true;
      }

      public bool deleteSquare(Square square) {
        try {
          using (var context = new ArchaeologyContext()) {
            context.Remove(square);
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
