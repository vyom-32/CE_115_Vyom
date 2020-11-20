using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sudoku.Models
{
    public interface ISudokuProblemRepository
    {
        SudokuProblem GetSudokuProblem(int Id);
        SudokuProblem AddSudoku(SudokuProblem sudokuProblem);
        SudokuProblem DeleteSudoku(int Id);
        SudokuProblem GetSudokuById(int Id,string level);
        SudokuProblem GetRandomSudoku(string level);
    }
}
