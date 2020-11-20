using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sudoku.Models
{
    public class SudokuProblem
    {
        public int Id { get; set; }
        public string Problem { get; set; }
        public string Result { get; set; }
        public string level { get; set; }
    }
}
