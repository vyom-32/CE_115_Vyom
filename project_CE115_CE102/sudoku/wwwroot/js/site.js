// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var refreshNavbar = function () {
    if ('userName' in window.localStorage) {
        document.getElementById("logout").hidden = false;
        document.getElementById("login").hidden = true;
        document.getElementById("register").hidden = true;
        document.getElementById("profile").hidden = false;
        document.getElementById("profile").href = "/User/Profile/" + window.localStorage.getItem('userId');
        //document.getElementById("easy").href = "/SudokuProblems/Sudoku?id=" + window.localStorage.getItem('userId') + "&level=Easy";
        //document.getElementById("medium").href = "/SudokuProblems/Sudoku?id=" + window.localStorage.getItem('userId') + "&level=Medium";
        //document.getElementById("hard").href = "/SudokuProblems/Sudoku?id=" + window.localStorage.getItem('userId') + "&level=Hard";
        if (window.localStorage.getItem('userRole') == "Admin") {
            document.getElementById("createSudoku").hidden = false;
        }
        else {
            //document.getElementById("easy").href = "/SudokuProblems/Sudoku?level=Easy";
            //document.getElementById("medium").href = "/SudokuProblems/Sudoku?level=Medium";
            //document.getElementById("hard").href = "/SudokuProblems/Sudoku?level=Hard";
            document.getElementById("createSudoku").hidden = true;
        }
    }
    else {
        document.getElementById("logout").hidden = true;
        document.getElementById("login").hidden = false;
        document.getElementById("register").hidden = false;
        document.getElementById("profile").hidden = true;
        document.getElementById("createSudoku").hidden = true;
    }
}