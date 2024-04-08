namespace TicTacToe.Models
{
    public class Cell
    {
        public string Id { get; set; } = string.Empty;
        public string Mark { get; set; } = string.Empty;
        public bool IsBlank => string.IsNullOrEmpty(Mark); //returns if Mark is null or empty
        public bool isEndCell => Id.EndsWith("Right"); // if the cell is on the right
    }
}
