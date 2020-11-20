using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sudoku.Models
{
    public class SQLSudokuProblemRepository : ISudokuProblemRepository
    {
        private readonly AppDbContext context;

        public SQLSudokuProblemRepository(AppDbContext context)
        {
            this.context = context;
        }

        public SudokuProblem AddSudoku(SudokuProblem sudokuProblem)
        {   
            context.SudokuProblem.Add(sudokuProblem);
            context.SaveChanges();
            return sudokuProblem;
        }

        public SudokuProblem DeleteSudoku(int Id)
        {
            throw new NotImplementedException();
        }

        public SudokuProblem GetRandomSudoku(string level)
        {
            List<SudokuProblem> sudoku_puzzles = context.SudokuProblem.ToList();
            List<SudokuProblem> required_level = new List<SudokuProblem>();
            for(int i = 0; i < sudoku_puzzles.Count(); i++)
            {
                if (sudoku_puzzles[i].level == level)
                {
                    required_level.Add(sudoku_puzzles[i]);
                }
            }
            Random r = new Random();
            return required_level[r.Next(0, required_level.Count())];
        }

        public SudokuProblem GetSudokuById(int Id, string level)
        {
            List<SudokuProblem> sudokuPuzzles = context.SudokuProblem.ToList();
            SudokuProblem sudokuPuzzle=null;
            for(int i = 0; i < sudokuPuzzles.Count; i++)
            {
                if(sudokuPuzzles[i].Id>Id && sudokuPuzzles[i].level == level)
                {
                    sudokuPuzzle = sudokuPuzzles[i];
                    break;
                }
            }
            if (sudokuPuzzle == null)
            {
                for (int i = 0; i < sudokuPuzzles.Count; i++)
                {
                    if (sudokuPuzzles[i].level == level)
                    {
                        sudokuPuzzle = sudokuPuzzles[i];
                        break;
                    }
                }
            }
            return sudokuPuzzle;
        }

        public SudokuProblem GetSudokuProblem(int Id)
        {
            return context.SudokuProblem.Find(Id);
        }
    }
}
