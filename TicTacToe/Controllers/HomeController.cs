using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TicTacToe.Models;

namespace TicTacToe.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
       
        public ViewResult Index()
        {
            var board = new TicTacToeBoard();

            foreach (Cell cell in board.Cells)
            {
                cell.Mark = TempData[cell.Id]?.ToString();
            }
            board.CheckForWinner();

            var model = new TicTacToeViewModel
            {
                Cells = board.Cells,
                Selected = new Cell { Mark = TempData["nextTurn"]?.ToString() ?? "X" },
                IsGameOver = board.HasWinner || board.HasAllCellsSelected
            };

            if (model.IsGameOver)
            {
                TempData["nextTurn"] = "X";
                TempData["message"] = (board.HasWinner) ? $"{board.WinningMark} wins!" : "It's a tie!";
            }
            else
            {
                TempData.Keep();
            }

            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult Index(TicTacToeViewModel tic)
        {
            TempData[tic.Selected.Id] = tic.Selected.Mark;

            TempData["nextTurn"] = (tic.Selected.Mark == "X") ? "O" : "X";

            return RedirectToAction("Index");

        }
        

       
    }
}
