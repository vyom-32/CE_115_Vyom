using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sudoku.Models;

namespace sudoku.Controllers
{
    public class SudokuProblemsController : Controller
    {
        private readonly ISudokuProblemRepository _sudokuProblemRepository;
        private readonly IUserRepository _userRepository;

        public SudokuProblemsController(ISudokuProblemRepository sudokuProblemRepository,IUserRepository userRepository)
        {
            _sudokuProblemRepository = sudokuProblemRepository;
            _userRepository = userRepository;
        }

        public SudokuProblem ById(int Id)
        {
            return _sudokuProblemRepository.GetSudokuProblem(Id);
        }

        public IActionResult Sudoku(int Id=0,string level="")
        {
            SudokuProblem sudoku_puzzle=null;
            if (Id!=0)
            {
                User user=_userRepository.GetUser(Id);
                int levelId = 0;
                if(level=="Easy")
                {
                    levelId = user.EasyId;
                }
                else if (level == "Medium")
                {
                    levelId = user.MediumId;
                }
                else if (level == "Hard")
                {
                    levelId = user.HardId;
                }


                sudoku_puzzle = _sudokuProblemRepository.GetSudokuById(levelId, level);
                User updated = user;
                if (level == "Easy")
                {
                    updated.EasyId = sudoku_puzzle.Id;
                }
                else if(level == "Medium")
                {
                    updated.MediumId = sudoku_puzzle.Id;
                }
                else if (level == "Hard")
                {
                    updated.HardId = sudoku_puzzle.Id;
                }
                updated = _userRepository.UpdateUser(updated);
            }
            else
            {
                sudoku_puzzle = _sudokuProblemRepository.GetRandomSudoku(level);
            }
            return View(sudoku_puzzle);
        }

        [HttpGet]
        public IActionResult createSudoku()
        {
            return View();
        }

        [HttpPost]
        public IActionResult createSudoku(SudokuProblem newSudoku)
        {
            _sudokuProblemRepository.AddSudoku(newSudoku);
            return View();
        }
    }
}
